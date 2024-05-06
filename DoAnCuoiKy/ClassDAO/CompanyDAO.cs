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
        public void ThemApplicant(int applicantID,int companyID)
        {
            if (checkApplied(applicantID, companyID))
            {
                db.ApplicantsOfCompanies.Add(new ApplicantsOfCompany
                {
                    CompanyID = companyID,
                    ApplicantID = applicantID,
                    IsAccepted = false,
                    IsFavorite = false,
                });
                db.SaveChanges();
            }
            else MessageBox.Show("You have already applied for this job");
        }
        public bool checkApplied(int applicantID,int companyID) 
        {
            var result = from c in db.ApplicantsOfCompanies where c.ApplicantID==applicantID && c.CompanyID == companyID select c;
            if (result.Count() == 0) return true;
            return false;
        }
    }

}
