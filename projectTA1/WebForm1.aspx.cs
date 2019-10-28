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
    public partial class WebForm1 : System.Web.UI.Page
    {
        controller ctrl = new controller();
        protected void Page_Load(object sender, EventArgs e)
        {
            tampil();
            
        }
        private void tampil()
        {
            DataTable dt = new DataTable();
            dt = ctrl.coba();
            R.DataSource = dt;
            R.DataBind();
            
        }
    }
}