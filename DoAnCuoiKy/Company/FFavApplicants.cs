﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DoAnCuoiKy.Company
{
    public partial class FFavoriteApplicants : Form
    {
        SqlConnection connStr = new SqlConnection(DoAnCuoiKy.Properties.Settings.Default.connStr);
        FavApplicantDAO favApplicantDao = new FavApplicantDAO();
        public FFavoriteApplicants()
        {
            InitializeComponent();
            favApplicantDao.LoadDanhSach(this);
            this.btnCountFavApplicants.Text = CountFavoriteApplicants().ToString();
        }
        
        public int CountFavoriteApplicants()
        {
            int count = 0;
            foreach (Control c in pnlFavApplicants.Controls)
            {
                if (c.GetType() == typeof(DoAnCuoiKy.UCApplicants))
                {
                    ++count;
                }
            }
            return count;
        }
       
       
        private void btnDelete_Click_1(object sender, EventArgs e)
        {
            List<UCApplicants> list = new List<UCApplicants>();
            foreach (Control c in pnlFavApplicants.Controls)
            {
                if (c.GetType() == typeof(UCApplicants))
                {
                    UCApplicants A = (UCApplicants)(c);

                    if (A.CBoxSelected.Checked)
                    {
                        list.Add(A);

                    }
                }

            }
            foreach (UCApplicants c in list)
            {
                this.pnlFavApplicants.Controls.Remove(c);
                this.btnCountFavApplicants.Text = CountFavoriteApplicants().ToString();
                favApplicantDao.xoaUC(c);
            }

        }
    }
}
