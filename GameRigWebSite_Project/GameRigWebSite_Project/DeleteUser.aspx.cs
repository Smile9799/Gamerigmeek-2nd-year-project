using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using GameRigWebSite_Project.ServiceReference1;
namespace GameRigWebSite_Project
{
    public partial class DeleteUser : System.Web.UI.Page
    {
        Service2Client sc = new Service2Client();
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void Button2_click(object sender, EventArgs e)
        {
            var del = sc.DeleteUser( email.Value);
            if (del.Equals(1))
            {
                
                //response message.
                messageDiv.Visible = true;
                message.Value = "Deleted successfully";
            }
            else
            {
                //response message...failed to delete
                messageDiv.Visible = true;
                message.Value = "Failed to Delete";
            }
        }
    }
}