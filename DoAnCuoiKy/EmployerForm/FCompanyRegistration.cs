using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DoAnCuoiKy.Company
{
    public partial class FCompanyRegistration : Form
    {
        public FCompanyRegistration()
        {
            InitializeComponent();
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            this.Hide();
           // FTrangChuCongTy f1 = new FTrangChuCongTy();
          //  f1.Show();
        }

        private void btnAddHeaderImage_Click(object sender, EventArgs e)
        {
            string imageLocation = "";
            try
            {
                OpenFileDialog dialog = new OpenFileDialog();
                dialog.Filter = "jpg files(.*jpg)|*.jpg| PNG files(.*png)|*.png| All Files(*.*)|*.*";
                if(dialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    imageLocation = dialog.FileName;

                    picboxCompany.ImageLocation = imageLocation;
                }
             }
            catch (Exception )
            {
                MessageBox.Show("Can not upload image","Error",MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            string imageLocation = "";
            try
            {
                OpenFileDialog dialog = new OpenFileDialog();
                dialog.Filter = "jpg files(.*jpg)|*.jpg| PNG files(.*png)|*.png| All Files(*.*)|*.*";
                if (dialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    imageLocation = dialog.FileName;

                    picboxCompany.ImageLocation = imageLocation;
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Can not upload image", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
