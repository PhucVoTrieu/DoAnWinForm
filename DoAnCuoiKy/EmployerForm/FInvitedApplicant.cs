using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DoAnCuoiKy.EmployerForm
{
    public partial class FInvitedApplicant : Form
    {
        public Company e1;
        public FInvitedApplicant()
        {
            InitializeComponent();
        }
        public FInvitedApplicant(Company company)
        {
            this.e1 = company;
            InitializeComponent();
        }
    }
}
