<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="formLogin.aspx.cs" Inherits="projectTA1.formLogin" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head>
    <title>Shoppy an Admin Panel Category Flat Bootstrap Responsive Website Template | Login :: w3layouts</title>
    <meta name="viewport" content="width=device-width, initial-scale=1"//>
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <meta name="keywords" content="Shoppy Responsive web template, Bootstrap Web Templates, Flat Web Templates, Android Compatible web template, 
Smartphone Compatible web template, free webdesigns for Nokia, Samsung, LG, SonyEricsson, Motorola web design" />
    <script type="application/x-javascript"> addEventListener("load", function() { setTimeout(hideURLbar, 0); }, false); function hideURLbar(){ window.scrollTo(0,1); } </script>
    <!-- jQuery (necessary for Bootstrap's JavaScript plugins) -->
    <link href="template/css/bootstrap.css" rel="stylesheet" type="text/css" media="all"/>
    <!-- Custom Theme files -->
    <link href="template/css/style.css" rel="stylesheet" type="text/css" media="all" />
    <!--js-->
    <script src="template/js/jquery-2.1.1.min.js"></script>
    <!--icons-css-->
    <link href="template/css/font-awesome.css" rel="stylesheet"/>
    <!--Google Fonts-->
    <link href='//fonts.googleapis.com/css?family=Carrois+Gothic' rel='stylesheet' type='text/css'/>
    <link href='//fonts.googleapis.com/css?family=Work+Sans:400,500,600' rel='stylesheet' type='text/css'/>
    <!--static chart-->
</head>
<body>
    <div class="login-page">
        <div class="login-main">
            <div class="login-head">
                <h1>Login</h1>
            </div>
            <div class="login-block">
                <form runat="server">
                    <asp:TextBox ID="TextBox1" runat="server" placeholder="Username" OnTextChanged="TextBox1_TextChanged"></asp:TextBox>
                    <asp:TextBox ID="TextBox2" runat="server" TextMode="Password" Text="Password" placeholder="Password"></asp:TextBox>
                    <asp:Label id="pesan" runat="server" Text="salah" Visible="false"  ></asp:Label>
                    <div class="forgot-top-grids">
                        <div class="forgot-grid">
                            <ul>
                                <li>
                                    <input type="checkbox" id="brand1" value=""/>
                                    <label for="brand1"><span></span>Remember me</label>
                                </li>
                            </ul>
                        </div>
                        <div class="forgot">
                            <a href="#">Forgot password?</a>
                        </div>
                        <div class="clearfix"></div>
                    </div>
                    <asp:Button ID="Button1" runat="server" Text="Login" OnClick="Button1_Click"/>
                </form>
            </div>
        </div>
    </div>
    <!--inner block end here-->
    <!--copy rights start here-->
    <div class="copyrights">
        <p>© 2016 Shoppy. All Rights Reserved | Design by  <a href="http://w3layouts.com/" target="_blank">W3layouts</a> </p>
    </div>
    <!--COPY rights end here-->

    <!--scrolling js-->
    <script src="template/js/jquery.nicescroll.js"></script>
    <script src="template/js/scripts.js"></script>
    <!--//scrolling js-->
    <script src="template/js/bootstrap.js"> </script>
    <!-- mother grid end here-->
</body>
</html>
