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
    public partial class FAddSkill : Form
    {
        public Skill Skill;
        public FProfileApplicant fprofile;
        public FAddSkill()
        {
            InitializeComponent();
        }
        public FAddSkill(FProfileApplicant f1)
        {
            InitializeComponent();
            this.fprofile = f1;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            ApplicantsDAO applicantsDAO = new ApplicantsDAO();
            applicantsDAO.ThemThongTinSkill(this);
            this.Close();
        }
    }
}
