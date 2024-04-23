using DoAnCuoiKy.ApplicantForm;
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
            LoadDanhSach();
        }
        public FProfileApplicant(Applicant applicant)
        {
            InitializeComponent();
            this.applicantInfor = applicant;
         
        }
        public void LoadDanhSach()
        {

        }
        private void btnEdit_Click(object sender, EventArgs e)
        {
            foreach (Control c in pnlAboutMe.Controls)  // pnlBasicinfo.controls not this.controls boi vi this.controls la form va cac txtbox ko nam trong form maf trong panel
            {
                if(c.GetType()==typeof(Guna.UI2.WinForms.Guna2TextBox))
                {
                    c.Enabled = true;
                }
            }
        }
        
    

        private void btnSave_Click(object sender, EventArgs e)
        {
            foreach (Control c in pnlAboutMe.Controls)  // pnlBasicinfo.controls not this.controls boi vi this.controls la form va cac txtbox ko nam trong form maf trong panel
            {
                if (c.GetType() == typeof(Guna.UI2.WinForms.Guna2TextBox))
                {
                    c.Enabled = false;
                }
            }
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            
            
        }

        private void pnlAboutMe_ControlAdded(object sender, ControlEventArgs e)
        {
          
       
        }

        private void btnAddAboutMe_Click(object sender, EventArgs e)
        {
            FAboutMe f1 = new FAboutMe();
            f1.Show();
            UCApplicantInformation uc1 = new UCApplicantInformation();
            foreach (Control panel1 in this.pnlMain.Controls)
            {
                if (panel1 is Panel && panel1 != this.pnlAboutMe)
                {
                    Panel panel = panel1 as Panel;

                    if (panel.Location.Y > pnlAboutMe.Location.Y)
                    {
                        panel.Location = new Point(panel.Location.X, panel.Location.Y + uc1.Height);
                        this.pnlMain.Size = new Size(this.pnlMain.Size.Width, this.pnlMain.Size.Height + uc1.Height);
                    }
                }
            }
            if (pnlListOfAboutMe.Controls.Count == 0)
            {
                pnlListOfAboutMe.Controls.Add(uc1);
            }
            else
            {
                this.pnlAboutMe.Size = new Size(this.pnlAboutMe.Size.Width, this.pnlAboutMe.Size.Height + uc1.Height);
                this.pnlListOfAboutMe.Size = new Size(this.pnlListOfAboutMe.Size.Width, this.pnlListOfAboutMe.Size.Height + uc1.Height);
                pnlListOfAboutMe.Controls.Add(uc1);
            }
        
            
        }

        private void btnEditBasicInfo_Click(object sender, EventArgs e)
        {
            FPersonalDetais f1 = new FPersonalDetais();
            f1.Show();
        }
    }
}
