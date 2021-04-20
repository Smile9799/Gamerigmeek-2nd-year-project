<%@ Page Title="" Language="C#" MasterPageFile="~/GameRigMasterPage.Master" AutoEventWireup="true" CodeBehind="contact.aspx.cs" Inherits="GameRigWebSite_Project.contact" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <title>Contact</title>
    <link href="css/loginstyle.css" rel="stylesheet">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div id="contact-page" class="container">
    	<div class="bg">
	    	<div class="row">    		
	    		<div class="col-sm-12">    			   			
					<h2 class="title text-center">Contact <strong>Us</strong></h2>    			    				    				
					<div id="gmap" class="contact-map" style="background-color:black">
                       
					</div>
				</div>			 		
			</div>    	
    		<div class="row" runat="server">  	
	    		<div class="col-sm-8" runat="server">
	    			<div class="contact-form" runat="server">
	    				<h2 class="title text-center">Get In Touch</h2>
	    				<div class="status alert alert-success" style="display: none"></div>
				    	<form id="form" runat="server">
				            <div class="form-group col-md-6" runat="server">
                                <asp:TextBox ID="name" runat="server" placeholder="Full names" required="required" class ="form-control"></asp:TextBox>
				            </div>
				            <div class="form-group col-md-6 " runat="server">
				                
                                <asp:TextBox ID="email" runat="server" placeholder="Email" required="required" class ="form-control"></asp:TextBox>
				            </div>
				            <div class="form-group col-md-12" runat="server">
				      
                                <asp:TextBox ID="sub" runat="server" placeholder="Subject" required="required" class ="form-control"></asp:TextBox>
				            </div>
				            <div class="form-group col-md-12" runat="server">
				               <asp:TextBox ID="message" runat="server" row="8" Columns="6" placeholder="Message" TextMode="MultiLine" MaxLength="200" required="required" class ="form-control"></asp:TextBox>
				            </div>                        
				            <div class="form-group col-md-12" runat="server">
                                <asp:Button ID="send" Text="Submit" runat="server" OnClick="sendMessage" class="btn btn-primary pull-right" />
				            </div>
				        </form>
	    			</div>
	    		</div>
	    		<div class="col-sm-4">
	    			<div class="contact-info">
	    				<h2 class="title text-center">Contact Info</h2>
	    				<address>
	    					<p>GameRig Store</p>
							<p>21 Huntley street, Auckland park</p>
							<p>Johannesburg SA</p>
							<p>Mobile: 0607870139</p>
							<p>Fax: 1-714-252-0026</p>
							<p>Email: GameRig@gmail.com</p>
	    				</address>
	    				<div class="social-networks">
	    					<h2 class="title text-center">Social Networking</h2>
							<ul>
								<li>
									<a href="#"><i class="fa fa-facebook"></i></a>
								</li>
								<li>
									<a href="#"><i class="fa fa-twitter"></i></a>
								</li>
								<li>
									<a href="#"><i class="fa fa-google-plus"></i></a>
								</li>
								<li>
									<a href="#"><i class="fa fa-youtube"></i></a>
								</li>
							</ul>
	    				</div>
	    			</div>
    			</div>    			
	    	</div>  
    	</div>	
    </div><!--/#contact-page-->
</asp:Content>
