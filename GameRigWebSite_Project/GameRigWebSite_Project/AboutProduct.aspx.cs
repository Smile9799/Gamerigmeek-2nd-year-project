using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using GameRigWebSite_Project.ServiceReference1;
namespace GameRigWebSite_Project
{
    public partial class AboutProduct : System.Web.UI.Page
    {
        Service2Client sc = new Service2Client();
        protected void Page_Load(object sender, EventArgs e)
        {
            AddProduct p = sc.GetProduct(Convert.ToInt32(Request.QueryString["ID"]));
            if (Session["Name"] != null)
            {
                ADDTOCART.Visible = false;
                string display = "";
                display += "<div class='col-sm-4'><div class='product-image-wrapper'>";
                display += "<div class='single-products'><div class='productinfo text-center'>";
                display += "<a href='#'>";
                display += "<img src='" + p.imgurl + "' alt='' /><h2>R" + p.price + "</h2></a>";
                display += "<h>Name: " + p.name + "</h><br><h>Description: " + p.desc + "</h><br><a href='Cart.aspx?ProductID="+Convert.ToInt32(Request.QueryString["ID"])+"&Qty=1'>AddToCart</a></div></div></div></div>";
                display += "<br/>";
                display += "<br/>";
                display += "<br/>";
                Session["ProductID"] = Convert.ToInt32(Request.QueryString["ID"]);
                product.InnerHtml += display;
            }
            else
            {
                string display = "";
                display += "<div class='col-sm-4'><div class='product-image-wrapper'>";
                display += "<div class='single-products'><div class='productinfo text-center'>";
                display += "<a href='#'>";
                display += "<img src='" + p.imgurl + "' alt='' /><h2>R" + p.price + "</h2></a>";
                display += "<h>Name: " + p.name + "</h><br><h>Description: " + p.desc + "</h></div></div></div></div>";
                display += "<br/>";
                display += "<br/>";
                display += "<br/>";

                product.InnerHtml += display;

            }

        }

        protected void ADDTOCART_Click(object sender, EventArgs e)
        {

           /* if (Session["UserID"] != null)
            {
                CartClass u = new CartClass
                {
                  //  UseID = Convert.ToInt32(Session["UserID"]),
                    ProID = Convert.ToInt32(Session["ProductID"])




                };
                //int Registration = sc.AddToCart(u);
                if (Registration.Equals(1))
                {
                    Response.Redirect("Cart.aspx");
                }
                else
                {
                    Response.Redirect("AboutPage33.aspx");
                }
            }
            else
            {
                Response.Redirect("Home.aspx");
            }*/
        }
    }
}
