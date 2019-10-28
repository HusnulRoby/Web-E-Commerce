<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="projectTA1.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Repeater ID="R" runat="server">
                <HeaderTemplate>
                    <table class="table table-hover" border="1" style="background-color: red">
                </HeaderTemplate>
                <ItemTemplate>

                    <tr>
                        <td colspan="3"><%#Eval("gambar") %></td>
                        <td colspan="3"><%#Eval("gambar") %></td>
                        <td colspan="3"><%#Eval("gambar") %></td>
                    </tr>
                    <tr>
                        <td colspan="3"><%#Eval("kategori") %></td>
                        <td colspan="3"><%#Eval("kategori") %></td>
                        <td colspan="3">kategori</td>
                    </tr>
                    <tr>
                        <td colspan="3"><%#Eval("nama") %></td>
                        <td colspan="3">nama</td>
                        <td colspan="3">nama</td>
                    </tr>
                    <tr>
                        <td colspan="3">harga</td>
                        <td colspan="3">harga</td>
                        <td colspan="3">harga</td>
                    </tr>
                    <tr>
                        <td>love</td>
                        <td>panah</td>
                        <td>mata</td>

                        <td>love</td>
                        <td>panah</td>
                        <td>mata</td>

                        <td>love</td>
                        <td>panah</td>
                        <td>mata</td>
                    </tr>
                    <tr>
                        <td colspan="3">button</td>
                        <td colspan="3">button</td>
                        <td colspan="3">button</td>
                    </tr>
                    <tr>
                        <td colspan="3"><br /></td> 
                    </tr>
                </ItemTemplate>
                <FooterTemplate>
                    </table>
                </FooterTemplate>
            </asp:Repeater>



        </div>
    </form>
</body>
</html>
