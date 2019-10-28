<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="formKategori.aspx.cs" Inherits="projectTA1.formKategori" %>

<%--<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" runat="server">
 
</asp:Content>--%>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
    <script type="text/javascript">
        function ConfirmDelete() {
            var c_value = document.createElement("INPUT");
            c_value.type = "hidden";
            c_value.name = "confirm_value";
            if (confirm("Are you Sure ?")) {
                c_value.value = "yes";
            } else {
                c_value.value = "no";
            }
            document.forms["kateAdmin"].appendChild(c_value);
        }
    </script>
    <div class="btn-effcts panel-widget">
        <div class="button-heading" style="margin-bottom: 50px">
            <h4 class="text-center">Data Kategori</h4>
        </div>
        <form id="kateAdmin" runat="server">
            <asp:MultiView ID="MultiView1" runat="server">
                <asp:View ID="View1" runat="server">
                    <asp:Button ID="tmbah" runat="server" Text="Tambah Data" OnClick="tmbah_Click" />
                    <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" BackColor="White" CssClass="gvv table table-bordered table-hover" BorderColor="#336666" BorderStyle="Double" BorderWidth="3px" CellPadding="4" GridLines="Horizontal" OnRowCommand="GridView1_RowCommand" OnRowDeleting="GridView1_RowDeleting" OnRowUpdating="GridView1_RowUpdating">
                        <Columns>
                            <asp:BoundField DataField="kode_kategori" HeaderText="KODE KATEGORI" />
                            <asp:BoundField DataField="nama_kategori" HeaderText="NAMA KATEGORI" />
                            <asp:BoundField DataField="keterangan" HeaderText="KETERANGAN" />
                            <asp:TemplateField>
                                <ItemTemplate>
                                    <asp:LinkButton ID="LinkButton1" runat="server" CommandArgument='<%#Eval("kode_kategori").ToString() %>' CommandName="update">Update</asp:LinkButton>
                                    <asp:LinkButton ID="LinkButton2" runat="server" CommandArgument='<%#Eval("kode_kategori").ToString() %>' CommandName="delete" OnClientClick="ConfirmDelete()">Delete</asp:LinkButton>

                                </ItemTemplate>
                            </asp:TemplateField>
                        </Columns>

                        <FooterStyle BackColor="White" ForeColor="#333333" />
                        <HeaderStyle BackColor="#336666" Font-Bold="True" ForeColor="White" />
                        <PagerStyle BackColor="#336666" ForeColor="White" HorizontalAlign="Center" />
                        <RowStyle BackColor="White" ForeColor="#333333" />
                        <SelectedRowStyle BackColor="#339966" Font-Bold="True" ForeColor="White" />
                        <SortedAscendingCellStyle BackColor="#F7F7F7" />
                        <SortedAscendingHeaderStyle BackColor="#487575" />
                        <SortedDescendingCellStyle BackColor="#E5E5E5" />
                        <SortedDescendingHeaderStyle BackColor="#275353" />
                    </asp:GridView>
                </asp:View>
                <asp:View ID="View2" runat="server">
                    <section class="content">
                        <div class="row">
                            <!-- left column -->
                            <div class="col-md-10">
                                <!-- general form elements -->
                                <div class="box box-primary">

                                    <div class="form-horizontal">
                                        <div class="box-body">
                                            <div class="form-group">
                                                <asp:Label ID="Label1" runat="server" Text="KODE KATEGORI" CssClass="col-sm-3 control-label"></asp:Label>
                                                <div class="col-sm-8" style="margin-left: 30px">
                                                    <asp:TextBox ID="txtkode" runat="server" CssClass="form-control" require=""></asp:TextBox>
                                                </div>
                                            </div>
                                            <br />
                                            <div class="form-group">
                                                <asp:Label ID="Label2" runat="server" Text="NAMA KATEGORI" CssClass="col-sm-3 control-label"></asp:Label>
                                                <div class="col-sm-8" style="margin-left: 30px">
                                                    <asp:TextBox ID="txtNamteg" runat="server" CssClass="form-control" require=""></asp:TextBox>
                                                </div>
                                            </div>
                                            <br />
                                            <div class="form-group">
                                                <asp:Label ID="Label3" runat="server" Text="KETERANGAN" CssClass="col-sm-3 control-label"></asp:Label>
                                                <div class="col-sm-8" style="margin-left: 30px">
                                                    <asp:TextBox ID="txtKet" runat="server" CssClass="form-control" require=""></asp:TextBox>
                                                </div>
                                            </div>
                                            <br />

                                            <!-- /.box-body -->
                                            <asp:Button ID="btnSave" runat="server" Text="Save" OnClick="btnSave_Click" CssClass="btn btn-1 btn-primary" Style="margin-left: 400px"/>
                                            <asp:Button ID="btnCancel" runat="server" Text="Cancel" OnClick="btnCancel_Click" CssClass="btn btn-1 btn-default" Style="margin-left: 15px"/>
                                        </div>
                                    </div>
                                </div>
                            </div>
                        </div>
                    </section>

                </asp:View>
            </asp:MultiView>
        </form>
    </div>
    <script>
        $(function () {
            $('.gvv').prepend($("<thead></thead>").append($(this).find("tr:first"))).dataTable({
                'paging': true,
                'lengthChange': true,
                'searching': true,
                'ordering': true,
                'info': true,
                'autoWidth': true
            });
        });
    </script>
</asp:Content>
