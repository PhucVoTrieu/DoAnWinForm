using DoAnCuoiKy.Class;
using DoAnCuoiKy.EmployerForm;
using DoAnCuoiKy.UC;
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
    public partial class FTrangChuCongTy : Form
    {
       
        private Company CompanyInformation;
        public FTrangChuCongTy(Company e1)
        {
            InitializeComponent();
            this.CompanyInformation = e1;

            FInformation fInformation = new FInformation(CompanyInformation);
            fInformation.guna2ControlBox1.Hide();
            OpenForm(fInformation);
        }
        private Form currentFormChild;

        private void OpenForm(Form form)
        {
            if (currentFormChild != null)
            {
                currentFormChild.Close();
            }
            currentFormChild = form;
            form.TopLevel = false;
            form.FormBorderStyle = FormBorderStyle.None;
            form.Dock = DockStyle.Fill;
            pnlContent.Controls.Add(form);
            pnlContent.Tag = form;
            form.BringToFront();
            form.Show();
        }
        private void btnHome_Click(object sender, EventArgs e)
        {
            FInformation fInformation = new FInformation(CompanyInformation);
            fInformation.guna2ControlBox1.Hide();
            OpenForm(fInformation);
        }
        private void btnApplicants_Click(object sender, EventArgs e)
        {
            OpenForm(new FApplicants(CompanyInformation));

        }

        private void btnPostAJob_Click(object sender, EventArgs e)
        {
            Form formBackground = new Form();
            try
            {
                using (FPostAJob f1 = new FPostAJob(CompanyInformation))
                {


                    formBackground.StartPosition = FormStartPosition.Manual;
                    formBackground.FormBorderStyle = FormBorderStyle.None;
                    formBackground.Opacity = .50d;
                    formBackground.BackColor = Color.Black;
                    formBackground.WindowState = FormWindowState.Maximized;
                    formBackground.TopMost = false;
                    formBackground.Location = this.Location;
                    formBackground.ShowInTaskbar = false;
                    formBackground.Show();

                    f1.Owner = formBackground;
                    f1.ShowDialog();

                    formBackground.Dispose();

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                formBackground.Dispose();

            }


        }
        private void btnJobs_Click(object sender, EventArgs e)
        {
            OpenForm(new FJobs(CompanyInformation));
        }

        private void btnFavApplicants_Click(object sender, EventArgs e)
        {
            OpenForm(new FFavoriteApplicants(CompanyInformation));
        }

        private void btnStatistic_Click(object sender, EventArgs e)
        {
            OpenForm(new FStatistic());
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            this.Hide();
            FLogin f1 = new FLogin();
            f1.Show();
        }

        private void btnInvitedApp_Click(object sender, EventArgs e)
        {
            OpenForm(new FInvitedApplicant(CompanyInformation));
        }
    }
}
