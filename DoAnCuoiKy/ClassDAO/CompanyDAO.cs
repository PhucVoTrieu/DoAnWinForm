using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoAnCuoiKy
{
    internal class CompanyDAO
    {
        public CompanyDAO() { 

        }
        public void ThemApplicant(int applicantID,int companyID)
        {
            DoAnCuoiKyEntities db = new DoAnCuoiKyEntities();
            var query = from app in db.ApplicantsOfCompanies  select app;
            db.ApplicantsOfCompanies.Add(new ApplicantsOfCompany
            {
                CompanyID = companyID,
                ApplicantID = applicantID,
                IsAccepted = false,
                IsFavorite = false,
            });
            var addFavorite = from status in db.JobStatus where status.ApplicantID == applicantID select status;
            addFavorite.First().IsApplied=true;
            db.SaveChanges();
        }
    }

}
