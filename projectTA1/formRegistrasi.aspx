<%@ Page Title="" Language="C#" MasterPageFile="~/formPembeli.Master" AutoEventWireup="true" CodeBehind="formRegistrasi.aspx.cs" Inherits="projectTA1.formRegistrasi" %>

<%--<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">--%>

<%--</asp:Content>--%>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <form runat="server">

        <div class="col-md-10">
            <!-- general form elements -->
            <div class="box box-primary">

                <div class="form-horizontal">
                    <div class="box-body">
                        <div class="form-group">
                            <asp:Label ID="Label7" runat="server" Text="Nama" CssClass="col-sm-3 control-label"></asp:Label>
                            <div class="col-sm-8" style="margin-left: 30px">
                                <asp:TextBox ID="txtNama" runat="server" CssClass="form-control" require=""></asp:TextBox>
                            </div>
                        </div>
                        <br />
                        <div class="form-group">
                            <asp:Label ID="Label1" runat="server" Text="Username" CssClass="col-sm-3 control-label"></asp:Label>
                            <div class="col-sm-8" style="margin-left: 30px">
                                <asp:TextBox ID="txtUser" runat="server" CssClass="form-control" require=""></asp:TextBox>
                            </div>
                        </div>
                        <br />
                        <div class="form-group">
                            <asp:Label ID="Label3" runat="server" Text="Kode Kota" CssClass="col-sm-3 control-label"></asp:Label>
                            <div class="col-sm-8" style="margin-left: 30px">
                                <asp:TextBox ID="txtKota" runat="server" CssClass="form-control" require=""></asp:TextBox>
                            </div>
                        </div>
                        <br />
                        <div class="form-group">
                            <asp:Label ID="Label4" runat="server" Text="No_Telp" CssClass="col-sm-3 control-label"></asp:Label>

                            <div class="col-sm-8" style="margin-left: 30px">
                                <asp:TextBox ID="txtTelp" runat="server" CssClass="form-control" require=""></asp:TextBox>
                            </div>
                        </div>
                        <br />
                        <div class="form-group">
                            <asp:Label ID="Label2" runat="server" Text="Alamat" CssClass="col-sm-3 control-label"></asp:Label>

                            <div class="col-sm-8" style="margin-left: 30px">
                                <asp:TextBox ID="txtAl" runat="server" CssClass="form-control" require=""></asp:TextBox>
                            </div>
                        </div>
                        <br />
                        <div class="form-group">
                            <asp:Label ID="Label5" runat="server" Text="Password" CssClass="col-sm-3 control-label"></asp:Label>

                            <div class="col-sm-8" style="margin-left: 30px">
                                <asp:TextBox ID="txtPass" runat="server" CssClass="form-control" require=""></asp:TextBox>
                            </div>
                        </div>
                        <br />
                        <div class="form-group">
                            <asp:Label ID="Label6" runat="server" Text="Konfirmasi Password" CssClass="col-sm-3 control-label"></asp:Label>

                            <div class="col-sm-8" style="margin-left: 30px">
                                <asp:TextBox ID="txtKonpas" runat="server" CssClass="form-control" require=""></asp:TextBox>
                            </div>
                        </div>
                    </div>
                    <!-- /.box-body -->
                    <br />

                    <asp:Button ID="btnSave" runat="server" Text="Save" OnClick="btnSave_Click" CssClass="btn btn-1 btn-primary" Style="margin-left: 400px" />
                    <asp:Button ID="btnCancel" runat="server" Text="Cancel" OnClick="btnCancel_Click" CssClass="btn btn-1 btn-default" Style="margin-left: 30px" />
                </div>
            </div>
        </div>
        <%-- </asp:View>
            <asp:View ID="View2" runat="server">
                <div class="box-body">
                    <button type="button" class="btn btn-default" data-toggle="modal" data-target="#modal-default">
                        Launch Default Modal
                    </button>
                </div>
                <div class="modal fade" id="modal-default">
                    <div class="modal-dialog">
                        <div class="modal-content">
                            <div class="modal-header">
                                <button type="button" class="close" data-dismiss="modal" aria-label="Close">
                                    <span aria-hidden="true">&times;</span></button>
                                <h4 class="modal-title">Default Modal</h4>
                            </div>
                            <div class="modal-body">
                                <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
                                <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
                            </div>
                            <div class="modal-footer">
                                <button type="button" class="btn btn-default pull-left" data-dismiss="modal">Close</button>
                                <button type="button" class="btn btn-primary">Save changes</button>
                            </div>
                        </div>
                        <!-- /.modal-content -->
                    </div>
                    <!-- /.modal-dialog -->
                </div>--%>
    </form>
</asp:Content>
