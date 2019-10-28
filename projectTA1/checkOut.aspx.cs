using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using Query;

namespace projectTA1
{
    public partial class checkOut : System.Web.UI.Page
    {
        controller ctrl = new controller();
        protected void Page_Load(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            dt = ctrl.getProf("Husnul","summimase");
            if (dt.Rows.Count > 0)
            {
                nama.Text = dt.Rows[0]["nama"].ToString();
                alamat.Text = dt.Rows[0]["alamat"].ToString();
                city.Text = dt.Rows[0]["kota"].ToString();
                telp.Text = dt.Rows[0]["no_telp"].ToString();
                tampil();
            }
            else
            {
               // showMessage("Data Not Found");
            }

            
        }

        private void tampil()
        {
            DataTable dt = new DataTable();
            dt = ctrl.ceckOut("PEM02");
            rPt.DataSource = dt;
            rPt.DataBind();
            dt = ctrl.countCeck("PEM02");
            Label1.Text = dt.Rows[0]["total"].ToString();
        }

        protected void order_Click(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            ctrl.inPembayaran("PEM01",Convert.ToInt32(Label1.Text),"cobabayarhla","Belum bayar");
            //Response.Redirect(Request.Url.AbsolutePath, true);

            // AGAR TIDAK TERJADI DUPLIKAT DATA PADA SAAT REFRESH PAGE
            Response.Redirect("formAwal.aspx");
        }
    }
}