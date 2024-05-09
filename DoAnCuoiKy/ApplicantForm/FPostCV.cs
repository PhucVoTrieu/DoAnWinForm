using DoAnCuoiKy.ApplicantForm;
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
    public partial class FPostCV : Form
    {
        public JobSeekerForum JobSeekerForum;
        public FPostCV()

        {
            InitializeComponent();
        }
        public FPostCV(JobSeekerForum jobSeekerForum)
        {
            InitializeComponent();
            this.JobSeekerForum = jobSeekerForum;
        }
        ApplicantsDAO applicantsDAO = new ApplicantsDAO();
        private void btnPost_Click_1(object sender, EventArgs e)
        {
            applicantsDAO.DangBai(this);
            applicantsDAO.LoadDanhSachBaiDang(this.JobSeekerForum);
            this.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
