using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Data;

namespace DoAnCuoiKy
{
    internal class DBconnection
    {
        SqlConnection connStr = new SqlConnection(DoAnCuoiKy.Properties.Settings.Default.connStr);

        public DataTable load(string sqlStr)
        {
            DataTable dataTable = new DataTable();
            try
            {
                connStr.Open();
                SqlDataAdapter adapter = new SqlDataAdapter(sqlStr, connStr);
                adapter.Fill(dataTable);
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message);
            }
            finally
            {
                connStr.Close();
            }
            return dataTable;
        }
        private bool successMessageShown = false;
        public void thucthi(string sqlStr)
        {
            try
            {

                connStr.Open();
                SqlCommand cmd = new SqlCommand(sqlStr, connStr);
                if (cmd.ExecuteNonQuery() > 0)
                {
                    if (!successMessageShown)
                    {
                        MessageBox.Show("Thành Công", "Thông Báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                        successMessageShown = true;
                    }
                }
                   
            }
            catch (Exception ex)
            {
                MessageBox.Show("Thất Bại" + ex);
            }
            finally
            {
                connStr.Close();
            }
        }
        public void kiemtra(string sqltStr)
        {
            connStr.Open();
            SqlCommand cmd = new SqlCommand(sqltStr, connStr);
            cmd.ExecuteNonQuery();
            connStr.Close();
        }

    }
}
