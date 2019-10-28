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
    public partial class formLogin : System.Web.UI.Page
    {
        controller ctrl;
        public string stat;

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
               
            }
           
        }

        protected void Button1_Click(object sender, EventArgs e)
        {

            DataTable dt = new DataTable();
            ctrl = new controller();

            dt = ctrl.admin(TextBox1.Text, TextBox2.Text, "Admin");
            if (dt.Rows.Count > 0)
            {

                stat = "admin";
                Response.Redirect("formAdmin.aspx");
            }
            dt = ctrl.admin(TextBox1.Text, TextBox2.Text, "Operator");
            if (dt.Rows.Count > 0)
            {
                stat = "Operator";
                Response.Redirect("formOperator.aspx");
            }
            else
            {
                pesan.Visible = true;


            }
        }

       

        protected void TextBox1_TextChanged(object sender, EventArgs e)
        {
            pesan.Visible = false;
        }
    }
}