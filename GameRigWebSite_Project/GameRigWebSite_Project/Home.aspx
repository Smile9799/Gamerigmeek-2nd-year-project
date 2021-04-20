<%@ Page Title="" Language="C#" MasterPageFile="~/GameRigMasterPage.Master" AutoEventWireup="true" CodeBehind="Home.aspx.cs" Inherits="GameRigWebSite_Project.Home" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <title>Home</title>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <form runat="server">
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
									<h1><span>G</span>ameRig</h1>
									<h2>FIFA 20</h2>
									<p>This year Competion</p>
									 <asp:Button Text="More" runat="server" OnClick="more3_Click"  class="btn btn-default get"/>
								</div>
								<div class="col-sm-6">
									<img src="images/GameRigHome/unnamed.jpg" class="girl img-responsive" alt="" />
								</div>
							</div>
							<div class="item">
								<div class="col-sm-6">
									<h1><span>G</span>ameRig</h1>
									<h2>Players Lounge</h2>
									<p>Join our player's lounge <strong>today</strong> </p>
									 <asp:Button Text="More" runat="server" OnClick="more2_Click"  class="btn btn-default get"/>
								</div>
								<div class="col-sm-6">
									<img src="images/GameRigHome/Playerlounge.jpg" class="girl img-responsive" alt="" />
								</div>
							</div>
							
							<div class="item">
								<div class="col-sm-6">
									<h1><span>G</span>ameRig</h1>
									<h2>First Prize</h2>
									<p>Our Prize for first place winner</p>
                                    <asp:Button Text="More" runat="server" OnClick="more1_Click"  class="btn btn-default get"/>
								</div>
								<div class="col-sm-6">
									<img src="images/CapeTown.jpg" class="girl img-responsive" alt="" />
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
    </form>
	
	<section>
		<div class="container">
			<div class="row">				
				<div class="col-sm-9 padding-right">
					<div class="features_items"><!--features_items-->
						<h2 class="title text-center">Features Items</h2>
                        <div id="produ" runat="server">					
					</div>
						<!--features_items-->
					<div class="category-tab"><!--category-tab-->
						<div class="col-sm-12">
							<ul class="nav nav-tabs">
								<li class="active"><a href="Laptops.aspx" >Laptops</a></li>
								<li><a href="Desktops.aspx" >Desktop</a></li>
								<li><a href="Accesories.aspx" >Accesories</a></li>
								<li><a href="Components.aspx" >Components</a></li>
                                <li><a href="Monitors.aspx" >Monitors</a></li>

							</ul>
						</div>
						<div class="tab-content">
							<div style="object-fit:scale-down" class="tab-pane fade active in " id="laptops" runat="server" >

							</div>
							
							<div class="tab-pane fade " id="desktops" runat="server">

							</div>
							
							<div class="tab-pane fade " id="monitors" runat="server" >

								
							</div>
							
							<div class="tab-pane fade  "  id="accesories" runat="server">
	
							</div>
							
							<div class="tab-pane fade " id="components" runat="server">
							
					
							</div>
                            
						</div>
					</div><!--/category-tab-->
				</div>
			</div>
		</div>
	</section>
</asp:Content>
