using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using GameRigWebSite_Project.ServiceReference1;

namespace GameRigWebSite_Project
{
    public partial class Register : System.Web.UI.Page
    {
        Service2Client sc = new Service2Client();
        String Type = "Customer";
        protected void Page_Load(object sender, EventArgs e)
        {
           if(Session["UserType"] != null)
            {
                if (Session["UserType"].Equals("Manager"))
                {
                    var select = 0;
                    Utype.Visible = true;
                    if (!IsPostBack)
                    {
                        select = userType.SelectedIndex;
                    }
                    if (select.Equals(1))
                    {
                        Type = "Customer";
                    }
                    if (select.Equals(2))
                    {
                        Type = "Admin";
                    }
                    else
                    {
                        Type = "Manager";
                    }

                }
            } 
        }
        protected void Button1_click(object sender, EventArgs e)
        {
            //register code here.
            if (pass.Value.Equals(con_pass.Value))
            {
                bool IsRegistered = sc.Registerd(email1.Value, pass.Value);
                if (IsRegistered != true)
                {
                    User u = new User
                    {
                        name = fname.Value,
                        lastname = lname.Value,
                        email = email1.Value,
                        phonenumber = cell.Value,
                        password = pass.Value,
                        active = 1,
                        usertype = Type
                    };
                    int Registration = sc.AddMember(u);
                    if (Registration.Equals(1))
                    {
                        Response.Redirect("login.aspx");
                    }
                    else
                        messageDiv.Visible = true;
                    message.Value = "User Already Registered";
                }
            }
            else
                messageDiv.Visible = true;
            message.Value = "Passwords Do not Match";
            
        }
    }
}