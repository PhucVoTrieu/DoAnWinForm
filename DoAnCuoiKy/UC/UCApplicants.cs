using DoAnCuoiKy.Class;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
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
        public UCApplicants()
        {
            InitializeComponent();
        }
        public UCApplicants(Applicant applicant)
        {
            InitializeComponent();
            DoAnCuoiKyEntities db = new DoAnCuoiKyEntities();
            this.applicantInfo = applicant;
            this.lblCandidateName.Text = applicant.ApplicantName;
            this.txtExpYears.Text = applicant.ApplicantExpYears;
            this.lblCandidateApplyPos.Text = applicant.ApplicantTitle;
        }
        public UCApplicants(Applicant applicant, FApplicants f1)
        {
            InitializeComponent();
            DoAnCuoiKyEntities db = new DoAnCuoiKyEntities();
            this.applicantInfo = applicant;
            this.lblCandidateName.Text = applicant.ApplicantName;
            this.txtExpYears.Text = applicant.ApplicantExpYears;
            this.lblCandidateApplyPos.Text = applicant.ApplicantTitle;
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
            FProfileApplicant applicant = new FProfileApplicant(this.applicantInfo);
            applicant.btnaAddWorkExp.Hide();
            applicant.btnAddEducation.Hide();
            applicant.btnAddAboutMe.Hide();
            applicant.btnEditBasicInfo.Hide();
            applicant.btnAddSkill.Hide();
            applicant.Show();
        }

        private void btnInviteCanidate_Click(object sender, EventArgs e)
        {
            applicantsDAO.Invite(this);
        }
    }
}
