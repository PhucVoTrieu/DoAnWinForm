using Guna.UI2.WinForms.Suite;
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
using System.Collections;

namespace DoAnCuoiKy
{
    public partial class FFindingCandidate : Form
    {
        SqlConnection connStr = new SqlConnection(DoAnCuoiKy.Properties.Settings.Default.connStr);
        JobDetailsDAO jobDetailsDAO = new JobDetailsDAO();
        public FFindingCandidate()
        {
            InitializeComponent();
            jobDetailsDAO.LoadDanhSach(this);

        }
        private void btnViewProfile_Click(object sender, EventArgs e)
        {
            FProfileApplicant fProfile1 = new FProfileApplicant();
            fProfile1.Show();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            List<JobDetails> list = new List<JobDetails>();
            this.PnlRecommendJobs.Controls.Clear();
            string selectedLocation = this.txtLocation.Text;
            jobDetailsDAO.laydulieuCoDieuKien(list, selectedLocation);
            foreach (JobDetails jobDetail in list)
            {
                UCJobUI uCJob = new UCJobUI(jobDetail);
                uCJob.CBoxSelected.Hide();
                this.PnlRecommendJobs.Controls.Add(uCJob);
            }
        }
      
    }
   }

