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
    public partial class formPembeli : System.Web.UI.MasterPage
    {
        controller ctrl = new controller();
        string pass;
        int cek = 0;
        DataTable dt = new DataTable();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                akun.Text = Session["user"].ToString();
                pass = Session["Pass"].ToString();
              
                if (pass!="")
                {
                    
                    dt = ctrl.Cartt(akun.Text, pass);
                    countCart.Text = dt.Rows[0]["count_cart"].ToString();
                    MultiView1.SetActiveView(View1);
                }
                else
                {
                    MultiView1.SetActiveView(View2);
                }

            }

        }
    }
}