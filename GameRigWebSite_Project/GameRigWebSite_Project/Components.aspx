﻿<%@ Page Title="" Language="C#" MasterPageFile="~/GameRigMasterPage.Master" AutoEventWireup="true" CodeBehind="Components.aspx.cs" Inherits="GameRigWebSite_Project.Processors" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <form runat="server" style="margin-left: 635px">
     <asp:Button runat="server" OnClick="Price_Click" Text="Filter by Price"  />
        <asp:Button runat="server" ID="Name" OnClick="Name_Click" Text="Filter by Name" />
    </form> 
        <div class="features_items" id="components" runat="server"><!--features_items-->
					
                        </div>
    
</asp:Content>
