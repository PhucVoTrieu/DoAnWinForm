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

namespace DoAnCuoiKy
{
    public partial class FJobDetails : Form
    {
        JobDetails jobDetails;
        public FJobDetails()
        {
            InitializeComponent();
        }
        public FJobDetails(JobDetails j1)
        {
            InitializeComponent();
            this.txtJobTitle.Text = j1.JobTitle.ToString();
            this.txtJobPosition.Text = j1.JobPosition.ToString();
            this.txtJobType.Text = j1.JobType.ToString();
            this.txtExperienceYears.Text = j1.ExpInYears;
            this.txtLocation.Text = j1.Location.ToString();
            this.txtRecruitmentQuota.Text= j1.RecruitmentQuota.ToString();
            this.txtSalary.Text = j1.JobSalary.ToString();
            this.txtJobDescription.Text = j1.JobDescription.ToString();

            this.jobDetails = j1;
            
        }

        private void btnApply_Click(object sender, EventArgs e)
        {
            FProfileApplicant f1 = new FProfileApplicant();f1.Show();
        }
    }
}
