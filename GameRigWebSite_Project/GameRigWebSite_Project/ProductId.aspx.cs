using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using GameRigWebSite_Project.ServiceReference1;

namespace GameRigWebSite_Project
{
    public partial class ProductId : System.Web.UI.Page
    {
        Service2Client sc = new Service2Client();
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void Button2_click(object sender, EventArgs e)
        {

            var part = sc.SearchProduct(Convert.ToInt32( id.Value));
            if (part > 0)
            {
                Response.Redirect("EditProduct.aspx?A=" + part);
            }
        }
    }
}