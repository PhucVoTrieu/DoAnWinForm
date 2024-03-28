using Guna.UI2.WinForms.Suite;
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
using static Guna.UI2.WinForms.Helpers.GraphicsHelper;
using System.Windows.Forms.DataVisualization.Charting;

namespace DoAnCuoiKy
{
    public partial class FFindingCandidate : Form
    {
        List<UCJobUI> UcJobList = new List<UCJobUI>();
        List<FJobDetails> JobDetailList = new List<FJobDetails>();
        SqlConnection connStr = new SqlConnection(DoAnCuoiKy.Properties.Settings.Default.connStr);

        public FFindingCandidate()
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
                    string title = reader["JobTitle"].ToString();
                    string position = reader["JobPosition"].ToString();
                    string type = reader["JobType"].ToString();
                    string salary = reader["JobSalary"].ToString();
                    string recruitmentQuota = reader["RecruitmentQuota"].ToString();
                    string location = reader["Location"].ToString();
                    string expYear = reader["ExpInYears"].ToString();
                    string description = reader["JobDescription"].ToString();
                    JobDetails jobdt1 = new JobDetails();
                    jobdt1.JobTitle = title;
                    jobdt1.JobPosition = position;
                    jobdt1.JobType = type;
                    jobdt1.JobSalary = salary;
                    jobdt1.RecruitmentQuota = recruitmentQuota;
                    jobdt1.Location = location;
                    jobdt1.ExpInYears = expYear;
                    jobdt1.JobDescription = description;
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
                this.PnlRecommendJobs.Controls.Add(UCJob);
            }
        }

        private void btnViewProfile_Click(object sender, EventArgs e)
        {
            FProfileApplicant fProfile1 = new FProfileApplicant();
            fProfile1.Show();
        }

       
    }
   }

