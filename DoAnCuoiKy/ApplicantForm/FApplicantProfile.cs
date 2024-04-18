using Guna.UI2.WinForms;
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
    public partial class FProfileApplicant : Form
    {
        Applicant applicantInfor;
        public FProfileApplicant()
        {
            InitializeComponent();
            Label lblPlaceHolderAboutMe = new Label();
            lblPlaceHolderAboutMe.Text = "Introduce your strengths and years of experience";
            lblPlaceHolderAboutMe.ForeColor = System.Drawing.Color.Gray;
            lblPlaceHolderAboutMe.Location = new Point(lblAboutMe.Location.X, lblAboutMe.Location.Y+20);
            lblPlaceHolderAboutMe.AutoSize = true;
            this.pnlAboutMe.Controls.Add(lblPlaceHolderAboutMe);
        }
        public FProfileApplicant(Applicant applicant)
        {
            InitializeComponent();
            this.applicantInfor = applicant;
         
        }
  
        private void btnEdit_Click(object sender, EventArgs e)
        {
            foreach (Control c in pnlWorkExp.Controls)  // pnlBasicinfo.controls not this.controls boi vi this.controls la form va cac txtbox ko nam trong form maf trong panel
            {
                if(c.GetType()==typeof(Guna.UI2.WinForms.Guna2TextBox))
                {
                    c.Enabled = true;
                }
            }
        }
        
    

        private void btnSave_Click(object sender, EventArgs e)
        {
            foreach (Control c in pnlWorkExp.Controls)  // pnlBasicinfo.controls not this.controls boi vi this.controls la form va cac txtbox ko nam trong form maf trong panel
            {
                if (c.GetType() == typeof(Guna.UI2.WinForms.Guna2TextBox))
                {
                    c.Enabled = false;
                }
            }
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            UCApplicantInformation uc1 = new UCApplicantInformation();
            foreach (Control panel1 in this.pnlMain.Controls)
            {
                if (panel1 is Panel && panel1 != this.pnlWorkExp){
                    Panel panel = panel1 as Panel;

                    if (panel.Location.Y > pnlWorkExp.Location.Y)
                    {                
                        panel.Location = new Point(panel.Location.X, panel.Location.Y + uc1.Height);
                        this.pnlMain.Size = new Size(this.pnlMain.Size.Width,this.pnlMain.Size.Height + uc1.Height);
                    }
                }
            }
            if (pnlAboutMe.Controls.Count == 0)
            {
                pnlAboutMe.Controls.Add(uc1);
            }
            else
            {
                this.pnlWorkExp.Size = new Size(this.pnlWorkExp.Size.Width, this.pnlWorkExp.Size.Height + uc1.Height);
                this.pnlAboutMe.Size = new Size(this.pnlAboutMe.Size.Width, this.pnlAboutMe.Size.Height + uc1.Height);
                pnlAboutMe.Controls.Add(uc1);
            }
            
        }

        private void pnlAboutMe_ControlAdded(object sender, ControlEventArgs e)
        {
          
       
        }

        private void btnAddAboutMe_Click(object sender, EventArgs e)
        {
            if(this.pnlAboutMe.Controls.Count > 0)
            {
                this.pnlAboutMe.Controls.Add(new UCApplicantInformation());
                foreach (Control C in this.pnlAboutMe.Controls)
                {
                    if (C is Label)
                    {
                       // this.pnlAboutMe.Controls.Remove(C);
                       C.Visible = false;
                    }
                }
                if (this.pnlAboutMe.Controls.Count > 2)
                {
                    this.pnlAboutMe.Controls.Remove(new UCApplicantInformation());
                    foreach (Control C in this.pnlAboutMe.Controls)
                    {
                        if (C is Label)
                        {
                            // this.pnlAboutMe.Controls.Remove(C);
                            C.Visible = true;
                        }
                    }
                }
            }
            
        }
    }
}
