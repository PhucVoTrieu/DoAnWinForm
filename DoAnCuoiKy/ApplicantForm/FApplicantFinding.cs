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
        private void btnViewProfile_Click(object sender, EventArgs e)
        {
            FProfileApplicant fProfile1 = new FProfileApplicant();
            fProfile1.Show();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            DoAnCuoiKyEntities db = new DoAnCuoiKyEntities();
            var result = from c in db.Jobs where c.JobTitle.Contains(this.txtJobName.Text) && c.Location.Contains(this.cbxLocation.SelectedItem.ToString()) select c;

            if (this.checkboxLessThan3.Checked)
            {
                var less3 = from c in result where Int32.Parse(c.ExpInYears) < 3 select c;
                result = less3;
            }
            if (this.checkbox3To5.Checked)
            {
                var threeToFive = from c in result where Int32.Parse(c.ExpInYears) >= 3 && Int32.Parse(c.ExpInYears) <= 5 select c;
                if (this.checkboxLessThan3.Checked)
                    result = result.Union(threeToFive);
                else result = threeToFive;
            }
            if (this.checkbox5To10.Checked)
            {
                var fiveToTen = from c in result where Int32.Parse(c.ExpInYears) > 5 && Int32.Parse(c.ExpInYears) <= 10 select c;
                if (this.checkbox3To5.Checked)
                    result = result.Union(fiveToTen);
                else result = fiveToTen;
            }
            if (this.checkboxFullTime.Checked)
            {
                var fullTime = from c in result where c.JobType.Contains("Full") select c;
                result=fullTime;
            }
            if(this.checkboxparttime.Checked)
            {
                var partTime = from c in result where c.JobType.Contains("Part") select c;
                if (this.checkboxFullTime.Checked)
                {
                    result = result.Union(partTime);
                }
                else result = partTime;
            }
            //int val = trackbarSalary.Value;
            //var salaryFilter = from c in result where Int32.Parse(c.JobSalary) <= val select c;
            //result = salaryFilter;
            var jobFilter = result.ToList();
            this.PnlRecommendJobs.Controls.Clear();
            jobDetailsDAO.LoadDanhSach2(this , jobFilter);
        }

        private void PnlRecommendJobs_MouseDown(object sender, MouseEventArgs e)
        {
            this.ScrollBar1.Focus();
        }

      

        private void PnlRecommendJobs_MouseEnter(object sender, EventArgs e)
        {
            this.PnlRecommendJobs.Focus();
        }

        private void txtJobName_TextChanged(object sender, EventArgs e)
        {

        }

        private void cbxLocation_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void FFindingCandidate_Load(object sender, EventArgs e)
        {

        }
    }
   }

