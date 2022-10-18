using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace FirstWebForm
{
    public partial class Login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }





        protected void Btn_Click(object sender, EventArgs e)
        {
            Btn.Text = "Login sucessfull!!";
            Session["NAME"] = TextBox1.Text;
            Session["Hobbies"] = new List<string>() { "Dancing", "Playing",  "Reading" };

            //create a cookie

            HttpCookie cookie = new HttpCookie("RemindMe");
            cookie.Value = "To attend National Conference Session";
            cookie.Expires = DateTime.Now.AddDays(1);

            //cookie for preferences
            HttpCookie prefCookie = new HttpCookie("Preferences");
            prefCookie.Value = "Magenta:White";
            prefCookie.Expires = DateTime.Now.AddDays(1);


            Response.Cookies.Add(cookie);
            Response.Cookies.Add(prefCookie);

        }  

   

        protected void ImageButton6_Click(object sender, ImageClickEventArgs e)
        {
            Response.Redirect("https://www.googleadservices.com/pagead/aclk?sa=L&ai=DChcSEwjGo4qMqtr6AhXvmmYCHfyBBwMYABAAGgJzbQ&ohost=www.google.com&cid=CAASJuRoRnbvyALFbxoySzPcu0xBJU2dse-CqCLLenYSlRhmnlOUcCnR&sig=AOD64_0JuQl-wjjKXPRgAq_px2dzjnqWKw&q&adurl&ved=2ahUKEwiZs4KMqtr6AhWAzzgGHRQNAT4Q0Qx6BAgIEAE");
        }
    }
}