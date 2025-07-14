namespace CarRental.People.Employee
{
    partial class frmListEmployees
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            this.lblTitle = new System.Windows.Forms.Label();
            this.cmbDepbartmennt = new Guna.UI2.WinForms.Guna2ComboBox();
            this.cbFilterBy = new Guna.UI2.WinForms.Guna2ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbBranches = new Guna.UI2.WinForms.Guna2ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.lable = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabSalary = new System.Windows.Forms.TabPage();
            this.txtToSalary = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cbSalary = new System.Windows.Forms.CheckBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtFromSalary = new System.Windows.Forms.TextBox();
            this.tabHireDate = new System.Windows.Forms.TabPage();
            this.cbHireDate = new System.Windows.Forms.CheckBox();
            this.dtpToHireDate = new System.Windows.Forms.DateTimePicker();
            this.dtpFromHireDate = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.tabExitDate = new System.Windows.Forms.TabPage();
            this.cbExitDate = new System.Windows.Forms.CheckBox();
            this.dtpToExitDate = new System.Windows.Forms.DateTimePicker();
            this.dtpFromExitDate = new System.Windows.Forms.DateTimePicker();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.tabDepartmentBrach = new System.Windows.Forms.TabPage();
            this.label8 = new System.Windows.Forms.Label();
            this.cmbCityName = new Guna.UI2.WinForms.Guna2ComboBox();
            this.txtFilterValue = new System.Windows.Forms.TextBox();
            this.btnCLose = new Guna.UI2.WinForms.Guna2Button();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvListEmployees = new Guna.UI2.WinForms.Guna2DataGridView();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.updateToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.createUserToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lblRecordsCount = new System.Windows.Forms.Label();
            this.btnAddNew = new Guna.UI2.WinForms.Guna2Button();
            this.tabControl1.SuspendLayout();
            this.tabSalary.SuspendLayout();
            this.tabHireDate.SuspendLayout();
            this.tabExitDate.SuspendLayout();
            this.tabDepartmentBrach.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListEmployees)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblTitle.ForeColor = System.Drawing.Color.Black;
            this.lblTitle.Location = new System.Drawing.Point(0, 0);
            this.lblTitle.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(1454, 51);
            this.lblTitle.TabIndex = 137;
            this.lblTitle.Text = "List Employees";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cmbDepbartmennt
            // 
            this.cmbDepbartmennt.AutoRoundedCorners = true;
            this.cmbDepbartmennt.BackColor = System.Drawing.Color.Transparent;
            this.cmbDepbartmennt.BorderColor = System.Drawing.Color.Black;
            this.cmbDepbartmennt.BorderRadius = 17;
            this.cmbDepbartmennt.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbDepbartmennt.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbDepbartmennt.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cmbDepbartmennt.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cmbDepbartmennt.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F);
            this.cmbDepbartmennt.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cmbDepbartmennt.ItemHeight = 30;
            this.cmbDepbartmennt.Location = new System.Drawing.Point(615, 5);
            this.cmbDepbartmennt.Margin = new System.Windows.Forms.Padding(2);
            this.cmbDepbartmennt.Name = "cmbDepbartmennt";
            this.cmbDepbartmennt.Size = new System.Drawing.Size(158, 36);
            this.cmbDepbartmennt.TabIndex = 161;
            this.cmbDepbartmennt.Tag = "Active Or NotActive ";
            this.cmbDepbartmennt.SelectedIndexChanged += new System.EventHandler(this.txtFilterValue_TextChanged);
            // 
            // cbFilterBy
            // 
            this.cbFilterBy.BackColor = System.Drawing.Color.Transparent;
            this.cbFilterBy.BorderColor = System.Drawing.Color.Black;
            this.cbFilterBy.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbFilterBy.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbFilterBy.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbFilterBy.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbFilterBy.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F);
            this.cbFilterBy.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cbFilterBy.ItemHeight = 30;
            this.cbFilterBy.Items.AddRange(new object[] {
            "None",
            "Employee ID",
            "Full Name",
            "Phone"});
            this.cbFilterBy.Location = new System.Drawing.Point(126, 130);
            this.cbFilterBy.Margin = new System.Windows.Forms.Padding(2);
            this.cbFilterBy.Name = "cbFilterBy";
            this.cbFilterBy.Size = new System.Drawing.Size(173, 36);
            this.cbFilterBy.StartIndex = 0;
            this.cbFilterBy.TabIndex = 160;
            this.cbFilterBy.SelectedIndexChanged += new System.EventHandler(this.cbFilterBy_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(10, 136);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(107, 25);
            this.label2.TabIndex = 158;
            this.label2.Text = "Filter By:";
            // 
            // cmbBranches
            // 
            this.cmbBranches.AutoRoundedCorners = true;
            this.cmbBranches.BackColor = System.Drawing.Color.Transparent;
            this.cmbBranches.BorderColor = System.Drawing.Color.Black;
            this.cmbBranches.BorderRadius = 17;
            this.cmbBranches.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbBranches.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbBranches.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cmbBranches.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cmbBranches.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F);
            this.cmbBranches.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cmbBranches.ItemHeight = 30;
            this.cmbBranches.Location = new System.Drawing.Point(355, 5);
            this.cmbBranches.Margin = new System.Windows.Forms.Padding(2);
            this.cmbBranches.Name = "cmbBranches";
            this.cmbBranches.Size = new System.Drawing.Size(158, 36);
            this.cmbBranches.TabIndex = 164;
            this.cmbBranches.Tag = "Active Or NotActive ";
            this.cmbBranches.SelectedIndexChanged += new System.EventHandler(this.guna2ComboBox1_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(294, 17);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(57, 16);
            this.label5.TabIndex = 241;
            this.label5.Text = "Branch :";
            // 
            // lable
            // 
            this.lable.AutoSize = true;
            this.lable.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lable.ForeColor = System.Drawing.Color.Black;
            this.lable.Location = new System.Drawing.Point(522, 15);
            this.lable.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lable.Name = "lable";
            this.lable.Size = new System.Drawing.Size(89, 16);
            this.lable.TabIndex = 242;
            this.lable.Text = "Department :";
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Controls.Add(this.tabSalary);
            this.tabControl1.Controls.Add(this.tabHireDate);
            this.tabControl1.Controls.Add(this.tabExitDate);
            this.tabControl1.Controls.Add(this.tabDepartmentBrach);
            this.tabControl1.Location = new System.Drawing.Point(649, 98);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(789, 73);
            this.tabControl1.TabIndex = 243;
            // 
            // tabSalary
            // 
            this.tabSalary.Controls.Add(this.txtToSalary);
            this.tabSalary.Controls.Add(this.label3);
            this.tabSalary.Controls.Add(this.cbSalary);
            this.tabSalary.Controls.Add(this.label4);
            this.tabSalary.Controls.Add(this.txtFromSalary);
            this.tabSalary.Location = new System.Drawing.Point(4, 22);
            this.tabSalary.Name = "tabSalary";
            this.tabSalary.Padding = new System.Windows.Forms.Padding(3);
            this.tabSalary.Size = new System.Drawing.Size(781, 47);
            this.tabSalary.TabIndex = 1;
            this.tabSalary.Text = "Salary";
            this.tabSalary.UseVisualStyleBackColor = true;
            // 
            // txtToSalary
            // 
            this.txtToSalary.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtToSalary.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtToSalary.ForeColor = System.Drawing.Color.Black;
            this.txtToSalary.Location = new System.Drawing.Point(282, 10);
            this.txtToSalary.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtToSalary.Multiline = true;
            this.txtToSalary.Name = "txtToSalary";
            this.txtToSalary.Size = new System.Drawing.Size(174, 30);
            this.txtToSalary.TabIndex = 246;
            this.txtToSalary.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtToSalary.TextChanged += new System.EventHandler(this.txtFilterValue_TextChanged);
            this.txtToSalary.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtFromSalary_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(232, 17);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(33, 17);
            this.label3.TabIndex = 244;
            this.label3.Text = "To :";
            // 
            // cbSalary
            // 
            this.cbSalary.AutoSize = true;
            this.cbSalary.Checked = true;
            this.cbSalary.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbSalary.Location = new System.Drawing.Point(475, 17);
            this.cbSalary.Name = "cbSalary";
            this.cbSalary.Size = new System.Drawing.Size(37, 17);
            this.cbSalary.TabIndex = 245;
            this.cbSalary.Text = "All";
            this.cbSalary.UseVisualStyleBackColor = true;
            this.cbSalary.CheckedChanged += new System.EventHandler(this.txtFilterValue_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(5, 16);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 17);
            this.label4.TabIndex = 245;
            this.label4.Text = "From ";
            // 
            // txtFromSalary
            // 
            this.txtFromSalary.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtFromSalary.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtFromSalary.ForeColor = System.Drawing.Color.Black;
            this.txtFromSalary.Location = new System.Drawing.Point(54, 10);
            this.txtFromSalary.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtFromSalary.Multiline = true;
            this.txtFromSalary.Name = "txtFromSalary";
            this.txtFromSalary.Size = new System.Drawing.Size(160, 30);
            this.txtFromSalary.TabIndex = 160;
            this.txtFromSalary.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtFromSalary.TextChanged += new System.EventHandler(this.txtFilterValue_TextChanged);
            this.txtFromSalary.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtFromSalary_KeyPress);
            // 
            // tabHireDate
            // 
            this.tabHireDate.AccessibleRole = System.Windows.Forms.AccessibleRole.OutlineButton;
            this.tabHireDate.Controls.Add(this.cbHireDate);
            this.tabHireDate.Controls.Add(this.dtpToHireDate);
            this.tabHireDate.Controls.Add(this.dtpFromHireDate);
            this.tabHireDate.Controls.Add(this.label6);
            this.tabHireDate.Controls.Add(this.label7);
            this.tabHireDate.Location = new System.Drawing.Point(4, 22);
            this.tabHireDate.Name = "tabHireDate";
            this.tabHireDate.Padding = new System.Windows.Forms.Padding(3);
            this.tabHireDate.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.tabHireDate.Size = new System.Drawing.Size(781, 47);
            this.tabHireDate.TabIndex = 2;
            this.tabHireDate.Text = "Hire Date";
            this.tabHireDate.UseVisualStyleBackColor = true;
            // 
            // cbHireDate
            // 
            this.cbHireDate.AutoSize = true;
            this.cbHireDate.Checked = true;
            this.cbHireDate.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbHireDate.Location = new System.Drawing.Point(412, 16);
            this.cbHireDate.Name = "cbHireDate";
            this.cbHireDate.Size = new System.Drawing.Size(37, 17);
            this.cbHireDate.TabIndex = 247;
            this.cbHireDate.Text = "All";
            this.cbHireDate.UseVisualStyleBackColor = true;
            this.cbHireDate.CheckedChanged += new System.EventHandler(this.txtFilterValue_TextChanged);
            // 
            // dtpToHireDate
            // 
            this.dtpToHireDate.CustomFormat = "yyyy";
            this.dtpToHireDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpToHireDate.Location = new System.Drawing.Point(271, 13);
            this.dtpToHireDate.Margin = new System.Windows.Forms.Padding(2);
            this.dtpToHireDate.MinDate = new System.DateTime(2023, 12, 25, 0, 0, 0, 0);
            this.dtpToHireDate.Name = "dtpToHireDate";
            this.dtpToHireDate.ShowUpDown = true;
            this.dtpToHireDate.Size = new System.Drawing.Size(112, 20);
            this.dtpToHireDate.TabIndex = 249;
            this.dtpToHireDate.Value = new System.DateTime(2024, 3, 16, 0, 0, 0, 0);
            this.dtpToHireDate.ValueChanged += new System.EventHandler(this.txtFilterValue_TextChanged);
            // 
            // dtpFromHireDate
            // 
            this.dtpFromHireDate.CustomFormat = "yyyy";
            this.dtpFromHireDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpFromHireDate.Location = new System.Drawing.Point(102, 13);
            this.dtpFromHireDate.Margin = new System.Windows.Forms.Padding(2);
            this.dtpFromHireDate.MinDate = new System.DateTime(2023, 12, 25, 0, 0, 0, 0);
            this.dtpFromHireDate.Name = "dtpFromHireDate";
            this.dtpFromHireDate.ShowUpDown = true;
            this.dtpFromHireDate.Size = new System.Drawing.Size(112, 20);
            this.dtpFromHireDate.TabIndex = 248;
            this.dtpFromHireDate.Value = new System.DateTime(2024, 3, 16, 0, 0, 0, 0);
            this.dtpFromHireDate.ValueChanged += new System.EventHandler(this.txtFilterValue_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(229, 14);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(29, 17);
            this.label6.TabIndex = 246;
            this.label6.Text = "To ";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(40, 14);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(44, 17);
            this.label7.TabIndex = 247;
            this.label7.Text = "From ";
            // 
            // tabExitDate
            // 
            this.tabExitDate.Controls.Add(this.cbExitDate);
            this.tabExitDate.Controls.Add(this.dtpToExitDate);
            this.tabExitDate.Controls.Add(this.dtpFromExitDate);
            this.tabExitDate.Controls.Add(this.label9);
            this.tabExitDate.Controls.Add(this.label10);
            this.tabExitDate.Location = new System.Drawing.Point(4, 22);
            this.tabExitDate.Name = "tabExitDate";
            this.tabExitDate.Size = new System.Drawing.Size(781, 47);
            this.tabExitDate.TabIndex = 4;
            this.tabExitDate.Text = "Exit Date";
            this.tabExitDate.UseVisualStyleBackColor = true;
            // 
            // cbExitDate
            // 
            this.cbExitDate.AutoSize = true;
            this.cbExitDate.Checked = true;
            this.cbExitDate.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbExitDate.Location = new System.Drawing.Point(439, 16);
            this.cbExitDate.Name = "cbExitDate";
            this.cbExitDate.Size = new System.Drawing.Size(37, 17);
            this.cbExitDate.TabIndex = 251;
            this.cbExitDate.Text = "All";
            this.cbExitDate.UseVisualStyleBackColor = true;
            this.cbExitDate.CheckedChanged += new System.EventHandler(this.txtFilterValue_TextChanged);
            // 
            // dtpToExitDate
            // 
            this.dtpToExitDate.CustomFormat = "yyyy";
            this.dtpToExitDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpToExitDate.Location = new System.Drawing.Point(298, 13);
            this.dtpToExitDate.Margin = new System.Windows.Forms.Padding(2);
            this.dtpToExitDate.MinDate = new System.DateTime(2023, 12, 25, 0, 0, 0, 0);
            this.dtpToExitDate.Name = "dtpToExitDate";
            this.dtpToExitDate.ShowUpDown = true;
            this.dtpToExitDate.Size = new System.Drawing.Size(112, 20);
            this.dtpToExitDate.TabIndex = 254;
            this.dtpToExitDate.Value = new System.DateTime(2024, 3, 16, 0, 0, 0, 0);
            this.dtpToExitDate.ValueChanged += new System.EventHandler(this.txtFilterValue_TextChanged);
            // 
            // dtpFromExitDate
            // 
            this.dtpFromExitDate.CustomFormat = "yyyy";
            this.dtpFromExitDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpFromExitDate.Location = new System.Drawing.Point(129, 13);
            this.dtpFromExitDate.Margin = new System.Windows.Forms.Padding(2);
            this.dtpFromExitDate.MinDate = new System.DateTime(2023, 12, 25, 0, 0, 0, 0);
            this.dtpFromExitDate.Name = "dtpFromExitDate";
            this.dtpFromExitDate.ShowUpDown = true;
            this.dtpFromExitDate.Size = new System.Drawing.Size(112, 20);
            this.dtpFromExitDate.TabIndex = 253;
            this.dtpFromExitDate.Value = new System.DateTime(2024, 3, 16, 0, 0, 0, 0);
            this.dtpFromExitDate.ValueChanged += new System.EventHandler(this.txtFilterValue_TextChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label9.ForeColor = System.Drawing.Color.Black;
            this.label9.Location = new System.Drawing.Point(256, 14);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(29, 17);
            this.label9.TabIndex = 250;
            this.label9.Text = "To ";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label10.ForeColor = System.Drawing.Color.Black;
            this.label10.Location = new System.Drawing.Point(67, 14);
            this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(44, 17);
            this.label10.TabIndex = 252;
            this.label10.Text = "From ";
            // 
            // tabDepartmentBrach
            // 
            this.tabDepartmentBrach.Controls.Add(this.label8);
            this.tabDepartmentBrach.Controls.Add(this.cmbDepbartmennt);
            this.tabDepartmentBrach.Controls.Add(this.cmbCityName);
            this.tabDepartmentBrach.Controls.Add(this.cmbBranches);
            this.tabDepartmentBrach.Controls.Add(this.lable);
            this.tabDepartmentBrach.Controls.Add(this.label5);
            this.tabDepartmentBrach.Location = new System.Drawing.Point(4, 22);
            this.tabDepartmentBrach.Name = "tabDepartmentBrach";
            this.tabDepartmentBrach.Padding = new System.Windows.Forms.Padding(3);
            this.tabDepartmentBrach.Size = new System.Drawing.Size(781, 47);
            this.tabDepartmentBrach.TabIndex = 3;
            this.tabDepartmentBrach.Text = "Department And Brach";
            this.tabDepartmentBrach.UseVisualStyleBackColor = true;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label8.Location = new System.Drawing.Point(35, 17);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(86, 16);
            this.label8.TabIndex = 250;
            this.label8.Text = "City Name :";
            // 
            // cmbCityName
            // 
            this.cmbCityName.AutoRoundedCorners = true;
            this.cmbCityName.BackColor = System.Drawing.Color.Transparent;
            this.cmbCityName.BorderRadius = 17;
            this.cmbCityName.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbCityName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCityName.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cmbCityName.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cmbCityName.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cmbCityName.ForeColor = System.Drawing.Color.Black;
            this.cmbCityName.ItemHeight = 30;
            this.cmbCityName.Items.AddRange(new object[] {
            "All"});
            this.cmbCityName.Location = new System.Drawing.Point(127, 5);
            this.cmbCityName.Name = "cmbCityName";
            this.cmbCityName.Size = new System.Drawing.Size(162, 36);
            this.cmbCityName.StartIndex = 0;
            this.cmbCityName.TabIndex = 249;
            this.cmbCityName.SelectedIndexChanged += new System.EventHandler(this.cmbCityName_SelectedIndexChanged);
            // 
            // txtFilterValue
            // 
            this.txtFilterValue.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtFilterValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtFilterValue.ForeColor = System.Drawing.Color.Black;
            this.txtFilterValue.Location = new System.Drawing.Point(309, 133);
            this.txtFilterValue.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtFilterValue.Multiline = true;
            this.txtFilterValue.Name = "txtFilterValue";
            this.txtFilterValue.Size = new System.Drawing.Size(206, 30);
            this.txtFilterValue.TabIndex = 159;
            this.txtFilterValue.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtFilterValue.Visible = false;
            this.txtFilterValue.TextChanged += new System.EventHandler(this.txtFilterValue_TextChanged);
            this.txtFilterValue.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtFilterValue_KeyPress);
            // 
            // btnCLose
            // 
            this.btnCLose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCLose.AutoRoundedCorners = true;
            this.btnCLose.BorderRadius = 14;
            this.btnCLose.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnCLose.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnCLose.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnCLose.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnCLose.FillColor = System.Drawing.Color.Black;
            this.btnCLose.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnCLose.ForeColor = System.Drawing.Color.White;
            this.btnCLose.Location = new System.Drawing.Point(1309, 469);
            this.btnCLose.Name = "btnCLose";
            this.btnCLose.Size = new System.Drawing.Size(129, 30);
            this.btnCLose.TabIndex = 248;
            this.btnCLose.Text = "Close";
            this.btnCLose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(6, 462);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 20);
            this.label1.TabIndex = 246;
            this.label1.Text = "# Records:";
            // 
            // dgvListEmployees
            // 
            this.dgvListEmployees.AllowUserToAddRows = false;
            this.dgvListEmployees.AllowUserToDeleteRows = false;
            this.dgvListEmployees.AllowUserToResizeRows = false;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.Black;
            this.dgvListEmployees.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle5;
            this.dgvListEmployees.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvListEmployees.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.None;
            this.dgvListEmployees.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvListEmployees.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.dgvListEmployees.ColumnHeadersHeight = 44;
            this.dgvListEmployees.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dgvListEmployees.ContextMenuStrip = this.contextMenuStrip1;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.MediumPurple;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvListEmployees.DefaultCellStyle = dataGridViewCellStyle7;
            this.dgvListEmployees.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvListEmployees.Location = new System.Drawing.Point(15, 176);
            this.dgvListEmployees.Margin = new System.Windows.Forms.Padding(2);
            this.dgvListEmployees.Name = "dgvListEmployees";
            this.dgvListEmployees.ReadOnly = true;
            this.dgvListEmployees.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvListEmployees.RowHeadersDefaultCellStyle = dataGridViewCellStyle8;
            this.dgvListEmployees.RowHeadersVisible = false;
            this.dgvListEmployees.RowHeadersWidth = 51;
            this.dgvListEmployees.RowTemplate.Height = 29;
            this.dgvListEmployees.Size = new System.Drawing.Size(1423, 283);
            this.dgvListEmployees.TabIndex = 245;
            this.dgvListEmployees.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvListEmployees.ThemeStyle.AlternatingRowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dgvListEmployees.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Black;
            this.dgvListEmployees.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvListEmployees.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dgvListEmployees.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.dgvListEmployees.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvListEmployees.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.Black;
            this.dgvListEmployees.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvListEmployees.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dgvListEmployees.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dgvListEmployees.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dgvListEmployees.ThemeStyle.HeaderStyle.Height = 44;
            this.dgvListEmployees.ThemeStyle.ReadOnly = true;
            this.dgvListEmployees.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvListEmployees.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvListEmployees.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dgvListEmployees.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dgvListEmployees.ThemeStyle.RowsStyle.Height = 29;
            this.dgvListEmployees.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvListEmployees.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.updateToolStripMenuItem,
            this.createUserToolStripMenuItem,
            this.deleteToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(135, 70);
            // 
            // updateToolStripMenuItem
            // 
            this.updateToolStripMenuItem.Name = "updateToolStripMenuItem";
            this.updateToolStripMenuItem.Size = new System.Drawing.Size(134, 22);
            this.updateToolStripMenuItem.Text = "Update";
            this.updateToolStripMenuItem.Click += new System.EventHandler(this.updateToolStripMenuItem_Click);
            // 
            // createUserToolStripMenuItem
            // 
            this.createUserToolStripMenuItem.Name = "createUserToolStripMenuItem";
            this.createUserToolStripMenuItem.Size = new System.Drawing.Size(134, 22);
            this.createUserToolStripMenuItem.Text = "Create User";
            this.createUserToolStripMenuItem.Click += new System.EventHandler(this.createUserToolStripMenuItem_Click);
            // 
            // deleteToolStripMenuItem
            // 
            this.deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
            this.deleteToolStripMenuItem.Size = new System.Drawing.Size(134, 22);
            this.deleteToolStripMenuItem.Text = "Delete";
            // 
            // lblRecordsCount
            // 
            this.lblRecordsCount.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblRecordsCount.AutoSize = true;
            this.lblRecordsCount.ForeColor = System.Drawing.Color.Black;
            this.lblRecordsCount.Location = new System.Drawing.Point(97, 466);
            this.lblRecordsCount.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblRecordsCount.Name = "lblRecordsCount";
            this.lblRecordsCount.Size = new System.Drawing.Size(19, 13);
            this.lblRecordsCount.TabIndex = 247;
            this.lblRecordsCount.Text = "??";
            // 
            // btnAddNew
            // 
            this.btnAddNew.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAddNew.AutoRoundedCorners = true;
            this.btnAddNew.BorderRadius = 14;
            this.btnAddNew.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnAddNew.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnAddNew.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnAddNew.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnAddNew.FillColor = System.Drawing.Color.Black;
            this.btnAddNew.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnAddNew.ForeColor = System.Drawing.Color.White;
            this.btnAddNew.Location = new System.Drawing.Point(1305, 62);
            this.btnAddNew.Name = "btnAddNew";
            this.btnAddNew.Size = new System.Drawing.Size(129, 30);
            this.btnAddNew.TabIndex = 249;
            this.btnAddNew.Text = "Add New";
            this.btnAddNew.Click += new System.EventHandler(this.btnAddNew_Click);
            // 
            // frmListEmployees
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1454, 518);
            this.Controls.Add(this.btnAddNew);
            this.Controls.Add(this.btnCLose);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvListEmployees);
            this.Controls.Add(this.lblRecordsCount);
            this.Controls.Add(this.txtFilterValue);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.cbFilterBy);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblTitle);
            this.Name = "frmListEmployees";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "List Employees";
            this.Load += new System.EventHandler(this.frmListEmployees_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabSalary.ResumeLayout(false);
            this.tabSalary.PerformLayout();
            this.tabHireDate.ResumeLayout(false);
            this.tabHireDate.PerformLayout();
            this.tabExitDate.ResumeLayout(false);
            this.tabExitDate.PerformLayout();
            this.tabDepartmentBrach.ResumeLayout(false);
            this.tabDepartmentBrach.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListEmployees)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private Guna.UI2.WinForms.Guna2ComboBox cmbDepbartmennt;
        private Guna.UI2.WinForms.Guna2ComboBox cbFilterBy;
        private System.Windows.Forms.Label label2;
        private Guna.UI2.WinForms.Guna2ComboBox cmbBranches;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lable;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabSalary;
        private System.Windows.Forms.TextBox txtToSalary;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtFromSalary;
        private System.Windows.Forms.TabPage tabHireDate;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DateTimePicker dtpToHireDate;
        private System.Windows.Forms.DateTimePicker dtpFromHireDate;
        private System.Windows.Forms.TabPage tabDepartmentBrach;
        private System.Windows.Forms.CheckBox cbSalary;
        private System.Windows.Forms.CheckBox cbHireDate;
        private System.Windows.Forms.TabPage tabExitDate;
        private System.Windows.Forms.CheckBox cbExitDate;
        private System.Windows.Forms.DateTimePicker dtpToExitDate;
        private System.Windows.Forms.DateTimePicker dtpFromExitDate;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtFilterValue;
        private Guna.UI2.WinForms.Guna2Button btnCLose;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2DataGridView dgvListEmployees;
        private System.Windows.Forms.Label lblRecordsCount;
        private System.Windows.Forms.Label label8;
        private Guna.UI2.WinForms.Guna2ComboBox cmbCityName;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem updateToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem createUserToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteToolStripMenuItem;
        private Guna.UI2.WinForms.Guna2Button btnAddNew;
    }
}