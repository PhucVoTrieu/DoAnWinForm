using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoAnCuoiKy
{
    internal class JobsDAO
    {
        DBconnection db = new DBconnection();
        SqlConnection connStr = new SqlConnection(DoAnCuoiKy.Properties.Settings.Default.connStr);
        public void them(JobDetails jobDetails)
        {
            string SQL = string.Format("INSERT INTO Jobdetails (JobTitle,JobPosition,JobType,JobSalary,RecruitmentQuota,Location,ExpInYears,JobDescription,CompanyName,Benefit) VALUES ('{0}', '{1}' , '{2}','{3}','{4}','{5}','{6}','{7}','{8}','{9}')",
                jobDetails.JobTitle, jobDetails.JobPosition, jobDetails.JobType,
                jobDetails.JobSalary, jobDetails.RecruitmentQuota, jobDetails.Location, jobDetails.ExpInYears,
                jobDetails.JobDescription, jobDetails.CompanyName,jobDetails.Benefit);
            db.thucthi(SQL);
        }
        public void laydulieuCoDieuKien(List<JobDetails> list, string conditionText)
        {
            try
            {

                connStr.Open();
                //
                //string selectedLocation = this.txtLocation.Text;

                string query = "SELECT  * from JobDetails WHERE Location = @Location";
                SqlCommand sqlCommand = new SqlCommand(query, connStr);
                sqlCommand.Parameters.AddWithValue("@Location", conditionText);
                SqlDataReader reader = sqlCommand.ExecuteReader();
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
        
        }
            public void LoadDanhSach(FFindingCandidate f)
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
                UCJobUI uCJob = new UCJobUI(jobDetail);
                uCJob.CBoxSelected.Hide();
                f.PnlRecommendJobs.Controls.Add(uCJob);
            }
        }
        public void LoadDanhSach1(FJobs f)
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
                UCJobUI uCJob = new UCJobUI(jobDetail);
                uCJob.btnApplyNow.Hide();
                uCJob.btnFavorite.Hide();
                f.pnlCreatedJob.Controls.Add(uCJob);
            }
        }
        public void xoaUC(UCJobUI uCJobUI)
        {
            string SQL = string.Format("DELETE FROM JobDetails WHERE  JobTitle = '{0}' ",
                uCJobUI.lblJobTitle.Text);
            db.thucthi(SQL);
        }
    } 
}
