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
    public partial class FNotification : Form
    {
        public Applicant applicant;
        CompanyDAO companyDAO = new CompanyDAO();
        public FNotification(Applicant a)
        {
            InitializeComponent();
            this.applicant = a;
            companyDAO.LoadThongBaoPhongVan(this.applicant , this);
        }
    }
}
