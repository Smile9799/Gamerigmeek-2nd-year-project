<%@ Page Title="" Language="C#" MasterPageFile="~/GameRigMasterPage.Master" AutoEventWireup="true" CodeBehind="DeleteProduct.aspx.cs" Inherits="GameRigWebSite_Project.DeleteProduct" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <section id="form"><!--form-->
		<div class="container">
			<div class="row">
				<div class="col-sm-4 col-sm-offset-1">
					<div class="login-form"><!--login form-->
						<h2>Delete Product</h2>
						<form action="#" method="post" runat="server">
							<input type="text" placeholder="Product Id" id="pID" runat="server"/>
                            <asp:Button ID="Button2" type="submit" runat="server" Text="Delete" OnClick="Button2_click" />

						</form>
					</div><!--/login form-->
				</div>
                 <div class="row form-group" visible="false" runat="server" id="messageDiv">
                    <div class="col-md-12">
                        <textarea name="message" id="message" cols="30" rows="5" class="form-control" placeholder="" runat="server"></textarea>
                    </div>
                </div>
			</div>
		</div>
       
	</section><!--/form-->
</asp:Content>
