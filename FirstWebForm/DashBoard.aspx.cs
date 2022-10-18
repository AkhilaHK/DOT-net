using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace FirstWebForm
{
    public partial class DashBoard : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack) //will execute only first time the page loads, after subsequent
                             //clicks(postback) this code will not execute
            {
                List<Employee> employees = new List<Employee>();
                employees.Add(new Employee() { EmpId = 1001, name = "Eena", Designation = "Analyst" });
                employees.Add(new Employee() { EmpId = 1002, name = "Mena", Designation = "Lead" });
                employees.Add(new Employee() { EmpId = 1003, name = "Teena", Designation = "Manager" });
                ViewState["EmpData"] = employees;
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Button1.Text = "You are logged In as: " + Convert.ToString(Session["NAME"]);
        }

        protected void ListBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            Label1.Text = "Your selected value : " + ListBox2.SelectedValue.ToString();
            Label1.Text = Label1.Text + " | Your selected Text : " + ListBox2.SelectedItem.Text;

        }

        protected void ListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            List<string> dataFromSession = (List<string>)Session["Hobbies"];
            ListBox1.DataSource = dataFromSession;
            ListBox1.DataBind();
        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            HttpCookie varReadCookie = Request.Cookies["RemindMe"];
            Button3.Text = varReadCookie.Value;

            HttpCookie varPrefCookie = Request.Cookies["Preferences"];
            string cookieValue = varPrefCookie.Value;     //seagreen:white
            string[] splits = cookieValue.Split(':');    //split[0]= "seagreen", split[1]="white";

            ApplyColor(splits[0], "BackColor");
            ApplyColor(splits[1], "ForeColor");

        }

        private void ApplyColor(string color, string property)
        {
            System.Drawing.Color resultColor = System.Drawing.Color.White;
            switch (color)
            {
                case "Majenta":
                    resultColor = System.Drawing.Color.Magenta;
                    break;
                case "White":
                    resultColor = System.Drawing.Color.White;
                    break;

                default:
                    resultColor = System.Drawing.Color.Tomato;
                    break;

            }

            if (property == "BackColor")
            {
                ListBox1.BackColor = resultColor;
                ListBox2.BackColor = resultColor;
            }
            else if (property == "ForeColor")
            {
                ListBox1.ForeColor = resultColor;
                ListBox2.ForeColor = resultColor;
            }
        }

        protected void Button4_Click(object sender, EventArgs e)
        {
            GridView1.DataSource = ViewState["EmpData"];
            GridView1.DataBind();
        }
    }
}