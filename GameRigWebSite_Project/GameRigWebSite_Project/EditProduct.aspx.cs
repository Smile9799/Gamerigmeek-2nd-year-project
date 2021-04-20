using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using GameRigWebSite_Project.ServiceReference1;
namespace GameRigWebSite_Project
{
    public partial class EditProduct1 : System.Web.UI.Page
    { Service2Client sc = new Service2Client();
        protected void Page_Load(object sender, EventArgs e)
        {

            if (Session["Name"] == null)
            {
                Response.Redirect("Home.aspx");
            }
            else
            {
                if (!Session["UserType"].Equals("Manager"))
                {
                    Response.Redirect("Home.aspx");
                }
                else
                {
                    if (!IsPostBack)
                    {
                        AddProduct part = sc.GetProduct(Convert.ToInt32(Request.QueryString["A"]));

                        pname.Value = part.name;
                        price.Value =Convert.ToString( part.price);
                        quantity.Value = part.Quant;
                        col.Value = part.Col;
                        desc.Value = part.desc;
                        type.Value = part.type;
                        img.Value = part.imgurl;

                    }
                }
            }
        }
        protected void Button1_click(object e, EventArgs ev)
        {
            AddProduct prod = new AddProduct
            {
               name=pname.Value,
                price=Convert.ToInt32( price.Value),
                Quant=quantity.Value,
                Col=col.Value,
                desc=desc.Value,
                type=type.Value,
                imgurl=img.Value
            };
            var edit = sc.EditProduct(prod, Convert.ToInt32(Request.QueryString["A"]));
            if (edit == true)
            {
                Response.Redirect("Home.aspx");
            }
        }
    }
}