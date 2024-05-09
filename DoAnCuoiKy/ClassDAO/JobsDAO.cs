using DoAnCuoiKy.Class;
using DoAnCuoiKy.UC;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data.SqlTypes;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DoAnCuoiKy
{
    internal class JobsDAO
    {
        DoAnCuoiKyEntities db = new DoAnCuoiKyEntities();
        #region Hàm Load
        public void LoadDanhSachJobYeuThich(FormFavoriteJobs f)
        {
            var favJob = from a in db.JobStatus where a.IsFavorite == true && a.ApplicantID == Constant.ApplicantID select a;

            var allJob = from job in db.Jobs
                         join jobStatus in favJob on job.JobID equals jobStatus.JobID
                         where jobStatus.IsFavorite == true
                         select job;
            var result = allJob.ToList();
            foreach (var job in result)
            {
                UCJobUI uCJob = new UCJobUI(job);
                f.pnlFavJobs.Controls.Add(uCJob);
            }
        }
        public void LoadDanhSach(FFindingCandidate f)
        {

            var allJob = from c in db.Jobs select c;

            foreach (var job in allJob)
            {
                UCJobUI uCJob = new UCJobUI(job);

                if (job.JobStatus.FirstOrDefault()!=null && job.JobStatus.FirstOrDefault().IsApplied == true)
                {
                    uCJob.btnApplyNow.Enabled = false;
                    uCJob.btnApplyNow.Text = "Applied";
                }
                uCJob.CBoxSelected.Visible = false;
                f.PnlRecommendJobs.Controls.Add(uCJob);
            }

        }
        public void LoadDanhSach2(FFindingCandidate f, List<Job> jobs)
        {
            foreach (var job in jobs)
            {
                UCJobUI ucJob = new UCJobUI(job);
                
                ucJob.CBoxSelected.Visible = false;
                f.PnlRecommendJobs.Controls.Add(ucJob);
            }
        }
        public void LoadDanhSach3(FJobs f, List<Job> jobs)
        {
            foreach (var job in jobs)
            {
                UCJobUI ucJob = new UCJobUI(job);
                ucJob.CBoxSelected.Visible = false;
                ucJob.btnApplyNow.Enabled = false;
                ucJob.btnApplyNow.Text = "Posted";
                f.pnlCreatedJob.Controls.Add(ucJob);
            }
        }
        public void LoadDanhSach4(FJobs f)
        {

            try
            {
                DoAnCuoiKyEntities db = new DoAnCuoiKyEntities();
                f.pnlCreatedJob.Controls.Clear();
                var jobsOfCompany = from c in db.Jobs where c.CompanyID == Constant.CompanyID select c;

                foreach (var job in jobsOfCompany)
                {
                    UCJobUI uCJob = new UCJobUI(job);
                    uCJob.btnApplyNow.Enabled = false;
                    uCJob.btnApplyNow.Text = "Posted";
                    f.pnlCreatedJob.Controls.Add(uCJob);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Lỗi truy vấn: " + ex.Message);
            }

        }
        public void LoadCompanyDetail(Company company,FInformation fInformation)
        {

        }
        public void LoadJobDetail(Job jobInfo , FJobDetails f)
        {
            var inforCompany = from c in db.Companies where c.CompanyID == jobInfo.CompanyID select c;
            var result = inforCompany.First();
            f.lblJobTitle.Text = jobInfo.JobTitle.ToString();
            f.lblCompanyName.Text = result.CompanyName.ToString();
            f.labelCompanyName2.Text = result.CompanyName.ToString();
            f.lblCompanySize.Text = result.CompanySize.ToString();
            f.lblCompanyType.Text = result.CompanyType.ToString();
            f.lblCountry.Text = result.CompanyCountry.ToString();
            f.lblWorkingday.Text = result.CompanyWorkingDays.ToString();
            f.lblSalary.Text = jobInfo.JobSalary.ToString();
            f.lblJobDescription.Text = jobInfo.JobDescription.ToString();
            f.lblJobBenefit.Text = jobInfo.JobBenefit.ToString();
            f.lblJobRequirement.Text = jobInfo.JobRequirement.ToString();
            f.pnlDetails.Size = new Size(f.pnlDetails.Width, f.lblJobBenefit.Height + f.lblJobDescription.Height + f.lblJobRequirement.Height + f.lblReasonToJoinUs.Height
                + 450);
            f.txtJobtype.Text = jobInfo.JobType;

        }
        
        #endregion

        #region Hàm Thêm
        public void YeuThich(Job job)
        {
            if (checkedFav(job) == true)
            {
                db.JobStatus.Add(new JobStatu
                {
                    JobID = job.JobID,
                    ApplicantID = Constant.ApplicantID,
                    IsFavorite = true,
                    IsApplied = false,
                });
                db.SaveChanges();
            }
            else MessageBox.Show("Job has available in favoriteList");
        }
        public void Them(FPostAJob f)
        {
            db.Jobs.Add(new Job
            {
                JobTitle = f.txtJobTitle.Text,
                JobType = f.cbJobType.SelectedItem.ToString(),
                JobSalary = f.txtJobSalary.Text
            ,
                RecruitmentQuota = f.txtRecruitmentQuota.Text,
                Location = f.cbLocation.SelectedItem.ToString(),
                ExpInYears = f.txtJobExperiencesInYears.Text
            ,
                JobRequirement = f.txtJobrequirement.Text,
                JobDescription = f.txtJobDescription.Text,
                CompanyID = f.employerInfor.CompanyID,
                JobBenefit = f.txtBenefit.Text
            });
            db.SaveChanges();
        }
        //public void them(Job job)
        //{
        //    db.Jobs.Add(job);

        //    db.SaveChanges();

        //}

        #endregion

        #region Hàm Xóa
        public void HuyYeuThich(Job job)
        {
            var query = (from a in db.JobStatus where job.JobID == a.JobID && a.ApplicantID == Constant.ApplicantID select a).First();
            db.JobStatus.Remove(query);
            db.SaveChanges();
        }
        public void XoaJob(Job job)
        {
            var applicant = db.Jobs.Find(job.JobID);
            if (applicant != null)
            {
                db.Jobs.Remove(applicant);
                db.SaveChanges();
            }
        }
        public void XoaUCfav(UCJobUI uCJobUI)
        {
            DoAnCuoiKyEntities db = new DoAnCuoiKyEntities();
            HuyYeuThich(uCJobUI.job);
            db.SaveChanges();
        }
        public void XoaUC(UCJobUI uCJobUI)
        {
            DoAnCuoiKyEntities db = new DoAnCuoiKyEntities();
            var query = (from a in db.JobStatus where a.JobID == uCJobUI.job.JobID select a);
            foreach (var a in query)
            {
                db.JobStatus.Remove(a);
            }
            db.SaveChanges();
            var result = from c in db.Jobs where c.JobID == uCJobUI.job.JobID select c;
            var deletedJob = result.First();
            db.Jobs.Remove(deletedJob);
            db.SaveChanges();
        }
        public void XoaUC2(UCNote uCNote)
        {
            var dateInterview = from c in db.DateInterviews 
                                where c.ApplicantID == Constant.ApplicantID && c.CompanyID == uCNote.company1.CompanyID && c.DateInterview1 == uCNote.date1.DateInterview1
                                select c;
            foreach (var a in dateInterview)
            {
                db.DateInterviews.Remove(a);
            }
            db.SaveChanges();

        }
        #endregion

        #region Hàm Check
        public bool checkedFav(Job job)
        {
            var result = from c in db.JobStatus where c.JobID == job.JobID && c.ApplicantID == Constant.ApplicantID select c;
            if (result.Count() == 0) return true;
            return false;
        }
        public bool CheckApply(Job job1, int ApplicantID)
        {
            var query = from a in db.JobStatus where a.JobID == job1.JobID && a.ApplicantID == ApplicantID select a;
            return query.First().IsApplied == true;
        }
        #endregion

        #region Hàm Search
        public void searchJobs(FFindingCandidate f)
        {
            DoAnCuoiKyEntities db = new DoAnCuoiKyEntities();
            var result = from c in db.Jobs where c.JobTitle.Contains(f.txtJobName.Text) && c.Location.Contains(f.cbxLocation.SelectedItem.ToString()) select c;
            int expInYearsAsInt;
            List<Job> resultList = new List<Job>();
            List<Job> jobFilter = new List<Job>();
            if (f.checkboxFullTime.Checked)
            {
                var fullTime = from c in result where c.JobType.Contains("Full") select c;
                if (f.checkboxPartTime.Checked)
                {
                    result = result.Union(fullTime);
                }
                else result = fullTime;
            }
            if (f.checkboxPartTime.Checked)
            {
                var partTime = from c in result where c.JobType.Contains("Part") select c;
                if (f.checkboxFullTime.Checked)
                {
                    result = result.Union(partTime);
                }
                else result = partTime;
            }
            if (f.checkboxLessThan3.Checked)
            {

                foreach (var job in result)
                {
                    expInYearsAsInt = int.Parse(job.ExpInYears);
                    if (expInYearsAsInt < 3)
                    {
                        resultList.Add(job);
                    }
                }
                jobFilter = resultList;

            }
            if (f.checkbox3To5.Checked)
            {
                foreach (var job in result)
                {
                    expInYearsAsInt = int.Parse(job.ExpInYears);
                    if (expInYearsAsInt >= 3 && expInYearsAsInt <= 5)
                    {

                        resultList.Add(job);
                    }
                }
                jobFilter = resultList;
            }
            if (f.checkbox5To10.Checked)
            {
                foreach (var job in result)
                {
                    expInYearsAsInt = int.Parse(job.ExpInYears);
                    if (expInYearsAsInt > 5 && expInYearsAsInt <= 10)
                    {
                        resultList.Add(job);
                    }
                }
                jobFilter = resultList;
            }
            if (jobFilter != resultList)
                jobFilter = result.ToList();
            f.PnlRecommendJobs.Controls.Clear();
            LoadDanhSach2(f, jobFilter);
        }
        public void searchCreatedJobs(FJobs f)
        {
            DoAnCuoiKyEntities db = new DoAnCuoiKyEntities();
            var result = from c in db.Jobs
                         where c.JobTitle.Contains(f.txtJobName.Text) && c.Location.Contains(f.cbxLocation.SelectedItem.ToString()) && c.CompanyID == Constant.CompanyID
                         select c;
            int expInYearsAsInt;
            List<Job> resultList = new List<Job>();
            List<Job> jobFilter = new List<Job>();
            if (f.checkboxFullTime.Checked)
            {
                var fullTime = from c in result where c.JobType.Contains("Full") select c;
                if (f.checkboxPartTime.Checked)
                {
                    result = result.Union(fullTime);
                }
                else result = fullTime;
            }
            if (f.checkboxPartTime.Checked)
            {
                var partTime = from c in result where c.JobType.Contains("Part") select c;
                if (f.checkboxFullTime.Checked)
                {
                    result = result.Union(partTime);
                }
                else result = partTime;
            }
            if (f.checkboxLessThan3.Checked)
            {

                foreach (var job in result)
                {
                    expInYearsAsInt = int.Parse(job.ExpInYears);
                    if (expInYearsAsInt < 3)
                    {
                        resultList.Add(job);
                    }
                }
                jobFilter = resultList;

            }
            if (f.checkbox3To5.Checked)
            {
                foreach (var job in result)
                {
                    expInYearsAsInt = int.Parse(job.ExpInYears);
                    if (expInYearsAsInt >= 3 && expInYearsAsInt <= 5)
                    {
                        resultList.Add(job);
                    }
                }
                jobFilter = resultList;
            }
            if (f.checkbox5To10.Checked)
            {
                foreach (var job in result)
                {
                    expInYearsAsInt = int.Parse(job.ExpInYears);
                    if (expInYearsAsInt > 5 && expInYearsAsInt <= 10)
                    {
                        resultList.Add(job);
                    }
                }
                jobFilter = resultList;
            }
            if (jobFilter != resultList)
                jobFilter = result.ToList();
            f.pnlCreatedJob.Controls.Clear();
            LoadDanhSach3(f, jobFilter);
        }
        #endregion

    }
}
