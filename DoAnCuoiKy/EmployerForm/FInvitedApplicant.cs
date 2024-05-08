using DoAnCuoiKy.Class;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DoAnCuoiKy.EmployerForm
{
  
    public partial class FInvitedApplicant : Form
    {
        ApplicantsDAO applicantsDAO = new ApplicantsDAO();
        public Company e1;
        public FInvitedApplicant(Company company)
        {
            this.e1 = company;
            InitializeComponent();
            applicantsDAO.LoadDanhSachUngVienTiemNang(this);
            this.btnCountFavApplicants.Text = CountFavoriteApplicants().ToString();
        }
        private void btnDelete_Click(object sender, EventArgs e)
        {
            List<UCApplicants> list = new List<UCApplicants>();
            foreach (Control c in pnlPotentialApplicant.Controls)
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
            if (list.Count() > 0)
            {
                foreach (UCApplicants c in list)
                {
                    this.pnlPotentialApplicant.Controls.Remove(c);
                    this.btnCountFavApplicants.Text = CountFavoriteApplicants().ToString();
                    applicantsDAO.XoaUC3(c);
                }
            }
            else MessageBox.Show("không thể xóa");

        }
        public int CountFavoriteApplicants()
        {
            int count = 0;
            foreach (Control c in pnlPotentialApplicant.Controls)
            {
                if (c.GetType() == typeof(DoAnCuoiKy.UCApplicants))
                {
                    ++count;
                }
            }
            return count;
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            applicantsDAO.SearchInvitedApp(this);
            this.btnCountFavApplicants.Text = CountFavoriteApplicants().ToString();
        }
    }
}
