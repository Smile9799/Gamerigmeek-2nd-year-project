using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using GameRigWebSite_Project.ServiceReference1;
namespace GameRigWebSite_Project
{
    public partial class Accesories : System.Web.UI.Page
    {
        Service2Client sc = new Service2Client();

        protected void Page_Load(object sender, EventArgs e)
        {
            var items = sc.getAllProducts();



            if (Session["Name"] != null)
            {

                foreach (ProductTable pc in items)
                {
                    string display = "";
                    if (pc.Type.Equals("Accesories"))
                    {
                        display += "<div class='col-sm-3'><div class='product-image-wrapper'>";
                        display += "<div class='single-products'><div class='productinfo text-center'>";
                        display += "<a href='AboutProduct.aspx?ID=" + pc.ProductId + "'>";
                        display += "<img src='" + pc.ImgUrl + "' alt='' /><h2>R" + pc.Price + "</h2>";
                        display += "<h>" + pc.ProductName + "</h></a><br><a href='Cart.aspx?ProductID=" + pc.ProductId + "&Qty=1'><font color='red'>AddToCart</font></a></div></div></div></div>";

                    }
                    accesories.InnerHtml += display;
                }
            }
            else
            {
                foreach (ProductTable pc in items)
                {
                    string display = "";
                    if (pc.Type.Equals("Accesories"))
                    {
                        display += "<div class='col-sm-3'><div class='product-image-wrapper'>";
                        display += "<div class='single-products'><div class='productinfo text-center'>";
                        display += "<a href='AboutProduct.aspx?ID=" + pc.ProductId + "'>";
                        display += "<img src='" + pc.ImgUrl + "' alt='' /><h2>R" + pc.Price + "</h2>";
                        display += "<h>" + pc.ProductName + "</h></a></div></div></div></div>";

                    }
                    accesories.InnerHtml += display;
                }
            }


        }
        protected void Price_Click(object sender, EventArgs e)
        {
            accesories.InnerHtml = null;
            var items = sc.getAllFpProducts();



            foreach (ProductTable pc in items)
            {
                string display = "";
                if (pc.Type.Equals("Accesories"))
                {
                    display += "<div class='col-sm-3'><div class='product-image-wrapper'>";
                    display += "<div class='single-products'><div class='productinfo text-center'>";
                    display += "<a href='AboutProduct.aspx?ID=" + pc.ProductId + "'>";
                    display += "<img src='" + pc.ImgUrl + "' alt='' /><h2>R" + pc.Price + "</h2>";
                    display += "<h>" + pc.ProductName + "</h></a></div></div></div></div>";

                }
                accesories.InnerHtml += display;
            }
        }
        protected void Name_Click(object sender, EventArgs e)
        {
            accesories.InnerHtml = null;
            var items = sc.getAllFnProducts();



            foreach (ProductTable pc in items)
            {
                string display = "";
                if (pc.Type.Equals("Accesories"))
                {
                    display += "<div class='col-sm-3'><div class='product-image-wrapper'>";
                    display += "<div class='single-products'><div class='productinfo text-center'>";
                    display += "<a href='AboutProduct.aspx?ID=" + pc.ProductId + "'>";
                    display += "<img src='" + pc.ImgUrl + "' alt='' /><h2>R" + pc.Price + "</h2>";
                    display += "<h>" + pc.ProductName + "</h></a></div></div></div></div>";

                }
                accesories.InnerHtml += display;
            }
        }

    }
}