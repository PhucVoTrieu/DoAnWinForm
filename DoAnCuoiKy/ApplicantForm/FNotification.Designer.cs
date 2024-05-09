namespace DoAnCuoiKy.ApplicantForm
{
    partial class FNotification
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
            this.label4 = new System.Windows.Forms.Label();
            this.pnlNote = new System.Windows.Forms.FlowLayoutPanel();
            this.btnCountNote = new Guna.UI2.WinForms.Guna2Button();
            this.btnDelete = new Guna.UI2.WinForms.Guna2Button();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(8, 11);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(211, 32);
            this.label4.TabIndex = 34;
            this.label4.Text = "Your Notification";
            // 
            // pnlNote
            // 
            this.pnlNote.AutoScroll = true;
            this.pnlNote.Location = new System.Drawing.Point(5, 55);
            this.pnlNote.Name = "pnlNote";
            this.pnlNote.Size = new System.Drawing.Size(1158, 642);
            this.pnlNote.TabIndex = 35;
            // 
            // btnCountNote
            // 
            this.btnCountNote.AutoRoundedCorners = true;
            this.btnCountNote.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(237)))), ((int)(((byte)(142)))));
            this.btnCountNote.BorderRadius = 17;
            this.btnCountNote.BorderThickness = 1;
            this.btnCountNote.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnCountNote.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnCountNote.DisabledState.FillColor = System.Drawing.Color.White;
            this.btnCountNote.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(237)))), ((int)(((byte)(142)))));
            this.btnCountNote.Enabled = false;
            this.btnCountNote.FillColor = System.Drawing.Color.Transparent;
            this.btnCountNote.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCountNote.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(237)))), ((int)(((byte)(142)))));
            this.btnCountNote.Location = new System.Drawing.Point(233, 11);
            this.btnCountNote.Name = "btnCountNote";
            this.btnCountNote.Size = new System.Drawing.Size(81, 37);
            this.btnCountNote.TabIndex = 36;
            this.btnCountNote.Text = "3";
            // 
            // btnDelete
            // 
            this.btnDelete.AutoRoundedCorners = true;
            this.btnDelete.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(237)))), ((int)(((byte)(142)))));
            this.btnDelete.BorderRadius = 18;
            this.btnDelete.BorderThickness = 1;
            this.btnDelete.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnDelete.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnDelete.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnDelete.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnDelete.FillColor = System.Drawing.Color.Transparent;
            this.btnDelete.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold);
            this.btnDelete.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(237)))), ((int)(((byte)(142)))));
            this.btnDelete.Location = new System.Drawing.Point(863, 10);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(148, 38);
            this.btnDelete.TabIndex = 37;
            this.btnDelete.Text = "Delete";
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // FNotification
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(99)))), ((int)(((byte)(124)))));
            this.ClientSize = new System.Drawing.Size(1168, 719);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnCountNote);
            this.Controls.Add(this.pnlNote);
            this.Controls.Add(this.label4);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FNotification";
            this.Text = "FNotification";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label4;
        public System.Windows.Forms.FlowLayoutPanel pnlNote;
        private Guna.UI2.WinForms.Guna2Button btnCountNote;
        private Guna.UI2.WinForms.Guna2Button btnDelete;
    }
}