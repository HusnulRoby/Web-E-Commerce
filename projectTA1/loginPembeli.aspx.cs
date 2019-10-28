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
    public partial class loginPembeli : System.Web.UI.Page
    {
        controller ctrl;

        protected void Page_Load(object sender, EventArgs e)
        {
            Session["user"] = "";
        }

        protected void btnLogin_Click(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            ctrl = new controller();

            dt = ctrl.logPembeli(txtUser.Text, txtPass.Text);
            if (dt.Rows.Count > 0)
            {
                Session["user"] = txtUser.Text;
                Session["Pass"] = txtPass.Text;
                Response.Redirect("formAwal.aspx");
            }
            else
            {
                //pesan.Visible = true;


            }
            


        }
    }
}