using DoAnCuoiKy.Class;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity.Core.Metadata.Edm;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DoAnCuoiKy
{
        
    public partial class FPostAJob : Form
    {
       
        public Company employerInfor;
        JobsDAO jobsDAO = new JobsDAO();
        public FPostAJob(Company e1)
        {
            InitializeComponent();
            this.employerInfor = e1;
        }
        private void btnPost_Click(object sender, EventArgs e)
        {
            try {
               
            DoAnCuoiKyEntities db = new DoAnCuoiKyEntities();
              

                jobsDAO.Them(this);
              
                db.SaveChanges();
                MessageBox.Show("Thành Công", "Thông Báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Lỗi truy vấn: " + ex.Message);
            }
            //  jobDetailsDAO.them(Job);
            this.Close();
        }

        
    }
}
