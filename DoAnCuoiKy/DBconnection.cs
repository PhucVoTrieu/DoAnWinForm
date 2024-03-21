using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace DoAnCuoiKy
{
    internal class DBconnection
    {
        SqlConnection connStr = new SqlConnection(DoAnCuoiKy.Properties.Settings.Default.connStr);
        public void thucthi(string sqlStr)
        {
            try
            {

                connStr.Open();
                SqlCommand cmd = new SqlCommand(sqlStr, connStr);
                if (cmd.ExecuteNonQuery() > 0)
                    MessageBox.Show("Thành Công", "Thông Báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
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
