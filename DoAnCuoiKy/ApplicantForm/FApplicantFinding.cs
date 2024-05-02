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
            int expInYearsAsInt;
            List<Job> resultList = new List<Job>();
            List < Job > jobFilter = new List<Job>();
            if (this.checkboxFullTime.Checked)
            {
                var fullTime = from c in result where c.JobType.Contains("Full") select c;
                if (this.checkboxPartTime.Checked)
                {
                    result = result.Union(fullTime);
                }
                else result = fullTime;
            }
            if (this.checkboxPartTime.Checked)
            {
                var partTime = from c in result where c.JobType.Contains("Part") select c;
                if (this.checkboxFullTime.Checked)
                {
                    result = result.Union(partTime);
                }
                else result = partTime;
            }
            if (this.checkboxLessThan3.Checked)
            {
                
                foreach (var job in result)
                {
                    expInYearsAsInt = int.Parse(job.ExpInYears);
                    if (expInYearsAsInt < 3)
                    {
                        resultList.Add(job);
                    }
                }
                jobFilter = resultList;

            }
            if (this.checkbox3To5.Checked)
            {
                foreach (var job in result)
                {
                    expInYearsAsInt = int.Parse(job.ExpInYears);
                    if (expInYearsAsInt >= 3 && expInYearsAsInt <= 5)
                    {
            
                        resultList.Add(job);
                    }
                }
                jobFilter = resultList;
            }
            if (this.checkbox5To10.Checked)
            {
                foreach (var job in result)
                {
                    expInYearsAsInt = int.Parse(job.ExpInYears);
                    if (expInYearsAsInt >5 && expInYearsAsInt <= 10)
                    {
                        resultList.Add(job);
                    }
                }
                jobFilter = resultList;
            }
            if(jobFilter != resultList)
             jobFilter = result.ToList();
            //int val = trackbarSalary.Value;
            //List<Job> salaryFilter = new List<Job>();
            //foreach(var c in jobFilter)
            //{
            //    if(int.Parse(c.JobSalary) < val)
            //    { salaryFilter.Add(c); }
            //}   
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

