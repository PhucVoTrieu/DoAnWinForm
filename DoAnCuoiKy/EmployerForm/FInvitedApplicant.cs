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
            this.btnCountFavApplicants.Text = CountFavoriteApplicants().ToString();
            LoadDanhSach();
        }
        private void LoadDanhSach()
        {
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
            foreach (UCApplicants c in list)
            {
                this.pnlPotentialApplicant.Controls.Remove(c);
                this.btnCountFavApplicants.Text = CountFavoriteApplicants().ToString();
                applicantsDAO.xoaUC3(c);
            }

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
            DoAnCuoiKyEntities db = new DoAnCuoiKyEntities();
            var result = from c in db.ApplicantsOfCompanies
                         where c.CompanyID == Constant.CompanyID && c.IsAccepted == true
                         select c.ApplicantID into query
                         from b in db.Applicants
                         where b.ApplicantID == query
                         select b;
            var result2 = from c in result where c.ApplicantTitle.Contains(this.txtJobName.Text) && c.ApplicantNationality.Contains(this.cbxLocation.SelectedItem.ToString()) select c;

            var applicantFilter = result2.ToList();
            this.pnlPotentialApplicant.Controls.Clear();
            applicantsDAO.LoadDanhSachUngVienTiemNang(this, applicantFilter);
            this.btnCountFavApplicants.Text = CountFavoriteApplicants().ToString();
        }
    }
}
