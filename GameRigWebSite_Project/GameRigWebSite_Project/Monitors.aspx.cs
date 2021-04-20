using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using GameRigWebSite_Project.ServiceReference1;
namespace GameRigWebSite_Project
{
    public partial class Monitors : System.Web.UI.Page
    {
        Service2Client sc = new Service2Client();

        protected void Page_Load(object sender, EventArgs e)
        {
            var items = sc.getAllProducts();


            if (Session["Name"] != null)
            {
                foreach (ProductTable pb in items)
                {
                    string display = "";
                    if (pb.Type.Equals("Monitor"))
                    {
                        display += "<div class='col-sm-3'><div class='product-image-wrapper'>";
                        display += "<div class='single-products'><div class='productinfo text-center'>";
                        display += "<a href='AboutProduct.aspx?ID=" + pb.ProductId + "'>";
                        display += "<img src='" + pb.ImgUrl + "' alt='' /><h2>R" + pb.Price + "</h2>";
                        display += "<h>" + pb.ProductName + "</h></a><br><a href='Cart.aspx?ProductID=" + pb.ProductId + "&Qty=1'><font color='red'>AddToCart</font></a></div></div></div></div>";

                    }
                    monitors.InnerHtml += display;
                }
            }
            else
            {
                foreach (ProductTable pb in items)
                {
                    string display = "";
                    if (pb.Type.Equals("Monitor"))
                    {
                        display += "<div class='col-sm-3'><div class='product-image-wrapper'>";
                        display += "<div class='single-products'><div class='productinfo text-center'>";
                        display += "<a href='AboutProduct.aspx?ID=" + pb.ProductId + "'>";
                        display += "<img src='" + pb.ImgUrl + "' alt='' /><h2>R" + pb.Price + "</h2>";
                        display += "<h>" + pb.ProductName + "</h></a></div></div></div></div>";

                    }
                    monitors.InnerHtml += display;
                }
            }



        }
        protected void Price_Click(object sender, EventArgs e)
        {
            monitors.InnerHtml = null;
            var items = sc.getAllFpProducts();


            foreach (ProductTable pb in items)
            {
                string display = "";
                if (pb.Type.Equals("Monitor"))
                {
                    display += "<div class='col-sm-3'><div class='product-image-wrapper'>";
                    display += "<div class='single-products'><div class='productinfo text-center'>";
                    display += "<a href='AboutProduct.aspx?ID=" + pb.ProductId + "'>";
                    display += "<img src='" + pb.ImgUrl + "' alt='' /><h2>R" + pb.Price + "</h2>";
                    display += "<h>" + pb.ProductName + "</h></a></div></div></div></div>";

                }
                monitors.InnerHtml += display;
            }
        }
        protected void Name_Click(object sender, EventArgs e)
        {
            monitors.InnerHtml = null;
            var items = sc.getAllFnProducts();


            foreach (ProductTable pb in items)
            {
                string display = "";
                if (pb.Type.Equals("Monitor"))
                {
                    display += "<div class='col-sm-3'><div class='product-image-wrapper'>";
                    display += "<div class='single-products'><div class='productinfo text-center'>";
                    display += "<a href='AboutProduct.aspx?ID=" + pb.ProductId + "'>";
                    display += "<img src='" + pb.ImgUrl + "' alt='' /><h2>R" + pb.Price + "</h2>";
                    display += "<h>" + pb.ProductName + "</h></a></div></div></div></div>";

                }
                monitors.InnerHtml += display;
            }
        }
    }
}