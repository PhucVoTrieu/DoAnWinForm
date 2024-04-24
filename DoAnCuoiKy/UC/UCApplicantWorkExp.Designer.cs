namespace DoAnCuoiKy.UC
{
    partial class UCApplicantWorkExp
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
            this.lblCompanyName = new System.Windows.Forms.Label();
            this.lblJobtitle = new System.Windows.Forms.Label();
            this.lblJobDescription = new System.Windows.Forms.Label();
            this.lblFromToDate = new System.Windows.Forms.Label();
            this.lblProjectName = new System.Windows.Forms.Label();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblCompanyName
            // 
            this.lblCompanyName.AutoSize = true;
            this.lblCompanyName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblCompanyName.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblCompanyName.Location = new System.Drawing.Point(17, 49);
            this.lblCompanyName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCompanyName.Name = "lblCompanyName";
            this.lblCompanyName.Size = new System.Drawing.Size(122, 20);
            this.lblCompanyName.TabIndex = 12;
            this.lblCompanyName.Text = "Company Name";
            // 
            // lblJobtitle
            // 
            this.lblJobtitle.AutoSize = true;
            this.lblJobtitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblJobtitle.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblJobtitle.Location = new System.Drawing.Point(17, 12);
            this.lblJobtitle.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblJobtitle.Name = "lblJobtitle";
            this.lblJobtitle.Size = new System.Drawing.Size(90, 24);
            this.lblJobtitle.TabIndex = 11;
            this.lblJobtitle.Text = "Job Title";
            // 
            // lblJobDescription
            // 
            this.lblJobDescription.AutoSize = true;
            this.lblJobDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblJobDescription.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblJobDescription.Location = new System.Drawing.Point(17, 123);
            this.lblJobDescription.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblJobDescription.Name = "lblJobDescription";
            this.lblJobDescription.Size = new System.Drawing.Size(134, 20);
            this.lblJobDescription.TabIndex = 18;
            this.lblJobDescription.Text = "Job Description";
            // 
            // lblFromToDate
            // 
            this.lblFromToDate.AutoSize = true;
            this.lblFromToDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblFromToDate.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblFromToDate.Location = new System.Drawing.Point(17, 86);
            this.lblFromToDate.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblFromToDate.Name = "lblFromToDate";
            this.lblFromToDate.Size = new System.Drawing.Size(100, 20);
            this.lblFromToDate.TabIndex = 19;
            this.lblFromToDate.Text = "From-toDate";
            // 
            // lblProjectName
            // 
            this.lblProjectName.AutoSize = true;
            this.lblProjectName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblProjectName.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblProjectName.Location = new System.Drawing.Point(17, 160);
            this.lblProjectName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblProjectName.Name = "lblProjectName";
            this.lblProjectName.Size = new System.Drawing.Size(92, 20);
            this.lblProjectName.TabIndex = 20;
            this.lblProjectName.Text = "My Project";
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.Transparent;
            this.btnDelete.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.Font = new System.Drawing.Font("Heebo", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.ForeColor = System.Drawing.Color.Black;
            this.btnDelete.Image = global::DoAnCuoiKy.Properties.Resources.trash2;
            this.btnDelete.Location = new System.Drawing.Point(1020, 9);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(2);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(46, 44);
            this.btnDelete.TabIndex = 59;
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.BackColor = System.Drawing.Color.Transparent;
            this.btnEdit.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEdit.Font = new System.Drawing.Font("Heebo", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEdit.ForeColor = System.Drawing.Color.Red;
            this.btnEdit.Image = global::DoAnCuoiKy.Properties.Resources.editing24;
            this.btnEdit.Location = new System.Drawing.Point(980, 12);
            this.btnEdit.Margin = new System.Windows.Forms.Padding(2);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(36, 37);
            this.btnEdit.TabIndex = 58;
            this.btnEdit.UseVisualStyleBackColor = false;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // UCApplicantWorkExp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.lblProjectName);
            this.Controls.Add(this.lblFromToDate);
            this.Controls.Add(this.lblJobDescription);
            this.Controls.Add(this.lblCompanyName);
            this.Controls.Add(this.lblJobtitle);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "UCApplicantWorkExp";
            this.Size = new System.Drawing.Size(1095, 200);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        public System.Windows.Forms.Label lblCompanyName;
        public System.Windows.Forms.Label lblJobtitle;
        public System.Windows.Forms.Label lblJobDescription;
        public System.Windows.Forms.Label lblFromToDate;
        public System.Windows.Forms.Label lblProjectName;
        public System.Windows.Forms.Button btnDelete;
        public System.Windows.Forms.Button btnEdit;
    }
}
