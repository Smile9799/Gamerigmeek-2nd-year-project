using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace GameRigWebSite_Project
{
    public partial class refund : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["CartProducts"] != null)
            {
                List<CartClass> items = (List<CartClass>)Session["CartProducts"];
                foreach (CartClass prod in items)
                {
                    if (prod.ProID.Equals(ID))
                    {
                        items.Remove(prod);
                        break;
                        
                    }
                }

            }
            Response.Redirect("cart.aspx");
        }
    }
}