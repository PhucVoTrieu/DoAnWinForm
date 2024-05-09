using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DoAnCuoiKy.ApplicantForm
{
    public partial class JobSeekerForum : Form
    {
        public Applicant Applicant;
        ApplicantsDAO applicantsDAO = new ApplicantsDAO();
        public JobSeekerForum()
        {
            InitializeComponent();
        }
        public JobSeekerForum(Applicant applicant)
        {
            InitializeComponent();
            this.Applicant = applicant;
            applicantsDAO.LoadDanhSachBaiDang(this);
        }
        private void btnPost_Click(object sender, EventArgs e)
        {
            FPostCV f1 = new FPostCV(this);
            f1.ShowDialog();
        }
    }
}
