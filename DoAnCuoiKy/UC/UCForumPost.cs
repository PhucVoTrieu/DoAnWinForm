using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DoAnCuoiKy.UC
{
    public partial class UCForumPost : UserControl
    {
        public Applicant applicant;
        public string content;
        public UCForumPost()
        {
            InitializeComponent();
        }
        public UCForumPost(Applicant applicant,string text)
        {
            InitializeComponent();
            this.applicant = applicant;
            this.content = text;
            LoadInfor();
        }
        public void LoadInfor()
        {
            if (applicant != null)
            {
                this.lblContentOfPost.Text = this.content;
                this.lblUserName.Text = applicant.ApplicantName;
            }
        }
    }
}
