using DoAnCuoiKy.ApplicantForm;
using DoAnCuoiKy.Class;
using DoAnCuoiKy.UC;
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
        public void XoaThongTinWorkExp(WorkExperience workExperience,FProfileApplicant f1)
        {
            using (DoAnCuoiKyEntities db = new DoAnCuoiKyEntities())
            {
                db.WorkExperiences.Remove(db.WorkExperiences.Find(workExperience.WorkExperienceID));
                db.SaveChanges();
            }
            LoadThongTinWorkExp(f1);
        }
        
        public void ThemThongTinWorkExp(FWorkExperience f1)  //thieu check null
        {
            db.WorkExperiences.Add(new WorkExperience
            {
                JobTitle = f1.txtJobTitle.Text,
                CompanyName = f1.txtCompany.Text,

                FromMonth = f1.cbWorkMonthFrom.Text,
                FromYear = f1.cbWorkYearFrom.Text,
                ToMonth = f1.cbWorkMonthTo.Text,
                ToYear = f1.cbWorkYearTo.Text,

                WorkDetails = f1.txtWorkAddDetails.Text,
                ProjectDetails = f1.txtProjectAddDetails.Text,
                ApplicantID = Constant.ApplicantID

            });
            db.SaveChanges();
            LoadThongTinWorkExp(f1.fProfile);
        }
        public void SuaThongTinWorkExp(FWorkExperience f1)
        {
            

            if (f1.WorkExperience != null)
            {
                var query = from c in db.WorkExperiences
                            where c.WorkExperienceID == f1.WorkExperience.WorkExperienceID
                            select c;

                query.Single().JobTitle = f1.txtJobTitle.Text;
                query.First().CompanyName = f1.txtCompany.Text;
                query.First().FromMonth = f1.cbWorkMonthFrom.Text;
                query.First().FromYear = f1.cbWorkYearFrom.Text;
                query.First().ToMonth = f1.cbWorkMonthTo.Text;
                query.First().ToYear = f1.cbWorkYearTo.Text;
                query.First().WorkDetails = f1.txtWorkAddDetails.Text;
                query.First().ProjectDetails = f1.txtProjectAddDetails.Text;
                db.SaveChanges();
            }
            else if (f1.WorkExperience == null)
            {
                ThemThongTinWorkExp(f1);
            }

            LoadThongTinWorkExp(f1.fProfile);
        }
        public void LoadThongTinWorkExp(FProfileApplicant f1)
        {
            try
            {
                var query = from c in db.WorkExperiences
                            where c.ApplicantID == Constant.ApplicantID
                            select c;
                if (query.Any())
                {
                    f1.pnlWorkExp.Size = new System.Drawing.Size(f1.pnlWorkExp.Size.Width, 142);
                    f1.pnlListOfWorkExp.Controls.Clear();
                    //f1.lblWorkExpPlaceholder.Visible=false;
                    foreach (var workExp in query)
                    {
                        UCApplicantWorkExp uc1 = new UCApplicantWorkExp(workExp, f1);

                        f1.pnlListOfWorkExp.Controls.Add(uc1);
                        f1.pnlWorkExp.Size = new System.Drawing.Size(f1.pnlWorkExp.Size.Width, f1.pnlWorkExp.Size.Height + uc1.Size.Height);
                    }
                }
                else
                {
                    // f1.lblWorkExpPlaceholder.Visible = true;
                    //f1.lblAboutMePlaceHolder.Text = "Introduce your strengths and years of experience";
                    //f1.pnlAboutMe.Size = new System.Drawing.Size(f1.pnlAboutMe.Size.Width, 100 + f1.lblAboutMePlaceHolder.Size.Height);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Lỗi truy vấn: " + ex.Message);
            }
        }

        public void SuaThongTinAboutMe(FAboutMe f1)
        {
            var query = from c in db.Aboutmes
                        where c.ApplicantID == Constant.ApplicantID
                        select c;

            if (query.Any())
            {
                query.First().AboutmeDetails = f1.txtAboutMe.Text;

                db.SaveChanges();
            }
            else
            {

                db.Aboutmes.Add(new Aboutme
                {
                    AboutmeDetails = f1.txtAboutMe.Text,
                    AboutmeID = Constant.ApplicantID

                });
                db.SaveChanges();
            }
        }

        public void LoadThongTinAboutMe(FProfileApplicant f1)
        {
            try
            {
                var query = from c in db.Aboutmes
                            where c.ApplicantID == Constant.ApplicantID
                            select c.AboutmeDetails;
                if (query.Count() > 0)
                {
                    if (query.First() != "")
                    {
                        f1.lblAboutMePlaceHolder.Text = query.First();
                        f1.pnlAboutMe.Size = new System.Drawing.Size(f1.pnlAboutMe.Size.Width, 100 + f1.lblAboutMePlaceHolder.Size.Height);
                    }
                    else
                    {
                        f1.lblAboutMePlaceHolder.Text = "Introduce your strengths and years of experience";
                        f1.pnlAboutMe.Size = new System.Drawing.Size(f1.pnlAboutMe.Size.Width, 100 + f1.lblAboutMePlaceHolder.Size.Height);
                    }

                }


            }
            catch (Exception ex)
            {
                Console.WriteLine("Lỗi truy vấn: " + ex.Message);
            }
        }
        public void LoadDanhSachUngVienYeuThich(FFavoriteApplicants f)
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
        public void LoadDanhSachUngVien(FApplicants f)
        {
            try
            {
                var candidate = from c in db.Applicants select c;

                foreach (var c in candidate)
                {
                    UCApplicants uCApplicants = new UCApplicants(c);
                    if (checkYeuThich(c))
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



    }
}
