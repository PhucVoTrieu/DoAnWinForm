using Guna.UI2.WinForms;
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
    public partial class FProfileApplicant : Form
    {
        CandidateDAO candidateDAO = new CandidateDAO();
        public FProfileApplicant()
        {
            InitializeComponent(); 
        }

        private void button9_Click(object sender, EventArgs e)
        {
            Candidate candidate = new Candidate(txtID.Text, txtName.Text
               , txtGender.Text, txtNationality.Text, txtAddress.Text
               , txtDOB.Text, txtExpYears.Text, txtEmail.Text,txtPhone.Text,txtDescribe.Text);
            candidateDAO.them(candidate);
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            foreach (Control c in pnlBasicInfo.Controls)  // pnlBasicinfo.controls not this.controls boi vi this.controls la form va cac txtbox ko nam trong form maf trong panel
            {
                if(c.GetType()==typeof(Guna.UI2.WinForms.Guna2TextBox))
                {
                    c.Enabled = true;
                }
            }
        }

        private void btnApplyNow_Click(object sender, EventArgs e)
        {
            foreach (Control c in pnlBasicInfo.Controls)  // pnlBasicinfo.controls not this.controls boi vi this.controls la form va cac txtbox ko nam trong form maf trong panel
            {
                if (c.GetType() == typeof(Guna.UI2.WinForms.Guna2TextBox))
                {
                    c.Enabled = false;
                }
            }
        }
    }
}
