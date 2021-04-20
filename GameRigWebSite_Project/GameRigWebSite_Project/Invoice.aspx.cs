using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using GameRigWebSite_Project.ServiceReference1;

namespace GameRigWebSite_Project
{
    public partial class InvoicePage : System.Web.UI.Page
    {
        Service2Client sc = new Service2Client();
        protected void Page_Load(object sender, EventArgs e)
        {
            string display = "";
            int Random(int min, int max)
            {
                Random random = new Random();
                return random.Next(min, max);
            }

            display += "<h1 style ='text-align:center'>INVOICE</h1>";
            display += "<p style='text-align:center'>Username:" + Session["Name"] + "</p>";
            display += "<p style ='text-align:center'>Date:" + DateTime.Today + "</p>";
            display += "<p style='text-align:center'>InvoiceNo:" + Random(1, 2000) + "</p>";
           


            var items = sc.getAllProducts();
            var CartIt = sc.getCartProducts();


            foreach (ProductTable pr in items)
            {
                foreach (CTable ct in CartIt)
                {
                    if (pr.ProductId == ct.ProductID && Convert.ToInt32(Session["UserID"]) == ct.UserId)
                    {

                        int a = 1;
                        int b = a++;

                        display += "<tbody> <tr> <td class='cart_product'>";
                        display += "<a href='#'><img src='" + pr.ImgUrl + "' alt='' style='width: 200px; height: 200px' '></a> </td>";
                        display += "<td class='cart_description'><h4><a href='#'>" + pr.ProductName + "</a></h4></td>";
                        display += "<td class='cart_price'><p>" + pr.Price + "</p></td>";
                       


                    }
                }

            }
            invo.InnerHtml = display;






        }


    }
}