using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using GameRigWebSite_Project.ServiceReference1;
namespace GameRigWebSite_Project
{
    public partial class Desktops : System.Web.UI.Page
    {
        Service2Client sc = new Service2Client();

        protected void Page_Load(object sender, EventArgs e)
        {
            var items = sc.getAllProducts();



            if (Session["Name"] != null)
            {
                foreach (ProductTable pa in items)
                {
                    string display = "";

                    if (pa.Type.Equals("Desktop"))
                    {
                        display += "<div class='col-sm-3'><div class='product-image-wrapper'>";
                        display += "<div class='single-products'><div class='productinfo text-center'>";
                        display += "<a href='AboutProduct.aspx?ID=" + pa.ProductId + "'>";
                        display += "<img src='" + pa.ImgUrl + "' alt='' /><h2>R" + pa.Price + "</h2>";
                        display += "<h>" + pa.ProductName + "</h></a><br><a href='Cart.aspx?ProductID=" + pa.ProductId + "&Qty=1'><font color='red'>AddToCart</font></a></div></div></div></div>";

                    }
                    desktops.InnerHtml += display;
                }
            }
            else
            {
                foreach (ProductTable pa in items)
                {
                    string display = "";

                    if (pa.Type.Equals("Desktop"))
                    {
                        display += "<div class='col-sm-3'><div class='product-image-wrapper'>";
                        display += "<div class='single-products'><div class='productinfo text-center'>";
                        display += "<a href='AboutProduct.aspx?ID=" + pa.ProductId + "'>";
                        display += "<img src='" + pa.ImgUrl + "' alt='' /><h2>R" + pa.Price + "</h2>";
                        display += "<h>" + pa.ProductName + "</h></a></div></div></div></div>";

                    }
                    desktops.InnerHtml += display;
                }
            }


        }
        protected void Price_Click(object sender, EventArgs e)
        {
            desktops.InnerHtml = null;
            var items = sc.getAllFpProducts();



            foreach (ProductTable pa in items)
            {
                string display = "";

                if (pa.Type.Equals("Desktop"))
                {
                    display += "<div class='col-sm-3'><div class='product-image-wrapper'>";
                    display += "<div class='single-products'><div class='productinfo text-center'>";
                    display += "<a href='AboutProduct.aspx?ID=" + pa.ProductId + "'>";
                    display += "<img src='" + pa.ImgUrl + "' alt='' /><h2>R" + pa.Price + "</h2>";
                    display += "<h>" + pa.ProductName + "</h></a></div></div></div></div>";

                }
                desktops.InnerHtml += display;
            }
        }
        protected void Name_Click(object sender, EventArgs e)
        {
            desktops.InnerHtml = null;
            var items = sc.getAllFnProducts();



            foreach (ProductTable pa in items)
            {
                string display = "";

                if (pa.Type.Equals("Desktop"))
                {
                    display += "<div class='col-sm-3'><div class='product-image-wrapper'>";
                    display += "<div class='single-products'><div class='productinfo text-center'>";
                    display += "<a href='AboutProduct.aspx?ID=" + pa.ProductId + "'>";
                    display += "<img src='" + pa.ImgUrl + "' alt='' /><h2>R" + pa.Price + "</h2>";
                    display += "<h>" + pa.ProductName + "</h></a></div></div></div></div>";

                }
                desktops.InnerHtml += display;
            }
        }
    }
}