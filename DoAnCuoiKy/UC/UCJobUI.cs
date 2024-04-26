using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static Guna.UI2.WinForms.Helpers.GraphicsHelper;
using System.Windows.Forms.DataVisualization.Charting;
using System.Runtime.CompilerServices;
using DoAnCuoiKy.Class;

namespace DoAnCuoiKy
{
    public partial class UCJobUI : UserControl
    {
        public Job job;
        SqlConnection connStr = new SqlConnection(DoAnCuoiKy.Properties.Settings.Default.connStr);
        DoAnCuoiKyEntities db = new DoAnCuoiKyEntities();

        public UCJobUI()
        {
            InitializeComponent();
        }
        public UCJobUI(Job j1)
        {
            InitializeComponent();
            this.job = j1;
            this.lblJobTitle.Text = j1.JobTitle;
            this.txtJobtype.Text = j1.JobType;
            this.lblSalary.Text = j1.JobSalary;
            this.lblLocation.Text = j1.Location;
            this.txtExpYear.Text = j1.ExpInYears;

        }
        //private void btnDetails_Click_1(object sender, EventArgs e)
        //{
        //    FJobDetails f1 = new FJobDetails(this.jobDetails);

        //    f1.ShowDialog();
        //}
        private void btnDetails_Click(object sender, EventArgs e)
        {
            FJobDetails f1 = new FJobDetails(this.job);
            f1.ShowDialog();
        }
        private void btnApplyNow_Click(object sender, EventArgs e)
        {

        }
        private void btnFavorite_CheckedChanged(object sender, EventArgs e)
        {
            if(this.btnFavorite.Checked)
            {
              //  favoriteJobDAO.them(this.job);
            }
            else
            {
               // favoriteJobDAO.xoa(this.job);
            }

            
        }

        private void btnFavorite_Click(object sender, EventArgs e)
        {
            
        }

        private void btnApplyNow_Click_1(object sender, EventArgs e)
        {
            this.btnApplyNow.Enabled= false;
            this.btnApplyNow.Text = "Applied";
            CompanyDAO companyDAO = new CompanyDAO();
            companyDAO.ThemApplicant(Constant.ApplicantID, (int)this.job.CompanyID);

        }

        private void btnFavorite_Click_1(object sender, EventArgs e)
        {
            JobsDAO jobsDAO = new JobsDAO();
            if (this.btnFavorite.Checked)
            {
                jobsDAO.YeuThich(this.job);
            }
            else
            {
                //jobsDAO.HuyYeuThich(this.job);
            }
        }
    }
}
