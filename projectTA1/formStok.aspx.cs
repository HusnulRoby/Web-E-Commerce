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
    public partial class formStok : System.Web.UI.Page
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
            GridView1.DataSource = ctrl.getStok();
            GridView1.DataBind();

        }

        protected void GridView1_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            if (e.CommandName == "update")
            {
                MultiView1.SetActiveView(View2);
                DataTable dt = new DataTable();
                ctrl = new controller();
                dt = ctrl.getStok(e.CommandArgument.ToString());
                if (dt.Rows.Count > 0)
                {
                    Session["kode_produk"] = dt.Rows[0]["kode_produk"].ToString();
                    txtPro.Text = dt.Rows[0]["kode_produk"].ToString();
                    txtStok.Text = dt.Rows[0]["stok"].ToString();
                    btnSave.Text= "UPDATE";
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

        protected void tmbah_Click(object sender, EventArgs e)
        {
            btnSave.Text = "Save";
            clearField();
            MultiView1.SetActiveView(View2);
        }

        protected void GridView1_RowUpdating(object sender, GridViewUpdateEventArgs e)
        {

        }

        protected void GridView1_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {

        }

        void clearField()
        {
            txtPro.Text = "";
            txtStok.Text = "";
            
        }

        void showMessage(string message)
        {
            ScriptManager.RegisterStartupScript(this.Page, this.GetType(), "Alert", "alert('" + message + "');", true);
        }

        private void Delete(string p)
        {
            ctrl = new controller();
            if (ctrl.deleteStok(p))
            {
                showMessage("Delete Data Berhasil"); clearField();
                MultiView1.SetActiveView(View1);
            }
        }
        protected void btnSave_Click(object sender, EventArgs e)
        {
            ctrl = new controller();
            if (btnSave.Text == "Save")
            {
                if (ctrl.insertStok(txtPro.Text,Convert.ToInt32(txtStok.Text)))
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

                if (ctrl.updateStok(Session["kode_produk"].ToString(),Convert.ToInt32(txtStok.Text)))
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

        protected void btnCancel_Click(object sender, EventArgs e)
        {
            clearField();
            MultiView1.SetActiveView(View1);
        }
        
    }
}