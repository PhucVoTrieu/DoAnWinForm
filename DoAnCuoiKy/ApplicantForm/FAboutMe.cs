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
    public partial class FAboutMe : Form
    {
        public FProfileApplicant profileApplicantInfo; 
        public FAboutMe()
        {
            InitializeComponent();
        }
        public FAboutMe(FProfileApplicant f1 )
        {
            InitializeComponent();
            
            this.profileApplicantInfo = f1;
            this.txtAboutMe.Text = f1.lblAboutMePlaceHolder.Text;
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            
            ApplicantsDAO applicantsDAO = new ApplicantsDAO();
            applicantsDAO.SuaThongTinAboutMe(this);
            this.Close();
        }
    }
}
