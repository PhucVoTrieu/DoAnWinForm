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

namespace DoAnCuoiKy
{
    public partial class UCJobUI : UserControl
    {
        JobDetails jobDetails;
        SqlConnection connStr = new SqlConnection(DoAnCuoiKy.Properties.Settings.Default.connStr);
        DBconnection db = new DBconnection();
        //JobDetailsDAO jobDetailsDAO = new JobDetailsDAO();
        public UCJobUI()
        {
            InitializeComponent();
        }
        public UCJobUI(JobDetails j1)
        {
            InitializeComponent();
            this.jobDetails = j1;

            this.lblJobTitle.Text = j1.JobTitle;
            this.lblJobPosition.Text = j1.JobPosition;
            this.txtJobtype.Text = j1.JobType;
            this.lblSalary.Text = j1.JobSalary;
            this.lblLocation.Text = j1.Location;
            this.txtExpYear.Text = j1.ExpInYears;
            
        }
        

        private void btnDetails_Click_1(object sender, EventArgs e)
        {
            FJobDetails f1 = new FJobDetails(this.jobDetails);
            f1.Show();
        }

        private void btnApplyNow_Click(object sender, EventArgs e)
        {

        }

        private void btnFavorite_Click(object sender, EventArgs e)
        {
            string SQL = string.Format("INSERT INTO FavoriteJob (JobTitle,JobPosition,JobType,JobSalary,RecruitmentQuota,Location,ExpInYears,JobDescription) VALUES ('{0}', '{1}' , '{2}','{3}','{4}','{5}','{6}','{7}')",
               this.jobDetails.JobTitle, this.jobDetails.JobPosition, this.jobDetails.JobType,
               this.jobDetails.JobSalary, this.jobDetails.RecruitmentQuota, this.jobDetails.Location, this.jobDetails.ExpInYears,
               this.jobDetails.JobDescription);
            db.thucthi(SQL);
        }
    }
}
