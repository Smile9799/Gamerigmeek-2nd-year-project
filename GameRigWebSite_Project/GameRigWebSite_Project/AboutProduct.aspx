<%@ Page Title="" Language="C#" MasterPageFile="~/GameRigMasterPage.Master" AutoEventWireup="true" CodeBehind="AboutProduct.aspx.cs" Inherits="GameRigWebSite_Project.AboutProduct" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
     <div class="site-section" id="Augment">
        <div class="container">
            <div class="row">
                <div class="site-section-heading text-center mb-5 w-border col-md-6 mx-auto">
                   
                </div>
            </div>
            <div class="row" runat="server" id="product">  
               
            </div>
            <form id="frm" runat="server">
             <asp:Button id="ADDTOCART" Text="ADDTOCART" runat="server" OnClick="ADDTOCART_Click" Visible="false" style="margin-left:155px"/>

            </form>
        </div>
    </div>
</asp:Content>
