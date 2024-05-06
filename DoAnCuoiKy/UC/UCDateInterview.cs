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
    public partial class UCDateInterview : UserControl
    {
        public DateInterview d1;
        public Applicant a1 ;
        public UCDateInterview(DateInterview dateInterview , Applicant applicant )
        {
            InitializeComponent();
            this.d1 = dateInterview;
            this.a1 = applicant;
            this.lblDate.Text = dateInterview.DateInterview1.ToString();
            this.lblName.Text = applicant.ApplicantName;
        }
    }
}
