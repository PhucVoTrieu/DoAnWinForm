using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DoAnCuoiKy
{
    public partial class UCApplicants : UserControl
    {
        Candidate candidate;
        FavApplicantDAO favoriteApplicantDAO = new FavApplicantDAO();
        public UCApplicants()
        {
            InitializeComponent();
        }
        public UCApplicants(Candidate candidate1)
        {
            InitializeComponent();
            this.candidate = candidate1;

            this.lblCandidateName.Text = candidate1.Name;
            this.lblCandidateApplyPos.Text = candidate1.ApplyPosition;
            this.txtExpYears.Text = candidate1.ExpYears;
            this.txtSkill.Text = candidate1.Skill;
           

            
        }
        private void btnCandidateDetails_Click_1(object sender, EventArgs e)
        {
            FProfileApplicant f1 = new FProfileApplicant(this.candidate);
            f1.Show();

        }

      

        private void btnFavorite_CheckedChanged(object sender, EventArgs e)
        {
            if (this.btnFavorite.Checked)
            {
                favoriteApplicantDAO.them(this.candidate);
            }
            else
            {
                favoriteApplicantDAO.xoa(this.candidate);
            }

        }
    }
}
