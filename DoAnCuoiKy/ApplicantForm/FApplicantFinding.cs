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
        JobsDAO jobDetailsDAO = new JobsDAO();
        public Applicant applicant;
        public FFindingCandidate()
        {
            InitializeComponent();
            jobDetailsDAO.LoadDanhSach(this);
        }
        public FFindingCandidate(Applicant applicant)
        {
            InitializeComponent();
            this.applicant = applicant;
            jobDetailsDAO.LoadDanhSach(this);


        }
        private void btnSearch_Click(object sender, EventArgs e)
        {
            jobDetailsDAO.searchJobs(this);
        }

        private void PnlRecommendJobs_MouseDown(object sender, MouseEventArgs e)
        {
            this.ScrollBar1.Focus();
        }
        private void PnlRecommendJobs_MouseEnter(object sender, EventArgs e)
        {
            this.PnlRecommendJobs.Focus();
        }

        
    }
   }

