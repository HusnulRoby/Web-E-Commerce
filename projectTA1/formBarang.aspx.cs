using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using Query;
using System.IO;
using System.Collections;
using System.ComponentModel;

namespace projectTA1
{
    public partial class formBarang : System.Web.UI.Page
    {
        controller ctrl;
    
        protected void Page_Load(object sender, EventArgs e)
        {
            ctrl = new controller();
            if (!IsPostBack)
            {
               
                refreshData();
            }
        }

        private void refreshData()
        {

            ctrl = new controller();
            MultiView1.SetActiveView(View1);
            GridView1.DataSource = ctrl.getProduk();
            GridView1.DataBind();

        }

        protected void GridView1_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            if (e.CommandName == "update")
            {
                MultiView1.SetActiveView(View2);
                DataTable dt = new DataTable();
                ctrl = new controller();
                dt = ctrl.getProduk(e.CommandArgument.ToString());
                if (dt.Rows.Count > 0)
                {
                    Session["kode_produk"] = dt.Rows[0]["kode_produk"].ToString();
                    txtPro.Text = dt.Rows[0]["kode_produk"].ToString();
                    txtkode.Text = dt.Rows[0]["kode_kategori"].ToString();
                    txtNampro.Text = dt.Rows[0]["nama_produk"].ToString();
                    txtBerat.Text = dt.Rows[0]["berat"].ToString();
                    txtWarna.Text = dt.Rows[0]["warna"].ToString();
                    txtUkuran.Text = dt.Rows[0]["ukuran"].ToString();
                    txtHarga.Text = dt.Rows[0]["harga_jual"].ToString();
                    txtStok.Text = dt.Rows[0]["stok_minimum"].ToString();
                    txtKet.Text = dt.Rows[0]["keterangan"].ToString();
                    tampGambar.ImageUrl = dt.Rows[0]["gambar"].ToString();
                    btnSave.Text = "UPDATE";
                }
                else
                {
                    showMessage("Data Not Found");
                }
            }
            else
            {
                string c_val = Request.Form["confirm_value"];
                if (c_val == "yes")
                {
                    Delete(e.CommandArgument.ToString());
                    refreshData();
                    clearField();
                    //MultiView1.SetActiveView(View1);
                }
            }
        }

        protected void GridView1_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {

        }

        protected void GridView1_RowUpdating(object sender, GridViewUpdateEventArgs e)
        {

        }

        protected void tmbah_Click(object sender, EventArgs e)
        {
            btnSave.Text = "Save";
            clearField();
            MultiView1.SetActiveView(View2);
        }

        void clearField()
        {
            txtPro.Text = "";
            txtkode.Text = "";
            txtNampro.Text = "";
            txtBerat.Text = "";
            txtWarna.Text = "";
            txtUkuran.Text = "";
            txtHarga.Text = "";
            txtStok.Text = "";
            txtKet.Text = "";
        }

        void showMessage(string message)
        {
            ScriptManager.RegisterStartupScript(this.Page, this.GetType(), "Alert", "alert('" + message + "');", true);
        }

        private void Delete(string p)
        {
            ctrl = new controller();
            if (ctrl.deleteProduk(p))
            {
                showMessage("Delete Data Berhasil"); clearField();
                MultiView1.SetActiveView(View1);
            }
        }

        protected void btnSave_Click(object sender, EventArgs e)
        {
            ctrl = new controller();
            string path = Server.MapPath("Images");
            if (flGambar.HasFile)
            {
                string ext = Path.GetExtension(flGambar.FileName);
                if (!(ext == ".jpg" || ext == ".png" || ext == ".gif"))
                {
                    showMessage("Error Jang");

                }
                else
                {

                    flGambar.SaveAs(path + flGambar.FileName);
                    string name = "Images" + flGambar.FileName;
                    if (btnSave.Text == "Save")
                    {
                        if (ctrl.insertProduk(txtPro.Text, name, txtkode.Text, txtNampro.Text, Convert.ToInt32(txtBerat.Text), txtWarna.Text,txtUkuran.Text, Convert.ToInt32(txtHarga.Text), Convert.ToInt32(txtStok.Text), txtKet.Text))
                        {
                            if (txtKet.Text=="Baru")
                            {
                                Session["nama"] = txtNampro.Text;
                                Session["harga"] = txtHarga.Text;
                                Session["gambar"] = name;
                                //Response.Redirect("formAwal.aspx");
                            }
                            showMessage("Insert Data Berhasil");
                            Response.Redirect(Request.Url.AbsolutePath, true);
                           
                            // AGAR TIDAK TERJADI DUPLIKAT DATA PADA SAAT REFRESH PAGE


                        }
                        else
                        {
                            showMessage("Insert Data Gagal");
                        }
                    }
                    else
                    {
                        if (ctrl.updateProduk(Session["kode_produk"].ToString(), name, txtkode.Text, txtNampro.Text, Convert.ToInt32(txtBerat.Text),txtWarna.Text,txtUkuran.Text, Convert.ToInt32(txtHarga.Text), Convert.ToInt32(txtStok.Text), txtKet.Text))
                        { 
                            showMessage("Update Sukses");
                        }
                        else
                        {
                            showMessage("Update Gagal");
                        }

                    }
                    clearField();
                    MultiView1.SetActiveView(View1);
                    refreshData();
                }

            }
            else
            {
                showMessage("Masukan Foto Dulu");
            }
        }
        protected void btnCancel_Click(object sender, EventArgs e)
        {
            clearField();
            MultiView1.SetActiveView(View1);
        }

        protected void GridView1_RowEditing(object sender, GridViewEditEventArgs e)
        {

        }

       

    }
}