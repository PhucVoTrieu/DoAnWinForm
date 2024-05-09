namespace DoAnCuoiKy
{
    partial class FFindingCandidate
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
            this.btnSearch = new Guna.UI2.WinForms.Guna2Button();
            this.label1 = new System.Windows.Forms.Label();
            this.PnlFinding = new Guna.UI2.WinForms.Guna2Panel();
            this.cbxLocation = new Guna.UI2.WinForms.Guna2ComboBox();
            this.txtJobName = new Guna.UI2.WinForms.Guna2TextBox();
            this.guna2CircleButton1 = new Guna.UI2.WinForms.Guna2CircleButton();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.pnlJobFilter = new Guna.UI2.WinForms.Guna2Panel();
            this.label8 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.trackbarSalary = new Guna.UI2.WinForms.Guna2TrackBar();
            this.checkboxTemporary = new Guna.UI2.WinForms.Guna2CheckBox();
            this.checkboxFullTime = new Guna.UI2.WinForms.Guna2CheckBox();
            this.label7 = new System.Windows.Forms.Label();
            this.checkboxPartTime = new Guna.UI2.WinForms.Guna2CheckBox();
            this.checkbox5To10 = new Guna.UI2.WinForms.Guna2CheckBox();
            this.checkboxLessThan3 = new Guna.UI2.WinForms.Guna2CheckBox();
            this.checkbox3To5 = new Guna.UI2.WinForms.Guna2CheckBox();
            this.label6 = new System.Windows.Forms.Label();
            this.PnlRecommendJobs = new System.Windows.Forms.FlowLayoutPanel();
            this.pnlViewProfile = new Guna.UI2.WinForms.Guna2Panel();
            this.FormFindingCandidateElipse = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.FindingBoxElipse = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.ViewProfileElipse = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.JobFilterElipse = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.RecommendJobsElipse = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.ScrollBar1 = new Guna.UI2.WinForms.Guna2VScrollBar();
            this.guna2PictureBox1 = new Guna.UI2.WinForms.Guna2PictureBox();
            this.guna2CirclePictureBox1 = new Guna.UI2.WinForms.Guna2CirclePictureBox();
            this.PnlFinding.SuspendLayout();
            this.pnlJobFilter.SuspendLayout();
            this.pnlViewProfile.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.guna2CirclePictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSearch
            // 
            this.btnSearch.AutoRoundedCorners = true;
            this.btnSearch.BorderRadius = 21;
            this.btnSearch.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnSearch.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnSearch.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnSearch.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnSearch.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(60)))), ((int)(((byte)(89)))));
            this.btnSearch.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnSearch.ForeColor = System.Drawing.Color.White;
            this.btnSearch.Location = new System.Drawing.Point(729, 86);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(131, 45);
            this.btnSearch.TabIndex = 5;
            this.btnSearch.Text = "Search";
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(202, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(658, 50);
            this.label1.TabIndex = 0;
            this.label1.Text = "Find And Get Your Dream Job Here...\r\n";
            // 
            // PnlFinding
            // 
            this.PnlFinding.BackColor = System.Drawing.Color.White;
            this.PnlFinding.Controls.Add(this.cbxLocation);
            this.PnlFinding.Controls.Add(this.btnSearch);
            this.PnlFinding.Controls.Add(this.txtJobName);
            this.PnlFinding.Controls.Add(this.label1);
            this.PnlFinding.Location = new System.Drawing.Point(12, 88);
            this.PnlFinding.Name = "PnlFinding";
            this.PnlFinding.Size = new System.Drawing.Size(964, 154);
            this.PnlFinding.TabIndex = 20;
            // 
            // cbxLocation
            // 
            this.cbxLocation.AutoRoundedCorners = true;
            this.cbxLocation.BackColor = System.Drawing.Color.Transparent;
            this.cbxLocation.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(60)))), ((int)(((byte)(89)))));
            this.cbxLocation.BorderRadius = 21;
            this.cbxLocation.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbxLocation.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxLocation.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbxLocation.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbxLocation.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cbxLocation.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cbxLocation.ItemHeight = 39;
            this.cbxLocation.Items.AddRange(new object[] {
            "",
            "Ha Noi",
            "Ho Chi Minh",
            "Hai Phong",
            "LonDon",
            "Berlin"});
            this.cbxLocation.Location = new System.Drawing.Point(574, 86);
            this.cbxLocation.Name = "cbxLocation";
            this.cbxLocation.Size = new System.Drawing.Size(149, 45);
            this.cbxLocation.StartIndex = 0;
            this.cbxLocation.TabIndex = 6;
            // 
            // txtJobName
            // 
            this.txtJobName.AutoRoundedCorners = true;
            this.txtJobName.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(60)))), ((int)(((byte)(89)))));
            this.txtJobName.BorderRadius = 21;
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
            this.txtJobName.Location = new System.Drawing.Point(211, 86);
            this.txtJobName.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtJobName.Name = "txtJobName";
            this.txtJobName.PasswordChar = '\0';
            this.txtJobName.PlaceholderText = "Search jobs by name and location";
            this.txtJobName.SelectedText = "";
            this.txtJobName.Size = new System.Drawing.Size(357, 44);
            this.txtJobName.TabIndex = 1;
            // 
            // guna2CircleButton1
            // 
            this.guna2CircleButton1.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2CircleButton1.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2CircleButton1.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2CircleButton1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2CircleButton1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2CircleButton1.ForeColor = System.Drawing.Color.White;
            this.guna2CircleButton1.Location = new System.Drawing.Point(316, 155);
            this.guna2CircleButton1.Name = "guna2CircleButton1";
            this.guna2CircleButton1.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.guna2CircleButton1.Size = new System.Drawing.Size(0, 0);
            this.guna2CircleButton1.TabIndex = 19;
            this.guna2CircleButton1.Text = "guna2CircleButton1";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(22, 101);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(164, 25);
            this.label3.TabIndex = 2;
            this.label3.Text = "James Maddision";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(99)))), ((int)(((byte)(124)))));
            this.label2.Location = new System.Drawing.Point(35, 126);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(139, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Senior UI/UX Designer";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(975, 257);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(120, 32);
            this.label5.TabIndex = 25;
            this.label5.Text = "Job Filter";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(4, 257);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(215, 32);
            this.label4.TabIndex = 24;
            this.label4.Text = "Recommend Jobs";
            // 
            // pnlJobFilter
            // 
            this.pnlJobFilter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(114)))), ((int)(((byte)(137)))));
            this.pnlJobFilter.Controls.Add(this.label8);
            this.pnlJobFilter.Controls.Add(this.label13);
            this.pnlJobFilter.Controls.Add(this.label12);
            this.pnlJobFilter.Controls.Add(this.trackbarSalary);
            this.pnlJobFilter.Controls.Add(this.checkboxTemporary);
            this.pnlJobFilter.Controls.Add(this.checkboxFullTime);
            this.pnlJobFilter.Controls.Add(this.label7);
            this.pnlJobFilter.Controls.Add(this.checkboxPartTime);
            this.pnlJobFilter.Controls.Add(this.checkbox5To10);
            this.pnlJobFilter.Controls.Add(this.checkboxLessThan3);
            this.pnlJobFilter.Controls.Add(this.checkbox3To5);
            this.pnlJobFilter.Controls.Add(this.label6);
            this.pnlJobFilter.Location = new System.Drawing.Point(982, 300);
            this.pnlJobFilter.Name = "pnlJobFilter";
            this.pnlJobFilter.Size = new System.Drawing.Size(208, 452);
            this.pnlJobFilter.TabIndex = 23;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(25, 244);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(128, 25);
            this.label8.TabIndex = 36;
            this.label8.Text = "Salary Range";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(141, 288);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(37, 13);
            this.label13.TabIndex = 35;
            this.label13.Text = "5000$";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(27, 288);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(19, 13);
            this.label12.TabIndex = 34;
            this.label12.Text = "0$";
            // 
            // trackbarSalary
            // 
            this.trackbarSalary.FillColor = System.Drawing.Color.White;
            this.trackbarSalary.Location = new System.Drawing.Point(30, 294);
            this.trackbarSalary.Name = "trackbarSalary";
            this.trackbarSalary.Size = new System.Drawing.Size(148, 31);
            this.trackbarSalary.TabIndex = 33;
            this.trackbarSalary.ThumbColor = System.Drawing.Color.Black;
            // 
            // checkboxTemporary
            // 
            this.checkboxTemporary.AutoSize = true;
            this.checkboxTemporary.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(114)))), ((int)(((byte)(137)))));
            this.checkboxTemporary.CheckedState.BorderRadius = 0;
            this.checkboxTemporary.CheckedState.BorderThickness = 0;
            this.checkboxTemporary.CheckedState.FillColor = System.Drawing.Color.White;
            this.checkboxTemporary.CheckMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(114)))), ((int)(((byte)(137)))));
            this.checkboxTemporary.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.checkboxTemporary.Location = new System.Drawing.Point(30, 217);
            this.checkboxTemporary.Name = "checkboxTemporary";
            this.checkboxTemporary.Size = new System.Drawing.Size(90, 21);
            this.checkboxTemporary.TabIndex = 32;
            this.checkboxTemporary.Text = "Temporary";
            this.checkboxTemporary.UncheckedState.BorderColor = System.Drawing.Color.White;
            this.checkboxTemporary.UncheckedState.BorderRadius = 0;
            this.checkboxTemporary.UncheckedState.BorderThickness = 1;
            this.checkboxTemporary.UncheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(114)))), ((int)(((byte)(137)))));
            // 
            // checkboxFullTime
            // 
            this.checkboxFullTime.AutoSize = true;
            this.checkboxFullTime.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(114)))), ((int)(((byte)(137)))));
            this.checkboxFullTime.CheckedState.BorderRadius = 0;
            this.checkboxFullTime.CheckedState.BorderThickness = 0;
            this.checkboxFullTime.CheckedState.FillColor = System.Drawing.Color.White;
            this.checkboxFullTime.CheckMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(114)))), ((int)(((byte)(137)))));
            this.checkboxFullTime.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.checkboxFullTime.Location = new System.Drawing.Point(30, 190);
            this.checkboxFullTime.Name = "checkboxFullTime";
            this.checkboxFullTime.Size = new System.Drawing.Size(76, 21);
            this.checkboxFullTime.TabIndex = 31;
            this.checkboxFullTime.Text = "Full-time";
            this.checkboxFullTime.UncheckedState.BorderColor = System.Drawing.Color.White;
            this.checkboxFullTime.UncheckedState.BorderRadius = 0;
            this.checkboxFullTime.UncheckedState.BorderThickness = 1;
            this.checkboxFullTime.UncheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(114)))), ((int)(((byte)(137)))));
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(18, 132);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(88, 25);
            this.label7.TabIndex = 30;
            this.label7.Text = "Job type";
            // 
            // checkboxPartTime
            // 
            this.checkboxPartTime.AutoSize = true;
            this.checkboxPartTime.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(114)))), ((int)(((byte)(137)))));
            this.checkboxPartTime.CheckedState.BorderRadius = 0;
            this.checkboxPartTime.CheckedState.BorderThickness = 0;
            this.checkboxPartTime.CheckedState.FillColor = System.Drawing.Color.White;
            this.checkboxPartTime.CheckMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(114)))), ((int)(((byte)(137)))));
            this.checkboxPartTime.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.checkboxPartTime.Location = new System.Drawing.Point(30, 163);
            this.checkboxPartTime.Name = "checkboxPartTime";
            this.checkboxPartTime.Size = new System.Drawing.Size(80, 21);
            this.checkboxPartTime.TabIndex = 29;
            this.checkboxPartTime.Text = "Part-time";
            this.checkboxPartTime.UncheckedState.BorderColor = System.Drawing.Color.White;
            this.checkboxPartTime.UncheckedState.BorderRadius = 0;
            this.checkboxPartTime.UncheckedState.BorderThickness = 1;
            this.checkboxPartTime.UncheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(114)))), ((int)(((byte)(137)))));
            // 
            // checkbox5To10
            // 
            this.checkbox5To10.AutoSize = true;
            this.checkbox5To10.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(114)))), ((int)(((byte)(137)))));
            this.checkbox5To10.CheckedState.BorderRadius = 0;
            this.checkbox5To10.CheckedState.BorderThickness = 0;
            this.checkbox5To10.CheckedState.FillColor = System.Drawing.Color.White;
            this.checkbox5To10.CheckMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(114)))), ((int)(((byte)(137)))));
            this.checkbox5To10.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.checkbox5To10.Location = new System.Drawing.Point(30, 105);
            this.checkbox5To10.Name = "checkbox5To10";
            this.checkbox5To10.Size = new System.Drawing.Size(61, 21);
            this.checkbox5To10.TabIndex = 28;
            this.checkbox5To10.Text = "5 - 10";
            this.checkbox5To10.UncheckedState.BorderColor = System.Drawing.Color.White;
            this.checkbox5To10.UncheckedState.BorderRadius = 0;
            this.checkbox5To10.UncheckedState.BorderThickness = 1;
            this.checkbox5To10.UncheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(114)))), ((int)(((byte)(137)))));
            // 
            // checkboxLessThan3
            // 
            this.checkboxLessThan3.AutoSize = true;
            this.checkboxLessThan3.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(114)))), ((int)(((byte)(137)))));
            this.checkboxLessThan3.CheckedState.BorderRadius = 0;
            this.checkboxLessThan3.CheckedState.BorderThickness = 0;
            this.checkboxLessThan3.CheckedState.FillColor = System.Drawing.Color.White;
            this.checkboxLessThan3.CheckMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(114)))), ((int)(((byte)(137)))));
            this.checkboxLessThan3.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.checkboxLessThan3.Location = new System.Drawing.Point(30, 51);
            this.checkboxLessThan3.Name = "checkboxLessThan3";
            this.checkboxLessThan3.Size = new System.Drawing.Size(92, 21);
            this.checkboxLessThan3.TabIndex = 0;
            this.checkboxLessThan3.Text = "Less than 3";
            this.checkboxLessThan3.UncheckedState.BorderColor = System.Drawing.Color.White;
            this.checkboxLessThan3.UncheckedState.BorderRadius = 0;
            this.checkboxLessThan3.UncheckedState.BorderThickness = 1;
            this.checkboxLessThan3.UncheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(114)))), ((int)(((byte)(137)))));
            // 
            // checkbox3To5
            // 
            this.checkbox3To5.AutoSize = true;
            this.checkbox3To5.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(114)))), ((int)(((byte)(137)))));
            this.checkbox3To5.CheckedState.BorderRadius = 0;
            this.checkbox3To5.CheckedState.BorderThickness = 0;
            this.checkbox3To5.CheckedState.FillColor = System.Drawing.Color.White;
            this.checkbox3To5.CheckMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(114)))), ((int)(((byte)(137)))));
            this.checkbox3To5.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.checkbox3To5.Location = new System.Drawing.Point(30, 78);
            this.checkbox3To5.Name = "checkbox3To5";
            this.checkbox3To5.Size = new System.Drawing.Size(54, 21);
            this.checkbox3To5.TabIndex = 27;
            this.checkbox3To5.Text = "3 - 5";
            this.checkbox3To5.UncheckedState.BorderColor = System.Drawing.Color.White;
            this.checkbox3To5.UncheckedState.BorderRadius = 0;
            this.checkbox3To5.UncheckedState.BorderThickness = 1;
            this.checkbox3To5.UncheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(114)))), ((int)(((byte)(137)))));
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(18, 20);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(160, 25);
            this.label6.TabIndex = 26;
            this.label6.Text = "Experience Years";
            // 
            // PnlRecommendJobs
            // 
            this.PnlRecommendJobs.AutoScroll = true;
            this.PnlRecommendJobs.Location = new System.Drawing.Point(12, 300);
            this.PnlRecommendJobs.Name = "PnlRecommendJobs";
            this.PnlRecommendJobs.Size = new System.Drawing.Size(964, 452);
            this.PnlRecommendJobs.TabIndex = 22;
            this.PnlRecommendJobs.MouseDown += new System.Windows.Forms.MouseEventHandler(this.PnlRecommendJobs_MouseDown);
            this.PnlRecommendJobs.MouseEnter += new System.EventHandler(this.PnlRecommendJobs_MouseEnter);
            // 
            // pnlViewProfile
            // 
            this.pnlViewProfile.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(237)))), ((int)(((byte)(142)))));
            this.pnlViewProfile.Controls.Add(this.label3);
            this.pnlViewProfile.Controls.Add(this.label2);
            this.pnlViewProfile.Location = new System.Drawing.Point(982, 88);
            this.pnlViewProfile.Name = "pnlViewProfile";
            this.pnlViewProfile.Size = new System.Drawing.Size(208, 154);
            this.pnlViewProfile.TabIndex = 21;
            // 
            // FormFindingCandidateElipse
            // 
            this.FormFindingCandidateElipse.BorderRadius = 30;
            this.FormFindingCandidateElipse.TargetControl = this;
            // 
            // FindingBoxElipse
            // 
            this.FindingBoxElipse.BorderRadius = 20;
            this.FindingBoxElipse.TargetControl = this.PnlFinding;
            // 
            // ViewProfileElipse
            // 
            this.ViewProfileElipse.BorderRadius = 20;
            this.ViewProfileElipse.TargetControl = this.pnlViewProfile;
            // 
            // JobFilterElipse
            // 
            this.JobFilterElipse.BorderRadius = 20;
            this.JobFilterElipse.TargetControl = this.pnlJobFilter;
            // 
            // RecommendJobsElipse
            // 
            this.RecommendJobsElipse.BorderRadius = 15;
            this.RecommendJobsElipse.TargetControl = this.PnlRecommendJobs;
            // 
            // ScrollBar1
            // 
            this.ScrollBar1.AutoRoundedCorners = true;
            this.ScrollBar1.AutoScroll = true;
            this.ScrollBar1.BindingContainer = this.PnlRecommendJobs;
            this.ScrollBar1.BorderRadius = 8;
            this.ScrollBar1.InUpdate = false;
            this.ScrollBar1.LargeChange = 10;
            this.ScrollBar1.Location = new System.Drawing.Point(958, 300);
            this.ScrollBar1.Name = "ScrollBar1";
            this.ScrollBar1.ScrollbarSize = 18;
            this.ScrollBar1.Size = new System.Drawing.Size(18, 452);
            this.ScrollBar1.TabIndex = 0;
            // 
            // guna2PictureBox1
            // 
            this.guna2PictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.guna2PictureBox1.Image = global::DoAnCuoiKy.Properties.Resources._865;
            this.guna2PictureBox1.ImageRotate = 0F;
            this.guna2PictureBox1.Location = new System.Drawing.Point(24, 8);
            this.guna2PictureBox1.Name = "guna2PictureBox1";
            this.guna2PictureBox1.Size = new System.Drawing.Size(214, 234);
            this.guna2PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.guna2PictureBox1.TabIndex = 18;
            this.guna2PictureBox1.TabStop = false;
            this.guna2PictureBox1.UseTransparentBackground = true;
            // 
            // guna2CirclePictureBox1
            // 
            this.guna2CirclePictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.guna2CirclePictureBox1.FillColor = System.Drawing.Color.Transparent;
            this.guna2CirclePictureBox1.Image = global::DoAnCuoiKy.Properties.Resources._293;
            this.guna2CirclePictureBox1.ImageRotate = 0F;
            this.guna2CirclePictureBox1.Location = new System.Drawing.Point(1035, 88);
            this.guna2CirclePictureBox1.Name = "guna2CirclePictureBox1";
            this.guna2CirclePictureBox1.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.guna2CirclePictureBox1.Size = new System.Drawing.Size(103, 103);
            this.guna2CirclePictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.guna2CirclePictureBox1.TabIndex = 17;
            this.guna2CirclePictureBox1.TabStop = false;
            this.guna2CirclePictureBox1.UseTransparentBackground = true;
            // 
            // FFindingCandidate
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(99)))), ((int)(((byte)(124)))));
            this.ClientSize = new System.Drawing.Size(1216, 718);
            this.Controls.Add(this.ScrollBar1);
            this.Controls.Add(this.guna2PictureBox1);
            this.Controls.Add(this.guna2CirclePictureBox1);
            this.Controls.Add(this.guna2CircleButton1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.pnlJobFilter);
            this.Controls.Add(this.PnlRecommendJobs);
            this.Controls.Add(this.pnlViewProfile);
            this.Controls.Add(this.PnlFinding);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FFindingCandidate";
            this.Text = "FFindingCandidate";
            this.PnlFinding.ResumeLayout(false);
            this.PnlFinding.PerformLayout();
            this.pnlJobFilter.ResumeLayout(false);
            this.pnlJobFilter.PerformLayout();
            this.pnlViewProfile.ResumeLayout(false);
            this.pnlViewProfile.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.guna2CirclePictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

       public  Guna.UI2.WinForms.Guna2CirclePictureBox guna2CirclePictureBox1;
       public  Guna.UI2.WinForms.Guna2Button btnSearch;
       public  Guna.UI2.WinForms.Guna2TextBox txtJobName;
       public  System.Windows.Forms.Label label1;
       public  Guna.UI2.WinForms.Guna2Panel PnlFinding;
       public  Guna.UI2.WinForms.Guna2CircleButton guna2CircleButton1;
       public  System.Windows.Forms.Label label3;
       public  Guna.UI2.WinForms.Guna2PictureBox guna2PictureBox1;
       public  System.Windows.Forms.Label label2;
       public  System.Windows.Forms.Label label5;
       public  System.Windows.Forms.Label label4;
       public  Guna.UI2.WinForms.Guna2Panel pnlJobFilter;
       public System.Windows.Forms.FlowLayoutPanel PnlRecommendJobs;
       public  Guna.UI2.WinForms.Guna2Panel pnlViewProfile;
       public  Guna.UI2.WinForms.Guna2Elipse FormFindingCandidateElipse;
       public  Guna.UI2.WinForms.Guna2Elipse FindingBoxElipse;
       public  Guna.UI2.WinForms.Guna2Elipse ViewProfileElipse;
       public  Guna.UI2.WinForms.Guna2Elipse JobFilterElipse;
       public  Guna.UI2.WinForms.Guna2Elipse RecommendJobsElipse;
       public  System.Windows.Forms.Label label6;
       public  Guna.UI2.WinForms.Guna2CheckBox checkboxLessThan3;
       public  Guna.UI2.WinForms.Guna2CheckBox checkboxTemporary;
       public  Guna.UI2.WinForms.Guna2CheckBox checkboxFullTime;
       public  System.Windows.Forms.Label label7;
       public  Guna.UI2.WinForms.Guna2CheckBox checkboxPartTime;
       public  Guna.UI2.WinForms.Guna2CheckBox checkbox5To10;
       public  Guna.UI2.WinForms.Guna2CheckBox checkbox3To5;
       public  System.Windows.Forms.Label label13;
       public  System.Windows.Forms.Label label12;
       public  Guna.UI2.WinForms.Guna2TrackBar trackbarSalary;
       public  System.Windows.Forms.Label label8;
       public  Guna.UI2.WinForms.Guna2VScrollBar ScrollBar1;
       public  Guna.UI2.WinForms.Guna2ComboBox cbxLocation;
    }
}