
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
        private string email;
        private string password;
        DBconnection db = new DBconnection();
        SqlConnection connStr = new SqlConnection(DoAnCuoiKy.Properties.Settings.Default.connStr);
        List<Employer> list = new List<Employer>();
        public FLogin()
        {
            InitializeComponent();
            this.email = this.txtEmail.Text;
            this.password = this.txtPassword.Text;
           //loadDanhSachTaiKhoan(this.list);
            
        }
        //public void loadDanhSachTaiKhoan(List<Employer> list)
        //{
           
        //    string query = "SELECT * FROM Company";
        //    SqlCommand command = new SqlCommand(query, connStr);
        //    connStr.Open();
        //    SqlDataReader reader = command.ExecuteReader();
        //    while (reader.Read())
        //    {              
        //            Employer employer = new Employer(
        //                  int.Parse(reader["CompanyID"].ToString()),
        //                  reader["CompanyEmail"].ToString(),
        //                  reader["CompanyPassword"].ToString(),
        //                  reader["CompanyName"].ToString(),
        //                  reader["CompanyType"].ToString(),
        //                  reader["CompanyAddress"].ToString(),
        //                  reader["CompanyOverview"].ToString(),
        //                  reader["CompanyBenefit"].ToString(),
        //                  reader["CompanyWorkingDays"].ToString(),
        //                  reader["CompanySize"].ToString(),
        //                  reader["CompanyCountry"].ToString()
        //                );
        //            list.Add(employer);   
              
        //    }
        //}
        private void guna2ControlBox1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
           
            if (rbtnEmployer.Checked)
            {
                FTrangChuCongTy fTrang=null;
                this.Hide();           
                try
                {
                    DoAnCuoiKyEntities db = new DoAnCuoiKyEntities();
                    var employerAccount = from account in db.Companies where account.CompanyEmail == this.txtEmail.Text 
                                              && account.CompanyPassword == this.txtPassword.Text select account;
                    Constant.CompanyID = employerAccount.SingleOrDefault().CompanyID;

                    fTrang = new FTrangChuCongTy(employerAccount.SingleOrDefault());
                       fTrang.Show();
                    
                  


                }
                catch (Exception ex)
                {
                    Console.WriteLine("Lỗi truy vấn: " + ex.Message);
                }
                finally
                {
                    connStr.Close();
                }
                

              
            }

            else if (rbtnApplicant.Checked)
            {
                this.Hide();
                FApplicantHomePage f1 = new FApplicantHomePage();
                f1.Show();
            }
        }
    }
}
