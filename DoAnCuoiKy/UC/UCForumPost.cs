using DoAnCuoiKy.ApplicantForm;
using DoAnCuoiKy.Class;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DoAnCuoiKy.UC
{
    public partial class UCForumPost : UserControl
    {
        public Post post;
        public JobSeekerForum jobSeekerForum;
        public UCForumPost()
        {
            InitializeComponent();
        }
        public UCForumPost(Post post,JobSeekerForum jobSeekerForum)
        {
            InitializeComponent();
            this.post = post;
            this.jobSeekerForum = jobSeekerForum;
            LoadInfor();
        }
        public void LoadInfor()
        {
            if (post != null)
            {
                this.lblContentOfPost.Text = this.post.PostContent;
                this.lblUserName.Text = this.post.Applicant.ApplicantName;
                this.pboxUserAvatar.Image = Image.FromFile(Path.Combine(Constant.appDirectory, post.Applicant.ApplicantAvatar));

            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            ApplicantsDAO applicantsDAO = new ApplicantsDAO();
            if(Constant.isApplicant)
            applicantsDAO.XoaBaiDang(this.post, this.jobSeekerForum);
            else if (Constant.isEmployer)
            {
                this.Hide();
            }
        }

        private void btnViewProfile_Click(object sender, EventArgs e)
        {
            Form formBackground = new Form();
            try
            {
                using (FProfileApplicant applicant = new FProfileApplicant(this.post.Applicant))
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
                    applicant.btnEditBasicInfo.Location = new Point(-5000, -5000);
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
    }
}
