using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoAnCuoiKy
{
    internal class JobDetailsDAO
    {
        DBconnection db = new DBconnection();
        SqlConnection connStr = new SqlConnection(DoAnCuoiKy.Properties.Settings.Default.connStr);
        FFindingCandidate FFindingCandidate = new FFindingCandidate();
        public void them(JobDetails jobDetails)
        {
            string SQL = string.Format("INSERT INTO Jobdetails (JobTitle,JobPosition,JobType,JobSalary,RecruitmentQuota,Location,ExpInYears,JobDescription) VALUES ('{0}', '{1}' , '{2}','{3}','{4}','{5}','{6}','{7}')",
                jobDetails.JobTitle, jobDetails.JobPosition, jobDetails.JobType,
                jobDetails.JobSalary, jobDetails.RecruitmentQuota, jobDetails.Location, jobDetails.ExpInYears,
                jobDetails.JobDescription);
            db.thucthi(SQL);

        }
        //public void them2(JobDetails jobDetails)
        //{
        //    string SQL = string.Format("INSERT INTO FavoriteJob (JobTitle,JobPosition,JobType,JobSalary,RecruitmentQuota,Location,ExpInYears,JobDescription) VALUES ('{0}', '{1}' , '{2}','{3}','{4}','{5}','{6}','{7}')",
        //        jobDetails.JobTitle, jobDetails.JobPosition, jobDetails.JobType,
        //        jobDetails.JobSalary, jobDetails.RecruitmentQuota, jobDetails.Location, jobDetails.ExpInYears,
        //        jobDetails.JobDescription);
        //    db.thucthi(SQL);

        //}
        //public List<JobDetails> loadJobDetails(){


        //    List<JobDetails> list = new List<JobDetails>();
          
        //        string query = "SELECT * FROM Jobdetails";


        //        SqlCommand command = new SqlCommand(query, connStr);
        //        connStr.Open();
        //        SqlDataReader reader = command.ExecuteReader();

        //        while (reader.Read())
        //        {
        //            string title = reader["JobTitle"].ToString();
        //            string position = reader["JobPosition"].ToString();
        //            string type = reader["JobType"].ToString();
        //            string salary = reader["JobSalary"].ToString();
        //            string recruitmentQuota = reader["RecruitmentQuota"].ToString();
        //            string location = reader["Location"].ToString();
        //            string expYear = reader["ExpInYears"].ToString();
        //            string description = reader["JobDescription"].ToString();
        //            JobDetails jobdt1 = new JobDetails();
        //            jobdt1.JobTitle = title;
        //            jobdt1.JobPosition = position;
        //            jobdt1.JobType = type;
        //            jobdt1.JobSalary = salary;
        //            jobdt1.RecruitmentQuota = recruitmentQuota;
        //            jobdt1.Location = location;
        //            jobdt1.ExpInYears = expYear;
        //            jobdt1.JobDescription = description;
        //            list.Add(jobdt1);
        //        }
        //        return list;
            
           
            
        //}
    } 
}
