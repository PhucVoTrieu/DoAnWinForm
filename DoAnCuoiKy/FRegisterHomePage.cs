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
    public partial class FRegisterHomePage : Form
    {
        public FRegisterHomePage()
        {
            InitializeComponent();
            OpenForm(new FSignup());
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
            pnlRegisterHomePage.Controls.Add(form);
            pnlRegisterHomePage.Tag = form;
            form.BringToFront();
            form.Show();
        }
        private void btnPersonalInfor_Click(object sender, EventArgs e)
        {
            OpenForm(new FSignup());
        }
    }
}
