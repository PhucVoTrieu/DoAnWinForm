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
    public partial class FInformation : Form
    {
        Employer employer;
        public FInformation()
        {
            InitializeComponent();
        }
        public FInformation(Employer e1)
        {
            InitializeComponent();
            this.employer = e1;
            this.txtBenefit.Text = e1.CompanyBenefit;
            this.lblAddress.Text = e1.CompanyAddress;
            this.lblCompanyName.Text = e1.CompanyName;
            this.lblCompanySize.Text = e1.CompanySize;
            this.lblCompanyType.Text = e1.CompanyType;
            this.lblCountry.Text = e1.CompanyCountry;
            this.lblWorkingDays.Text = e1.CompanyWorkingDays;
            this.txtCompanyOverview.Text = e1.ComapnyOverview;
        }
        private void FInformation_Load(object sender, EventArgs e)
        {

        }
    }
}
