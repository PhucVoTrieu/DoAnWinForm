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
    public partial class FWorkExperience : Form
    {
        public FProfileApplicant fProfile;
        public WorkExperience WorkExperience;
        public FWorkExperience()
        {
            InitializeComponent();
        }
        public FWorkExperience(WorkExperience workExperienceDetail, FProfileApplicant f1)
        {
            InitializeComponent();
            if(workExperienceDetail != null)
            {
                this.WorkExperience = workExperienceDetail;
                this.txtCompany.Text = workExperienceDetail.CompanyName;
                this.txtJobTitle.Text = workExperienceDetail.JobTitle;
                this.txtProjectAddDetails.Text = workExperienceDetail.ProjectDetails;
                this.txtWorkAddDetails.Text = workExperienceDetail.WorkDetails;
                this.cbWorkMonthFrom.Text = workExperienceDetail.FromMonth;
                this.cbWorkMonthTo.Text = workExperienceDetail.ToMonth;
                this.cbWorkYearFrom.Text = workExperienceDetail.FromYear;
                this.cbWorkYearTo.Text = workExperienceDetail.ToYear;
            }
           

            this.fProfile = f1;
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            ApplicantsDAO applicantsDAO = new ApplicantsDAO();
            applicantsDAO.SuaThongTinWorkExp(this);
            this.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
