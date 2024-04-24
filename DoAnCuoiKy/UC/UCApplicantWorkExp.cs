using DoAnCuoiKy.ApplicantForm;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Hosting;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace DoAnCuoiKy.UC
{
    public partial class UCApplicantWorkExp : UserControl
    {
        public WorkExperience workExperienceDetail;
        public FProfileApplicant fProfile;
        public UCApplicantWorkExp()
        {
            InitializeComponent();
        }
        public UCApplicantWorkExp(WorkExperience workExperienceDetail, FProfileApplicant f1)
        {
            InitializeComponent();
            this.workExperienceDetail = workExperienceDetail;
            this.fProfile = f1;
            LoadUC();
        }
        public void LoadUC()
        {
            this.lblCompanyName.Text = workExperienceDetail.CompanyName;
            this.lblFromToDate.Text = workExperienceDetail.FromMonth+"/"+workExperienceDetail.FromYear+"-"+workExperienceDetail.ToMonth+"/"+workExperienceDetail.ToYear; 
            this.lblJobDescription.Text = workExperienceDetail.WorkDetails;
            this.lblJobtitle.Text = workExperienceDetail.JobTitle;
            this.lblProjectName.Text = workExperienceDetail.ProjectDetails;
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
                //FWorkExperience f1 = new FWorkExperience(new FProfileApplicant());
            //f1.txtCompany.Text = workExperienceDetail.CompanyName;
            //f1.txtJobTitle.Text = workExperienceDetail.JobTitle;
            //f1.txtProjectAddDetails.Text = workExperienceDetail.ProjectDetails;
            //f1.txtWorkAddDetails.Text = workExperienceDetail.WorkDetails;
            //f1.cbWorkMonthFrom.Text = workExperienceDetail.FromMonth;
            //f1.cbWorkMonthTo.Text = workExperienceDetail.ToMonth;
            //f1.cbWorkYearFrom.Text = workExperienceDetail.FromYear;
            //f1.cbWorkYearTo.Text = workExperienceDetail.ToYear;
            //ApplicantsDAO applicantsDAO = new ApplicantsDAO();
            //applicantsDAO.SuaThongTinWorkExp(f1);
            FWorkExperience f1 = new FWorkExperience(workExperienceDetail,this.fProfile);
            f1.Show();
           
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            ApplicantsDAO applicantsDAO = new ApplicantsDAO();
            applicantsDAO.XoaThongTinWorkExp(this.workExperienceDetail,this.fProfile);
        }
    }
}
