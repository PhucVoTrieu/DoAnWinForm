namespace DoAnCuoiKy.UC
{
    partial class UCForumPost
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.btnInvite = new Guna.UI2.WinForms.Guna2GradientButton();
            this.lblUserName = new System.Windows.Forms.Label();
            this.pnlContent = new System.Windows.Forms.FlowLayoutPanel();
            this.lblContentOfPost = new System.Windows.Forms.Label();
            this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.btnViewProfile = new Guna.UI2.WinForms.Guna2Button();
            this.pboxUserAvatar = new Guna.UI2.WinForms.Guna2CirclePictureBox();
            this.pnlContent.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pboxUserAvatar)).BeginInit();
            this.SuspendLayout();
            // 
            // btnInvite
            // 
            this.btnInvite.BorderRadius = 10;
            this.btnInvite.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnInvite.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnInvite.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnInvite.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnInvite.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnInvite.FillColor = System.Drawing.Color.Black;
            this.btnInvite.FillColor2 = System.Drawing.Color.Black;
            this.btnInvite.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnInvite.ForeColor = System.Drawing.Color.White;
            this.btnInvite.Location = new System.Drawing.Point(766, 41);
            this.btnInvite.Margin = new System.Windows.Forms.Padding(2);
            this.btnInvite.Name = "btnInvite";
            this.btnInvite.Size = new System.Drawing.Size(139, 44);
            this.btnInvite.TabIndex = 32;
            this.btnInvite.Text = "Invite";
            // 
            // lblUserName
            // 
            this.lblUserName.AutoSize = true;
            this.lblUserName.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUserName.Location = new System.Drawing.Point(103, 15);
            this.lblUserName.Name = "lblUserName";
            this.lblUserName.Size = new System.Drawing.Size(141, 32);
            this.lblUserName.TabIndex = 33;
            this.lblUserName.Text = "Your Name";
            // 
            // pnlContent
            // 
            this.pnlContent.AutoSize = true;
            this.pnlContent.BackColor = System.Drawing.Color.White;
            this.pnlContent.Controls.Add(this.lblContentOfPost);
            this.pnlContent.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlContent.Location = new System.Drawing.Point(0, 102);
            this.pnlContent.Name = "pnlContent";
            this.pnlContent.Padding = new System.Windows.Forms.Padding(15, 20, 15, 20);
            this.pnlContent.Size = new System.Drawing.Size(930, 60);
            this.pnlContent.TabIndex = 34;
            // 
            // lblContentOfPost
            // 
            this.lblContentOfPost.AutoSize = true;
            this.lblContentOfPost.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblContentOfPost.Location = new System.Drawing.Point(18, 20);
            this.lblContentOfPost.Name = "lblContentOfPost";
            this.lblContentOfPost.Size = new System.Drawing.Size(477, 20);
            this.lblContentOfPost.TabIndex = 0;
            this.lblContentOfPost.Text = "label1label1label1label1label1label1label1label1label1label1label1label1";
            // 
            // guna2Elipse1
            // 
            this.guna2Elipse1.BorderRadius = 15;
            this.guna2Elipse1.TargetControl = this;
            // 
            // btnViewProfile
            // 
            this.btnViewProfile.AutoRoundedCorners = true;
            this.btnViewProfile.BorderRadius = 12;
            this.btnViewProfile.BorderThickness = 1;
            this.btnViewProfile.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnViewProfile.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnViewProfile.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnViewProfile.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnViewProfile.FillColor = System.Drawing.Color.Transparent;
            this.btnViewProfile.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnViewProfile.ForeColor = System.Drawing.Color.Black;
            this.btnViewProfile.Location = new System.Drawing.Point(109, 58);
            this.btnViewProfile.Name = "btnViewProfile";
            this.btnViewProfile.Size = new System.Drawing.Size(135, 27);
            this.btnViewProfile.TabIndex = 38;
            this.btnViewProfile.Text = "View Profile";
            // 
            // pboxUserAvatar
            // 
            this.pboxUserAvatar.Image = global::DoAnCuoiKy.Properties.Resources._907;
            this.pboxUserAvatar.ImageRotate = 0F;
            this.pboxUserAvatar.Location = new System.Drawing.Point(16, 15);
            this.pboxUserAvatar.Name = "pboxUserAvatar";
            this.pboxUserAvatar.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.pboxUserAvatar.Size = new System.Drawing.Size(70, 70);
            this.pboxUserAvatar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pboxUserAvatar.TabIndex = 0;
            this.pboxUserAvatar.TabStop = false;
            // 
            // UCForumPost
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Cornsilk;
            this.Controls.Add(this.btnViewProfile);
            this.Controls.Add(this.pnlContent);
            this.Controls.Add(this.pboxUserAvatar);
            this.Controls.Add(this.lblUserName);
            this.Controls.Add(this.btnInvite);
            this.Margin = new System.Windows.Forms.Padding(3, 3, 3, 20);
            this.Name = "UCForumPost";
            this.Size = new System.Drawing.Size(930, 162);
            this.pnlContent.ResumeLayout(false);
            this.pnlContent.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pboxUserAvatar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2CirclePictureBox pboxUserAvatar;
        public Guna.UI2.WinForms.Guna2GradientButton btnInvite;
        private System.Windows.Forms.Label lblUserName;
        private System.Windows.Forms.FlowLayoutPanel pnlContent;
        private System.Windows.Forms.Label lblContentOfPost;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private Guna.UI2.WinForms.Guna2Button btnViewProfile;
    }
}
