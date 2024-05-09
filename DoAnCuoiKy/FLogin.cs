
using DoAnCuoiKy.Class;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.UI.WebControls;
using System.Windows.Forms;

namespace DoAnCuoiKy
{
    public partial class FLogin : Form
    {
        public FLogin()
        {
            InitializeComponent();
        }
        
        private void guna2ControlBox1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
           
            if (rbtnEmployer.Checked)
            {
                Constant.isEmployer = true;
                this.Hide();           
                try
                {
                    DoAnCuoiKyEntities db = new DoAnCuoiKyEntities();
                    var employerAccount = from account in db.Companies where account.CompanyEmail == this.txtEmail.Text 
                                              && account.CompanyPassword == this.txtPassword.Text select account;
                    if (employerAccount.Any()) 
                    {
                        Constant.CompanyID = employerAccount.SingleOrDefault().CompanyID;

                        FTrangChuCongTy fTrang = new FTrangChuCongTy(employerAccount.SingleOrDefault());
                        fTrang.Show();
                    }
                    else 
                    {
                        MessageBox.Show("Wrong Password", "Help?", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        FLogin fLogin = new FLogin();
                        fLogin.Show();
                    }
                    
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Lỗi truy vấn: " + ex.Message);
                }
            
                

              
            }

            else if (rbtnApplicant.Checked)
            {
                Constant.isApplicant = true;
                this.Hide();
                try
                {
                    DoAnCuoiKyEntities db = new DoAnCuoiKyEntities();
                    var applicantAccount = (from account in db.Applicants
                                            where account.ApplicantEmail == this.txtEmail.Text
                                                && account.ApplicantPassword == this.txtPassword.Text
                                            select account);
                   if(applicantAccount.Any()) 
                    {
                        Applicant applicant = applicantAccount.SingleOrDefault();
                        Constant.ApplicantID = applicantAccount.FirstOrDefault().ApplicantID;
                        FApplicantHomePage fTrang = new FApplicantHomePage(applicant);
                        fTrang.Show();
                    }
                    else
                    {
                        MessageBox.Show("Wrong Password", "Help?", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        FLogin fLogin = new FLogin();
                        fLogin.Show();
                    }

                }
                catch (Exception ex)
                {
                    Console.WriteLine("Lỗi truy vấn1312312: " + ex.Message);
                }


            }
        }
    }
}
