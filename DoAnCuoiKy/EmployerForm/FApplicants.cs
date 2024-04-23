using DoAnCuoiKy.Class;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DoAnCuoiKy
{
    public partial class FApplicants : Form
    {
        ApplicantsDAO applicantsDAO = new ApplicantsDAO();
        SqlConnection connStr = new SqlConnection(DoAnCuoiKy.Properties.Settings.Default.connStr);
        Company companyInfo;
        public FApplicants(Company e1)
        {
            InitializeComponent();
            this.companyInfo = e1;
            applicantsDAO.LoadDanhSachUngVien(this);
        }
        private void btnDelete_Click(object sender, EventArgs e)
        {
            List<UCApplicants> list = new List<UCApplicants>();
            foreach (Control c in pnlAllCandidate.Controls)
            {
                if (c.GetType() == typeof(UCApplicants))
                {
                    UCApplicants A = (UCApplicants)(c);

                    if (A.CBoxSelected.Checked)
                    {
                        list.Add(A);
                    }
                }
            }
            foreach (UCApplicants c in list)
            {
                this.pnlAllCandidate.Controls.Remove(c);
                applicantsDAO.xoaUC(c);
            }
        }
    }

}

