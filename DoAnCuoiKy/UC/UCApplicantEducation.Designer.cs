namespace DoAnCuoiKy.UC
{
    partial class UCApplicantEducation
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
            this.guna2Separator1 = new Guna.UI2.WinForms.Guna2Separator();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.lblFromToDate = new System.Windows.Forms.Label();
            this.lblDetails = new System.Windows.Forms.Label();
            this.lblMajor = new System.Windows.Forms.Label();
            this.lblSchool = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // guna2Separator1
            // 
            this.guna2Separator1.Location = new System.Drawing.Point(31, 22);
            this.guna2Separator1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.guna2Separator1.Name = "guna2Separator1";
            this.guna2Separator1.Size = new System.Drawing.Size(1389, 22);
            this.guna2Separator1.TabIndex = 141;
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.Transparent;
            this.btnDelete.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.Font = new System.Drawing.Font("Heebo", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.ForeColor = System.Drawing.Color.Black;
            this.btnDelete.Image = global::DoAnCuoiKy.Properties.Resources.trash2;
            this.btnDelete.Location = new System.Drawing.Point(1374, 46);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(61, 54);
            this.btnDelete.TabIndex = 140;
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
            this.btnEdit.Location = new System.Drawing.Point(1320, 50);
            this.btnEdit.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(48, 46);
            this.btnEdit.TabIndex = 139;
            this.btnEdit.UseVisualStyleBackColor = false;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // lblFromToDate
            // 
            this.lblFromToDate.AutoSize = true;
            this.lblFromToDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblFromToDate.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblFromToDate.Location = new System.Drawing.Point(26, 160);
            this.lblFromToDate.Name = "lblFromToDate";
            this.lblFromToDate.Size = new System.Drawing.Size(121, 25);
            this.lblFromToDate.TabIndex = 137;
            this.lblFromToDate.Text = "From-toDate";
            // 
            // lblDetails
            // 
            this.lblDetails.AutoSize = true;
            this.lblDetails.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblDetails.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblDetails.Location = new System.Drawing.Point(26, 210);
            this.lblDetails.Name = "lblDetails";
            this.lblDetails.Size = new System.Drawing.Size(78, 25);
            this.lblDetails.TabIndex = 136;
            this.lblDetails.Text = "Details";
            // 
            // lblMajor
            // 
            this.lblMajor.AutoSize = true;
            this.lblMajor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblMajor.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblMajor.Location = new System.Drawing.Point(26, 110);
            this.lblMajor.Name = "lblMajor";
            this.lblMajor.Size = new System.Drawing.Size(61, 25);
            this.lblMajor.TabIndex = 135;
            this.lblMajor.Text = "Major";
            // 
            // lblSchool
            // 
            this.lblSchool.AutoSize = true;
            this.lblSchool.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblSchool.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblSchool.Location = new System.Drawing.Point(26, 56);
            this.lblSchool.Name = "lblSchool";
            this.lblSchool.Size = new System.Drawing.Size(94, 29);
            this.lblSchool.TabIndex = 134;
            this.lblSchool.Text = "School";
            // 
            // UCApplicantEducation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.guna2Separator1);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.lblFromToDate);
            this.Controls.Add(this.lblDetails);
            this.Controls.Add(this.lblMajor);
            this.Controls.Add(this.lblSchool);
            this.Name = "UCApplicantEducation";
            this.Size = new System.Drawing.Size(1460, 255);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Separator guna2Separator1;
        public System.Windows.Forms.Button btnDelete;
        public System.Windows.Forms.Button btnEdit;
        public System.Windows.Forms.Label lblFromToDate;
        public System.Windows.Forms.Label lblDetails;
        public System.Windows.Forms.Label lblMajor;
        public System.Windows.Forms.Label lblSchool;
    }
}
