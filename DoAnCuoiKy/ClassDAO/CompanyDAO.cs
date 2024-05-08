using DoAnCuoiKy.ApplicantForm;
using DoAnCuoiKy.Class;
using DoAnCuoiKy.UC;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DoAnCuoiKy
{
    internal class CompanyDAO
    {
        DoAnCuoiKyEntities db = new DoAnCuoiKyEntities();
        public void ThemApplicant(int applicantID,Job job)
        {
            if (checkApplied(applicantID, job))
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
            }
            else MessageBox.Show("You have already applied for this job");
        }
        public bool checkApplied(int applicantID,Job job) 
        {
            var result = from c in db.ApplicantsOfCompanies where c.ApplicantID==applicantID && c.CompanyID == job.CompanyID && c.JobID == job.JobID select c;
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
    }

}
