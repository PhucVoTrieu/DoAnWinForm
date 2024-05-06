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
    public partial class FFavoriteApplicants : Form
    {
        ApplicantsDAO applicantsDAO = new ApplicantsDAO();
        public Company employerInfor;
        public FFavoriteApplicants(Company e1)
        {
            InitializeComponent();
            this.employerInfor = e1;
            applicantsDAO.LoadDanhSachUngVienYeuThich(this);
            this.btnCountFavApplicants.Text = CountFavoriteApplicants().ToString();
        }
        public int CountFavoriteApplicants()
        {
            int count = 0;
            foreach (Control c in pnlFavApplicants.Controls)
            {
                if (c.GetType() == typeof(DoAnCuoiKy.UCApplicants))
                {
                    ++count;
                }
            }
            return count;
        }
       
       
        private void btnDelete_Click_1(object sender, EventArgs e)
        {
            List<UCApplicants> list = new List<UCApplicants>();
            foreach (Control c in pnlFavApplicants.Controls)
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
                this.pnlFavApplicants.Controls.Remove(c);
                this.btnCountFavApplicants.Text = CountFavoriteApplicants().ToString();
                applicantsDAO.xoaUC2(c);
            }

        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            applicantsDAO.searchFavApplicant(this);
            this.btnCountFavApplicants.Text = CountFavoriteApplicants().ToString();
        }
    }
}
