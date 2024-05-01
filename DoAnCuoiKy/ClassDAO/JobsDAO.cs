using DoAnCuoiKy.Class;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data.SqlTypes;
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

               // uCJob.CBoxSelected.Visible = false;
                f.pnlFavJobs.Controls.Add(uCJob);
            }
        }
        public void HuyYeuThich(Job job)
        {
            var query = (from a in db.JobStatus where job.JobID == a.JobID && a.ApplicantID == Constant.ApplicantID select a).First();
            db.JobStatus.Remove(query);
            db.SaveChanges();
        }
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
        public bool checkedFav(Job job)
        {
            var result = from c in db.JobStatus where c.JobID == job.JobID && c.ApplicantID == Constant.ApplicantID select c;
            if(result.Count() == 0) return true;
            return false;
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
        public void laydulieuCoDieuKien(List<JobDetails> list, string conditionText)
        {


        }
        public void LoadDanhSach(FFindingCandidate f)
        {

            var allJob = from c in db.Jobs select c;

            foreach (var job in allJob)
            {
                UCJobUI uCJob = new UCJobUI(job);

                //if (CheckApply(job, f.applicant.ApplicantID))
                //{
                //    uCJob.btnApplyNow.Enabled = false;
                //    uCJob.btnApplyNow.Text = "Applied";
                //}
                uCJob.CBoxSelected.Visible = false;
                f.PnlRecommendJobs.Controls.Add(uCJob);
            }

        }
        public void LoadDanhSach2(FFindingCandidate f , List<Job> jobs)
        {
            foreach (var job in jobs)
            {
                UCJobUI ucJob = new UCJobUI(job);
                ucJob.CBoxSelected.Visible = false;
                f.PnlRecommendJobs.Controls.Add(ucJob);
            }    
        }
        public bool CheckApply(Job job1, int ApplicantID)
        {
            var query = from a in db.JobStatus where a.JobID == job1.JobID && a.ApplicantID == ApplicantID select a;
            return query.First().IsApplied == true;
        }

        public void them(Job job)
        {
            db.Jobs.Add(job);

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
        //public void LoadDanhSach(FormFavoriteJobs f)
        //{
        //    try
        //    {
        //        DoAnCuoiKyEntities db = new DoAnCuoiKyEntities();
        //        var job = from c in db.Jobs select c;

        //        foreach (var c in job)
        //        {
        //            UCJobUI uCApplicants = new UCJobUI(c);

        //            f.pnlFavJobs.Controls.Add(uCApplicants);
        //        }
        //    }
        //    catch (Exception ex)
        //    {
        //        Console.WriteLine("Lỗi truy vấnFavojob: " + ex.Message);
        //    }
        //}
        public void xoaUCfav(UCJobUI uCJobUI)
        {
            DoAnCuoiKyEntities db = new DoAnCuoiKyEntities();
            HuyYeuThich(uCJobUI.job);
            db.SaveChanges();
        }
        public void xoaUC(UCJobUI uCJobUI)
        {
            DoAnCuoiKyEntities db = new DoAnCuoiKyEntities();
            var query = (from a in db.JobStatus where a.JobID == uCJobUI.job.JobID select a);
            foreach (var a in query) 
            {
                db.JobStatus.Remove(a);
            }
            db.SaveChanges();
            var result = from c in db.Jobs where c.JobID ==  uCJobUI.job.JobID select c;
            var deletedJob = result.First();
            db.Jobs.Remove(deletedJob);
            db.SaveChanges();
        }
    }
}
