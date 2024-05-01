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
            //this.lblCandidateApplyPos.Text = applicant.appli;
            this.txtExpYears.Text = applicant.ApplicantExpYears;
            //this.txtSkill.Text = applicant.appli;
            this.lblCandidateApplyPos.Text = applicant.ApplicantTitle;


        }
        private void btnCandidateDetails_Click_1(object sender, EventArgs e)
        {
            //FProfileApplicant f1 = new FProfileApplicant(this.candidate);
            FProfileApplicant f1 = new FProfileApplicant();
            f1.Show();

        }

      

        private void btnFavorite_CheckedChanged(object sender, EventArgs e)
        {
            

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
    }
}
