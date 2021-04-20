<%@ Page Title="" Language="C#" MasterPageFile="~/GameRigMasterPage.Master" AutoEventWireup="true" CodeBehind="Catalogue.aspx.cs" Inherits="GameRigWebSite_Project.catagories" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <section>
		<div class="container">
			<div class="row">				
				<div class="col-sm-9 padding-right">
					<div class="features_items"><!--features_items-->
						<h2 class="title text-center">Categories</h2>
						<div class="col-sm-4">
							<div class="product-image-wrapper">
								<div class="single-products">
										<div class="productinfo text-center">
											<img src="images/GameRigHome/index1.jpg" alt="" />
											<p>Laptops</p>
										</div>
								</div>
								<div class="choose">
									<ul class="nav nav-pills nav-justified">
										<li><a href="Laptops.aspx">Visit</a></li>
									</ul>
								</div>
							</div>
						</div>
				<div class="col-sm-4">
							<div class="product-image-wrapper">
								<div class="single-products">
										<div class="productinfo text-center">
											<img src="images/GameRigHome/index.jpg" alt="" />
											<p>Desktops</p>
										</div>
								</div>
								<div class="choose">
									<ul class="nav nav-pills nav-justified">
										<li><a href="Desktops.aspx">Visit</a></li>
									</ul>
								</div>
							</div>
						</div>
							
							<div class="col-sm-4">
							<div class="product-image-wrapper">
								<div class="single-products">
										<div class="productinfo text-center">
											<img src="images/GameRigHome/index2.jpg" alt="" />
											<p>Components</p>
										</div>
								</div>
								<div class="choose">
									<ul class="nav nav-pills nav-justified">
										<li><a href="Components.aspx">Visit</a></li>
									</ul>
								</div>
							</div>
						</div>
					<div class="col-sm-4">
							<div class="product-image-wrapper">
								<div class="single-products">
										<div class="productinfo text-center">
											<img src="images/joypad1.png" alt="" />
											<p>Accesories</p>
										</div>
								</div>
								<div class="choose">
									<ul class="nav nav-pills nav-justified">
										<li><a href="Accesories.aspx">Visit</a></li>
									</ul>
								</div>
							</div>
						</div>
					<div class="col-sm-4">
							<div class="product-image-wrapper">
								<div class="single-products">
										<div class="productinfo text-center">
											<img src="images/monitor1.png" alt="" />
											<p>Monitors</p>
										</div>
								</div>
								<div class="choose">
									<ul class="nav nav-pills nav-justified">
										<li><a href="Monitors.aspx">Visit</a></li>
									</ul>
								</div>
							</div>
						</div>
						
					</div>
                    </div>
                    </div>
                    </div>
                    </section>
</asp:Content>
