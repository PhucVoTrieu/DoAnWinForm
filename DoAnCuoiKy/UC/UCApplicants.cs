using DoAnCuoiKy.Class;
using DoAnCuoiKy.UC;
using Guna.UI2.WinForms;
using System;
using System.CodeDom;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DoAnCuoiKy
{
    public partial class UCApplicants : UserControl
    {
        public Applicant applicantInfo;
        public FApplicants fApplicants;
        ApplicantsDAO applicantsDAO = new ApplicantsDAO();
        JobsDAO jobsDAO = new JobsDAO();
        public UCApplicants()
        {
            InitializeComponent();
        }
        public UCApplicants(Applicant applicant)
        {
            InitializeComponent();
            this.applicantInfo = applicant;
            this.lblCandidateName.Text = applicant.ApplicantName;
            this.lblCandidateApplyPos.Text = applicant.ApplicantTitle;
            // 2 dòng skill này phải được add nếu không hàm khởi tạo UC sẽ bị lỗi và sẽ không tạo được UC khiến cho không có UC để add vào panel 
            // mỗi ứng viên có trên 2 skill mới load lên được 
            //this.txtSkill2.Text = applicant.ApplicantSkills.Skip(1).First().Skill.SkillName;
            //this.txtSkill.Text = applicant.ApplicantSkills.First().Skill.SkillName;
            if (applicant.ApplicantAvatar != null)
            {
                this.pBoxAvatar.Image = Image.FromFile(Path.Combine(Constant.appDirectory, applicant.ApplicantAvatar));
            }
        }
        public UCApplicants(Applicant applicant, FApplicants f1)
        {
            InitializeComponent();
            this.applicantInfo = applicant;
            this.lblCandidateName.Text = applicant.ApplicantName;
            this.lblCandidateApplyPos.Text = applicant.ApplicantTitle;
            //this.txtSkill2.Text = applicant.ApplicantSkills.Skip(1).First().Skill.SkillName;
            //this.txtSkill.Text = applicant.ApplicantSkills.First().Skill.SkillName;
            if (applicant.ApplicantAvatar != null)
            {
                this.pBoxAvatar.Image = Image.FromFile(Path.Combine(Constant.appDirectory, applicant.ApplicantAvatar));
            }
            this.fApplicants = f1;
        }
        private void btnCandidateDetails_Click_1(object sender, EventArgs e)
        {
            FProfileApplicant f1 = new FProfileApplicant();
            f1.Show();

        }
        private void btnFavorite_Click(object sender, EventArgs e)
        {
            if (this.btnFavorite.Checked)
            {
                applicantsDAO.YeuThich(this.applicantInfo);
            }
            else
            {
                applicantsDAO.HuyYeuThich(this.applicantInfo);
            }
        }

        private void btnApplicantDetails_Click(object sender, EventArgs e)
        {
            Form formBackground = new Form();
            try
            {
                using (FProfileApplicant applicant = new FProfileApplicant(this.applicantInfo))
                {
                    formBackground.StartPosition = FormStartPosition.Manual;
                    formBackground.FormBorderStyle = FormBorderStyle.None;
                    formBackground.Opacity = .50d;
                    formBackground.BackColor = Color.Black;
                    formBackground.WindowState = FormWindowState.Maximized;
                    formBackground.TopMost = false;
                    formBackground.Location = this.Location;
                    formBackground.ShowInTaskbar = false;
                    formBackground.Show();


                   
                    foreach (Control d in applicant.pnlListOfEducation.Controls)
                    {
                        if (d is UCApplicantEducation)
                        {
                            ((UCApplicantEducation)d).btnDelete.Hide();
                            ((UCApplicantEducation)d).btnEdit.Hide();
                        }
                    }
                    foreach (Control d in applicant.pnlListOfWorkExp.Controls)
                    {
                        if (d is UCApplicantWorkExp)
                        {
                            ((UCApplicantWorkExp)d).btnDelete.Hide();
                            ((UCApplicantWorkExp)d).btnEdit.Hide();
                        }
                    }
                    foreach (Control d in applicant.pnlListOfSkills.Controls)
                    {
                        if (d is UCApplicantSkill)
                        {
                            ((UCApplicantSkill)d).btnDelete.Hide();
                        }
                    }



                    applicant.btnaAddWorkExp.Hide();
                    applicant.btnAddEducation.Hide();
                    applicant.btnAddAboutMe.Hide();
                    applicant.btnAddSkill.Hide();

                    applicant.btnEditBasicInfo.BackColor = Color.Transparent;
                    applicant.btnEditBasicInfo.Location = new Point(-5000,-5000);
                    applicant.btnEditBasicInfo.Image = null;
                    applicant.Owner = formBackground;
                    applicant.ShowDialog();
                    formBackground.Dispose();

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
              formBackground.Dispose();

            } 
        }

        private void btnInviteCanidate_Click(object sender, EventArgs e)
        {
            applicantsDAO.Invite(this, fApplicants);
        }
    }
}
