using DoAnCuoiKy.UC;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DoAnCuoiKy.ApplicantForm
{
    public partial class FNotification : Form
    {
        public Applicant applicant;
        CompanyDAO companyDAO = new CompanyDAO();
        JobsDAO jobsDAO = new JobsDAO();
        public FNotification(Applicant a)
        {
            InitializeComponent();
            this.applicant = a;
            companyDAO.LoadThongBaoPhongVan(this.applicant , this);
            btnCountNote.Text = CountNotification().ToString();
        }
        public int CountNotification()
        {
            int count = 0;
            foreach (Control c in pnlNote.Controls)
            {
                if (c.GetType() == typeof(DoAnCuoiKy.UCNote))
                {
                    ++count;
                }
            }
            return count;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            List<UCNote> list = new List<UCNote>();
            foreach (Control c in pnlNote.Controls)
            {
                if (c.GetType() == typeof(UCNote))
                {
                    UCNote A = (UCNote)(c);

                    if (A.CBoxSelected.Checked)
                    {
                        list.Add(A);
                    }
                }

            }
            foreach (UCNote c in list)
            {
                this.pnlNote.Controls.Remove(c);
                this.btnCountNote.Text = CountNotification().ToString();
                jobsDAO.XoaUC2(c);
            }
        }
    }
}
