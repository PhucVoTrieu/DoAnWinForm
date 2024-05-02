namespace DoAnCuoiKy.EmployerForm
{
    partial class FInvitedApplicant
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
            this.cbxLocation = new Guna.UI2.WinForms.Guna2ComboBox();
            this.btnSearch = new Guna.UI2.WinForms.Guna2Button();
            this.txtJobName = new Guna.UI2.WinForms.Guna2TextBox();
            this.btnDelete = new Guna.UI2.WinForms.Guna2Button();
            this.btnCountFavApplicants = new Guna.UI2.WinForms.Guna2Button();
            this.lblFavApplicants = new System.Windows.Forms.Label();
            this.pnlPotentialApplicant = new System.Windows.Forms.FlowLayoutPanel();
            this.SuspendLayout();
            // 
            // cbxLocation
            // 
            this.cbxLocation.BackColor = System.Drawing.Color.Transparent;
            this.cbxLocation.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(60)))), ((int)(((byte)(89)))));
            this.cbxLocation.BorderRadius = 10;
            this.cbxLocation.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbxLocation.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxLocation.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbxLocation.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbxLocation.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.cbxLocation.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cbxLocation.ItemHeight = 46;
            this.cbxLocation.Items.AddRange(new object[] {
            "Ha Noi",
            "Ho Chi Minh",
            "Hai Phong",
            "London",
            "Berlin"});
            this.cbxLocation.Location = new System.Drawing.Point(29, 37);
            this.cbxLocation.Margin = new System.Windows.Forms.Padding(4);
            this.cbxLocation.Name = "cbxLocation";
            this.cbxLocation.Size = new System.Drawing.Size(261, 52);
            this.cbxLocation.StartIndex = 0;
            this.cbxLocation.TabIndex = 46;
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.Color.Transparent;
            this.btnSearch.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.btnSearch.BorderRadius = 10;
            this.btnSearch.BorderThickness = 1;
            this.btnSearch.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnSearch.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnSearch.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnSearch.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnSearch.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.btnSearch.Font = new System.Drawing.Font("Nirmala UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.ForeColor = System.Drawing.Color.White;
            this.btnSearch.Location = new System.Drawing.Point(1015, 37);
            this.btnSearch.Margin = new System.Windows.Forms.Padding(4);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(220, 64);
            this.btnSearch.TabIndex = 45;
            this.btnSearch.Text = "Search";
            // 
            // txtJobName
            // 
            this.txtJobName.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(60)))), ((int)(((byte)(89)))));
            this.txtJobName.BorderRadius = 10;
            this.txtJobName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtJobName.DefaultText = "";
            this.txtJobName.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtJobName.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtJobName.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtJobName.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtJobName.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtJobName.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtJobName.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtJobName.IconLeft = global::DoAnCuoiKy.Properties.Resources._871;
            this.txtJobName.IconLeftOffset = new System.Drawing.Point(5, 0);
            this.txtJobName.Location = new System.Drawing.Point(297, 37);
            this.txtJobName.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtJobName.Name = "txtJobName";
            this.txtJobName.PasswordChar = '\0';
            this.txtJobName.PlaceholderText = "Search jobs by name and location";
            this.txtJobName.SelectedText = "";
            this.txtJobName.Size = new System.Drawing.Size(677, 64);
            this.txtJobName.TabIndex = 44;
            // 
            // btnDelete
            // 
            this.btnDelete.AutoRoundedCorners = true;
            this.btnDelete.BorderRadius = 22;
            this.btnDelete.BorderThickness = 1;
            this.btnDelete.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnDelete.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnDelete.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnDelete.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnDelete.FillColor = System.Drawing.Color.Transparent;
            this.btnDelete.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold);
            this.btnDelete.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(99)))), ((int)(((byte)(124)))));
            this.btnDelete.Location = new System.Drawing.Point(1015, 157);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(4);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(197, 47);
            this.btnDelete.TabIndex = 49;
            this.btnDelete.Text = "Delete";
            // 
            // btnCountFavApplicants
            // 
            this.btnCountFavApplicants.AutoRoundedCorners = true;
            this.btnCountFavApplicants.BorderRadius = 22;
            this.btnCountFavApplicants.BorderThickness = 1;
            this.btnCountFavApplicants.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnCountFavApplicants.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnCountFavApplicants.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnCountFavApplicants.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnCountFavApplicants.Enabled = false;
            this.btnCountFavApplicants.FillColor = System.Drawing.Color.Transparent;
            this.btnCountFavApplicants.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCountFavApplicants.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(99)))), ((int)(((byte)(124)))));
            this.btnCountFavApplicants.Location = new System.Drawing.Point(440, 153);
            this.btnCountFavApplicants.Margin = new System.Windows.Forms.Padding(4);
            this.btnCountFavApplicants.Name = "btnCountFavApplicants";
            this.btnCountFavApplicants.Size = new System.Drawing.Size(108, 46);
            this.btnCountFavApplicants.TabIndex = 48;
            this.btnCountFavApplicants.Text = "3";
            // 
            // lblFavApplicants
            // 
            this.lblFavApplicants.AutoSize = true;
            this.lblFavApplicants.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFavApplicants.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(99)))), ((int)(((byte)(124)))));
            this.lblFavApplicants.Location = new System.Drawing.Point(22, 159);
            this.lblFavApplicants.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblFavApplicants.Name = "lblFavApplicants";
            this.lblFavApplicants.Size = new System.Drawing.Size(304, 32);
            this.lblFavApplicants.TabIndex = 47;
            this.lblFavApplicants.Text = "Your Potential Applicants";
            // 
            // pnlPotentialApplicant
            // 
            this.pnlPotentialApplicant.AutoScroll = true;
            this.pnlPotentialApplicant.Location = new System.Drawing.Point(29, 228);
            this.pnlPotentialApplicant.Margin = new System.Windows.Forms.Padding(4);
            this.pnlPotentialApplicant.Name = "pnlPotentialApplicant";
            this.pnlPotentialApplicant.Size = new System.Drawing.Size(1284, 595);
            this.pnlPotentialApplicant.TabIndex = 50;
            // 
            // FInvitedApplicant
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1343, 845);
            this.Controls.Add(this.pnlPotentialApplicant);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnCountFavApplicants);
            this.Controls.Add(this.lblFavApplicants);
            this.Controls.Add(this.cbxLocation);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.txtJobName);
            this.Name = "FInvitedApplicant";
            this.Text = "FInvitedApplicant";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2ComboBox cbxLocation;
        private Guna.UI2.WinForms.Guna2Button btnSearch;
        private Guna.UI2.WinForms.Guna2TextBox txtJobName;
        public Guna.UI2.WinForms.Guna2Button btnDelete;
        public Guna.UI2.WinForms.Guna2Button btnCountFavApplicants;
        public System.Windows.Forms.Label lblFavApplicants;
        public System.Windows.Forms.FlowLayoutPanel pnlPotentialApplicant;
    }
}