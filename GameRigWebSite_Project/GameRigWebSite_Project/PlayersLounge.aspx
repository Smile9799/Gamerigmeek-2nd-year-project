<%@ Page Title="" Language="C#" MasterPageFile="~/GameRigMasterPage.Master" AutoEventWireup="true" CodeBehind="PlayersLounge.aspx.cs" Inherits="GameRigWebSite_Project.PlayersLounge" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
     <section id="slider"><!--slider-->
		<div class="container">
			<div class="row">
				<div class="col-sm-12">
					<div id="slider-carousel" class="carousel slide" data-ride="carousel">
						<ol class="carousel-indicators">
							<li data-target="#slider-carousel" data-slide-to="0" class="active"></li>
							<li data-target="#slider-carousel" data-slide-to="1"></li>
							<li data-target="#slider-carousel" data-slide-to="2"></li>
						</ol>
						
						<div class="carousel-inner">
							<div class="item active">
								<div class="col-sm-6">
									<h1><span>PLAYERS</span>-LOUNGE</h1>
									<h2 >FIFA OR TAKEN? WHATS YOUR POISON</h2>
									<p>You stand a chance to win a once in a lifetime opportunity. </p>
									<a href="CompInformation.aspx" class="btn btn-default get">JOIN NOW!</a>
								</div>
								<div class="col-sm-6">
									<img src="images/Playerlounge.jpg" class="girl img-responsive" alt="" />
								</div>
							</div>
							<div class="item">
								<div class="col-sm-6">
									<h1><span>PLAYERS</span>-LOUNGE</h1>
									<h2>Are you ready for this years heat?</h2>
									<p>Do you have what it takes to be this years champ? </p>
									<a href="CompInformation.aspx" class="btn btn-default get">JOIN NOW!</a>
								</div>
								<div class="col-sm-6">
									<img src="images/Playerlounge.jpg" class="girl img-responsive" alt="" />
								</div>
							</div>
							
							<div class="item">
								<div class="col-sm-6">
                                  	<h1><span>PLAYERS</span>-LOUNGE</h1>
                                      <h2>Looking for a good time?</h2>
									<p>Do you have what it takes to be this years champ?  </p>
									<a href="CompInformation.aspx" class="btn btn-default get">JOIN NOW!</a>
								</div>
								<div class="col-sm-6">
									<img src="images/Playerlounge.jpg" class="girl img-responsive" alt="" />
								</div>
							</div>
							
						</div>
						
						<a href="#slider-carousel" class="left control-carousel hidden-xs" data-slide="prev">
							<i class="fa fa-angle-left"></i>
						</a>
						<a href="#slider-carousel" class="right control-carousel hidden-xs" data-slide="next">
							<i class="fa fa-angle-right"></i>
						</a>
					</div>
					
				</div>
			</div>
		</div>
	</section><!--/slider-->
	
	<section>
		<div class="container">
			<div class="row">

				
				<div class="col-sm-9 padding-right">
					<div class="features_items"><!--features_items-->
						<h2 class="title text-center">Available Prizes To Be Won!</h2>
						<div class="col-sm-4">
							<div class="product-image-wrapper">
								<div class="single-products">
										<div class="productinfo text-center">
											<img src="images/CapeTown.jpg" alt="" />
											<h2>1st Place</h2>
											<p>Win a trip to CapeTown for two nights</p>
										</div>

								</div>
							</div>
						</div>
						<div class="col-sm-4">
							<div class="product-image-wrapper">
								<div class="single-products">
									<div class="productinfo text-center">
										<img src="images/XBox.jpg" alt="" />
										<h2>2nd place</h2>
										<p>Win a brand new console on us</p>
									</div>
								</div>
							</div>
						</div>
						<div class="col-sm-4">
							<div class="product-image-wrapper">
								<div class="single-products">
									<div class="productinfo text-center">
										<img src="images/restaurant.jpg" alt="" />
										<h2>3rd Place</h2>
										<p>Win a dinner on us</p>
									</div>
								</div>
							</div>
						</div>
						<h3 style="color :crimson"> How to Enter?</h3>
                        <p> Buy any one of our participating products with the Free Players Pass Sticker, Or pay R300 to join the Players Lounge Crew. 
                            T's & C's Conditions Apply. For More Information Press <a href="CompInformation.aspx" style="color:green">Join Now!</a> 

                        </p>
                        
						
	</section>
</asp:Content>
