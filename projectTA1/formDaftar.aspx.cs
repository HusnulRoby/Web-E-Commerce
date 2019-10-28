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
    public partial class formDaftar : System.Web.UI.Page
    {
        controller ctrl;
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            ctrl = new controller();

            ctrl.tmbahAdmin(txtUser.Text, txtPass.Text, admin.Text);
            showMessage("Insert Data Berhasil");
            Response.Redirect(Request.Url.AbsolutePath, true);
            // AGAR TIDAK TERJADI DUPLIKAT DATA PADA SAAT REFRESH PAGE
            Response.Redirect("formAdmin.aspx");



        }

        void showMessage(string pesan)
        {
            ScriptManager.RegisterStartupScript(this.Page, this.GetType(), "Alert", "alert('" + pesan + "');", true);
        }
    }
}