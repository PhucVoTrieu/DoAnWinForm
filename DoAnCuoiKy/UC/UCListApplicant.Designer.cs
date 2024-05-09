namespace DoAnCuoiKy.UC
{
    partial class UCListApplicant
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
            this.pnlJobCreated = new System.Windows.Forms.FlowLayoutPanel();
            this.pnlJobTitle = new System.Windows.Forms.Panel();
            this.btnJobTitle = new Guna.UI2.WinForms.Guna2Button();
            this.pnlJobCreated.SuspendLayout();
            this.pnlJobTitle.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlJobCreated
            // 
            this.pnlJobCreated.BackColor = System.Drawing.Color.Gainsboro;
            this.pnlJobCreated.Controls.Add(this.pnlJobTitle);
            this.pnlJobCreated.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlJobCreated.Location = new System.Drawing.Point(0, 0);
            this.pnlJobCreated.Margin = new System.Windows.Forms.Padding(2);
            this.pnlJobCreated.Name = "pnlJobCreated";
            this.pnlJobCreated.Size = new System.Drawing.Size(675, 47);
            this.pnlJobCreated.TabIndex = 2;
            // 
            // pnlJobTitle
            // 
            this.pnlJobTitle.BackColor = System.Drawing.Color.LightGray;
            this.pnlJobTitle.Controls.Add(this.btnJobTitle);
            this.pnlJobTitle.Location = new System.Drawing.Point(2, 2);
            this.pnlJobTitle.Margin = new System.Windows.Forms.Padding(2);
            this.pnlJobTitle.Name = "pnlJobTitle";
            this.pnlJobTitle.Size = new System.Drawing.Size(670, 43);
            this.pnlJobTitle.TabIndex = 1;
            // 
            // btnJobTitle
            // 
            this.btnJobTitle.BackColor = System.Drawing.Color.Transparent;
            this.btnJobTitle.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.btnJobTitle.BorderRadius = 10;
            this.btnJobTitle.BorderThickness = 1;
            this.btnJobTitle.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.ToogleButton;
            this.btnJobTitle.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnJobTitle.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnJobTitle.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnJobTitle.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnJobTitle.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.btnJobTitle.Font = new System.Drawing.Font("Nirmala UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnJobTitle.ForeColor = System.Drawing.Color.White;
            this.btnJobTitle.Location = new System.Drawing.Point(11, 5);
            this.btnJobTitle.Name = "btnJobTitle";
            this.btnJobTitle.Size = new System.Drawing.Size(645, 32);
            this.btnJobTitle.TabIndex = 101;
            this.btnJobTitle.Text = "JobTitle";
            this.btnJobTitle.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnJobTitle.TextOffset = new System.Drawing.Point(0, -2);
            this.btnJobTitle.CheckedChanged += new System.EventHandler(this.btnJobTitle_CheckedChanged);
            this.btnJobTitle.Click += new System.EventHandler(this.btnJobTitle_Click);
            // 
            // UCListApplicant
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pnlJobCreated);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "UCListApplicant";
            this.Size = new System.Drawing.Size(675, 47);
            this.pnlJobCreated.ResumeLayout(false);
            this.pnlJobTitle.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.FlowLayoutPanel pnlJobCreated;
        public System.Windows.Forms.Panel pnlJobTitle;
        public Guna.UI2.WinForms.Guna2Button btnJobTitle;
    }
}
