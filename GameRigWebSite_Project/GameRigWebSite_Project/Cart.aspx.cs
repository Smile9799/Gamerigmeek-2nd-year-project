using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using GameRigWebSite_Project.ServiceReference1;
namespace GameRigWebSite_Project
{
    public partial class Cart : System.Web.UI.Page
    {
        Service2Client sc = new Service2Client();
        protected void Page_Load(object sender, EventArgs e)
        {



            if (Request.QueryString["ProductID"] != null && Request.QueryString["Qty"] != null)
            {
                int ProdID = Convert.ToInt32(Request.QueryString["ProductID"]);

                AddProduct fetchedProduct = sc.GetProduct(ProdID);
                int providedQuantity = Convert.ToInt32(Request.QueryString["Qty"]);
                if (providedQuantity < 1)
                {
                    providedQuantity = 1;
                }

                if (Convert.ToInt32(fetchedProduct.Quant) <= providedQuantity)
                {
                    AddProdToCart(Convert.ToInt32(Request.QueryString["ProductID"]), Convert.ToInt32(fetchedProduct.Quant));

                    ScriptManager.RegisterClientScriptBlock(this.Page, this.GetType(), "alertMessage", "notifyUser()", true);
                }
                else
                {
                    AddProdToCart(Convert.ToInt32(Request.QueryString["ProductID"]), providedQuantity);
                }



            }
            List<CartClass> itemsCount = (List<CartClass>)Session["CartProducts"];
            int exists = itemsCount.Count;

            if (exists > 0)
            {
                checkoutDiv.Visible = true;
            }
            else
            {
                checkoutDiv.Visible = false;
                vatValue.InnerHtml = null;
                delivery.InnerHtml = null;
                vat.InnerHtml = null;
                subtotal.InnerHtml = null;

            }

            if (Request.QueryString["removeID"] != null)
            {
                int ID = Convert.ToInt32(Request.QueryString["removeID"]);
                RemoveProduct(ID);

            }

            String display = "";
            double total = 0;


            if (Session["CartProducts"] != null)
            {
                List<CartClass> items = (List<CartClass>)Session["CartProducts"];

                foreach (CartClass pr in items)
                {


                    AddProduct single = sc.GetProduct(pr.ProID);
                    total += Convert.ToInt64( single.price )* pr.Quantity;
                    int id = sc.getProId(single.name);

                    display += "<tr class='text-center'>";
                    display += $"<td class='product-remove'><a href='cart.aspx?removeID={id}' ><span class='ion-ios-close'></span></a></td>";
                    display += $"<td class='image-prod'><div class='img' style='background-image:url({single.imgurl});'></div></td>";
                    display += "<td class='product-name'>";
                    display += $"<h3>{single.name}</h3>";
                    display += "</td>";
                    display += $"<td class='price'>R{single.price}</td>";
                    display += "<td class='quantity'>";
                    display += "<div class='input-group mb-3'>";
                    display += $"<input type='number' name='quantity' id='{id}' class='quantity form-control input-number' value='{pr.Quantity}'>";
                    display += "</div>";
                    display += "</td>";
                    display += "<td>";
                    display += $"<a onclick='updateQty({id});' style='padding: 0 0.5rem 0 0.5rem;' class='btn btn-primary py-3 px-4'>update cart</a>";
                    display += "</td>";
                    display += "<td>";
                    display += $"<a onclick='RemoveProduct({id});' href='remove.aspx?={id}' style='padding: 0 0.5rem 0 0.5rem;' class='btn btn-primary py-3 px-4'>Remove</a>";
                    display += "</td>";
                    display += $"<td class='total'>R{Convert.ToInt64(single.price) * pr.Quantity}</td>";
                    display += "</tr>";
                    
                }

                theCart.InnerHtml = display;
                vat.InnerHtml = "VAT: "; //+ Convert.ToString(0.15 * 100) + "%";
                vatValue.InnerHtml = "R" + Math.Round(total * 0.15, 2);
                delivery.InnerHtml = "R" + Convert.ToString(70);
                subtotal.InnerHtml = "R" + Math.Round(total, 2);
                FarmUtilities.setSubtotal(total);
                string display2 = null;
                double id1;
                double id2;
                if (total >= 400 && coupon.Value.Equals("CM010"))
                {

                    delivery.InnerHtml = "R0.00";
                    totalPrice.InnerHtml = "R" + Math.Round(total * 0.15 + total - (total * 0.1), 2);
                    discount.InnerHtml = "R0.00" ;
                    FarmUtilities.setTotal(total * FarmUtilities.getVat() + total);
                    FarmUtilities.setDeliveryFee(0);
                    id1= Math.Round(total * 0.15 + total - (total * 0.1), 2);
                    id2 = total * 0.1;
                    display2 += " <a class='btn btn-default check_out' href='InvoicePage.aspx?ProductTotal=" + id1 + " &Discount=" + id2 + "'id='checkout'>Check Out</a> ";


                }
                else if(total >=400 && coupon.Value.Equals(""))
                {
                    delivery.InnerHtml = "R0.00";
                    totalPrice.InnerHtml = "R" + Math.Round(total * 0.15 + total, 2);
                    discount.InnerHtml = "R0.00";
                    id2 = 0;
                    id1 = Math.Round(total * 0.15 + total, 2);
                    display2 += " <a class='btn btn-default check_out' href='InvoicePage.aspx?ProductTotal=" + id1 + " &Discount=" + id2 + "'id='checkout'>Check Out</a> ";

                }
                else if(total <400 && coupon.Value.Equals("CM010"))
                {
                    discount.InnerHtml =  0 + "%";
                    totalPrice.InnerHtml = "R" + Math.Round(total * 0.15 + total + 70, 2);
                    id1 = Math.Round(total * 0.15 + total + 70 - (total * 0.1), 2);
                    id2 = total * 0.1;
                 display2 += " <a class='btn btn-default check_out' href='InvoicePage.aspx?ProductTotal=" + id1 + " &Discount=" + id2 + "'id='checkout'>Check Out</a> ";

                }
                else
                {
                    discount.InnerHtml = 0 + "%";
                    totalPrice.InnerHtml = "R" + Math.Round(total * 0.15 + total + 70, 2);
                   // id1 = Math.Round(total * 0.15 + total + 70 , 2);
                    id2 = 0;
                    id1 = Math.Round(total * 0.15 + total + 70, 2);
                    display2 += " <a class='btn btn-default check_out' href='InvoicePage.aspx?ProductTotal=" + id1 + " &Discount=" + id2 + "'id='checkout'>Check Out</a> ";
                }




                display2 += "<br/>";
                display2 += "<br/>";
               checkoutDiv.InnerHtml = display2;

            }

        }


       /* protected void checkOutBtn_Click(object sender, EventArgs e)
        {
            if (Session["Name"] == null)
            {
                
            }
            else if (Session["Name"] != null)
            {
                Response.Redirect("InvoicePage.aspx?ProductID="+ Convert.ToInt32(Request.QueryString["Qty"]));
                //  Response.Redirect("checkout.aspx");

            }

        }*/

        protected void applyCoupon_Click(object sender, EventArgs e)
        {
            // testing... coupon.Value = CouponGenerator.GetCoupon().ToString();
            discount.InnerHtml = null;
            //totalPrice.InnerHtml = null;
            if (coupon.Value.Equals("CM010"))
            {
                discount.InnerHtml = "R" + 10 + "%";
               // totalPrice.InnerHtml = "R" + Math.Round(total * 0.15 + total + 70 - (total * 0.1), 2);
            }

        }

        private void RemoveProduct(int ID)
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
        }

        public void AddProdToCart(int ID, int qty)
        {
            if (Session["CartProducts"] != null)
            {
                List<CartClass> items = (List<CartClass>)Session["CartProducts"];
                Boolean found = false;

                foreach (CartClass pr in items)
                {

                    if (ID.Equals(pr.ProID))
                    {
                        found = true;
                        pr.Quantity = qty;

                        break;
                    }

                }

                if (!found)
                {
                    var newItem = new CartClass
                    {
                        ProID = ID,
                        Quantity = 1
                    };

                    items.Add(newItem);
                }

            }

        }

    }
}

