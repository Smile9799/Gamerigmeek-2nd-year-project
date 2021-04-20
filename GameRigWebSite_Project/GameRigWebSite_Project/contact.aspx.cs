using System;
using System.Net.Mail;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace GameRigWebSite_Project
{
    public partial class contact : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void sendMessage(object sender, EventArgs e)
        {
            MailMessage mail = new MailMessage();

            mail.From = new MailAddress(email.Text.ToString());
            mail.To.Add("evesmile9799g@gmail.com");

            mail.Subject = "Mail Via GameRig From " + name.Text.ToString();
            mail.IsBodyHtml = true;
            mail.Body = "<html><body>"
                       + email.Text.ToString() +
                       "<br><br>" +
                       sub.Text.ToString() +
                       "<br><br>" +
                       message.Text.ToString() +
                       "</body></html>";

            SmtpClient smtpClient = new SmtpClient();
            smtpClient.EnableSsl = false;
            smtpClient.Send(mail);
        }
    }
}