using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DoAnCuoiKy.ApplicantForm
{
    public partial class FAddEducation : Form
    {
        public FProfileApplicant fProfile;
        public Education Education;
        public FAddEducation()
        {
            InitializeComponent();
        }
        public FAddEducation(Education education, FProfileApplicant f1)
        {
            InitializeComponent();
            if (education != null)
            {
                this.Education = education;
                this.txtSchoolApplicant.Text = education.School;
                this.txtMajorApplicant.Text = education.Major;
                this.txtEducationAdd.Text = education.AddDetails;
                this.cbEducationMonthFrom.Text = education.FromMonth;
                this.cbEducationMonthTo.Text = education.ToMonth;
                this.cbEducationYearFrom.Text = education.FromYear;
                this.cbEducationYearTo.Text = education.ToYear;
            }
            this.fProfile = f1;

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            ApplicantsDAO applicantsDAO = new ApplicantsDAO();
            applicantsDAO.SuaThongTinEducation(this);
            this.Close();
        }
    }
}
