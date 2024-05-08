using DoAnCuoiKy.ApplicantForm;
using DoAnCuoiKy.Class;
using DoAnCuoiKy.EmployerForm;
using DoAnCuoiKy.UC;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity.Core.Common.CommandTrees;
using System.Data.Entity.Infrastructure;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DoAnCuoiKy
{
    internal class ApplicantsDAO
    {

        DoAnCuoiKyEntities db = new DoAnCuoiKyEntities();
        #region Hàm Load
        public void LoadThongTinWorkExp(FProfileApplicant f1)
        {
            try
            {
                var query = from c in db.WorkExperiences
                            where c.ApplicantID == f1.applicantInfo.ApplicantID
                            select c;
                if (query.Any())
                {
                    f1.pnlWorkExp.Size = new System.Drawing.Size(f1.pnlWorkExp.Size.Width, 65);
                    f1.pnlListOfWorkExp.Controls.Clear();
                    //f1.lblWorkExpPlaceholder.Visible=false;
                    foreach (var workExp in query)
                    {
                        UCApplicantWorkExp uc1 = new UCApplicantWorkExp(workExp, f1);

                        f1.pnlListOfWorkExp.Controls.Add(uc1);
                        f1.pnlWorkExp.Size = new System.Drawing.Size(f1.pnlWorkExp.Size.Width, f1.pnlWorkExp.Size.Height + uc1.Size.Height);
                    }
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
                var inforJob = from a in db.Jobs where a.CompanyID == f.companyInfo.CompanyID select a;
                var result = inforJob.ToList();
                foreach (var allListJob in result)
                {
                    UCListApplicant uc = new UCListApplicant(allListJob, f);
                    f.pnlListOfApplicant.Controls.Add(uc);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Lỗi truy vấn: " + ex.Message);
            }

        }
        public void LoadThongTinEducation(FProfileApplicant f1)
        {
            try
            {
                var query = from c in db.Educations
                            where c.ApplicantID == f1.applicantInfo.ApplicantID
                            select c;
                if (query.Any())
                {
                    f1.pnlEducation.Size = new System.Drawing.Size(f1.pnlEducation.Size.Width, 45);
                    f1.pnlListOfEducation.Controls.Clear();
                    foreach (var education in query)
                    {
                        UCApplicantEducation uc1 = new UCApplicantEducation(education, f1);

                        f1.pnlListOfEducation.Controls.Add(uc1);
                        f1.pnlEducation.Size = new System.Drawing.Size(f1.pnlEducation.Size.Width, f1.pnlEducation.Size.Height + uc1.Size.Height);
                    }
                }
                else
                {

                }

            }
            catch (Exception ex)
            {
                Console.WriteLine("Lỗi truy vấn: " + ex.Message);
            }
        }
        public void LoadThongTinBasicInforlenForm(FProfileApplicant f1)
        {
            DoAnCuoiKyEntities db = new DoAnCuoiKyEntities();
            var query = from applicant in db.Applicants where f1.applicantInfo.ApplicantID == applicant.ApplicantID select applicant;

            f1.lblEmail.Text = query.Single().ApplicantEmail;
            f1.lblAddress.Text = query.Single().ApplicantAddress;
            DateTime a = (DateTime)query.Single().ApplicantDOB;
            f1.lblDOB.Text = a.ToString("dd/MM/yyyy");
            f1.lblPhoneNum.Text = query.Single().ApplicantPhonenumber;
            f1.lblYourName.Text = query.Single().ApplicantName;
            f1.lblYourTitle.Text = query.Single().ApplicantTitle;
            f1.lblGender.Text = query.Single().ApplicantGender;
            f1.lblPersonalPink.Text = query.Single().ApplicantPersonalLink;



            if (query.Single().ApplicantAvatar != null)
            {
                string appDirectory = Directory.GetParent(Environment.CurrentDirectory).Parent.FullName;
                f1.pboxAvatar.Image = Image.FromFile(Path.Combine(appDirectory, query.Single().ApplicantAvatar));
            }
            else if (query.Single().ApplicantAvatar == null)
            {
                f1.pboxAvatar.Image = DoAnCuoiKy.Properties.Resources.ss1;
            }
        }
        public void LoadThongTinBasicInfor(FeditBasicInfor f1)
        {
            try
            {
                var result = from c in db.Applicants where c.ApplicantID == f1.applicant1.ApplicantID select c;

                f1.txtAddress.Text = result.First().ApplicantAddress;
                f1.txtEmail.Text = result.First().ApplicantEmail;
                f1.txtGender.Text = result.First().ApplicantGender;
                f1.txtPersonalLink.Text = result.First().ApplicantPersonalLink;
                f1.txtPhoneNumber.Text = result.First().ApplicantPhonenumber;
                f1.txtDOB.Text = result.First().ApplicantDOB.ToString();
                if (result.First().ApplicantAvatar != null)
                {
                    string appDirectory = Directory.GetParent(Environment.CurrentDirectory).Parent.FullName;
                    f1.pboxAvatar.Image = Image.FromFile(Path.Combine(appDirectory, result.First().ApplicantAvatar));
                }
                else if (result.First().ApplicantAvatar == null)
                {
                    f1.pboxAvatar.Image = DoAnCuoiKy.Properties.Resources.ss1;
                }


            }
            catch (Exception ex)
            {
                Console.WriteLine("Lỗi truy vấn: " + ex.Message);
            }
        }
        public void LoadThongTinSkill(FProfileApplicant f1)
        {
            try
            {
                // danh sách toàn bộ Skill có trong ApplicantID
                var allSkillID = from c in db.ApplicantSkills
                                 where c.ApplicantID == f1.applicantInfo.ApplicantID
                                 select c;
                //chuyển sang list
                allSkillID.ToList();
                List<Skill> listOFSkill = new List<Skill>();
                foreach (var skillid in allSkillID)
                {
                    //skillname là dữ liệu các skill có trong ApplicantID
                    var Skillname = from c in db.Skills where c.SkillID == skillid.SkillID select c;
                    //thêm vào list
                    listOFSkill.AddRange(Skillname.ToList());
                }

                // f1.pnlSkill.Size = new System.Drawing.Size(f1.pnlEducation.Size.Width, 20);
                f1.pnlListOfSkills.Controls.Clear();
                foreach (var allSkill in listOFSkill)
                {
                    UCApplicantSkill uc1 = new UCApplicantSkill(allSkill, f1);
                    f1.pnlListOfSkills.Controls.Add(uc1);
                    //   f1.pnlSkill.Size = new System.Drawing.Size(f1.pnlSkill.Size.Width, f1.pnlSkill.Size.Height + uc1.Size.Height);
                }

            }
            catch (Exception ex)
            {
                Console.WriteLine("Lỗi truy vấn: " + ex.Message);
            }
        }
        public void LoadDanhSachUngVienTiemNang(FInvitedApplicant f)
        {
            try
            {
                // Lấy ID ứng viên yêu thích
                var favoriteApplicantIDs = from c in db.ApplicantsOfCompanies
                                           where c.CompanyID == Constant.CompanyID && c.IsAccepted == true
                                           select c.ApplicantID;

                // Lấy thông tin ứng viên yêu thích
                var allApplicant = from applicant in db.Applicants
                                   join favoriteApplicantID in favoriteApplicantIDs on applicant.ApplicantID equals favoriteApplicantID
                                   select applicant;
                var result = allApplicant.ToList();
                foreach (var c in allApplicant)
                {
                    UCApplicants uCApplicants = new UCApplicants(c);
                    uCApplicants.btnFavorite.Hide();
                    uCApplicants.btnInviteCanidate.Text = "Invited";
                    f.pnlPotentialApplicant.Controls.Add(uCApplicants);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Lỗi truy vấn: " + ex.Message);
            }

        }
        public void LoadDanhSachUngVienTiemNang(FInvitedApplicant f, List<Applicant> applicants)
        {
            foreach (var a in applicants)
            {
                UCApplicants uCApplicants = new UCApplicants(a);
                uCApplicants.btnFavorite.Hide();
                uCApplicants.btnInviteCanidate.Text = "Invited"; 
                f.pnlPotentialApplicant.Controls.Add(uCApplicants);
            }
        }
        public void LoadDanhSachUngVienYeuThich(FFavoriteApplicants f, List<Applicant> applicants)
        {
            foreach (var a in applicants)
            {
                UCApplicants uCApplicants = new UCApplicants(a);
                uCApplicants.btnFavorite.Hide();
                f.pnlFavApplicants.Controls.Add(uCApplicants);
            }
        }
        public void LoadThongTinAboutMe(FProfileApplicant f1)
        {
            try
            {
                var query = from c in db.Aboutmes
                            where c.ApplicantID == f1.applicantInfo.ApplicantID
                            select c.AboutmeDetails;
                if (query.Count() > 0)
                {
                    if (query.First() != "")
                    {
                        f1.lblAboutMePlaceHolder.Text = query.First();
                        f1.lblAboutMePlaceHolder.ForeColor = Color.Black;
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

                var favApplicant = from c in db.ApplicantsOfCompanies where c.CompanyID == Constant.CompanyID && c.IsFavorite == true select c;
                var allApplicant = from applicant in db.Applicants join c in favApplicant on applicant.ApplicantID equals c.ApplicantID select applicant;
                int tmpID = 0 ;
                foreach (var c in allApplicant)
                {
                    if(c.ApplicantID != tmpID)
                    {
                        tmpID = c.ApplicantID;
                        UCApplicants uCApplicants = new UCApplicants(c);
                        uCApplicants.btnFavorite.Hide();
                        f.pnlFavApplicants.Controls.Add(uCApplicants);
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Lỗi truy vấn:333 " + ex.Message);
            }

        }
        public void LoadDanhSachNgayPhongVan(FApplicants f )
        {
            try
            {
                f.pnlDateInterview.Controls.Clear();    
                var dateInterviewinfor = from c in db.DateInterviews where c.CompanyID == Constant.CompanyID select c;
                foreach (var c in dateInterviewinfor)
                {
                    var applicantInfor = from a in db.Applicants where a.ApplicantID == c.ApplicantID select a;
                    var result = applicantInfor.FirstOrDefault(); 
                    UCDateInterview u1 = new UCDateInterview(c,result);
                    f.pnlDateInterview.Controls.Add(u1);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Lỗi truy vấn: " + ex.Message);
            }
        }
        //public void LoadDanhSachUngVienGroup(Job job, FApplicants f, UCListApplicant u1)
        //{
        //    var allApplicantOnJob = from c in db.ApplicantsOfCompanies
        //                            where c.JobID == job.JobID && c.CompanyID == job.CompanyID
        //                            select c.ApplicantID into query
        //                            from a in db.Applicants
        //                            where a.ApplicantID == query
        //                            select a;
        //    var result = allApplicantOnJob.ToList();
        //    var result2 = allApplicantOnJob.ToList();
        //    int count = 0;
        //    UCApplicants uCApplicants1 = new UCApplicants();
        //    if (allApplicantOnJob.Any())
        //    {
        //        u1.pnlJobCreated.Size = new System.Drawing.Size(902, uCApplicants1.Size.Height);
        //        u1.pnlJobCreated.Controls.Clear();
        //        u1.Size = new System.Drawing.Size(902, uCApplicants1.Size.Height);
        //        foreach (var allApplicant in result2)
        //        {
        //            if (count < 3)
        //            {
        //                count++;
        //                UCApplicants uCApplicants = new UCApplicants(allApplicant, f);
        //                uCApplicants.btnInviteCanidate.Enabled = true;
        //                u1.pnlJobCreated.Controls.Add(uCApplicants);
        //                result.Remove(allApplicant);
        //                result2 = result;
        //            }
        //            else
        //            {
        //                count = 0;
        //                u1.pnlJobCreated.Size = new System.Drawing.Size(u1.pnlJobCreated.Size.Width, u1.pnlJobCreated.Size.Height + u1.Size.Height);
        //            }
        //        }
        //    }
        //}
        public void LoadDanhSachUngVienGroup(Job job, FApplicants f, UCListApplicant u1)
        {
            var allApplicantOnJob = from c in db.ApplicantsOfCompanies
                                    where c.JobID == job.JobID && c.CompanyID == job.CompanyID
                                    select c.ApplicantID into query
                                    from a in db.Applicants
                                    where a.ApplicantID == query
                                    select a;
            var result = allApplicantOnJob.ToList();
            if (allApplicantOnJob.Any())
            {
                foreach (var allApplicant in result)
                {
                    UCApplicants uCApplicants = new UCApplicants(allApplicant, f);
                    uCApplicants.btnInviteCanidate.Enabled = true;
                    u1.pnlJobCreated.Controls.Add(uCApplicants);
                }
            }

        }
        #endregion

        #region Hàm Thêm
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
            //LoadThongTinWorkExp(f1.fProfile);
        }
        public void YeuThich(Applicant applicant)
        {
            var allapplicant = from a in db.ApplicantsOfCompanies where a.ApplicantID == applicant.ApplicantID && a.CompanyID == Constant.CompanyID select a;
            foreach (var a in allapplicant)
            {
                a.IsFavorite = true;
            }
            db.SaveChanges();

        }
        public void Invite(UCApplicants u , FApplicants f)
        {
            var dtpDate = u.fApplicants.dtpInvite.Value.ToString("dd/MM/yyyy");
            var check = from c in db.DateInterviews where c.DateInterview1 == dtpDate && c.CompanyID == Constant.CompanyID select c;
            if (check.Any())
            {
                MessageBox.Show("Date already has an interview scheduled");
            }
            else
            {
                db.DateInterviews.Add(new DateInterview
                {
                    DateInterview1 = u.fApplicants.dtpInvite.Value.ToString("dd/MM/yyyy"),
                    CompanyID = Constant.CompanyID,
                    ApplicantID = u.applicantInfo.ApplicantID
                });
                db.SaveChanges();
                var applicant2 = from c in db.ApplicantsOfCompanies where Constant.CompanyID == c.CompanyID && c.ApplicantID == u.applicantInfo.ApplicantID select c;
                applicant2.First().IsAccepted = true;
                db.SaveChanges();
                LoadDanhSachNgayPhongVan(f);
            }
        }
        public void ThemThongTinEducation(FAddEducation f1)
        {
            db.Educations.Add(new Education
            {
                School = f1.txtSchoolApplicant.Text,
                Major = f1.txtMajorApplicant.Text,
                AddDetails = f1.txtEducationAdd.Text,

                FromMonth = f1.cbEducationMonthFrom.Text,
                ToMonth = f1.cbEducationMonthTo.Text,
                FromYear = f1.cbEducationYearFrom.Text,
                ToYear = f1.cbEducationYearTo.Text,
                ApplicantID = Constant.ApplicantID
            });
            db.SaveChanges();
            LoadThongTinEducation(f1.fProfile);

        }
        public void ThemThongTinSkill(FAddSkill f1)
        {

            //if(f1.Skill == null)
            //{
            db.Skills.Add(new Skill
            {
                SkillName = f1.txtYourSkill.Text
            });
            // tìm theo tên lấy ID của những skill vừa thêm
            var result = from c in db.Skills where c.SkillName == f1.txtYourSkill.Text select c;

            db.SaveChanges();
            if (result.Any())
            {
                // thêm vào ApplicantSkill theo ID 
                db.ApplicantSkills.Add(new ApplicantSkill
                {
                    SkillID = result.Single().SkillID,
                    ApplicantID = Constant.ApplicantID
                });
                db.SaveChanges();
            }
            LoadThongTinSkill(f1.fprofile);
            //}
        }


        #endregion

        #region Hàm Sửa
        public void LuuAvatar(Applicant app)
        {
            var query = from a in db.Applicants where app.ApplicantID == a.ApplicantID select a;
            query.First().ApplicantAvatar = app.ApplicantAvatar;
            db.SaveChanges();
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
        public void SuaThongTinEducation(FAddEducation f1)
        {
            if (f1.Education != null)
            {
                var query = from c in db.Educations
                            where c.EducationID == f1.Education.EducationID
                            select c;
                query.First().School = f1.txtSchoolApplicant.Text;
                query.First().Major = f1.txtMajorApplicant.Text;
                query.First().AddDetails = f1.txtEducationAdd.Text;
                query.First().FromMonth = f1.cbEducationMonthFrom.Text;
                query.First().ToMonth = f1.cbEducationMonthTo.Text;
                query.First().FromYear = f1.cbEducationYearFrom.Text;
                query.First().ToYear = f1.cbEducationYearTo.Text;
                db.SaveChanges();

            }
            else if (f1.Education == null)
            {
                ThemThongTinEducation(f1);
            }
            LoadThongTinEducation(f1.fProfile);
        }
        public void SuaThongTinBasicInfor(FeditBasicInfor f1)
        {
            if (f1 != null)
            {
                var result = from c in db.Applicants where c.ApplicantID == f1.applicant1.ApplicantID select c;
                result.First().ApplicantEmail = f1.applicant1.ApplicantEmail;
                result.First().ApplicantPhonenumber = f1.applicant1.ApplicantPhonenumber;
                result.First().ApplicantGender = f1.applicant1.ApplicantGender;
                result.First().ApplicantAddress = f1.applicant1.ApplicantAddress;
                result.First().ApplicantPersonalLink = f1.applicant1.ApplicantPersonalLink;
                result.First().ApplicantDOB = f1.applicant1.ApplicantDOB;


                db.SaveChanges();
            }
            LoadThongTinBasicInfor(f1);
        }

        #endregion

        #region Hàm Xóa
        public void XoaAvatar(Applicant app)
        {
            var query = from a in db.Applicants where app.ApplicantID == a.ApplicantID select a;
            query.First().ApplicantAvatar = null;
            db.SaveChanges();
        }
        public void XoaUC(UCApplicants uCApplicants)
        {
            var deletedApplicant = from c in db.ApplicantsOfCompanies where c.ApplicantID == uCApplicants.applicantInfo.ApplicantID && c.CompanyID == Constant.CompanyID select c;
            db.ApplicantsOfCompanies.Remove(deletedApplicant.First());
            db.SaveChanges();
        }
        public void XoaUC2(UCApplicants uCApplicants)
        {
            var deletedApplicant = from c in db.ApplicantsOfCompanies where c.ApplicantID == uCApplicants.applicantInfo.ApplicantID && c.CompanyID == Constant.CompanyID select c;
            if(deletedApplicant.Any())
            {
                foreach (var c in deletedApplicant)
                {
                    c.IsFavorite = false;
                }
            }    
            db.SaveChanges();
        }
        public void XoaUC3(UCApplicants uCApplicants)
        {
            var deletedApplicant = from c in db.ApplicantsOfCompanies where c.ApplicantID == uCApplicants.applicantInfo.ApplicantID && c.CompanyID == Constant.CompanyID select c;
            deletedApplicant.First().IsAccepted = false;
            var deletedDate = from c in db.DateInterviews where c.ApplicantID == uCApplicants.applicantInfo.ApplicantID && c.CompanyID == Constant.CompanyID select c;
            if(deletedDate.Any())
            {
                db.DateInterviews.Remove(deletedDate.First());
            }    
            db.SaveChanges();
        }
        public void HuyYeuThich(Applicant applicant)
        {
            var entity = from a in db.ApplicantsOfCompanies where a.ApplicantID == applicant.ApplicantID && a.CompanyID == Constant.CompanyID select a;
            entity.SingleOrDefault().IsFavorite = false;
            db.SaveChanges();
        }
        public void Xoa(Applicant applicant)
        {
            var applicant1 = db.Applicants.Find(applicant.ApplicantID);
            if (applicant1 != null)
            {
                db.Applicants.Remove(applicant1);
                db.SaveChanges();
            }
        }
        public void XoaThongTinEducation(Education education, FProfileApplicant f1)
        {
            using (DoAnCuoiKyEntities db = new DoAnCuoiKyEntities())
            {
                var result = db.Educations.Find(education.EducationID);
                if (result != null)
                {
                    db.Educations.Remove(result);
                }
                db.SaveChanges();
            }
            LoadThongTinEducation(f1);
        }
        public void XoaThongTinSkill(Skill skill, FProfileApplicant f1)
        {
            using (DoAnCuoiKyEntities db = new DoAnCuoiKyEntities())
            {
                var result = from c in db.ApplicantSkills where c.SkillID == skill.SkillID && c.ApplicantID == f1.applicantInfo.ApplicantID select c;
                // điều kiện phải bằng skill ID  vì sẽ có skill ID giống nhau nhưng khác ApplicantID
                result.ToList();
                foreach (var skill3 in result)
                {
                    db.ApplicantSkills.Remove(skill3);
                }
                var result2 = db.Skills.Find(skill.SkillID);
                if (result2 != null)
                {
                    db.Skills.Remove(result2);
                }
                db.SaveChanges();
            }
            LoadThongTinSkill(f1);
        }
        public void XoaThongTinWorkExp(WorkExperience workExperience, FProfileApplicant f1)
        {
            using (DoAnCuoiKyEntities db = new DoAnCuoiKyEntities())
            {
                db.WorkExperiences.Remove(db.WorkExperiences.Find(workExperience.WorkExperienceID));
                db.SaveChanges();
            }
            LoadThongTinWorkExp(f1);
        }
        #endregion

        #region Hàm Search
        public void SearchFavApplicant(FFavoriteApplicants f)
        {
            DoAnCuoiKyEntities db = new DoAnCuoiKyEntities();
            var result = from c in db.ApplicantsOfCompanies
                         where c.CompanyID == Constant.CompanyID && c.IsFavorite == true
                         select c.ApplicantID into query
                         from b in db.Applicants
                         where b.ApplicantID == query
                         select b;
            var result2 = from c in result where c.ApplicantTitle.Contains(f.txtJobName.Text) && c.ApplicantNationality.Contains(f.cbxLocation.SelectedItem.ToString()) select c;

            var applicantFilter = result2.ToList();
            f.pnlFavApplicants.Controls.Clear();
            LoadDanhSachUngVienYeuThich(f, applicantFilter);
        }
        public void SearchInvitedApp(FInvitedApplicant f)
        {
            DoAnCuoiKyEntities db = new DoAnCuoiKyEntities();
            var result = from c in db.ApplicantsOfCompanies
                         where c.CompanyID == Constant.CompanyID && c.IsAccepted == true
                         select c.ApplicantID into query
                         from b in db.Applicants
                         where b.ApplicantID == query
                         select b;
            var result2 = from c in result where c.ApplicantTitle.Contains(f.txtJobName.Text) && c.ApplicantNationality.Contains(f.cbxLocation.SelectedItem.ToString()) select c;

            var applicantFilter = result2.ToList();
            f.pnlPotentialApplicant.Controls.Clear();
            LoadDanhSachUngVienTiemNang(f, applicantFilter);
        }
        #endregion
    }


}

