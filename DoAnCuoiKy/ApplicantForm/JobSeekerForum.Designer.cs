namespace DoAnCuoiKy.ApplicantForm
{
    partial class JobSeekerForum
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.btnPost = new Guna.UI2.WinForms.Guna2GradientButton();
            this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.pnlPostsOfUser = new System.Windows.Forms.FlowLayoutPanel();
            this.SuspendLayout();
            // 
            // btnPost
            // 
            this.btnPost.BorderRadius = 10;
            this.btnPost.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnPost.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnPost.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnPost.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnPost.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnPost.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.btnPost.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.btnPost.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnPost.ForeColor = System.Drawing.Color.White;
            this.btnPost.Location = new System.Drawing.Point(76, 27);
            this.btnPost.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnPost.Name = "btnPost";
            this.btnPost.Size = new System.Drawing.Size(131, 37);
            this.btnPost.TabIndex = 30;
            this.btnPost.Text = "Post";
            this.btnPost.Click += new System.EventHandler(this.btnPost_Click);
            // 
            // guna2Elipse1
            // 
            this.guna2Elipse1.BorderRadius = 15;
            this.guna2Elipse1.TargetControl = this.pnlPostsOfUser;
            // 
            // pnlPostsOfUser
            // 
            this.pnlPostsOfUser.AutoScroll = true;
            this.pnlPostsOfUser.BackColor = System.Drawing.Color.Transparent;
            this.pnlPostsOfUser.Location = new System.Drawing.Point(76, 85);
            this.pnlPostsOfUser.Name = "pnlPostsOfUser";
            this.pnlPostsOfUser.Size = new System.Drawing.Size(1020, 610);
            this.pnlPostsOfUser.TabIndex = 31;
            // 
            // JobSeekerForum
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(99)))), ((int)(((byte)(124)))));
            this.ClientSize = new System.Drawing.Size(1208, 736);
            this.Controls.Add(this.pnlPostsOfUser);
            this.Controls.Add(this.btnPost);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "JobSeekerForum";
            this.Text = "JobSeekerForum";
            this.ResumeLayout(false);

        }

        #endregion

        public Guna.UI2.WinForms.Guna2GradientButton btnPost;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        public System.Windows.Forms.FlowLayoutPanel pnlPostsOfUser;
    }
}