<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="formDaftar.aspx.cs" Inherits="projectTA1.formDaftar" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head>
    <title>Shoppy an Admin Panel Category Flat Bootstrap Responsive Website Template | Signup :: w3layouts</title>
    <meta name="viewport" content="width=device-width, initial-scale=1" />
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <meta name="keywords" content="Shoppy Responsive web template, Bootstrap Web Templates, Flat Web Templates, Android Compatible web template, 
Smartphone Compatible web template, free webdesigns for Nokia, Samsung, LG, SonyEricsson, Motorola web design" />
    <script type="application/x-javascript"> addEventListener("load", function() { setTimeout(hideURLbar, 0); }, false); function hideURLbar(){ window.scrollTo(0,1); } </script>
    <!-- jQuery (necessary for Bootstrap's JavaScript plugins) -->
    <link href="template/css/bootstrap.css" rel="stylesheet" type="text/css" media="all" />
    <!-- Custom Theme files -->
    <link href="template/css/style.css" rel="stylesheet" type="text/css" media="all" />
    <!--js-->
    <script src="template/js/jquery-2.1.1.min.js"></script>
    <!--icons-css-->
    <link href="template/css/font-awesome.css" rel="stylesheet">
    <!--Google Fonts-->
    <link href='//fonts.googleapis.com/css?family=Carrois+Gothic' rel='stylesheet' type='text/css'>
    <link href='//fonts.googleapis.com/css?family=Work+Sans:400,500,600' rel='stylesheet' type='text/css'>
    <!--//charts-->
</head>
<body>
    <!--inner block start here-->
    <div class="signup-page-main">
        <div class="signup-main">
            <div class="signup-head">
                <h1>Sign Up</h1>
            </div>
            <div class="signup-block">
                <form runat="server">
                    <asp:TextBox ID="txtUser" placeholder="Name" runat="server"></asp:TextBox>
                    <asp:TextBox ID="txtEm" placeholder="Email"  runat="server" ></asp:TextBox>
                    <asp:TextBox ID="txtPass" CssClass="glyphicon-lock" placeholder="Password" runat="server"></asp:TextBox>
                    <asp:Label ID="Label1" runat="server" Text="Management role :"></asp:Label>
                    <asp:RadioButton ID="admin" runat="server" text="Admin"/>
                    <asp:RadioButton ID="operator" runat="server" text="Operator" />
                    <div class="forgot-top-grids">
                        <div class="forgot-grid">
                            <ul>
                                <li>
                                    <input type="checkbox" id="brand1" value="" />
                                    <label for="brand1"><span></span>I agree to the terms</label>
                                </li>
                            </ul>
                        </div>

                        <div class="clearfix"></div>
                    </div>
                    <asp:Button ID="Button1" runat="server" Text="Sign Up" OnClick="Button1_Click" />
                </form>
                <div class="sign-down">
                    <h4>Already have an account? <a href="formLogin.aspx">Login here.</a></h4>
                </div>
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
