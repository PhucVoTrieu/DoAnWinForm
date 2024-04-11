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
        ApplicantsDAO candidateDAO = new ApplicantsDAO();
        public FProfileApplicant()
        {
            InitializeComponent(); 
        }
        public FProfileApplicant(Candidate candidate)
        {
            InitializeComponent();
            this.txtID.Text = candidate.ID;
            this.txtExpYears.Text = candidate.ExpYears;
            this.txtName.Text = candidate.Name;
            this.txtNationality.Text = candidate.Nationality;
            this.txtPhone.Text = candidate.Phone;
            this.txtAddress.Text = candidate.Address;
            this.txtDOB.Text = candidate.DOB;
            this.txtEmail.Text = candidate.Email;
            this.txtGender.Text = candidate.Gender;
            this.txtApplyPos.Text = candidate.ApplyPosition;
            this.txtSkill.Text = candidate.Skill;
            this.txtDescribe.Text = candidate.Describe;
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
        
        private void btnApply_Click(object sender, EventArgs e)
        {
            Candidate candidate = new Candidate(txtID.Text, txtName.Text
              , txtGender.Text, txtNationality.Text, txtAddress.Text
              , txtDOB.Text, txtExpYears.Text, txtEmail.Text, txtPhone.Text, txtDescribe.Text, txtApplyPos.Text, txtSkill.Text);
            candidateDAO.them(candidate);
        }

        private void btnSave_Click(object sender, EventArgs e)
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
