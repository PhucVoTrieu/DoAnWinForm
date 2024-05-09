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
        CompanyDAO companyDAO = new CompanyDAO();
        public FInformation()
        {
            InitializeComponent();
        }
        public FInformation(Company e1 )
        {
            InitializeComponent();
            this.employerInfo = e1;
            LoadInformation();
        }
        public void LoadInformation()
        {

            //this.lblBenefit.Text = employerInfo.CompanyBenefit;
            //this.lblAddress.Text = employerInfo.CompanyAddress;
            //this.lblCompanyName.Text = employerInfo.CompanyName;
            //this.lblCompanySize.Text = employerInfo.CompanySize;
            //this.lblCompanyType.Text = employerInfo.CompanyType;
            //this.lblCountry.Text = employerInfo.CompanyCountry;
            //this.lblWorkingDays.Text = employerInfo.CompanyWorkingDays;
            //this.lblCompanyOverviewContent.Text = employerInfo.CompanyOverview;

            companyDAO.LoadCompanyDetail(employerInfo, this);
            companyDAO.LoadJobCreatedByCompany(employerInfo, this);
        }

 
    }
}
