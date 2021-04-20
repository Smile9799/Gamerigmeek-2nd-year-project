using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using GameRigWebSite_Project.ServiceReference1;

namespace GameRigWebSite_Project
{
    public partial class Invoice : System.Web.UI.Page
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

            // display += "< div class='col-md-4 clearfix'>";
            display += "<div class='logo pull-left'>";
            display += "<img src='images/GameRigHome/c619d286-b4ef-4dfb-ba9f-96cd7f82bd5e_200x200.png' style='margin-left:0px' width='100' height='100' />";
            display += "<p style=' margin-left:0px'>Email:" + "GameRig@gmail.com" + "</p>";
            display += "<p style=' margin-left:0px'>Cell:" + "0607870139" + "</p>";
            display += "</div>";
            display += "</div>";
            display += "<br/>";
            display += "<br/>";
            display += "<br/>";
            display += "<br/>";
            display += "<br/>";
            display += "<br/>";
            display += "<br/>";
            display += "<br/>";
            display += "<h1 style ='text-align:center;text-decoration:underline'>INVOICE</h1>";
            display += "<br/>";
            display += "<p style='text-align:center'>Username:" + Session["email"] + "</p>";
            display += "<p style='text-align:center'>Names:" + Session["Name"] + " " + Session["surname"] + "</p>";
            display += "<p style ='text-align:center'>Date:" + DateTime.Today + "</p>";
            display += "<p style='text-align:center'>InvoiceNo:" + Random(1, 2000) + "</p>";
            display += "<p style='text-align:center'>Cell Number:"+ Session["contact"]+ "</p>";
            
            //display += "<p style ='text - align:center'>Products</p>";

            var items = sc.getAllProducts();
            List < CartClass > cart =  (List<CartClass>)Session["CartProducts"];

            //AddProduct single = sc.GetProduct(cart.ProID);
            foreach (CartClass ct in cart)
                {
                AddProduct single = sc.GetProduct(ct.ProID);


                display += "<tbody> <tr> <td class='cart_product'>";
                display += " <td style='margin-left:0px; padding:0'><h4 >" + single.name + "</h4>";
                display += "<td class='cart_description'><h4 >" + single.desc + "</h4>";
                display += "</td><td class='cart_price'><p id='price'>" + ct.Quantity + "</p></td>";
                display += "</td><td class='cart_price'><p id='price'>R" + Math.Round((Convert.ToDecimal(ct.Quantity) * single.price ),2)+ "</p></td>";
                display += "<td class='cart_quantity'>";
                // display += "<a class='cart_quantity_down' href='#'>-</a>";
              //  display += "<input class='cart_quantity_input' id='quantity' style='margin-left:35px' type='text' name='quantity' value='1' autocomplete='off' size='2'/>";
                //  display += "<a class='cart_quantity_up' href='IncrementProduct.aspx?ID="+pr.ProductId+"&QU="+qua+"'>+</a>";
                //display += "</div></td><td class='cart_total'>";
                // String total = Convert.ToString(3 * pr.Price2);
                // Session["TOTAL"] = total;
                //display += "<td class='cart_delete'>";
                display += "</td></tr>";
                /*display += "<tr>";
                display += "<td>"+single.name+"</td>";
                display += "<td>" + single.desc + "</td>";
                display += "<td>" + ct.Quantity + "</td>";
                display += "<td>" + single.price + "</td>";
                display += "  </tr>";
               /* display += "<tbody> <tr> <td class='cart_product'>";
                display += "<td class='cart_description'><h4 style='margin-left:20px'>Name: " + single.name+ "</h4></td>";
                display += "<td class='cart_description'><h4 style='margin-left:20px'>Description: " + single.desc + "</h4></td>";
                display += "<td class='cart_price'><h4 style='margin-left:20px'>Quantity: " + ct.Quantity + "</h4></td>";
                display += "<td class='cart_price'><h4 style='margin-left:20px'>Price: R" +single.price + "</h4></td>";*/
                display += "<br/>";
                display += "<br/>";
                display += "<br/>";
                

            }
            display += "<td class='cart_price'><h4 style='margin-left:20px'>Discount: R" +Request.QueryString["Discount"] + "</h4></td>";
            display += "<td class='cart_price'><h4 style='margin-left:20px'>Total Price: R" + Request.QueryString["ProductTotal"] + "</h4></td>";



            invo.InnerHtml = display;
        }
        


    }
}