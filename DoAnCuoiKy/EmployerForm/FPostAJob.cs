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
       
        Company employerInfor;
        public FPostAJob(Company e1)
        {
            InitializeComponent();
            this.employerInfor = e1;
        }
        private void btnPost_Click(object sender, EventArgs e)
        {
            try { 
            DoAnCuoiKyEntities db = new DoAnCuoiKyEntities();
            db.Jobs.Add(new Job { JobTitle=this.txtJobTitle.Text, JobType=this.cbJobType.SelectedItem.ToString(),JobSalary =this.txtJobSalary.Text
            , RecruitmentQuota = this.txtRecruitmentQuota.Text, Location = this.cbLocation.SelectedItem.ToString(), ExpInYears = this.txtJobExperiencesInYears.Text
            , JobRequirement = this.txtJobrequirement.Text,JobDescription= this.txtJobDescription.Text,CompanyID = this.employerInfor.CompanyID,
            JobBenefit = this.txtBenefit.Text});
                db.SaveChanges();
                MessageBox.Show("Thành Công", "Thông Báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Lỗi truy vấn: " + ex.Message);
            }
            //  jobDetailsDAO.them(Job);
            this.Close();
        }
    }
}
