using DoAnCuoiKy.Class;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoAnCuoiKy
{
    internal class ApplicantsDAO
    {

        DoAnCuoiKyEntities db = new DoAnCuoiKyEntities();
        public void LoadDanhSachYeuThich(FFavoriteApplicants f)
        {

            try
            {

                var favoriteApplicant = from c in db.ApplicantsOfCompanies
                                        where c.CompanyID == Constant.CompanyID && c.IsFavorite == true
                                        from a in db.Applicants
                                        where a.ApplicantID == c.ApplicantID
                                        select a;

                foreach (var c in favoriteApplicant)
                {
                    UCApplicants uCApplicants = new UCApplicants(c);
                    uCApplicants.btnFavorite.Hide();
                        f.pnlFavApplicants.Controls.Add(uCApplicants);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Lỗi truy vấn: " + ex.Message);
            }

        }
        public void LoadDanhSach(FApplicants f)
        {

            try
            {

                var candidate = from c in db.Applicants select c;

                foreach (var c in candidate)
                {

                    UCApplicants uCApplicants = new UCApplicants(c);
                    if(checkYeuThich(c))
                    {
                        uCApplicants.btnFavorite.Checked = true;
                    }
                    f.pnlAllCandidate.Controls.Add(uCApplicants);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Lỗi truy vấn: " + ex.Message);
            }

        }
        public bool checkYeuThich(Applicant app1)
        {
            var query = from c in db.ApplicantsOfCompanies where c.ApplicantID == app1.ApplicantID select c;
            return query.SingleOrDefault().IsFavorite == true;
        }
        public void xoaUC(UCApplicants uCApplicants)
        {
            //string SQL = string.Format("DELETE FROM Profile WHERE  ApplyPosition = '{0}' ",
            // uCApplicants.lblCandidateApplyPos.Text);
            //db.thucthi(SQL);
        }
        public void HuyYeuThich(Applicant applicant)
        {


            var entity = from a in db.ApplicantsOfCompanies where a.ApplicantID == applicant.ApplicantID select a;
            entity.SingleOrDefault().IsFavorite = false;

            db.SaveChanges();

        }

        public void YeuThich(Applicant applicant)
        {


            var entity = from a in db.ApplicantsOfCompanies where a.ApplicantID == applicant.ApplicantID select a;
            entity.SingleOrDefault().IsFavorite = true;

            db.SaveChanges();

        }

        public void xoa(Applicant applicant)
        {
            var applicant1 = db.Applicants.Find(applicant.ApplicantID);
            if (applicant1 != null)
            {
                db.Applicants.Remove(applicant1);
                db.SaveChanges();
            }
        }
        public void LoadDanhSach(FFavoriteApplicants f)
        {
            try
            {
                DoAnCuoiKyEntities db = new DoAnCuoiKyEntities();
                var query = (from a in db.Applicants select a);

                foreach (var applicant in query)
                {

                    UCApplicants uCApplicants = new UCApplicants(applicant);

                    f.pnlFavApplicants.Controls.Add(uCApplicants);

                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Lỗi truy vấn: " + ex.Message);
            }


        }
    }
}
