using Guna.UI2.WinForms.Suite;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static Guna.UI2.WinForms.Helpers.GraphicsHelper;
using System.Windows.Forms.DataVisualization.Charting;
using DoAnCuoiKy.Class;

namespace DoAnCuoiKy
{
    public partial class FJobDetails : Form
    {
        Job jobInfo;
        JobsDAO jobsDAO = new JobsDAO();
        CompanyDAO companyDAO = new CompanyDAO();
        public FJobDetails()
        {
            InitializeComponent();
        }
        public FJobDetails(Job j1 )
        {
            InitializeComponent();
            this.jobInfo = j1;
            jobsDAO.LoadJobDetail(j1,this);
        }
    
        private void btnCompanyName_Click(object sender, EventArgs e)
        {
            
        }

        private void btnApplyNow_Click(object sender, EventArgs e)
        {
            FProfileApplicant f1 = new FProfileApplicant();
            f1.Show();
        }

        private void btnViewCompany_Click(object sender, EventArgs e)
        {
            companyDAO.LoadInforJobOfCompany(this.jobInfo);
        }

        private void btnApplyNow_Click_1(object sender, EventArgs e)
        {
            CompanyDAO companyDAO = new CompanyDAO();
            companyDAO.ThemApplicant(Constant.ApplicantID,this.jobInfo);
        }
    }
}
