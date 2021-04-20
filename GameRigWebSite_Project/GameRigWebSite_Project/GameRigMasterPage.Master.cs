using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using GameRigWebSite_Project.ServiceReference1;
namespace GameRigWebSite_Project
{
    
    public partial class GameRigMasterPage : System.Web.UI.MasterPage
    {
        
        Service2Client sc = new Service2Client();
        
        protected void Page_Load(object sender, EventArgs e)
        {
            
            if (Session["Name"] != null)
            {
                
                logoutbutton.Visible = true;
                logoutbutton2.Visible = true;
                loginButton.Visible = false;
                loginButton1.Visible = false;
                regbutton.Visible = false;
                register1.Visible = false;
                cartbutton.Visible = true;
                cartbutton2.Visible = true;



                if (Session["UserType"].Equals("Manager"))
                {
                    add.Visible = true;
                    edit.Visible = true;
                    adduserbutton.Visible = true;
                    register2.Visible = true;
                    deleteP.Visible = true;
                    deleteU.Visible = true;
                }
                else
                {
                    add.Visible = false;
                    edit.Visible = false;
                    adduserbutton.Visible = false;
                    register2.Visible = false;
                    deleteP.Visible = false;
                    deleteU.Visible = false;
                }

            }
            else
            {
                logoutbutton.Visible = false;
                register2.Visible = false;
                register1.Visible = true;
                logoutbutton2.Visible = false;
                loginButton.Visible = true;
                regbutton.Visible = true;
                adduserbutton.Visible = false;
                loginButton1.Visible = true;
                add.Visible = false;
                edit.Visible = false;
                cartbutton.Visible = false;
                cartbutton2.Visible = false;
                deleteP.Visible = false;
                deleteU.Visible = false;
            }
            if (Session["CartProducts"] == null)
            {
                Session["CartProducts"] = new List<CartClass>();
            }

        }
        protected void SearchButton(object sender, EventArgs e)
        {
          
        }

      
    }
}