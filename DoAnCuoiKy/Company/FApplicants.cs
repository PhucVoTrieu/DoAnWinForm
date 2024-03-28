using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DoAnCuoiKy
{
    public partial class FApplicants : Form
    {
        CandidateDAO candidateDAO = new CandidateDAO();
        SqlConnection connStr = new SqlConnection(DoAnCuoiKy.Properties.Settings.Default.connStr);
        public FApplicants()
        {
            InitializeComponent();
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {

        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {

        }

        private void guna2Button3_Click(object sender, EventArgs e)
        {

        }

        private void DTGVCandidate_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void FApplicants_Load(object sender, EventArgs e)
        {
           
            DTGVCandidate.DataSource = candidateDAO.loadDanhSach();
        }

        private void fillByToolStripButton_Click(object sender, EventArgs e)
        {
          

        }

        private void DTGVCandidate_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }
        public void LoadDanhSach()
        {
            List<JobDetails> list = new List<JobDetails>();
            try
            {

                string query = "SELECT * FROM Profile";
                SqlCommand command = new SqlCommand(query, connStr);
                connStr.Open();
                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    //DTGVCandidate.Rows[0].Cells[0].Value = reader["ID"].ToString();
                    //DTGVCandidate.Rows[0].Cells[1].Value = reader["Name"].ToString();
                    //DTGVCandidate.Rows[0].Cells[2].Value = reader["Phone"].ToString();
                    //DTGVCandidate.Rows[0].Cells[3].Value = reader["Gender"].ToString();
                    //DTGVCandidate.Rows[0].Cells[4].Value = reader["Nationality"].ToString();

                }
            }

            catch (Exception ex)
            {
                Console.WriteLine("Lỗi truy vấn: " + ex.Message);
            }
            finally
            {
                connStr.Close();
            }


           
        }

    }
}
