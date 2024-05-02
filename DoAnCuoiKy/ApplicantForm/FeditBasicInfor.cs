using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;

namespace DoAnCuoiKy.ApplicantForm
{
    public partial class FeditBasicInfor : Form
    {
        ApplicantsDAO applicantsDAO = new ApplicantsDAO();
        string appDirectory = Directory.GetParent(Environment.CurrentDirectory).Parent.FullName;
        public Applicant applicant1;
        public FProfileApplicant fProfile;
        public FeditBasicInfor()
        {
            InitializeComponent();
        }
        public  FeditBasicInfor(Applicant applicant , FProfileApplicant f1)
        {
            InitializeComponent();
            LoadDanhSach(applicant, f1);
            
        }
        public void LoadDanhSach(Applicant applicant, FProfileApplicant f1)
        {
            this.fProfile = f1;
            this.applicant1 = applicant;
            this.txtAddress.Text = applicant.ApplicantAddress;
            this.txtDOB.Text = applicant.ApplicantDOB.ToString();
            this.txtEmail.Text = applicant.ApplicantEmail;
            this.txtGender.Text = applicant.ApplicantGender;
            this.txtPersonalLink.Text = applicant.ApplicantPersonalLink;
            this.txtPhoneNumber.Text = applicant.ApplicantPhonenumber;
            if (applicant.ApplicantAvatar != null)
            {
                this.pboxAvatar.Image = System.Drawing.Image.FromFile(Path.Combine(appDirectory, applicant.ApplicantAvatar));

            }
        }
        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            ApplicantsDAO applicantsDAO = new ApplicantsDAO();
            this.applicant1.ApplicantAddress = this.txtAddress.Text;
            this.applicant1.ApplicantDOB = DateTime.Parse(this.txtDOB.Text);
            this.applicant1.ApplicantEmail = this.txtEmail.Text;
            this.applicant1.ApplicantGender = this.txtGender.Text;
            this.applicant1.ApplicantPersonalLink = this.txtPersonalLink.Text;
            this.applicant1.ApplicantPhonenumber = this.txtPhoneNumber.Text;


            applicantsDAO.LuuAvatar(this.applicant1);

            applicantsDAO.SuaThongTinBasicInfor(this);
            applicantsDAO.LoadThongTinBasicInforlenForm(this.fProfile);
            this.Close();
        }
        private void pboxAvatar_Click(object sender, EventArgs e)
        {
           
        }
        private void btnEdit_Click(object sender, EventArgs e)
        {

            
            using (OpenFileDialog ofd = new OpenFileDialog())
            {
                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    string fileName = ofd.FileName;
                    string a = DateTime.Now.ToString("dddd, dd MMMM yyyy HHmmss" + Path.GetFileName(fileName));
                    string desPath = Path.Combine(appDirectory, a);

                    File.Copy(fileName, desPath, true);
                    this.applicant1.ApplicantAvatar = a;
                    
                    this.pboxAvatar.Image = System.Drawing.Image.FromFile(desPath);
                }
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            applicantsDAO.XoaAvatar(this.applicant1);
            this.applicant1.ApplicantAvatar=null;
            applicantsDAO.LoadThongTinBasicInfor(this);
        }
    }
}
