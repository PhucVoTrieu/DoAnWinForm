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
    public partial class FJobs : Form
    {
        List<UCJobUI> UcJobList = new List<UCJobUI>();
        SqlConnection connStr = new SqlConnection(DoAnCuoiKy.Properties.Settings.Default.connStr);

        public FJobs()
        {
            InitializeComponent();
            LoadDanhSach();
        }
        public void LoadDanhSach()
        {
            List<JobDetails> list = new List<JobDetails>();
            try
            {

                string query = "SELECT * FROM Jobdetails";
                SqlCommand command = new SqlCommand(query, connStr);
                connStr.Open();
                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {

                    // lấy dữ liệu từ các cột
                    string title = reader["JobTitle"].ToString();
                    string position = reader["JobPosition"].ToString();
                    string type = reader["JobType"].ToString();
                    string salary = reader["JobSalary"].ToString();
                    string recruitmentQuota = reader["RecruitmentQuota"].ToString();
                    string location = reader["Location"].ToString();
                    string expYear = reader["ExpInYears"].ToString();
                    string description = reader["JobDescription"].ToString();
                    JobDetails jobdt1 = new JobDetails(title, position, type, salary, recruitmentQuota, location, expYear, description);
                    // thêm jobd1 vào list
                    list.Add(jobdt1);
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


            foreach (JobDetails jobDetail in list)
            {
                UCJobUI UCJob = new UCJobUI(jobDetail);
                UCJob.btnApplyNow.Hide();
                this.pnlCreatedJob.Controls.Add(UCJob);
            }
        }
       
    }
}
