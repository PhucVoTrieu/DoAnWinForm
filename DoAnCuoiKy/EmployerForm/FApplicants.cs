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
        public Company companyInfo;
        public FApplicants(Company e1)
        {
            InitializeComponent();
            this.companyInfo = e1;
            applicantsDAO.LoadDanhSachUngVien(this);
            applicantsDAO.LoadDanhSachNgayPhongVan(this);
        }
        //private void btnDelete_Click(object sender, EventArgs e)
        //{
        //    List<UCApplicants> list = new List<UCApplicants>();
        //    foreach (Control c in pnlDeveLoperApplicant.Controls)
        //    {
        //        if (c.GetType() == typeof(UCApplicants))
        //        {
        //            UCApplicants A = (UCApplicants)(c);

        //            if (A.CBoxSelected.Checked)
        //            {
        //                list.Add(A);
        //            }
        //        }
        //    }
        //    if (list.Count > 0) 
        //    {
        //        foreach (UCApplicants c in list)
        //        {
        //            this.pnlDeveLoperApplicant.Controls.Remove(c);
        //            applicantsDAO.XoaUC(c);
        //        }
        //    }
           
        //    List<UCApplicants> list2 = new List<UCApplicants>();
        //    foreach (Control c in pnlDesignerApplicant.Controls)
        //    {
        //        if (c.GetType() == typeof(UCApplicants))
        //        {
        //            UCApplicants A = (UCApplicants)(c);

        //            if (A.CBoxSelected.Checked)
        //            {
        //                list2.Add(A);
        //            }
        //        }
        //    }
        //    if (list2.Count > 0)
        //    {
        //        foreach (UCApplicants c in list2)
        //        {
        //            this.pnlDesignerApplicant.Controls.Remove(c);
        //            applicantsDAO.XoaUC(c);
        //        }
        //    }
        //}
    }

}

