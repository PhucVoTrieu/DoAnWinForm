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
    public partial class UCNote : UserControl
    {
        public DateInterview date1;
        public Company company1;
        public Applicant applicant1;
        public UCNote(DateInterview d , Company c , Applicant a)
        {
            InitializeComponent();
            this.date1 = d;
            this.company1 = c;
            this.lblNameApp.Text = a.ApplicantName;
            this.lblNameCom.Text = c.CompanyName;
            this.lblDateInterview.Text = d.DateInterview1;
        }
    }
}
