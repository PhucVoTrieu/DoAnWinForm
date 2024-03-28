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
        
    public partial class FPostAJob : Form
    {
        JobDetailsDAO jobDetailsDAO = new JobDetailsDAO();
        
        public FPostAJob()
        {
            InitializeComponent();
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            
        }

        private void guna2GradientButton1_Click(object sender, EventArgs e)
        {
            JobDetails jobDetails = new JobDetails(txtJobTitle.Text,txtJobPosition.Text
                ,cbJobType.SelectedItem.ToString() , txtJobSalary.Text , txtRecruitmentQuota.Text
                ,cbLocation.SelectedItem.ToString() ,txtJobExperiencesInYears.Text ,txtJobDescription.Text );
            jobDetailsDAO.them(jobDetails);
            this.Close();
        }
    }
}
