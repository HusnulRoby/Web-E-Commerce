<%@ Page Title="" Language="C#" MasterPageFile="~/formPembeli.Master" AutoEventWireup="true" CodeBehind="viewCart.aspx.cs" Inherits="projectTA1.viewCart" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <form runat="server">
           
        <asp:Repeater ID="rPt" runat="server">
            <HeaderTemplate>
                <table class="table table-hover" border="1">
                    <thead>
            </HeaderTemplate>
            <ItemTemplate>
                <tr>
                    <th rowspan="3"><%#Eval("id_pembeli")%></th>
                    <th colspan="2"><%#Eval("nama_produk")%></th>
                    
                </tr>
                <tr>

                    <th><%#Eval("quantity")%></th>
                    <th><%#Eval("warna")%></th>

                </tr>
                <tr>
                    <th colspan="2"><%#Eval("ukuran")%></th>
                </tr>
                <tr>
                    <th style="border-left:hidden;border-right:hidden" colspan="3"></th>
                </tr>
            </ItemTemplate>
            <FooterTemplate>
                </thead>
                </table>
            </FooterTemplate>
        </asp:Repeater>
        <a href="checkOut.aspx">Check Out</a>
        <asp:Label ID="cart" runat="server">Cart</asp:Label>
    </form>
</asp:Content>
