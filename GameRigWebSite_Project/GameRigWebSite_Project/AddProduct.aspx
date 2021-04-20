<%@ Page Title="" Language="C#" MasterPageFile="~/GameRigMasterPage.Master" AutoEventWireup="true" CodeBehind="AddProduct.aspx.cs" Inherits="GameRigWebSite_Project.EditProduct" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <title>AddProduct</title>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="container">
            <div class="row">     
    <div class="col-sm-4">
					<div class="signup-form"><!--sign up form-->
						<h2>Add Your Product</h2>
						<form id="add" runat="server">
                            <label>Product Name</label>
							<input type="text" placeholder="Product Name"  id="pname" runat ="server"/>
                            <label>Product Description</label>
                            <input type="text" placeholder="Product Description"  id="description" runat ="server"/>
                            <label>Product Price</label>
                            <input type="text" placeholder="Price" id="price" runat ="server"/>
                            <label>Product Quantity</label>
							<input type="number" min="1" placeholder="Quantity" id="quantity" runat ="server"/>
                            <label>Product Colour</label>
                            <input type="text" placeholder="Colour" id="col" runat ="server"/>
                            <label>Product Type</label>
                            <input type="text" placeholder="Product Type"  id="type" runat ="server"/>
                            <label>Product Image</label>
                            <input type="text" placeholder="Product Image"  id="img" runat ="server"/>
							<asp:Button ID="Button1" type="submit" runat="server" Text="AddProduct" OnClick="Button1_click" />
						</form>
					</div><!--/sign up form-->
				</div>
                </div>
            </div>
       <br />
        <br />
        <br />
</asp:Content>
