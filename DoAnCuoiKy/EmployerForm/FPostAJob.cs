using DoAnCuoiKy.Class;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DoAnCuoiKy
{
        
    public partial class FPostAJob : Form
    {
        JobsDAO jobDetailsDAO = new JobsDAO();
        Employer employerInfor;
        public FPostAJob(Employer e1)
        {
            InitializeComponent();
            this.employerInfor = e1;
        }
        private void btnPost_Click(object sender, EventArgs e)
        {
            JobDetails jobDetails = new JobDetails(txtJobTitle.Text, txtJobPosition.Text
                , cbJobType.SelectedItem.ToString(), txtJobSalary.Text, txtRecruitmentQuota.Text
                , cbLocation.SelectedItem.ToString(), txtJobExperiencesInYears.Text, txtJobDescription.Text,txtCompanyName.Text, txtBenefit.Text );
            jobDetailsDAO.them(jobDetails);
            this.Close();
        }
    }
}
