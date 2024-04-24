using DoAnCuoiKy.ApplicantForm;
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
    public partial class UCApplicantEducation : UserControl
    {
        public FProfileApplicant fprofile;
        public Education education;
        public UCApplicantEducation()
        {
            InitializeComponent();
        }
        public UCApplicantEducation(Education education, FProfileApplicant f1)
        {
            InitializeComponent();
            this.education = education;
            this.fprofile = f1;
            loadUC();
        }
        public void loadUC() 
        {
            this.lblSchool.Text = education.School;
            this.lblMajor.Text = education.Major;
            this.lblDetails.Text = education.AddDetails;
            this.lblFromToDate.Text = education.FromMonth + "/" + education.FromYear + "-" + education.ToMonth + "/" + education.ToYear; 
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            FAddEducation f1 = new FAddEducation(education,this.fprofile);
            f1.Show();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            ApplicantsDAO applicantsDAO = new ApplicantsDAO();
            applicantsDAO.XoaThongTinEducation(this.education,this.fprofile);
        }
    }
}
