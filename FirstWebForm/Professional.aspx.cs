using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace FirstWebForm
{
    public partial class Professional : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void TextBox1_TextChanged(object sender, EventArgs e)
        {


        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            //connect to database
            SqlDataAdapter adapter = new SqlDataAdapter();
            
           
                //get the command from sqlDataSource1
              adapter.InsertCommand = new SqlCommand(SqlDataSource1.InsertCommand);
            adapter.InsertCommand.Connection = new SqlConnection(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=KpmgDb;Integrated Security=True");

            //add parameters for command
            adapter.InsertCommand.Parameters.Add(new SqlParameter("Name", txtName.Text));
            adapter.InsertCommand.Parameters.Add(new SqlParameter("Designation", txtDesignation.Text));
            adapter.InsertCommand.Parameters.Add(new SqlParameter("Salary", txtSalary.Text));


            //open connection //execute command
            using (adapter.InsertCommand.Connection)
            {
                adapter.InsertCommand.Connection.Open();
                adapter.InsertCommand.ExecuteNonQuery();
            }

            //re-bind the grid
            GridView1.DataBind();

        }
    }
}