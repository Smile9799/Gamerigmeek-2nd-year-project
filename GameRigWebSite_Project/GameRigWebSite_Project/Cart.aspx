<%@ Page Title="" Language="C#" MasterPageFile="~/GameRigMasterPage.Master" AutoEventWireup="true" CodeBehind="Cart.aspx.cs" Inherits="GameRigWebSite_Project.Cart" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
<script type="text/javascript">

        function updateQty(productID) {
            var qty = document.getElementById(productID).value;

             window.location.href = "Cart.aspx?ProductID=" + productID + "&Qty=" + qty;
           
           
        }

        function notifyUser() {
             alert("Only few items remaining");
        }
    
         
    </script>

     <form method="post" action="#" runat="server" class="fields">
           
    <section class="ftco-section ftco-cart">
			<div class="container">
				<div class="row">
    			<div class="col-md-12 ftco-animate">
    				<div class="cart-list">
	    				<table class="table">
						    <thead class="thead-primary">
						      <tr class="text-center">
						        <th>&nbsp;</th>
						        <th>&nbsp;</th>
						        <th>Product name</th>
						        <th>Price</th>
						        <th>Quantity</th>
                                  <th>Update Cart</th>
                                  <th>Remove</th>
						        <th>Total</th>
						      </tr>
						    </thead>
						    <tbody id="theCart" runat="server">
                                
						  
						    </tbody>
						  </table>
					  </div>
    			</div>
    		</div>
               
    		<div class="row justify-content-end">
    			<div class="col-lg-4 mt-5 cart-wrap ftco-animate">
    				<div class="cart-total mb-3">
    					<h3>Coupon Code</h3>
    					<p>Enter your coupon code if you have one</p>
                       
  						
	              <div class="form-group">
	              	<label for="">Coupon code</label>
	                <input id="coupon" runat="server" type="text" class="form-control text-left px-3" placeholder="">
	              </div>
	          
    				</div>
    				
                   
                        
                        <asp:Button ID="applyCouponBtn" class="btn btn-primary py-3 px-4" runat="server" Text="Apply Coupon"  OnClick="applyCoupon_Click" />
                        
    			</div>
    			
    			<div class="col-lg-4 mt-5 cart-wrap ftco-animate" style="margin-left:630px">
                     
    				<div class="cart-total mb-3">
    					<h3>Cart Totals</h3>
    					<p class="d-flex">
    						<span>Subtotal</span>
    						<span id="subtotal" runat="server"></span>
    					</p>
    					<p class="d-flex">
    						<span>Delivery</span>
    						<span id="delivery" runat="server"></span>
    					</p>
    					<p class="d-flex">
    						<span>Discount</span>
    						<span id="discount" runat="server"></span>
    					</p>
    					<hr>
                        <p class="d-flex">
    						<span id="vat" runat="server"></span>
    						<span id="vatValue" runat="server"></span>
    					</p>
    					<p class="d-flex total-price">
    						<span>Total</span>
    						<span id="totalPrice" runat="server"></span>
    					</p>
    				</div>

                    <div id="checkoutDiv" runat="server" visible="false">
            
                    </div>
                       
    			</div>
    		</div>
			</div>
		</section>
            </form> 

    		
</asp:Content>
