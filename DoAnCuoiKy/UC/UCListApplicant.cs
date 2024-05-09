using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DoAnCuoiKy.UC
{
    public partial class UCListApplicant : UserControl
    {
        public Applicant applicantInfo;
        public FApplicants fApplicants;
        ApplicantsDAO applicantsDAO = new ApplicantsDAO();
        public Job job;
        public UCListApplicant(Job a , FApplicants f)
        {
            InitializeComponent();
            this.job = a;
            this.fApplicants = f;
            this.btnJobTitle.Text = a.JobTitle;

            LoadDanhSach();
        }
        private void btnJobTitle_Click(object sender, EventArgs e)
        {
            
        }
        public void LoadDanhSach()
        {
            applicantsDAO.LoadDanhSachUngVienGroup(this.job, this.fApplicants, this);
        }
        private void btnJobTitle_CheckedChanged(object sender, EventArgs e)
        {
            if(this.btnJobTitle.Checked)
            {

                this.Size = new Size(this.Width, this.pnlJobTitle.Height+325);
            }
            else
            {
                this.Size = new Size(this.Width, this.pnlJobTitle.Height+20);
            }
            
        }
    }
}
