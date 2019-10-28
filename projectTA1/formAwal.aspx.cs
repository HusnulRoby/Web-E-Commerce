using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Query;
using System.Data;

namespace projectTA1
{
    public partial class formAwal : System.Web.UI.Page
    {
        controller ctrl = new controller();
        string pass;
        int tambah;
        string kode;
        string status;
        DataTable dt = new DataTable();
        protected void Page_Load(object sender, EventArgs e)
        {
            akun.Text = Session["user"].ToString();
            
           
            if (akun.Text!="")
            {
                pass = Session["Pass"].ToString();
                dt = ctrl.Cartt(akun.Text, pass);
                countCart.Text = dt.Rows[0]["count_cart"].ToString();    
                MultiView1.SetActiveView(View1);
            }
            else
            {
                MultiView1.SetActiveView(View2);
            }
            
            dt = ctrl.getProdukPembeli("Baru");
            if (dt.Rows.Count > 0)
            {
                for (int i = 0; i < 5; i++)
                {

                    if (i == 0 && dt.Rows[0]["nama_produk"].ToString() != null )
                    {
                        kategori1.Text = dt.Rows[0]["nama_kategori"].ToString();
                        new1.Text = dt.Rows[0]["nama_produk"].ToString();
                        newImg1.ImageUrl = dt.Rows[0]["gambar"].ToString();
                        price1.Text = dt.Rows[0]["harga_jual"].ToString();
                        kode = dt.Rows[0]["kode_produk"].ToString();
                        status = "pending";


                    }
                    //if (i == 1 && dt.Rows[i]["nama_produk"].ToString() != null)
                    //{
                    //    kategori2.Text = dt.Rows[i]["nama_kategori"].ToString();
                    //    new2.Text = dt.Rows[i]["nama_produk"].ToString();
                    //    newImg2.ImageUrl = dt.Rows[i]["gambar"].ToString();
                    //    price2.Text = dt.Rows[i]["harga_jual"].ToString();
                    //}

                    //if (i == 2 && dt.Rows[i]["nama_produk"].ToString() != null)
                    //{
                    //    kategori3.Text = dt.Rows[i]["nama_kategori"].ToString();
                    //    new3.Text = dt.Rows[i]["nama_produk"].ToString();
                    //    newImg3.ImageUrl = dt.Rows[i]["gambar"].ToString();
                    //    price3.Text = dt.Rows[i]["harga_jual"].ToString();
                    //}

                    //if (i == 3 && dt.Rows[i]["nama_produk"].ToString() != null)
                    //{
                    //    kategori4.Text = dt.Rows[i]["nama_kategori"].ToString();
                    //    new4.Text = dt.Rows[i]["nama_produk"].ToString();
                    //    newImg4.ImageUrl = dt.Rows[i]["gambar"].ToString();
                    //    price4.Text = dt.Rows[i]["harga_jual"].ToString();
                    //}

                    //if (i == 4 && dt.Rows[i]["nama_produk"].ToString() != null)
                    //{
                    //    kategori5.Text = dt.Rows[i]["nama_kategori"].ToString();
                    //    new5.Text = dt.Rows[i]["nama_produk"].ToString();
                    //    newImg5.ImageUrl = dt.Rows[i]["gambar"].ToString();
                    //    price5.Text = dt.Rows[i]["harga_jual"].ToString();
                    //}

                }

            }
            else
            {
                //showMessage("Data Not Found");
            }

        }

        protected void cek_Click(object sender, EventArgs e)
        {
            
            tambah = Convert.ToInt32(countCart.Text);
            tambah+=1;
            ctrl.updateCart(akun.Text,pass,tambah);

            ctrl.insertCart("PEM02",kode,new1.Text,newImg1.ImageUrl,1,"merah","12",status);
            Response.Redirect(Request.Url.AbsolutePath, true);
        }
    }
}