<%@ Page Title="" Language="C#" MasterPageFile="~/GameRigMasterPage.Master" AutoEventWireup="true" CodeBehind="ProductId.aspx.cs" Inherits="GameRigWebSite_Project.ProductId" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <title>ProductId</title>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
     <section id="form"><!--form-->
		<div class="container">
			<div class="row">
				<div class="col-sm-4 col-sm-offset-1">
					<div class="login-form"><!--login form-->
						<h2>Search Your Product</h2>
						<form action="#" method="post" runat="server">
							<input type="text" placeholder="ProductID" id="id" runat="server"/>
                            <asp:Button ID="Button2" type="submit" runat="server" Text="Search" OnClick="Button2_click" />
						</form>
					</div><!--/login form-->
				</div>
			</div>
		</div>
	</section><!--/form-->
</asp:Content>
