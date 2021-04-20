<%@ Page Title="" Language="C#" MasterPageFile="~/GameRigMasterPage.Master" AutoEventWireup="true" CodeBehind="login.aspx.cs" Inherits="GameRigWebSite_Project.login" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <title>LogIn</title>
    <link href="css/loginstyle.css" rel="stylesheet">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <section id="form"><!--form-->
		<div class="container">
			<div class="row">
				<div class="col-sm-4 col-sm-offset-1">
					<div class="login-form"><!--login form-->
						<h2>Login to your account</h2>
						<form action="#" method="post" runat="server">
							<input type="email" placeholder="Email Address" id="email" runat="server"/>
                            <input type="password" placeholder="Password" id="password" runat="server"/>
                            <asp:Button ID="Button2" type="submit" runat="server" Text="SignIn" OnClick="Button2_click" />
                              <asp:Button ID="Button1" runat="server" type="submit" text="Don't Have an Account.Sign Up" class="primary" OnClick="BtnSend_Click1" />
                             <div  visible="false" runat="server" id="messageDiv" >
                    <div>
                        <textarea name="message" id="message" cols="30" rows="5"  placeholder="" runat="server"></textarea>
                    </div>
                </div>
						</form>
					</div><!--/login form-->
				</div>
			</div>
		</div>
	</section><!--/form-->
</asp:Content>
