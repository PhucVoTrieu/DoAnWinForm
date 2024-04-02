using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoAnCuoiKy
{
    internal class FavJobDAO
    {
        DBconnection db = new DBconnection();
        SqlConnection connStr = new SqlConnection(DoAnCuoiKy.Properties.Settings.Default.connStr);

        public void them(JobDetails jobDetails)
        {
            string SQL = string.Format("INSERT INTO FavoriteJob (JobTitle,JobPosition,JobType,JobSalary,RecruitmentQuota,Location,ExpInYears,JobDescription,CompanyName,Benefit) VALUES ('{0}', '{1}' , '{2}','{3}','{4}','{5}','{6}','{7}','{8}','{9}')",
             jobDetails.JobTitle, jobDetails.JobPosition, jobDetails.JobType,
             jobDetails.JobSalary, jobDetails.RecruitmentQuota, jobDetails.Location, jobDetails.ExpInYears,
             jobDetails.JobDescription, jobDetails.CompanyName, jobDetails.Benefit);
            db.thucthi(SQL);
        }
        public void xoa(JobDetails jobDetails)
        {
            string SQL = string.Format("DELETE FROM FavoriteJob WHERE  JobTitle = '{0}' ",
                jobDetails.JobTitle);
            db.thucthi(SQL);
        }
        public void LoadDanhSach(FormFavoriteJobs f)
        {
            List<JobDetails> list = new List<JobDetails>();
            try
            {
                string query = "SELECT * FROM FavoriteJob";
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
                    string companyName = reader["CompanyName"].ToString();
                    string benefit = reader["Benefit"].ToString();
                    JobDetails jobdt1 = new JobDetails(title, position, type, salary, recruitmentQuota, location, expYear, description, companyName, benefit);
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
                UCJob.btnFavorite.Hide();
                f.pnlFavJobs.Controls.Add(UCJob);
            }
        }

        public void xoaUC(UCJobUI uCJobUI)
        {
            string SQL = string.Format("DELETE FROM FavoriteJob WHERE  JobTitle = '{0}' ",
                uCJobUI.lblJobTitle.Text);
            db.thucthi(SQL);
        }
    }
}

