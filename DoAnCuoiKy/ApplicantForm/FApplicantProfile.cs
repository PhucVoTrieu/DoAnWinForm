using DoAnCuoiKy.ApplicantForm;
using DoAnCuoiKy.Class;
using DoAnCuoiKy.UC;
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
        public Applicant applicantInfo;
        public FProfileApplicant()
        {
            InitializeComponent();
            DoAnCuoiKyEntities db = new DoAnCuoiKyEntities();
            var query = from a in db.Applicants where Constant.ApplicantID == a.ApplicantID select a;   
            this.applicantInfo = query.FirstOrDefault();
            LoadDanhSach();
        }
        public FProfileApplicant(Applicant applicant)
        {
            this.applicantInfo = applicant;
            InitializeComponent();
            LoadDanhSach();
        }
        public void LoadDanhSach()
        {
            applicantsDAO.LoadThongTinBasicInforlenForm(this);
            applicantsDAO.LoadThongTinAboutMe(this);
            applicantsDAO.LoadThongTinWorkExp(this);
            applicantsDAO.LoadThongTinEducation(this);
            applicantsDAO.LoadThongTinSkill(this);
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


        private void btnAddEducation_Click(object sender, EventArgs e)
        {
            FAddEducation f1 = new FAddEducation(null,this);
            f1.Show();
        }

        private void btnAddSkill_Click(object sender, EventArgs e)
        {
            FAddSkill f1 = new FAddSkill(this);
            f1.Show();
            applicantsDAO.LoadThongTinSkill(this);
        }

        private void btnEditBasicInfo_Click(object sender, EventArgs e)
        {
            DoAnCuoiKyEntities db = new DoAnCuoiKyEntities();
            var result = from c in db.Applicants where c.ApplicantID == Constant.ApplicantID select c;
            FeditBasicInfor f1 = new FeditBasicInfor( result.First() ,this);
            f1.Show();
        }
    }
}
