using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DoAnCuoiKy
{
    public partial class FormFavoriteJobs : Form
    {
        SqlConnection connStr = new SqlConnection(DoAnCuoiKy.Properties.Settings.Default.connStr);
        
        public FormFavoriteJobs()
        {
            InitializeComponent();
            //favoriteJobDAO.LoadDanhSach(this);
            this.btnCountFavJob.Text = CountFavoriteJob().ToString();

        }
        public int CountFavoriteJob()
        {
            int count = 0;
            foreach ( Control c in pnlFavJobs.Controls)
            {
                if( c.GetType() == typeof(DoAnCuoiKy.UCJobUI))
                {
                    ++count;
                }
            }
            return count;
        }
        

        private void btnDelete_Click(object sender, EventArgs e)
        {
            List <UCJobUI> list = new List <UCJobUI>();
            foreach (Control c in pnlFavJobs.Controls)
            {
                if (c.GetType() == typeof(UCJobUI))
                {
                    UCJobUI A = (UCJobUI)(c);

                    if (A.CBoxSelected.Checked )
                    {
                        list.Add (A);
                        
                    }
                }             
              
             }
              foreach (UCJobUI c in list)
            {
                this.pnlFavJobs.Controls.Remove(c);
                this.btnCountFavJob.Text = CountFavoriteJob().ToString();
                //favoriteJobDAO.xoaUC(c);
            }
           

        }
    }
}

