using DoAnCuoiKy.Class;
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

namespace DoAnCuoiKy
{
    public partial class FJobs : Form
    {
        SqlConnection connStr = new SqlConnection(DoAnCuoiKy.Properties.Settings.Default.connStr);
        JobsDAO jobDetailsDAO = new JobsDAO();
        Company employerInfor;
        public FJobs(Company e1)
        {
            InitializeComponent();
            this.employerInfor = e1;
            LoadDanhSach();
         //   this.btnCountCreatedJob.Text = CountCreatedJob().ToString();
        }
        public void LoadDanhSach()
        {

            try
            {
                DoAnCuoiKyEntities db = new DoAnCuoiKyEntities();
                this.pnlCreatedJob.Controls.Clear();
                var jobsOfCompany = from c in db.Jobs where c.CompanyID == Constant.CompanyID select c;

                foreach (var job in jobsOfCompany)
                {
                    UCJobUI uCJob = new UCJobUI(job);
                   uCJob.btnApplyNow.Visible = false;
                    this.pnlCreatedJob.Controls.Add(uCJob);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Lỗi truy vấn: " + ex.Message);
            }

        }
        public int CountCreatedJob()
        {
            int count = 0;
            foreach (Control c in pnlCreatedJob.Controls)
            {
                if (c.GetType() == typeof(DoAnCuoiKy.UCJobUI))
                {
                    ++count;
                }
            }
            return count;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            List<UCJobUI> list = new List<UCJobUI>();
            foreach (Control c in pnlCreatedJob.Controls)
            {
                if (c.GetType() == typeof(UCJobUI))
                {
                    UCJobUI A = (UCJobUI)(c);

                    if (A.CBoxSelected.Checked)
                    {
                        list.Add(A);

                    }
                }

            }
            foreach (UCJobUI c in list)
            {
                this.pnlCreatedJob.Controls.Remove(c);
                //this.btnCountCreatedJob.Text = CountCreatedJob().ToString();
                jobDetailsDAO.xoaUC(c);
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            DoAnCuoiKyEntities db = new DoAnCuoiKyEntities();
            var result = from c in db.Jobs 
                         where c.JobTitle.Contains(this.txtJobName.Text) && c.Location.Contains(this.cbxLocation.SelectedItem.ToString()) && c.CompanyID == Constant.CompanyID select c;
            int expInYearsAsInt;
            List<Job> resultList = new List<Job>();
            List<Job> jobFilter = new List<Job>();
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
                    if (expInYearsAsInt > 5 && expInYearsAsInt <= 10)
                    {
                        resultList.Add(job);
                    }
                }
                jobFilter = resultList;
            }
            if (jobFilter != resultList)
                jobFilter = result.ToList();
            //int val = trackbarSalary.Value;
            //List<Job> salaryFilter = new List<Job>();
            //foreach(var c in jobFilter)
            //{
            //    if(int.Parse(c.JobSalary) < val)
            //    { salaryFilter.Add(c); }
            //}   
            this.pnlCreatedJob.Controls.Clear();
            jobDetailsDAO.LoadDanhSach3(this, jobFilter);
        }

        //private void btnDelete_Click_1(object sender, EventArgs e)
        //{
        //    JobsDAO jobsDAO = new JobsDAO();
        //    foreach ( UCJobUI uCJobUI in pnlCreatedJob.Controls)
        //    {
        //        if (uCJobUI.CBoxSelected.Checked)
        //        {
        //            jobsDAO.XoaJob(uCJobUI.job);
        //        }
        //    }
        //    LoadDanhSach();
        //}
    }
}
