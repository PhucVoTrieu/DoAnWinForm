using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;

namespace DoAnCuoiKy.ApplicantForm
{
    public partial class FeditBasicInfor : Form
    {
        public Applicant applicant1;
        public FProfileApplicant fProfile;
        public FeditBasicInfor()
        {
            InitializeComponent();
        }
        public  FeditBasicInfor(Applicant applicant , FProfileApplicant f1)
        {
            InitializeComponent();
            this.fProfile = f1;
            this.applicant1 = applicant;
            this.txtAddress.Text = applicant.ApplicantAddress;
            this.txtDOB.Text = applicant.ApplicantDOB.ToString();
            this.txtEmail.Text = applicant.ApplicantEmail;
            this.txtGender.Text = applicant.ApplicantGender;
            this.txtPersonalLink.Text = applicant.ApplicantPersonalLink;
            this.txtPhoneNumber.Text = applicant.ApplicantPhonenumber;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            ApplicantsDAO applicantsDAO = new ApplicantsDAO();
            this.applicant1.ApplicantAddress = this.txtAddress.Text;
            this.applicant1.ApplicantDOB = DateTime.Parse(this.txtDOB.Text);
            this.applicant1.ApplicantEmail = this.txtEmail.Text;
            this.applicant1.ApplicantGender = this.txtGender.Text;
            this.applicant1.ApplicantPersonalLink = this.txtPersonalLink.Text;
            this.applicant1.ApplicantPhonenumber = this.txtPhoneNumber.Text;
            applicantsDAO.suaThongTinBasicInfor(this);
            this.Close();
        }

        private void btnEditBasicInfo_Click(object sender, EventArgs e)
        {

        }
    }
}
