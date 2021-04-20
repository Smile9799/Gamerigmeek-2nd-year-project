using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using GameRigWebSite_Project.ServiceReference1;
namespace GameRigWebSite_Project
{
    public partial class Laptops : System.Web.UI.Page
    {
        Service2Client sc = new Service2Client();

        protected void Page_Load(object sender, EventArgs e)
        {
            var items = sc.getAllProducts();

            if (Session["Name"] != null)
            {
                foreach (ProductTable p in items)
                {
                    string display = "";

                    if (p.Type.Equals("Laptop"))
                    {
                        display += "<div class='col-sm-4'><div class='product-image-wrapper'>";
                        display += "<div class='single-products'><div class='productinfo text-center'>";
                        display += "<a href='AboutProduct.aspx?ID=" + p.ProductId + "'>";
                        display += "<img src='" + p.ImgUrl + "' alt='' /><h2>R" + p.Price + "</h2>";
                        display += "<h>" + p.ProductName + "</h></a><br><a href='Cart.aspx?ProductID=" + p.ProductId + "&Qty=1'><font color='red'>AddToCart</font></a></div></div></div></div>";

                    }
                    laptops.InnerHtml += display;
                }
            }
            else
            {
                foreach (ProductTable p in items)
                {
                    string display = "";

                    if (p.Type.Equals("Laptop"))
                    {
                        display += "<div class='col-sm-4'><div class='product-image-wrapper'>";
                        display += "<div class='single-products'><div class='productinfo text-center'>";
                        display += "<a href='AboutProduct.aspx?ID=" + p.ProductId + "'>";
                        display += "<img src='" + p.ImgUrl + "' alt='' /><h2>R" + p.Price + "</h2>";
                        display += "<h>" + p.ProductName + "</h></a></div></div></div></div>";

                    }
                    laptops.InnerHtml += display;
                }
            }

        }



        protected void Price_Click(object sender, EventArgs e)
        {
            laptops.InnerHtml = null;
            var items = sc.getAllFpProducts();

            foreach (ProductTable p in items)
            {
                string display = "";

                if (p.Type.Equals("Laptop"))
                {
                    display += "<div class='col-sm-4'><div class='product-image-wrapper'>";
                    display += "<div class='single-products'><div class='productinfo text-center'>";
                    display += "<a href='AboutProduct.aspx?ID=" + p.ProductId + "'>";
                    display += "<img src='" + p.ImgUrl + "' alt='' /><h2>R" + p.Price + "</h2>";
                    display += "<h>" + p.ProductName + "</h></a></div></div></div></div>";
                    display += "<br/>";
                    display += "<br/>";
                    display += "<br/>";

                }
                laptops.InnerHtml += display;
            }
        }
        protected void Name_Click(object sender, EventArgs e)
        {
            laptops.InnerHtml = null;
            var items = sc.getAllFnProducts();

            foreach (ProductTable p in items)
            {
                string display = "";

                if (p.Type.Equals("Laptop"))
                {
                    display += "<div class='col-sm-4'><div class='product-image-wrapper'>";
                    display += "<div class='single-products'><div class='productinfo text-center'>";
                    display += "<a href='AboutProduct.aspx?ID=" + p.ProductId + "'>";
                    display += "<img src='" + p.ImgUrl + "' alt='' /><h2>R" + p.Price + "</h2>";
                    display += "<h>" + p.ProductName + "</h></a></div></div></div></div>";

                }
                laptops.InnerHtml += display;
            }
        }
    }
}