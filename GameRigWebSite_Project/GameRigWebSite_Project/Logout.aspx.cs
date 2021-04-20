using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace GameRigWebSite_Project
{
    public partial class Logout : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Session["Name"] = null;
            Session["CartProducts"] = null;
            Session["UserType"] = null;
            Response.Redirect("Home.aspx");
        }
    }
}