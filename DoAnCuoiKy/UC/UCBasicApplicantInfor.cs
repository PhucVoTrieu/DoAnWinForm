using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DoAnCuoiKy.UC
{
    public partial class UCBasicApplicantInfor : UserControl
    {
        Applicant applicant1;
        public UCBasicApplicantInfor()
        {
            InitializeComponent();
        }
        public UCBasicApplicantInfor(Applicant applicant)
        {
            this.applicant1 = applicant;
            this.txtEmail.Text = applicant1.ApplicantEmail;
            this.txtAddress.Text = applicant1.ApplicantAddress;
            this.txtDOB.Text = applicant1.ApplicantDOB.ToString();
            this.txtPhoneNumber.Text = applicant1.ApplicantPhonenumber;
            this.txtPersonalLink.Text = applicant1.ApplicantPersonalLink;
            this.txtGender.Text = applicant1.ApplicantGender;

        }
        private void btnCancel_Click(object sender, EventArgs e)
        {

        }
    }
}
