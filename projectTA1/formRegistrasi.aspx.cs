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
    public partial class formRegistrasi : System.Web.UI.Page
    {
        controller ctrl;
        DataTable dt;
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        void showMessage(string message)
        {
            ScriptManager.RegisterStartupScript(this.Page, this.GetType(), "Alert", "alert('" + message + "');", true);
        }
        protected void btnSave_Click(object sender, EventArgs e)
        {
            ctrl = new controller();
            dt = new DataTable();
            if (txtKonpas.Text == txtPass.Text)
            {
                if (ctrl.registrasi(txtNama.Text,txtUser.Text,txtKota.Text,txtTelp.Text, txtAl.Text, txtPass.Text,0))
                {
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
                showMessage("Password Tidak Cocok");
                txtKonpas.Text = "";
            }
        }

        protected void btnCancel_Click(object sender, EventArgs e)
        {
            txtNama.Text = "";
            txtUser.Text = "";
            txtKota.Text = "";
            txtTelp.Text = "";
            txtAl.Text = "";
            txtPass.Text = "";
            txtKonpas.Text = "";
        }
    }
}