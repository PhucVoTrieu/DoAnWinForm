namespace DoAnCuoiKy
{
    partial class FTrangChuCongTy
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
            this.guna2DragControl1 = new Guna.UI2.WinForms.Guna2DragControl(this.components);
            this.pnlContent = new Guna.UI2.WinForms.Guna2Panel();
            this.guna2ShadowForm1 = new Guna.UI2.WinForms.Guna2ShadowForm(this.components);
            this.guna2Panel2 = new Guna.UI2.WinForms.Guna2Panel();
            this.btnForum = new Guna.UI2.WinForms.Guna2Button();
            this.btnInvitedApp = new Guna.UI2.WinForms.Guna2Button();
            this.btnLogout = new Guna.UI2.WinForms.Guna2Button();
            this.btnHome = new Guna.UI2.WinForms.Guna2Button();
            this.btnFavApplicants = new Guna.UI2.WinForms.Guna2Button();
            this.btnApplicants = new Guna.UI2.WinForms.Guna2Button();
            this.btnJobs = new Guna.UI2.WinForms.Guna2Button();
            this.btnPostAJob = new Guna.UI2.WinForms.Guna2GradientButton();
            this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.guna2Panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // guna2DragControl1
            // 
            this.guna2DragControl1.DockIndicatorTransparencyValue = 0.6D;
            this.guna2DragControl1.TargetControl = this;
            this.guna2DragControl1.UseTransparentDrag = true;
            // 
            // pnlContent
            // 
            this.pnlContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlContent.Location = new System.Drawing.Point(197, 0);
            this.pnlContent.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pnlContent.Name = "pnlContent";
            this.pnlContent.Size = new System.Drawing.Size(1611, 1088);
            this.pnlContent.TabIndex = 22;
            // 
            // guna2ShadowForm1
            // 
            this.guna2ShadowForm1.TargetForm = this;
            // 
            // guna2Panel2
            // 
            this.guna2Panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(248)))), ((int)(((byte)(255)))));
            this.guna2Panel2.Controls.Add(this.btnForum);
            this.guna2Panel2.Controls.Add(this.btnInvitedApp);
            this.guna2Panel2.Controls.Add(this.btnLogout);
            this.guna2Panel2.Controls.Add(this.btnHome);
            this.guna2Panel2.Controls.Add(this.btnFavApplicants);
            this.guna2Panel2.Controls.Add(this.btnApplicants);
            this.guna2Panel2.Controls.Add(this.btnJobs);
            this.guna2Panel2.Controls.Add(this.btnPostAJob);
            this.guna2Panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.guna2Panel2.Location = new System.Drawing.Point(0, 0);
            this.guna2Panel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.guna2Panel2.Name = "guna2Panel2";
            this.guna2Panel2.Size = new System.Drawing.Size(197, 1088);
            this.guna2Panel2.TabIndex = 19;
            // 
            // btnForum
            // 
            this.btnForum.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.btnForum.CheckedState.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnForum.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnForum.CheckedState.ForeColor = System.Drawing.Color.White;
            this.btnForum.CheckedState.Image = global::DoAnCuoiKy.Properties.Resources._24;
            this.btnForum.CustomBorderColor = System.Drawing.Color.Transparent;
            this.btnForum.CustomBorderThickness = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.btnForum.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnForum.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnForum.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnForum.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnForum.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(248)))), ((int)(((byte)(255)))));
            this.btnForum.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnForum.ForeColor = System.Drawing.Color.Black;
            this.btnForum.Image = global::DoAnCuoiKy.Properties.Resources.chat;
            this.btnForum.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnForum.Location = new System.Drawing.Point(2, 504);
            this.btnForum.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnForum.Name = "btnForum";
            this.btnForum.Size = new System.Drawing.Size(195, 62);
            this.btnForum.TabIndex = 28;
            this.btnForum.Text = "Applicant Forum";
            this.btnForum.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnForum.Click += new System.EventHandler(this.btnForum_Click);
            // 
            // btnInvitedApp
            // 
            this.btnInvitedApp.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.btnInvitedApp.CheckedState.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnInvitedApp.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnInvitedApp.CheckedState.ForeColor = System.Drawing.Color.White;
            this.btnInvitedApp.CheckedState.Image = global::DoAnCuoiKy.Properties.Resources._24;
            this.btnInvitedApp.CustomBorderColor = System.Drawing.Color.Transparent;
            this.btnInvitedApp.CustomBorderThickness = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.btnInvitedApp.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnInvitedApp.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnInvitedApp.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnInvitedApp.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnInvitedApp.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(248)))), ((int)(((byte)(255)))));
            this.btnInvitedApp.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnInvitedApp.ForeColor = System.Drawing.Color.Black;
            this.btnInvitedApp.Image = global::DoAnCuoiKy.Properties.Resources._991;
            this.btnInvitedApp.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnInvitedApp.Location = new System.Drawing.Point(0, 438);
            this.btnInvitedApp.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnInvitedApp.Name = "btnInvitedApp";
            this.btnInvitedApp.Size = new System.Drawing.Size(195, 62);
            this.btnInvitedApp.TabIndex = 27;
            this.btnInvitedApp.Text = "Invited Applicant";
            this.btnInvitedApp.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnInvitedApp.Click += new System.EventHandler(this.btnInvitedApp_Click);
            // 
            // btnLogout
            // 
            this.btnLogout.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.btnLogout.CheckedState.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnLogout.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnLogout.CheckedState.ForeColor = System.Drawing.Color.White;
            this.btnLogout.CustomBorderColor = System.Drawing.Color.Transparent;
            this.btnLogout.CustomBorderThickness = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.btnLogout.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnLogout.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnLogout.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnLogout.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnLogout.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(248)))), ((int)(((byte)(255)))));
            this.btnLogout.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnLogout.ForeColor = System.Drawing.Color.Black;
            this.btnLogout.Image = global::DoAnCuoiKy.Properties.Resources._15;
            this.btnLogout.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnLogout.Location = new System.Drawing.Point(0, 622);
            this.btnLogout.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(195, 62);
            this.btnLogout.TabIndex = 25;
            this.btnLogout.Text = "Log out";
            this.btnLogout.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // btnHome
            // 
            this.btnHome.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.btnHome.CheckedState.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnHome.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnHome.CheckedState.ForeColor = System.Drawing.Color.White;
            this.btnHome.CheckedState.Image = global::DoAnCuoiKy.Properties.Resources._25;
            this.btnHome.CustomBorderColor = System.Drawing.Color.Transparent;
            this.btnHome.CustomBorderThickness = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.btnHome.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnHome.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnHome.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnHome.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnHome.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(248)))), ((int)(((byte)(255)))));
            this.btnHome.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnHome.ForeColor = System.Drawing.Color.Black;
            this.btnHome.Image = global::DoAnCuoiKy.Properties.Resources._18;
            this.btnHome.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnHome.Location = new System.Drawing.Point(0, 172);
            this.btnHome.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnHome.Name = "btnHome";
            this.btnHome.Size = new System.Drawing.Size(195, 62);
            this.btnHome.TabIndex = 24;
            this.btnHome.Text = "Information";
            this.btnHome.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnHome.Click += new System.EventHandler(this.btnHome_Click);
            // 
            // btnFavApplicants
            // 
            this.btnFavApplicants.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.btnFavApplicants.CheckedState.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnFavApplicants.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnFavApplicants.CheckedState.ForeColor = System.Drawing.Color.White;
            this.btnFavApplicants.CheckedState.Image = global::DoAnCuoiKy.Properties.Resources._981;
            this.btnFavApplicants.CustomBorderColor = System.Drawing.Color.Transparent;
            this.btnFavApplicants.CustomBorderThickness = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.btnFavApplicants.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnFavApplicants.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnFavApplicants.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnFavApplicants.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnFavApplicants.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(248)))), ((int)(((byte)(255)))));
            this.btnFavApplicants.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnFavApplicants.ForeColor = System.Drawing.Color.Black;
            this.btnFavApplicants.Image = global::DoAnCuoiKy.Properties.Resources.bookmark;
            this.btnFavApplicants.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnFavApplicants.Location = new System.Drawing.Point(0, 372);
            this.btnFavApplicants.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnFavApplicants.Name = "btnFavApplicants";
            this.btnFavApplicants.Size = new System.Drawing.Size(195, 62);
            this.btnFavApplicants.TabIndex = 23;
            this.btnFavApplicants.Text = "Favorite Applicants";
            this.btnFavApplicants.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnFavApplicants.Click += new System.EventHandler(this.btnFavApplicants_Click);
            // 
            // btnApplicants
            // 
            this.btnApplicants.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.btnApplicants.CheckedState.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnApplicants.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnApplicants.CheckedState.ForeColor = System.Drawing.Color.White;
            this.btnApplicants.CheckedState.Image = global::DoAnCuoiKy.Properties.Resources._23;
            this.btnApplicants.CustomBorderColor = System.Drawing.Color.Transparent;
            this.btnApplicants.CustomBorderThickness = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.btnApplicants.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnApplicants.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnApplicants.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnApplicants.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnApplicants.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(248)))), ((int)(((byte)(255)))));
            this.btnApplicants.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnApplicants.ForeColor = System.Drawing.Color.Black;
            this.btnApplicants.Image = global::DoAnCuoiKy.Properties.Resources._22;
            this.btnApplicants.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnApplicants.Location = new System.Drawing.Point(0, 306);
            this.btnApplicants.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnApplicants.Name = "btnApplicants";
            this.btnApplicants.Size = new System.Drawing.Size(195, 62);
            this.btnApplicants.TabIndex = 22;
            this.btnApplicants.Text = "Applicants";
            this.btnApplicants.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnApplicants.Click += new System.EventHandler(this.btnApplicants_Click);
            // 
            // btnJobs
            // 
            this.btnJobs.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.btnJobs.CheckedState.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnJobs.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnJobs.CheckedState.ForeColor = System.Drawing.Color.White;
            this.btnJobs.CheckedState.Image = global::DoAnCuoiKy.Properties.Resources._21;
            this.btnJobs.CustomBorderColor = System.Drawing.Color.Transparent;
            this.btnJobs.CustomBorderThickness = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.btnJobs.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnJobs.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnJobs.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnJobs.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnJobs.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(248)))), ((int)(((byte)(255)))));
            this.btnJobs.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnJobs.ForeColor = System.Drawing.Color.Black;
            this.btnJobs.Image = global::DoAnCuoiKy.Properties.Resources._20;
            this.btnJobs.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnJobs.Location = new System.Drawing.Point(0, 239);
            this.btnJobs.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnJobs.Name = "btnJobs";
            this.btnJobs.Size = new System.Drawing.Size(195, 62);
            this.btnJobs.TabIndex = 21;
            this.btnJobs.Text = "Jobs";
            this.btnJobs.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnJobs.Click += new System.EventHandler(this.btnJobs_Click);
            // 
            // btnPostAJob
            // 
            this.btnPostAJob.AutoRoundedCorners = true;
            this.btnPostAJob.BackColor = System.Drawing.Color.Transparent;
            this.btnPostAJob.BorderRadius = 28;
            this.btnPostAJob.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnPostAJob.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnPostAJob.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnPostAJob.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnPostAJob.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnPostAJob.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnPostAJob.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnPostAJob.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPostAJob.ForeColor = System.Drawing.Color.White;
            this.btnPostAJob.Image = global::DoAnCuoiKy.Properties.Resources._17;
            this.btnPostAJob.Location = new System.Drawing.Point(3, 62);
            this.btnPostAJob.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnPostAJob.Name = "btnPostAJob";
            this.btnPostAJob.ShadowDecoration.BorderRadius = 15;
            this.btnPostAJob.ShadowDecoration.Color = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnPostAJob.ShadowDecoration.Depth = 20;
            this.btnPostAJob.ShadowDecoration.Enabled = true;
            this.btnPostAJob.ShadowDecoration.Shadow = new System.Windows.Forms.Padding(2);
            this.btnPostAJob.Size = new System.Drawing.Size(188, 59);
            this.btnPostAJob.TabIndex = 20;
            this.btnPostAJob.Text = "Post a job";
            this.btnPostAJob.Click += new System.EventHandler(this.btnPostAJob_Click);
            // 
            // guna2Elipse1
            // 
            this.guna2Elipse1.BorderRadius = 15;
            // 
            // FTrangChuCongTy
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1808, 1088);
            this.Controls.Add(this.pnlContent);
            this.Controls.Add(this.guna2Panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FTrangChuCongTy";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FTrangChuCongTy";
            this.guna2Panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2DragControl guna2DragControl1;
        private Guna.UI2.WinForms.Guna2ShadowForm guna2ShadowForm1;
        private Guna.UI2.WinForms.Guna2GradientButton btnPostAJob;
        private Guna.UI2.WinForms.Guna2Button btnFavApplicants;
        private Guna.UI2.WinForms.Guna2Button btnApplicants;
        private Guna.UI2.WinForms.Guna2Button btnJobs;
        private Guna.UI2.WinForms.Guna2Panel pnlContent;
        private Guna.UI2.WinForms.Guna2Button btnHome;
        private Guna.UI2.WinForms.Guna2Button btnLogout;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel2;
        private Guna.UI2.WinForms.Guna2Button btnInvitedApp;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private Guna.UI2.WinForms.Guna2Button btnForum;
    }
}