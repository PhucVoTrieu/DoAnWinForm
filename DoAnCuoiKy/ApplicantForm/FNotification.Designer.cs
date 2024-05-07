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
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(11, 14);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(260, 41);
            this.label4.TabIndex = 34;
            this.label4.Text = "Your Notification";
            // 
            // pnlNote
            // 
            this.pnlNote.AutoScroll = true;
            this.pnlNote.Location = new System.Drawing.Point(7, 68);
            this.pnlNote.Margin = new System.Windows.Forms.Padding(4);
            this.pnlNote.Name = "pnlNote";
            this.pnlNote.Size = new System.Drawing.Size(1544, 790);
            this.pnlNote.TabIndex = 35;
            // 
            // btnCountNote
            // 
            this.btnCountNote.AutoRoundedCorners = true;
            this.btnCountNote.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(237)))), ((int)(((byte)(142)))));
            this.btnCountNote.BorderRadius = 22;
            this.btnCountNote.BorderThickness = 1;
            this.btnCountNote.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnCountNote.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnCountNote.DisabledState.FillColor = System.Drawing.Color.White;
            this.btnCountNote.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(237)))), ((int)(((byte)(142)))));
            this.btnCountNote.Enabled = false;
            this.btnCountNote.FillColor = System.Drawing.Color.Transparent;
            this.btnCountNote.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCountNote.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(237)))), ((int)(((byte)(142)))));
            this.btnCountNote.Location = new System.Drawing.Point(311, 13);
            this.btnCountNote.Margin = new System.Windows.Forms.Padding(4);
            this.btnCountNote.Name = "btnCountNote";
            this.btnCountNote.Size = new System.Drawing.Size(108, 46);
            this.btnCountNote.TabIndex = 36;
            this.btnCountNote.Text = "3";
            // 
            // FNotification
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(99)))), ((int)(((byte)(124)))));
            this.ClientSize = new System.Drawing.Size(1558, 885);
            this.Controls.Add(this.btnCountNote);
            this.Controls.Add(this.pnlNote);
            this.Controls.Add(this.label4);
            this.Name = "FNotification";
            this.Text = "FNotification";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label4;
        public System.Windows.Forms.FlowLayoutPanel pnlNote;
        private Guna.UI2.WinForms.Guna2Button btnCountNote;
    }
}