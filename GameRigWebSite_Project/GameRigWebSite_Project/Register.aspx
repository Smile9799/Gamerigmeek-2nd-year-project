<%@ Page Title="" Language="C#" MasterPageFile="~/GameRigMasterPage.Master" AutoEventWireup="true" CodeBehind="Register.aspx.cs" Inherits="GameRigWebSite_Project.Register" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <title>Register</title>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    	<div class="container">
            <div class="row">     
    <div class="col-sm-4">
					<div class="signup-form"><!--sign up form-->
						<h2>New User Signup!</h2>
						<form action="#" method="post" runat="server">
                            <label >First name</label>
							<input type="text" placeholder="First Name"  id="fname" runat ="server"/>
                            <label >Last name</label>
                            <input type="text" placeholder="Last Name" id="lname" runat ="server"/>
                            <label >Email</label>
							<input type="email" placeholder="Email Address" id="email1" runat ="server"/>
                            <label >Cell number</label>
                            <input type="text" minlength="10" maxlength="10" value="0" placeholder="Cell number" id="cell" runat ="server"/>
                            <label >Password</label>
							<input type="password" title="at least one number and one uppercase and lowercase letter, and at least 8 or more characters" pattern="(?=.*\d)(?=.*[a-z])(?=.*[A-Z]).{8,}" minlength="8" placeholder="Password" id="pass" runat ="server"/>
                            <label >Confirm password</label>
                            <input type="password" title="at least one number and one uppercase and lowercase letter, and at least 8 or more characters" pattern="(?=.*\d)(?=.*[a-z])(?=.*[A-Z]).{8,}"  minlength="8" placeholder="ConfirmPassword" id="con_pass" runat ="server"/>
                           <div id="Utype" runat="server" visible="false">
                               <label >UserType</label>
                               <select id="userType" runat="server">
                                   <option selected>Customer</option>
                                   <option value="1">Admin</option>
                                   <option value="2">Manager</option>
                               </select>
                           </div> 
                            <br />
                            <br />
							<asp:Button ID="Button1" type="submit" runat="server" Text="SignUp" OnClick="Button1_click" />
                              <div  visible="false" runat="server" id="messageDiv" >
                    <div>
                        <textarea name="message" id="message" cols="30" rows="5"  placeholder="" runat="server"></textarea>
                    </div>
                </div>
						</form>
					</div><!--/sign up form-->
				</div>
                </div>
            </div>
           <br />
        <br />
        <br />
</asp:Content>
