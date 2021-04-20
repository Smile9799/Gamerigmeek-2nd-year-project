using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using GameRigWebSite_Project.ServiceReference1;

namespace GameRigWebSite_Project
{
    public partial class Home : System.Web.UI.Page
    {
        Service2Client sc = new Service2Client();

        protected void Page_Load(object sender, EventArgs e)
        {
           
            var items = sc.getAllProducts();



            if (Session["Name"] != null)
            {
                foreach (ProductTable pr in items)
                {

                    string display = "";
                    if (pr.Type.Equals("Laptop"))
                    {
                        display += "<div class='col-sm-3'><div class='product-image-wrapper'>";
                        display += "<div class='single-products'><div class='productinfo text-center'>";
                        display += "<a href='AboutProduct.aspx?ID=" + pr.ProductId + "'>";
                        display += "<img src='" + pr.ImgUrl + "' alt='' /><h2>R" + pr.Price + "</h2>";
                        display += "<h>" + pr.ProductName + "</h></a><br><a href='Cart.aspx?ProductID=" + pr.ProductId + "&Qty=1'><font color='red'>AddToCart</font></a></div></div></div></div>";
                        Session["ProductID"] = pr.ProductId;
                    }
                    laptops.InnerHtml += display;
                }

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
                foreach (ProductTable pr in items)
                {
                    string display = "";
                    if (pr.Type.Equals("Laptop"))
                    {
                        display += "<div class='col-sm-3'><div class='product-image-wrapper'>";
                        display += "<div class='single-products'><div class='productinfo text-center'>";
                        display += "<a href='AboutProduct.aspx?ID=" + pr.ProductId + "'>";
                        display += "<img src='" + pr.ImgUrl + "' alt='' /><h2>R" + pr.Price + "</h2>";
                        display += "<h>" + pr.ProductName + "</h></a></div></div></div></div>";

                    }
                    laptops.InnerHtml += display;
                }

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

                foreach (ProductTable pd in items)
                {
                    string display = "";
                    if (pd.Type.Equals("Components"))
                    {

                        display += "<div class='col-sm-3'><div class='product-image-wrapper'>";
                        display += "<div class='single-products'><div class='productinfo text-center'>";
                        display += "<a href='AboutProduct.aspx?ID=" + pd.ProductId + "'>";
                        display += "<img src='" + pd.ImgUrl + "' alt='' /><h2>R" + pd.Price + "</h2>";
                        display += "<h>" + pd.ProductName + "</h></a></div></div></div></div>";

                    }
                    components.InnerHtml += display;
                }
            }













        }

        protected void more1_Click(object sender, EventArgs e)
        {
            Response.Redirect("AboutProduct.aspx?ID=1002");
        }
        protected void more2_Click(object sender, EventArgs e)
        {
            Response.Redirect("AboutProduct.aspx?ID=1004");
        }
        protected void more3_Click(object sender, EventArgs e)
        {
            Response.Redirect("AboutProduct.aspx?ID=1006");
        }
    }
}

