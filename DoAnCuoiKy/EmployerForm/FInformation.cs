using DoAnCuoiKy.Class;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DoAnCuoiKy
{
    public partial class FInformation : Form
    {
        Company employerInfo;
        public FInformation()
        {
            InitializeComponent();
        }
        public FInformation(Company e1)
        {
            InitializeComponent();
            this.employerInfo = e1;
            this.txtBenefit.Text = e1.CompanyBenefit;
            this.lblAddress.Text = e1.CompanyAddress;
            this.lblCompanyName.Text = e1.CompanyName;
            this.lblCompanySize.Text = e1.CompanySize;
            this.lblCompanyType.Text = e1.CompanyType;
            this.lblCountry.Text = e1.CompanyCountry;
            this.lblWorkingDays.Text = e1.CompanyWorkingDays;
            this.txtCompanyOverview.Text = e1.CompanyOverview;
            LoadDanhSach();
        }
        private void FInformation_Load(object sender, EventArgs e)
        {

        }
        public void LoadDanhSach()
        {
          
            try
            {
                DoAnCuoiKyEntities db = new DoAnCuoiKyEntities();
                var jobsOfCompany = from c in db.Jobs where c.CompanyID == this.employerInfo.CompanyID select c;
                
                foreach(var job in  jobsOfCompany)
                {
                    UCJobUI uCJob = new UCJobUI(job);
                    uCJob.CBoxSelected.Hide();
                    this.pnlJobOpenings.Controls.Add(uCJob);
                }  
            }
            catch (Exception ex)
            {
                Console.WriteLine("Lỗi truy vấn: " + ex.Message);
            } 
           
        }
        private void pnlInformation_MouseEnter(object sender, EventArgs e)
        {
            this.pnlInformation.Focus();
        }
    }
}
