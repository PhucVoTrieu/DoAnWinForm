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
        Skill Skill;
        FProfileApplicant fprofile;
        public FAddSkill()
        {
            InitializeComponent();
        }
        public FAddSkill(Skill skill , FProfileApplicant f1)
        {
            InitializeComponent();
            if(skill != null) 
            { 
                this.Skill = skill;
                this.txtYourSkill.Text = skill.SkillName;
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {

        }
    }
}
