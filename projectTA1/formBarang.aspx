<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="formBarang.aspx.cs" Inherits="projectTA1.formBarang" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
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
            document.forms["barAdmin"].appendChild(c_value);
        }
    </script>
    <div class="btn-effcts panel-widget">
        <div class="button-heading" style="margin-bottom: 50px">
            <h4 class="text-center">Data Barang</h4>
        </div>
        <form id="barAdmin" runat="server">

            <asp:MultiView ID="MultiView1" runat="server">
                <asp:View ID="View1" runat="server">
                    <asp:Label ID="Label10" runat="server" Text="Label"></asp:Label>
                    <asp:Button ID="tmbah" runat="server" Text="Tambah Data" OnClick="tmbah_Click" />

                    <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" CssClass="gvv table table-bordered table-hover" BackColor="White" BorderColor="#336666" BorderStyle="Double" BorderWidth="3px" CellPadding="4" GridLines="Horizontal" OnRowCommand="GridView1_RowCommand" OnRowDeleting="GridView1_RowDeleting" OnRowUpdating="GridView1_RowUpdating" OnRowEditing="GridView1_RowEditing">
                        <Columns>
                            <asp:BoundField DataField="kode_produk" HeaderText="KODE PRODUK" />
                            <asp:BoundField DataField="gambar" HeaderText="GAMBAR" />
                            <asp:BoundField DataField="kode_kategori" HeaderText="KODE KATEGORI" />
                            <asp:BoundField DataField="nama_produk" HeaderText="NAMA PRODUK" />
                            <asp:BoundField DataField="berat" HeaderText="BERAT (kg)" />
                            <asp:BoundField DataField="warna" HeaderText="Warna" />
                            <asp:BoundField DataField="ukuran" HeaderText="Ukuran" />
                            <asp:BoundField DataField="harga_jual" HeaderText="HARGA JUAL" />
                            <asp:BoundField DataField="stok_minimum" HeaderText="STOK MINIMUM" />
                            <asp:BoundField DataField="keterangan" HeaderText="KETERANGAN" />
                            <asp:TemplateField>
                                <ItemTemplate>
                                    <asp:LinkButton ID="LinkButton1" runat="server" CommandArgument='<%#Eval("kode_produk").ToString() %>' CommandName="update">Update</asp:LinkButton>
                                    <asp:LinkButton ID="LinkButton2" runat="server" CommandArgument='<%#Eval("kode_produk").ToString() %>' CommandName="delete" OnClientClick="ConfirmDelete()">Delete</asp:LinkButton>

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
                                                <asp:Label ID="Label7" runat="server" Text="Kode Produk" CssClass="col-sm-3 control-label"></asp:Label>
                                                <div class="col-sm-8" style="margin-left: 30px">
                                                    <asp:TextBox ID="txtPro" runat="server" CssClass="form-control" require=""></asp:TextBox>
                                                </div>
                                            </div>
                                            <br />

                                            <br />
                                            <div class="form-group">
                                                <asp:Label ID="Label4" runat="server" Text="Kode Kategori" CssClass="col-sm-3 control-label"></asp:Label>

                                                <div class="col-sm-8" style="margin-left: 30px">
                                                    <asp:TextBox ID="txtkode" runat="server" CssClass="form-control" require=""></asp:TextBox>
                                                </div>
                                            </div>
                                            <br />
                                            <div class="form-group">
                                                <asp:Label ID="Label2" runat="server" Text="Nama Produk" CssClass="col-sm-3 control-label"></asp:Label>

                                                <div class="col-sm-8" style="margin-left: 30px">
                                                    <asp:TextBox ID="txtNampro" runat="server" CssClass="form-control" require=""></asp:TextBox>
                                                </div>
                                            </div>
                                            <br />
                                            <div class="form-group">
                                                <asp:Label ID="Label8" runat="server" Text="Berat" CssClass="col-sm-3 control-label"></asp:Label>
                                                <div class="col-sm-8" style="margin-left: 30px">
                                                    <asp:TextBox ID="txtBerat" runat="server" CssClass="form-control" require=""></asp:TextBox>
                                                </div>
                                            </div>
                                            <br />
                                            <div class="form-group">
                                                <asp:Label ID="Label11" runat="server" Text="Warna" CssClass="col-sm-3 control-label"></asp:Label>
                                                <div class="col-sm-8" style="margin-left: 30px">
                                                    <asp:TextBox ID="txtWarna" runat="server" CssClass="form-control"></asp:TextBox>
                                                </div>
                                            </div>
                                            <br />
                                            <div class="form-group">
                                                <asp:Label ID="Label12" runat="server" Text="Ukuran" CssClass="col-sm-3 control-label"></asp:Label>
                                                <div class="col-sm-8" style="margin-left: 30px">
                                                    <asp:TextBox ID="txtUkuran" runat="server" CssClass="form-control"></asp:TextBox>
                                                </div>
                                            </div>
                                            <br />
                                            <div class="form-group">
                                                <asp:Label ID="Label5" runat="server" Text="Harga Jual" CssClass="col-sm-3 control-label"></asp:Label>

                                                <div class="col-sm-8" style="margin-left: 30px">
                                                    <asp:TextBox ID="txtHarga" runat="server" CssClass="form-control" require=""></asp:TextBox>
                                                </div>
                                            </div>
                                            <br />
                                            <div class="form-group">
                                                <asp:Label ID="Label6" runat="server" Text="Stok Minimum" CssClass="col-sm-3 control-label"></asp:Label>

                                                <div class="col-sm-8" style="margin-left: 30px">
                                                    <asp:TextBox ID="txtStok" runat="server" CssClass="form-control" require=""></asp:TextBox>
                                                </div>
                                            </div>
                                            <br />
                                            <div class="form-group">
                                                <asp:Label ID="Label3" runat="server" Text="Keterangan" CssClass="col-sm-3 control-label"></asp:Label>

                                                <div class="col-sm-8" style="margin-left: 30px">
                                                    <asp:TextBox ID="txtKet" runat="server" CssClass="form-control" require=""></asp:TextBox>
                                                </div>
                                            </div>
                                        </div>
                                        <!-- /.box-body -->
                                        <br />
                                        <div class="form-group">
                                            <asp:Label ID="Label1" runat="server" Text="Gambar" CssClass="col-sm-3 control-label"></asp:Label>
                                            <div class="col-sm-8" style="margin-left: 30px">
                                                <asp:FileUpload ID="flGambar" runat="server" />
                                            </div>
                                        </div>
                                        <div class="form-group">
                                            <asp:Label ID="Label9" runat="server" Text="Gambar" CssClass="col-sm-3 control-label"></asp:Label>
                                            <div class="col-sm-8" style="margin-left: 30px">
                                                <asp:Image ID="tampGambar" runat="server" />
                                            </div>
                                        </div>
                                        <asp:Button ID="btnSave" runat="server" Text="Save" OnClick="btnSave_Click" CssClass="btn btn-1 btn-primary" Style="margin-left: 400px" />
                                        <asp:Button ID="btnCancel" runat="server" Text="Cancel" OnClick="btnCancel_Click" CssClass="btn btn-1 btn-default" Style="margin-left: 30px" />
                                    </div>
                                </div>
                            </div>
                        </div>
                    </section>
                    <!-- /.box -->

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
