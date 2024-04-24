using DoAnCuoiKy.ApplicantForm;
using DoAnCuoiKy.Class;
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
        ApplicantsDAO applicantsDAO = new ApplicantsDAO();
        public FProfileApplicant()
        {
            InitializeComponent();
            LoadDanhSach();
        }
        public FProfileApplicant(Applicant applicant)
        {
            InitializeComponent();
            LoadDanhSach();
        }
        public void LoadDanhSach()
        {
           DoAnCuoiKyEntities db = new DoAnCuoiKyEntities();
            var query = from applicant in db.Applicants where Constant.ApplicantID == applicant.ApplicantID select applicant;

            this.lblEmail.Text = query.Single().ApplicantEmail;
            this.lblAddress.Text = query.Single().ApplicantAddress;
            DateTime a = (DateTime)query.Single().ApplicantDOB;
            this.lblDOB.Text = a.ToString("dd/MM/yyyy");
            this.lblPhoneNum.Text = query.Single().ApplicantPhonenumber;
            this.lblYourName.Text = query.Single().ApplicantName;
            this.lblYourTitle.Text = query.Single().ApplicantTitle;
            this.lblGender.Text = query.Single().ApplicantGender;
            this.lblPersonalPink.Text = query.Single().ApplicantPersonalLink;

            applicantsDAO.LoadThongTinAboutMe(this);
            applicantsDAO.LoadThongTinWorkExp(this);
        }
        private void btnEdit_Click(object sender, EventArgs e)
        {
            foreach (Control c in pnlAboutMe.Controls)  // pnlBasicinfo.controls not this.controls boi vi this.controls la form va cac txtbox ko nam trong form maf trong panel
            {
                if(c.GetType()==typeof(Guna.UI2.WinForms.Guna2TextBox))
                {
                    c.Enabled = true;
                }
            }
        }
        
    

        private void btnSave_Click(object sender, EventArgs e)
        {
            foreach (Control c in pnlAboutMe.Controls)  // pnlBasicinfo.controls not this.controls boi vi this.controls la form va cac txtbox ko nam trong form maf trong panel
            {
                if (c.GetType() == typeof(Guna.UI2.WinForms.Guna2TextBox))
                {
                    c.Enabled = false;
                }
            }
        }
        private void btnAddAboutMe_Click(object sender, EventArgs e)
        {

        }

        private void btnEditBasicInfo_Click(object sender, EventArgs e)
        {
            FPersonalDetais f1 = new FPersonalDetais();
            f1.Show();
        }

        private void lblPersonalPink_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(this.lblPersonalPink.Text);
        }

        private void btnAddAboutMe_Click_1(object sender, EventArgs e)
        {
            FAboutMe f1 = new FAboutMe(this);
            f1.ShowDialog();
            applicantsDAO.LoadThongTinAboutMe(this);
        }

        private void btnaAddWorkExp_Click(object sender, EventArgs e)
        {
            FWorkExperience f1 = new FWorkExperience(null,this);
            f1.Show();
          //  applicantsDAO.LoadThongTinWorkExp(this);
        }

        private void pnlMain_MouseEnter(object sender, EventArgs e)
        {
            this.pnlMain.Focus();
        }
    }
}
