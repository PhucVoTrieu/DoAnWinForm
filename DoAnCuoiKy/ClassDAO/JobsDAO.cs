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
        DoAnCuoiKyEntities db = new DoAnCuoiKyEntities();
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

            DoAnCuoiKyEntities db = new DoAnCuoiKyEntities();
            var allJob = from c in db.Jobs select c;

            foreach (var job in allJob)
            {
                UCJobUI uCJob = new UCJobUI(job);
                uCJob.CBoxSelected.Visible = false;
                f.PnlRecommendJobs.Controls.Add(uCJob);
            }
          
        }
        public void them(Job job)
        {
            db.Jobs.Add(job);

            db.SaveChanges();

        }
        public void xoa(Job job)
        {
            var applicant = db.Jobs.Find(job.JobID);
            if (applicant != null)
            {
                db.Jobs.Remove(applicant);
                db.SaveChanges();
            }
        }
        public void LoadDanhSach(FormFavoriteJobs f)
        {
            try
            {
                DoAnCuoiKyEntities db = new DoAnCuoiKyEntities();
                var job = from c in db.Jobs select c;

                foreach (var c in job)
                {
                    UCJobUI uCApplicants = new UCJobUI(c);

                    f.pnlFavJobs.Controls.Add(uCApplicants);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Lỗi truy vấn: " + ex.Message);
            }
        }
        public void xoaUC(UCJobUI uCJobUI)
        {
            
            DoAnCuoiKyEntities db = new DoAnCuoiKyEntities();
            //var deleteUCJobUI = from UCJob in db.Jobs where UCJob.JobID == uCJobUI.job.JobID select UCJob;
            //db.Jobs.Remove(deleteUCJobUI.SingleOrDefault());
            var deleteUCJobUI = db.Jobs.Find(uCJobUI.job.JobID);
            if ( deleteUCJobUI != null )
            {
                db.Jobs.Remove(deleteUCJobUI);
            }
            db.SaveChanges();
        }
    } 
}
