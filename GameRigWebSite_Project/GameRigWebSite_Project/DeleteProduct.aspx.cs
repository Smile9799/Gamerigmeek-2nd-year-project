using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using GameRigWebSite_Project.ServiceReference1;

namespace GameRigWebSite_Project
{
    public partial class DeleteProduct : System.Web.UI.Page
    {
        Service2Client sc = new Service2Client();
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void Button2_click(object sender, EventArgs e)
        {
            var delete = sc.DeleteProduct(Convert.ToInt32(pID.Value));

            if (delete.Equals(1))
            {
                //redirect

                // successs message 
                messageDiv.Visible = true;
                message.Value = "Succefully deleted Product";
            }
            else
            {
                messageDiv.Visible = true;
                message.Value = "Failed to Remove the product";
            }
        }
    }
}