using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using GameRigWebSite_Project.ServiceReference1;
namespace GameRigWebSite_Project
{
    public partial class Processors : System.Web.UI.Page
    {
        Service2Client sc = new Service2Client();

        protected void Page_Load(object sender, EventArgs e)
        {
            var items = sc.getAllProducts();


            if (Session["Name"] != null)
            {
                foreach (ProductTable pd in items)
                {
                    string display = "";
                    if (pd.Type.Equals("Components"))
                    {

                        display += "<div class='col-sm-3'><div class='product-image-wrapper'>";
                        display += "<div class='single-products'><div class='productinfo text-center'>";
                        display += "<a href='AboutProduct.aspx?ID=" + pd.ProductId + "'>";
                        display += "<img src='" + pd.ImgUrl + "' alt='' /><h2>R" + pd.Price + "</h2>";
                        display += "<h>" + pd.ProductName + "</h></a><br><a href='Cart.aspx?ProductID=" + pd.ProductId + "&Qty=1'><font color='red'>AddToCart</font></a></div></div></div></div>";

                    }
                    components.InnerHtml += display;
                }
            }
            else
            {
                foreach (ProductTable pd in items)
                {
                    string display = "";
                    if (pd.Type.Equals("Components"))
                    {

                        display += "<div class='col-sm-3'><div class='product-image-wrapper'>";
                        display += "<div class='single-products'><div class='productinfo text-center'>";
                        display += "<a href='AboutProduct.aspx?ID=" + pd.ProductId + "'>";
                        display += "<img src='" + pd.ImgUrl + "' alt='' /><h2>" + pd.Price + "</h2>";
                        display += "<h>" + pd.ProductName + "</h></a></div></div></div></div>";

                    }
                    components.InnerHtml += display;
                }
            }



        }

        protected void Price_Click(object sender, EventArgs e)
        {
            components.InnerHtml = null;
            var items = sc.getAllFpProducts();


            foreach (ProductTable pd in items)
            {
                
                string display = "";
                if (pd.Type.Equals("Components"))
                {

                    display += "<div class='col-sm-3'><div class='product-image-wrapper'>";
                    display += "<div class='single-products'><div class='productinfo text-center'>";
                    display += "<a href='AboutProduct.aspx?ID=" + pd.ProductId + "'>";
                    display += "<img src='" + pd.ImgUrl + "' alt='' /><h2>" + pd.Price + "</h2>";
                    display += "<h>" + pd.ProductName + "</h></a></div></div></div></div>";

                }
                components.InnerHtml += display;
            }

        }
        protected void Name_Click(object sender, EventArgs e)
        {
            components.InnerHtml = null;
            var items = sc.getAllFnProducts();


            foreach (ProductTable pd in items)
            {
                string display = "";
                if (pd.Type.Equals("Components"))
                {

                    display += "<div class='col-sm-3'><div class='product-image-wrapper'>";
                    display += "<div class='single-products'><div class='productinfo text-center'>";
                    display += "<a href='AboutProduct.aspx?ID=" + pd.ProductId + "'>";
                    display += "<img src='" + pd.ImgUrl + "' alt='' /><h2>" + pd.Price + "</h2>";
                    display += "<h>" + pd.ProductName + "</h></a></div></div></div></div>";

                }
                components.InnerHtml += display;
            }

        }
    }
}