using DoAnCuoiKy.ApplicantForm;
using DoAnCuoiKy.Class;
using DoAnCuoiKy.UC;
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
    public partial class FApplicantHomePage : Form
    {
        public Applicant applicant;
        public FApplicantHomePage()
        {
            InitializeComponent();
        }
        public FApplicantHomePage(Applicant applicant)
        {
            this.applicant = applicant;
            InitializeComponent();
            OpenForm(new FFindingCandidate(this.applicant));
            
        }
        public Form currentFormChild;
        public void OpenForm(Form form)
        {
            if (currentFormChild != null)
            {
                currentFormChild.Close();
            }
            currentFormChild = form;
            form.TopLevel = false;
            form.FormBorderStyle = FormBorderStyle.None;
            form.Dock = DockStyle.Fill;
            pnlContentCandidate.Controls.Add(form);
            pnlContentCandidate.Tag = form;
            form.BringToFront();
            form.Show();
        }
        private void btnFindding_Click(object sender, EventArgs e)
        {
            OpenForm(new FFindingCandidate(this.applicant));
        }

        private void btnFavorite_Click(object sender, EventArgs e)
        {
            OpenForm(new FormFavoriteJobs());
        }

        private void btnProfile_Click(object sender, EventArgs e)
        {
            FProfileApplicant fProfileApplicant = new FProfileApplicant();
            fProfileApplicant.guna2ControlBox1.Hide();
            OpenForm(fProfileApplicant);

        }

        private void btnPostJobFinding_Click(object sender, EventArgs e)
        {
            OpenForm(new JobSeekerForum(this.applicant));

        }

        private void btnLogOut_Click(object sender, EventArgs e)
        {
            this.Hide();
            FLogin f1 = new FLogin();
            f1.Show();
        }

        private void btnNote_Click(object sender, EventArgs e)
        {
           OpenForm(new FNotification(this.applicant));  
        }
    }
}
