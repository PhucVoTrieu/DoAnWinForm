using DoAnCuoiKy.ApplicantForm;
using DoAnCuoiKy.Class;
using DoAnCuoiKy.UC;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DoAnCuoiKy
{
    internal class CompanyDAO
    {
        DoAnCuoiKyEntities db = new DoAnCuoiKyEntities();
        public void ThemApplicant(int applicantID, Job job)
        {
            if (CheckNotApplied(applicantID, job))
            {
                var companyID = job.CompanyID;
                db.ApplicantsOfCompanies.Add(new ApplicantsOfCompany
                {
                    CompanyID = (int)companyID,
                    ApplicantID = applicantID,
                    IsAccepted = false,
                    IsFavorite = false,
                    JobID = job.JobID
                });
                db.SaveChanges();
                var checkedJob = from c in db.JobStatus where c.JobID == job.JobID && applicantID == c.ApplicantID select c;
                if (checkedJob.Count() == 0)
                {
                    db.JobStatus.Add(new JobStatu
                    {
                        ApplicantID = applicantID,
                        JobID = job.JobID,
                        IsApplied = true,
                        IsFavorite = false
                    });
                }
                else 
                {
                    if (checkedJob.FirstOrDefault().IsApplied == false)
                        checkedJob.FirstOrDefault().IsApplied = true;
                }
                db.SaveChanges();
            }
            else MessageBox.Show("You have already applied for this job");
        }
        public bool CheckNotApplied(int applicantID, Job job)
        {
            var result = from c in db.ApplicantsOfCompanies where c.ApplicantID == applicantID && c.CompanyID == job.CompanyID && c.JobID == job.JobID select c;
            if (result.Count() == 0) return true;
            return false;
        }
        public void LoadThongBaoPhongVan(Applicant a ,FNotification f)
        {
            try
            {
                f.pnlNote.Controls.Clear();
                var dateInterview = from c in db.DateInterviews where c.ApplicantID == a.ApplicantID select c;
                if (dateInterview.Any())
                {
                    foreach (var interviewinfor in dateInterview)
                    {
                        var companyName = from b in db.Companies where b.CompanyID == interviewinfor.CompanyID select b;
                        var result = companyName.FirstOrDefault();
                        if (result != null)
                        {
                            UCNote uCNote = new UCNote(interviewinfor, result, a);
                            f.pnlNote.Controls.Add(uCNote);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Lỗi truy vấn:LoadTHongBaoPhongVan" + ex.Message);
            }
        }
        
        public void LoadInforJobOfCompany(Job j)
        {
            var inforCompany = from c in db.Companies where j.CompanyID == c.CompanyID select c;
            var result = inforCompany.FirstOrDefault();
            FInformation f1 = new FInformation(result);
            f1.Show();
        }


        public void LoadCompanyDetail(Company employerInfo, FInformation f)
        {
            try
            {
                DoAnCuoiKyEntities db = new DoAnCuoiKyEntities();
                f.lblBenefit.Text = employerInfo.CompanyBenefit;
                f.lblAddress.Text = employerInfo.CompanyAddress;
                f.lblCompanyName.Text = employerInfo.CompanyName;
                f.lblCompanySize.Text = employerInfo.CompanySize;
                f.lblCompanyType.Text = employerInfo.CompanyType;
                f.lblCountry.Text = employerInfo.CompanyCountry;
                f.lblWorkingDays.Text = employerInfo.CompanyWorkingDays;
                f.lblCompanyOverviewContent.Text = employerInfo.CompanyOverview;

                f.pnlOverview.Size = new Size(f.pnlOverview.Width, 200 + f.lblCompanyOverviewContent.Height + f.lblBenefit.Height);

            }
            catch (Exception ex)
            {
                Console.WriteLine("Lỗi truy vấn: " + ex.Message);
            }

        }


        public void LoadJobCreatedByCompany(Company employerInfo, FInformation f)
        {

            try
            {
                DoAnCuoiKyEntities db = new DoAnCuoiKyEntities();
                var jobsOfCompany = from c in db.Jobs where c.CompanyID == employerInfo.CompanyID select c;
                int jobCreatedQuanity = 0;
                foreach (var job in jobsOfCompany)
                {
                    UCJobUI uCJob = new UCJobUI(job);
                    uCJob.CBoxSelected.Hide();
                    uCJob.btnApplyNow.Enabled = false;
                    uCJob.btnApplyNow.Text = "Posted";
                    f.pnlJobOpenings.Controls.Add(uCJob);
                    ++jobCreatedQuanity;
                }
                f.lblJobsOpenings.Text = jobCreatedQuanity.ToString() + f.lblJobsOpenings.Text;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Lỗi truy vấn: " + ex.Message);
            }

        }
    }

}
