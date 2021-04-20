using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using GameRigWebSite_Project.ServiceReference1;

namespace GameRigWebSite_Project
{
    public partial class EditProduct : System.Web.UI.Page
    {
        Service2Client sc = new Service2Client();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["Name"] == null)
            {
                Response.Redirect("Home.aspx");
            }
            else
            {
                if (!Session["UserType"].Equals("Manager"))
                {
                    Response.Redirect("Home.aspx");
                }
            }
        }
        protected void Button1_click(object sender, EventArgs e)
        {
            var product = sc.AddNewProduct(pname.Value,Convert.ToInt32( price.Value), col.Value, quantity.Value,type.Value,description.Value,img.Value );

            if( product == 1)
            {
                Response.Redirect("Home.aspx");
            }
        }
    }
}