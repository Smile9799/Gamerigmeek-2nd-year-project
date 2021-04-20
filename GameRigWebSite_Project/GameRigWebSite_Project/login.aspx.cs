using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Xml.Linq;
using GameRigWebSite_Project.ServiceReference1;

namespace GameRigWebSite_Project
{
    public partial class login : System.Web.UI.Page
    {
        Service2Client sc = new Service2Client();

        protected void Page_Load(object sender, EventArgs e)
        {
           
        }

        protected void Button2_click(object sender, EventArgs e)
        {
            //Login code,

            //Test for email and password
            int logIn = sc.Login(email.Value, password.Value);
            if (logIn !=0)
            {
                User u = sc.GetUser(logIn);
                Session["Name"] = u.name;
                Session["surname"] = u.lastname;
                Session["email"] = u.email;
                Session["UserID"] = u.id;
                Session["contact"] = u.phonenumber;
                Session["UserType"] = u.usertype;
             
                Response.Redirect("Home.aspx");
            }
           else
                messageDiv.Visible = true;
            message.Value = "Incorrect UserName or Password"; 
        }
        protected void BtnSend_Click1(object sender, EventArgs e)
        {
            Response.Redirect("Register.aspx");
        }
    }
}