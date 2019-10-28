using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using System.Collections;

namespace dataTier
{
    public class command
    {
        private string strCon = @"Data Source=DESKTOP-84UQCTE\PUB;Initial Catalog=eCommerce;Integrated Security=True";
        private static SqlConnection sqlCon;
        private static SqlCommand sqlCmd;
        private static SqlTransaction sqlTran;

        public bool openCon()
        {
            try
            {
                sqlCon = new SqlConnection(strCon);
                sqlCon.Open();
                sqlTran = sqlCon.BeginTransaction();
                return true;
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message, ex);
            }
        }

        public void closeCon()
        {
            try
            {
                if (sqlCon.State == System.Data.ConnectionState.Open)
                {
                    sqlTran.Commit();
                    sqlCon.Close();

                }
            }
            catch (Exception ex)
            {
                if (sqlTran.Connection != null)
                {
                    sqlTran.Rollback();
                }
                throw new Exception(ex.Message, ex);
            }

        }

        public bool executeNonquery(string query, List<SqlParameter> param)
        {
            try
            {
                sqlCmd = new SqlCommand(query, sqlCon, sqlTran);
                sqlCmd.CommandType = CommandType.Text;
                sqlCmd.Parameters.AddRange(param.ToArray());
                sqlCmd.ExecuteNonQuery();
                return true;
            }
            catch (Exception ex)
            {
                if (sqlCon.State == System.Data.ConnectionState.Open)
                {

                    if (sqlTran.Connection != null)
                    {
                        sqlTran.Rollback();
                    }
                    sqlCon.Close();
                }
                throw new Exception(ex.Message, ex);
            }
        }

        public bool executeNonquery(string query)
        {
            try
            {
                sqlCmd = new SqlCommand(query, sqlCon, sqlTran);
                sqlCmd.CommandType = CommandType.Text;
                sqlCmd.ExecuteNonQuery();
                return true;
            }
            catch (Exception ex)
            {
                if (sqlCon.State == System.Data.ConnectionState.Open)
                {

                    if (sqlTran.Connection != null)
                    {
                        sqlTran.Rollback();
                    }
                    sqlCon.Close();
                }
                throw new Exception(ex.Message, ex);
            }
        }

        public DataTable executeQuery(string query, List<SqlParameter> param)
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter();
            try
            {
                sqlCmd = new SqlCommand(query, sqlCon, sqlTran);
                sqlCmd.CommandType = CommandType.Text;
                sqlCmd.CommandTimeout = 0;
                da.SelectCommand = sqlCmd;
                sqlCmd.Parameters.AddRange(param.ToArray());
                da.Fill(dt);
                return dt;
            }
            catch (Exception ex)
            {
                if (sqlCon.State == ConnectionState.Open)
                {
                    if (sqlTran.Connection != null)
                    {
                        sqlTran.Rollback();
                    }
                    sqlCon.Close();
                }
                throw new Exception(ex.Message, ex);
            }
        }

        public DataTable executeQuery(string query)
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter();
            try
            {
                sqlCmd = new SqlCommand(query, sqlCon, sqlTran);
                sqlCmd.CommandType = CommandType.Text;
                da.SelectCommand = sqlCmd;
                da.Fill(dt);
                return dt;
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
