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
    public partial class UCApplicantSkill : UserControl
    {
        public Skill Skill;
        public FProfileApplicant fProfile;
        public UCApplicantSkill()
        {
            InitializeComponent();
        }
        public UCApplicantSkill(Skill skill , FProfileApplicant f1)
        {
            InitializeComponent();
            this.Skill = skill;
            this.fProfile = f1;
            loadUC();
        }
        public void loadUC()
        {
            this.lblSkills.Text = Skill.SkillName;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            ApplicantsDAO applicantsDAO = new ApplicantsDAO();
            applicantsDAO.xoaThongTinSkill(this.Skill, this.fProfile);
        }
    }
}
