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
    public partial class FCandidateHomePage : Form
    {
        public FCandidateHomePage()
        {
            InitializeComponent();
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
            pnlContentCandidate.Controls.Add(form);
            pnlContentCandidate.Tag = form;
            form.BringToFront();
            form.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            OpenForm(new FProfileApplicant());
        }

        private void button3_Click(object sender, EventArgs e)
        {
            OpenForm(new FFindingCandidate());
        }

        private void FCandidateHomePage_Load(object sender, EventArgs e)
        {
            
        }
    }
}
