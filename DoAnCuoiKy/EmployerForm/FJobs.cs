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
            jobDetailsDAO.LoadDanhSach4(this);
            this.btnCountCreatedJobs.Text = CountCreatedJob().ToString();
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
                jobDetailsDAO.xoaUC(c);
                this.btnCountCreatedJobs.Text = CountCreatedJob().ToString();
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            jobDetailsDAO.searchCreatedJobs(this);
            this.btnCountCreatedJobs.Text = CountCreatedJob().ToString();
        }
    }
}
