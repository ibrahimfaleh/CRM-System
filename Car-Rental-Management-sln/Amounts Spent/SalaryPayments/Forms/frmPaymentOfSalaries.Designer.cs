namespace CarRental.Amounts_Spent.Salary_Payments
{
    partial class frmPaymentOfSalaries
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.lblTitle = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblTotalAmountOfSalaries = new System.Windows.Forms.Label();
            this.txtFilterValue = new System.Windows.Forms.TextBox();
            this.cbFilterBy = new Guna.UI2.WinForms.Guna2ComboBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.cmbPayment = new Guna.UI2.WinForms.Guna2ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txtFromExpectedProfit = new Guna.UI2.WinForms.Guna2TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.txtFromActualProfits = new Guna.UI2.WinForms.Guna2TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.txtFromAnotherIncome = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtAmountVBR = new Guna.UI2.WinForms.Guna2TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtTotalAmount = new Guna.UI2.WinForms.Guna2TextBox();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.txtFromVehicleSales = new Guna.UI2.WinForms.Guna2TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabSalary = new System.Windows.Forms.TabPage();
            this.txtToSalary = new System.Windows.Forms.TextBox();
            this.txtFromSalary = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cbSalary = new System.Windows.Forms.CheckBox();
            this.label6 = new System.Windows.Forms.Label();
            this.tabHireDate = new System.Windows.Forms.TabPage();
            this.cbHireDate = new System.Windows.Forms.CheckBox();
            this.dtpToHireDate = new System.Windows.Forms.DateTimePicker();
            this.dtpFromHireDate = new System.Windows.Forms.DateTimePicker();
            this.label7 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.tabDepartmentBrach = new System.Windows.Forms.TabPage();
            this.cmbDepbartmennt = new Guna.UI2.WinForms.Guna2ComboBox();
            this.cmbBranch = new Guna.UI2.WinForms.Guna2ComboBox();
            this.lable = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblDate = new System.Windows.Forms.Label();
            this.btnSave = new Guna.UI2.WinForms.Guna2Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnClose = new Guna.UI2.WinForms.Guna2Button();
            this.lblRecordsCount = new System.Windows.Forms.Label();
            this.dgvListEmployeeSalaries = new Guna.UI2.WinForms.Guna2DataGridView();
            this.llll = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ctrlGeneralRevenueFundCardWithIncomeDetails1 = new CarRental.General_Revenue_Fund.ctrlGeneralRevenueFundCardWithIncomeDetails();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabSalary.SuspendLayout();
            this.tabHireDate.SuspendLayout();
            this.tabDepartmentBrach.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListEmployeeSalaries)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblTitle.ForeColor = System.Drawing.Color.SlateBlue;
            this.lblTitle.Location = new System.Drawing.Point(0, 0);
            this.lblTitle.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(1356, 41);
            this.lblTitle.TabIndex = 157;
            this.lblTitle.Text = "Payment Of Salaries";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.Color.SlateBlue;
            this.label2.Location = new System.Drawing.Point(9, 67);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(281, 26);
            this.label2.TabIndex = 160;
            this.label2.Text = "Total amount of salaries :";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblTotalAmountOfSalaries
            // 
            this.lblTotalAmountOfSalaries.AutoSize = true;
            this.lblTotalAmountOfSalaries.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblTotalAmountOfSalaries.ForeColor = System.Drawing.Color.Red;
            this.lblTotalAmountOfSalaries.Location = new System.Drawing.Point(301, 69);
            this.lblTotalAmountOfSalaries.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTotalAmountOfSalaries.Name = "lblTotalAmountOfSalaries";
            this.lblTotalAmountOfSalaries.Size = new System.Drawing.Size(21, 24);
            this.lblTotalAmountOfSalaries.TabIndex = 161;
            this.lblTotalAmountOfSalaries.Text = "0";
            this.lblTotalAmountOfSalaries.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtFilterValue
            // 
            this.txtFilterValue.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtFilterValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtFilterValue.ForeColor = System.Drawing.Color.Black;
            this.txtFilterValue.Location = new System.Drawing.Point(307, 395);
            this.txtFilterValue.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtFilterValue.Multiline = true;
            this.txtFilterValue.Name = "txtFilterValue";
            this.txtFilterValue.Size = new System.Drawing.Size(206, 30);
            this.txtFilterValue.TabIndex = 246;
            this.txtFilterValue.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtFilterValue.Visible = false;
            this.txtFilterValue.TextChanged += new System.EventHandler(this.txtFilterValue_TextChanged);
            this.txtFilterValue.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtFilterValue_KeyPress);
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
            this.cbFilterBy.Location = new System.Drawing.Point(124, 394);
            this.cbFilterBy.Margin = new System.Windows.Forms.Padding(2);
            this.cbFilterBy.Name = "cbFilterBy";
            this.cbFilterBy.Size = new System.Drawing.Size(173, 36);
            this.cbFilterBy.StartIndex = 0;
            this.cbFilterBy.TabIndex = 247;
            this.cbFilterBy.SelectedIndexChanged += new System.EventHandler(this.cbFilterBy_SelectedIndexChanged);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold);
            this.label13.ForeColor = System.Drawing.Color.SlateBlue;
            this.label13.Location = new System.Drawing.Point(12, 395);
            this.label13.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(107, 25);
            this.label13.TabIndex = 245;
            this.label13.Text = "Filter By:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label10.ForeColor = System.Drawing.Color.Black;
            this.label10.Location = new System.Drawing.Point(11, 120);
            this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(140, 18);
            this.label10.TabIndex = 251;
            this.label10.Text = "Payment Details :";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cmbPayment
            // 
            this.cmbPayment.BackColor = System.Drawing.Color.Transparent;
            this.cmbPayment.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.cmbPayment.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbPayment.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbPayment.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cmbPayment.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cmbPayment.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cmbPayment.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cmbPayment.ItemHeight = 30;
            this.cmbPayment.Items.AddRange(new object[] {
            "Transformation",
            "Cash"});
            this.cmbPayment.Location = new System.Drawing.Point(178, 111);
            this.cmbPayment.Name = "cmbPayment";
            this.cmbPayment.Size = new System.Drawing.Size(199, 36);
            this.cmbPayment.StartIndex = 0;
            this.cmbPayment.TabIndex = 252;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label11.Location = new System.Drawing.Point(3, 212);
            this.label11.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(169, 17);
            this.label11.TabIndex = 281;
            this.label11.Text = "From Expected Profit :";
            // 
            // txtFromExpectedProfit
            // 
            this.txtFromExpectedProfit.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.txtFromExpectedProfit.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtFromExpectedProfit.DefaultText = "";
            this.txtFromExpectedProfit.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtFromExpectedProfit.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtFromExpectedProfit.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtFromExpectedProfit.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtFromExpectedProfit.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtFromExpectedProfit.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtFromExpectedProfit.ForeColor = System.Drawing.Color.Black;
            this.txtFromExpectedProfit.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtFromExpectedProfit.Location = new System.Drawing.Point(178, 202);
            this.txtFromExpectedProfit.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtFromExpectedProfit.Name = "txtFromExpectedProfit";
            this.txtFromExpectedProfit.PasswordChar = '\0';
            this.txtFromExpectedProfit.PlaceholderForeColor = System.Drawing.Color.Gray;
            this.txtFromExpectedProfit.PlaceholderText = "Amount ";
            this.txtFromExpectedProfit.SelectedText = "";
            this.txtFromExpectedProfit.Size = new System.Drawing.Size(199, 36);
            this.txtFromExpectedProfit.TabIndex = 280;
            this.txtFromExpectedProfit.TextChanged += new System.EventHandler(this.txtFromExpectedProfit_TextChanged);
            this.txtFromExpectedProfit.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtFromExpectedProfit_KeyPress);
            this.txtFromExpectedProfit.Validating += new System.ComponentModel.CancelEventHandler(this.txtFromExpectedProfit_Validating);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label14.Location = new System.Drawing.Point(14, 256);
            this.label14.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(156, 17);
            this.label14.TabIndex = 279;
            this.label14.Text = "From Actual Profits :";
            // 
            // txtFromActualProfits
            // 
            this.txtFromActualProfits.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.txtFromActualProfits.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtFromActualProfits.DefaultText = "";
            this.txtFromActualProfits.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtFromActualProfits.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtFromActualProfits.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtFromActualProfits.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtFromActualProfits.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtFromActualProfits.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtFromActualProfits.ForeColor = System.Drawing.Color.Black;
            this.txtFromActualProfits.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtFromActualProfits.Location = new System.Drawing.Point(178, 246);
            this.txtFromActualProfits.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtFromActualProfits.Name = "txtFromActualProfits";
            this.txtFromActualProfits.PasswordChar = '\0';
            this.txtFromActualProfits.PlaceholderForeColor = System.Drawing.Color.Gray;
            this.txtFromActualProfits.PlaceholderText = "Amount ";
            this.txtFromActualProfits.SelectedText = "";
            this.txtFromActualProfits.Size = new System.Drawing.Size(200, 36);
            this.txtFromActualProfits.TabIndex = 278;
            this.txtFromActualProfits.TextChanged += new System.EventHandler(this.txtFromActualProfits_TextChanged);
            this.txtFromActualProfits.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtFromActualProfits_KeyPress);
            this.txtFromActualProfits.Validating += new System.ComponentModel.CancelEventHandler(this.txtFromExpectedProfit_Validating);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label15.Location = new System.Drawing.Point(4, 342);
            this.label15.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(172, 17);
            this.label15.TabIndex = 277;
            this.label15.Text = "From Another Income :";
            // 
            // txtFromAnotherIncome
            // 
            this.txtFromAnotherIncome.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.txtFromAnotherIncome.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtFromAnotherIncome.DefaultText = "";
            this.txtFromAnotherIncome.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtFromAnotherIncome.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtFromAnotherIncome.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtFromAnotherIncome.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtFromAnotherIncome.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtFromAnotherIncome.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtFromAnotherIncome.ForeColor = System.Drawing.Color.Black;
            this.txtFromAnotherIncome.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtFromAnotherIncome.Location = new System.Drawing.Point(177, 334);
            this.txtFromAnotherIncome.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtFromAnotherIncome.Name = "txtFromAnotherIncome";
            this.txtFromAnotherIncome.PasswordChar = '\0';
            this.txtFromAnotherIncome.PlaceholderForeColor = System.Drawing.Color.Gray;
            this.txtFromAnotherIncome.PlaceholderText = "Amount ";
            this.txtFromAnotherIncome.SelectedText = "";
            this.txtFromAnotherIncome.Size = new System.Drawing.Size(200, 36);
            this.txtFromAnotherIncome.TabIndex = 276;
            this.txtFromAnotherIncome.TextChanged += new System.EventHandler(this.txtFromAnotherIncome_TextChanged);
            this.txtFromAnotherIncome.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtFromAnotherIncome_KeyPress);
            this.txtFromAnotherIncome.Validating += new System.ComponentModel.CancelEventHandler(this.txtFromExpectedProfit_Validating);
            // 
            // txtAmountVBR
            // 
            this.txtAmountVBR.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.txtAmountVBR.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtAmountVBR.DefaultText = "";
            this.txtAmountVBR.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtAmountVBR.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtAmountVBR.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtAmountVBR.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtAmountVBR.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtAmountVBR.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtAmountVBR.ForeColor = System.Drawing.Color.Black;
            this.txtAmountVBR.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtAmountVBR.Location = new System.Drawing.Point(177, 290);
            this.txtAmountVBR.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtAmountVBR.Name = "txtAmountVBR";
            this.txtAmountVBR.PasswordChar = '\0';
            this.txtAmountVBR.PlaceholderForeColor = System.Drawing.Color.Gray;
            this.txtAmountVBR.PlaceholderText = "Amount ";
            this.txtAmountVBR.SelectedText = "";
            this.txtAmountVBR.Size = new System.Drawing.Size(200, 36);
            this.txtAmountVBR.TabIndex = 275;
            this.txtAmountVBR.TextChanged += new System.EventHandler(this.txtAmountVBR_TextChanged);
            this.txtAmountVBR.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtAmountVBR_KeyPress);
            this.txtAmountVBR.Validating += new System.ComponentModel.CancelEventHandler(this.txtFromExpectedProfit_Validating);
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label16.ForeColor = System.Drawing.Color.Black;
            this.label16.Location = new System.Drawing.Point(24, 302);
            this.label16.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(150, 18);
            this.label16.TabIndex = 274;
            this.label16.Text = "From Vehicle B.R :";
            this.label16.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(396, 343);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(114, 17);
            this.label4.TabIndex = 283;
            this.label4.Text = "Total Amount :";
            // 
            // txtTotalAmount
            // 
            this.txtTotalAmount.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.txtTotalAmount.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtTotalAmount.DefaultText = "0";
            this.txtTotalAmount.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtTotalAmount.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtTotalAmount.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtTotalAmount.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtTotalAmount.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtTotalAmount.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtTotalAmount.ForeColor = System.Drawing.Color.Black;
            this.txtTotalAmount.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtTotalAmount.Location = new System.Drawing.Point(518, 334);
            this.txtTotalAmount.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtTotalAmount.Name = "txtTotalAmount";
            this.txtTotalAmount.PasswordChar = '\0';
            this.txtTotalAmount.PlaceholderForeColor = System.Drawing.Color.Gray;
            this.txtTotalAmount.PlaceholderText = "Amount ";
            this.txtTotalAmount.ReadOnly = true;
            this.txtTotalAmount.SelectedText = "";
            this.txtTotalAmount.Size = new System.Drawing.Size(199, 36);
            this.txtTotalAmount.TabIndex = 282;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // txtFromVehicleSales
            // 
            this.txtFromVehicleSales.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.txtFromVehicleSales.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtFromVehicleSales.DefaultText = "";
            this.txtFromVehicleSales.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtFromVehicleSales.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtFromVehicleSales.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtFromVehicleSales.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtFromVehicleSales.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtFromVehicleSales.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtFromVehicleSales.ForeColor = System.Drawing.Color.Black;
            this.txtFromVehicleSales.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtFromVehicleSales.Location = new System.Drawing.Point(178, 158);
            this.txtFromVehicleSales.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtFromVehicleSales.Name = "txtFromVehicleSales";
            this.txtFromVehicleSales.PasswordChar = '\0';
            this.txtFromVehicleSales.PlaceholderForeColor = System.Drawing.Color.Gray;
            this.txtFromVehicleSales.PlaceholderText = "Amount ";
            this.txtFromVehicleSales.SelectedText = "";
            this.txtFromVehicleSales.Size = new System.Drawing.Size(199, 36);
            this.txtFromVehicleSales.TabIndex = 285;
            this.txtFromVehicleSales.TextChanged += new System.EventHandler(this.txtFromVehicleSales_TextChanged);
            this.txtFromVehicleSales.Validating += new System.ComponentModel.CancelEventHandler(this.ValidateEmptyTextBox);
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label17.ForeColor = System.Drawing.Color.Black;
            this.label17.Location = new System.Drawing.Point(8, 166);
            this.label17.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(159, 18);
            this.label17.TabIndex = 284;
            this.label17.Text = "From VehicleSales :";
            this.label17.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Controls.Add(this.tabSalary);
            this.tabControl1.Controls.Add(this.tabHireDate);
            this.tabControl1.Controls.Add(this.tabDepartmentBrach);
            this.tabControl1.Location = new System.Drawing.Point(785, 373);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(550, 72);
            this.tabControl1.TabIndex = 293;
            // 
            // tabSalary
            // 
            this.tabSalary.Controls.Add(this.txtToSalary);
            this.tabSalary.Controls.Add(this.txtFromSalary);
            this.tabSalary.Controls.Add(this.label5);
            this.tabSalary.Controls.Add(this.cbSalary);
            this.tabSalary.Controls.Add(this.label6);
            this.tabSalary.Location = new System.Drawing.Point(4, 22);
            this.tabSalary.Name = "tabSalary";
            this.tabSalary.Padding = new System.Windows.Forms.Padding(3);
            this.tabSalary.Size = new System.Drawing.Size(542, 46);
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
            this.txtToSalary.TextChanged += new System.EventHandler(this.txtFromSalary_TextChanged);
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
            this.txtFromSalary.TextChanged += new System.EventHandler(this.txtFromSalary_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(232, 17);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(33, 17);
            this.label5.TabIndex = 244;
            this.label5.Text = "To :";
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
            this.cbSalary.CheckedChanged += new System.EventHandler(this.txtFromSalary_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(5, 16);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(44, 17);
            this.label6.TabIndex = 245;
            this.label6.Text = "From ";
            // 
            // tabHireDate
            // 
            this.tabHireDate.AccessibleRole = System.Windows.Forms.AccessibleRole.OutlineButton;
            this.tabHireDate.Controls.Add(this.cbHireDate);
            this.tabHireDate.Controls.Add(this.dtpToHireDate);
            this.tabHireDate.Controls.Add(this.dtpFromHireDate);
            this.tabHireDate.Controls.Add(this.label7);
            this.tabHireDate.Controls.Add(this.label9);
            this.tabHireDate.Location = new System.Drawing.Point(4, 22);
            this.tabHireDate.Name = "tabHireDate";
            this.tabHireDate.Padding = new System.Windows.Forms.Padding(3);
            this.tabHireDate.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.tabHireDate.Size = new System.Drawing.Size(542, 46);
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
            this.cbHireDate.CheckedChanged += new System.EventHandler(this.txtFromSalary_TextChanged);
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
            this.dtpToHireDate.ValueChanged += new System.EventHandler(this.txtFromSalary_TextChanged);
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
            this.dtpFromHireDate.ValueChanged += new System.EventHandler(this.txtFromSalary_TextChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(229, 14);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(29, 17);
            this.label7.TabIndex = 246;
            this.label7.Text = "To ";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label9.ForeColor = System.Drawing.Color.Black;
            this.label9.Location = new System.Drawing.Point(40, 14);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(44, 17);
            this.label9.TabIndex = 247;
            this.label9.Text = "From ";
            // 
            // tabDepartmentBrach
            // 
            this.tabDepartmentBrach.Controls.Add(this.cmbDepbartmennt);
            this.tabDepartmentBrach.Controls.Add(this.cmbBranch);
            this.tabDepartmentBrach.Controls.Add(this.lable);
            this.tabDepartmentBrach.Controls.Add(this.label12);
            this.tabDepartmentBrach.Location = new System.Drawing.Point(4, 22);
            this.tabDepartmentBrach.Name = "tabDepartmentBrach";
            this.tabDepartmentBrach.Padding = new System.Windows.Forms.Padding(3);
            this.tabDepartmentBrach.Size = new System.Drawing.Size(542, 46);
            this.tabDepartmentBrach.TabIndex = 3;
            this.tabDepartmentBrach.Text = "Department And Brach";
            this.tabDepartmentBrach.UseVisualStyleBackColor = true;
            // 
            // cmbDepbartmennt
            // 
            this.cmbDepbartmennt.BackColor = System.Drawing.Color.Transparent;
            this.cmbDepbartmennt.BorderColor = System.Drawing.Color.Black;
            this.cmbDepbartmennt.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbDepbartmennt.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbDepbartmennt.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cmbDepbartmennt.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cmbDepbartmennt.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F);
            this.cmbDepbartmennt.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cmbDepbartmennt.ItemHeight = 30;
            this.cmbDepbartmennt.Location = new System.Drawing.Point(376, 5);
            this.cmbDepbartmennt.Margin = new System.Windows.Forms.Padding(2);
            this.cmbDepbartmennt.Name = "cmbDepbartmennt";
            this.cmbDepbartmennt.Size = new System.Drawing.Size(158, 36);
            this.cmbDepbartmennt.TabIndex = 161;
            this.cmbDepbartmennt.Tag = "Active Or NotActive ";
            this.cmbDepbartmennt.SelectedIndexChanged += new System.EventHandler(this.txtFromSalary_TextChanged);
            // 
            // cmbBranch
            // 
            this.cmbBranch.BackColor = System.Drawing.Color.Transparent;
            this.cmbBranch.BorderColor = System.Drawing.Color.Black;
            this.cmbBranch.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbBranch.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbBranch.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cmbBranch.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cmbBranch.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F);
            this.cmbBranch.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cmbBranch.ItemHeight = 30;
            this.cmbBranch.Location = new System.Drawing.Point(86, 5);
            this.cmbBranch.Margin = new System.Windows.Forms.Padding(2);
            this.cmbBranch.Name = "cmbBranch";
            this.cmbBranch.Size = new System.Drawing.Size(158, 36);
            this.cmbBranch.TabIndex = 164;
            this.cmbBranch.Tag = "Active Or NotActive ";
            this.cmbBranch.SelectedIndexChanged += new System.EventHandler(this.txtFromSalary_TextChanged);
            // 
            // lable
            // 
            this.lable.AutoSize = true;
            this.lable.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lable.ForeColor = System.Drawing.Color.SlateBlue;
            this.lable.Location = new System.Drawing.Point(256, 12);
            this.lable.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lable.Name = "lable";
            this.lable.Size = new System.Drawing.Size(110, 21);
            this.lable.TabIndex = 242;
            this.lable.Text = "Department :";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.SlateBlue;
            this.label12.Location = new System.Drawing.Point(5, 12);
            this.label12.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(71, 21);
            this.label12.TabIndex = 241;
            this.label12.Text = "Branch :";
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.ForeColor = System.Drawing.Color.SlateBlue;
            this.label3.Location = new System.Drawing.Point(732, 97);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(271, 26);
            this.label3.TabIndex = 292;
            this.label3.Text = "General Revenue Fund :";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblDate
            // 
            this.lblDate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblDate.AutoSize = true;
            this.lblDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblDate.ForeColor = System.Drawing.Color.Blue;
            this.lblDate.Location = new System.Drawing.Point(926, 343);
            this.lblDate.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(43, 18);
            this.lblDate.TabIndex = 291;
            this.lblDate.Text = "Date";
            this.lblDate.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnSave
            // 
            this.btnSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSave.BackColor = System.Drawing.Color.Black;
            this.btnSave.BorderColor = System.Drawing.Color.White;
            this.btnSave.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnSave.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnSave.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnSave.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnSave.FillColor = System.Drawing.Color.Black;
            this.btnSave.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnSave.ForeColor = System.Drawing.Color.White;
            this.btnSave.Location = new System.Drawing.Point(1202, 684);
            this.btnSave.Margin = new System.Windows.Forms.Padding(2);
            this.btnSave.Name = "btnSave";
            this.btnSave.PressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnSave.Size = new System.Drawing.Size(135, 33);
            this.btnSave.TabIndex = 290;
            this.btnSave.Text = "Payment";
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Tai Le", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.SlateBlue;
            this.label1.Location = new System.Drawing.Point(17, 682);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 23);
            this.label1.TabIndex = 289;
            this.label1.Text = "# Records:";
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.BackColor = System.Drawing.Color.Black;
            this.btnClose.BorderColor = System.Drawing.Color.White;
            this.btnClose.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnClose.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnClose.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnClose.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnClose.FillColor = System.Drawing.Color.Black;
            this.btnClose.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnClose.ForeColor = System.Drawing.Color.White;
            this.btnClose.Location = new System.Drawing.Point(1046, 684);
            this.btnClose.Margin = new System.Windows.Forms.Padding(2);
            this.btnClose.Name = "btnClose";
            this.btnClose.PressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnClose.Size = new System.Drawing.Size(135, 33);
            this.btnClose.TabIndex = 288;
            this.btnClose.Text = "Close";
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // lblRecordsCount
            // 
            this.lblRecordsCount.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblRecordsCount.AutoSize = true;
            this.lblRecordsCount.Font = new System.Drawing.Font("Microsoft Tai Le", 10.8F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRecordsCount.ForeColor = System.Drawing.Color.SlateBlue;
            this.lblRecordsCount.Location = new System.Drawing.Point(114, 684);
            this.lblRecordsCount.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblRecordsCount.Name = "lblRecordsCount";
            this.lblRecordsCount.Size = new System.Drawing.Size(133, 19);
            this.lblRecordsCount.TabIndex = 287;
            this.lblRecordsCount.Text = "Add Update Check";
            // 
            // dgvListEmployeeSalaries
            // 
            this.dgvListEmployeeSalaries.AllowUserToAddRows = false;
            this.dgvListEmployeeSalaries.AllowUserToDeleteRows = false;
            this.dgvListEmployeeSalaries.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black;
            this.dgvListEmployeeSalaries.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvListEmployeeSalaries.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvListEmployeeSalaries.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.None;
            this.dgvListEmployeeSalaries.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvListEmployeeSalaries.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvListEmployeeSalaries.ColumnHeadersHeight = 44;
            this.dgvListEmployeeSalaries.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dgvListEmployeeSalaries.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.llll});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvListEmployeeSalaries.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvListEmployeeSalaries.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvListEmployeeSalaries.Location = new System.Drawing.Point(9, 450);
            this.dgvListEmployeeSalaries.Margin = new System.Windows.Forms.Padding(2);
            this.dgvListEmployeeSalaries.Name = "dgvListEmployeeSalaries";
            this.dgvListEmployeeSalaries.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvListEmployeeSalaries.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvListEmployeeSalaries.RowHeadersVisible = false;
            this.dgvListEmployeeSalaries.RowHeadersWidth = 51;
            this.dgvListEmployeeSalaries.RowTemplate.Height = 29;
            this.dgvListEmployeeSalaries.Size = new System.Drawing.Size(1328, 230);
            this.dgvListEmployeeSalaries.TabIndex = 286;
            this.dgvListEmployeeSalaries.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvListEmployeeSalaries.ThemeStyle.AlternatingRowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dgvListEmployeeSalaries.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Black;
            this.dgvListEmployeeSalaries.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvListEmployeeSalaries.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dgvListEmployeeSalaries.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.dgvListEmployeeSalaries.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvListEmployeeSalaries.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.Black;
            this.dgvListEmployeeSalaries.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvListEmployeeSalaries.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dgvListEmployeeSalaries.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dgvListEmployeeSalaries.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dgvListEmployeeSalaries.ThemeStyle.HeaderStyle.Height = 44;
            this.dgvListEmployeeSalaries.ThemeStyle.ReadOnly = false;
            this.dgvListEmployeeSalaries.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvListEmployeeSalaries.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvListEmployeeSalaries.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dgvListEmployeeSalaries.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dgvListEmployeeSalaries.ThemeStyle.RowsStyle.Height = 29;
            this.dgvListEmployeeSalaries.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvListEmployeeSalaries.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dgvListEmployeeSalaries.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvListEmployeeSalaries_CellEndEdit);
            // 
            // llll
            // 
            this.llll.FillWeight = 20F;
            this.llll.HeaderText = " ";
            this.llll.MinimumWidth = 6;
            this.llll.Name = "llll";
            this.llll.Width = 1684;
            // 
            // ctrlGeneralRevenueFundCardWithIncomeDetails1
            // 
            this.ctrlGeneralRevenueFundCardWithIncomeDetails1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ctrlGeneralRevenueFundCardWithIncomeDetails1.AutoSize = true;
            this.ctrlGeneralRevenueFundCardWithIncomeDetails1.BackColor = System.Drawing.Color.White;
            this.ctrlGeneralRevenueFundCardWithIncomeDetails1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ctrlGeneralRevenueFundCardWithIncomeDetails1.Location = new System.Drawing.Point(737, 136);
            this.ctrlGeneralRevenueFundCardWithIncomeDetails1.Name = "ctrlGeneralRevenueFundCardWithIncomeDetails1";
            this.ctrlGeneralRevenueFundCardWithIncomeDetails1.Size = new System.Drawing.Size(590, 133);
            this.ctrlGeneralRevenueFundCardWithIncomeDetails1.TabIndex = 294;
            // 
            // frmPaymentOfSalaries
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1356, 723);
            this.Controls.Add(this.ctrlGeneralRevenueFundCardWithIncomeDetails1);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblDate);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.lblRecordsCount);
            this.Controls.Add(this.dgvListEmployeeSalaries);
            this.Controls.Add(this.txtFromVehicleSales);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtTotalAmount);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.txtFromExpectedProfit);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.txtFromActualProfits);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.txtFromAnotherIncome);
            this.Controls.Add(this.txtAmountVBR);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.cmbPayment);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.txtFilterValue);
            this.Controls.Add(this.cbFilterBy);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.lblTotalAmountOfSalaries);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblTitle);
            this.Name = "frmPaymentOfSalaries";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Payment Of Salaries";
            this.Load += new System.EventHandler(this.frmPaymentOfSalaries_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabSalary.ResumeLayout(false);
            this.tabSalary.PerformLayout();
            this.tabHireDate.ResumeLayout(false);
            this.tabHireDate.PerformLayout();
            this.tabDepartmentBrach.ResumeLayout(false);
            this.tabDepartmentBrach.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListEmployeeSalaries)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblTotalAmountOfSalaries;
        private System.Windows.Forms.TextBox txtFilterValue;
        private Guna.UI2.WinForms.Guna2ComboBox cbFilterBy;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label10;
        private Guna.UI2.WinForms.Guna2ComboBox cmbPayment;
        private System.Windows.Forms.Label label11;
        private Guna.UI2.WinForms.Guna2TextBox txtFromExpectedProfit;
        private System.Windows.Forms.Label label14;
        private Guna.UI2.WinForms.Guna2TextBox txtFromActualProfits;
        private System.Windows.Forms.Label label15;
        private Guna.UI2.WinForms.Guna2TextBox txtFromAnotherIncome;
        private Guna.UI2.WinForms.Guna2TextBox txtAmountVBR;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label4;
        private Guna.UI2.WinForms.Guna2TextBox txtTotalAmount;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private Guna.UI2.WinForms.Guna2TextBox txtFromVehicleSales;
        private System.Windows.Forms.Label label17;
        private General_Revenue_Fund.ctrlGeneralRevenueFundCardWithIncomeDetails ctrlGeneralRevenueFundCardWithIncomeDetails1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabSalary;
        private System.Windows.Forms.TextBox txtToSalary;
        private System.Windows.Forms.TextBox txtFromSalary;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.CheckBox cbSalary;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TabPage tabHireDate;
        private System.Windows.Forms.CheckBox cbHireDate;
        private System.Windows.Forms.DateTimePicker dtpToHireDate;
        private System.Windows.Forms.DateTimePicker dtpFromHireDate;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TabPage tabDepartmentBrach;
        private Guna.UI2.WinForms.Guna2ComboBox cmbDepbartmennt;
        private Guna.UI2.WinForms.Guna2ComboBox cmbBranch;
        private System.Windows.Forms.Label lable;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblDate;
        private Guna.UI2.WinForms.Guna2Button btnSave;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2Button btnClose;
        private System.Windows.Forms.Label lblRecordsCount;
        private Guna.UI2.WinForms.Guna2DataGridView dgvListEmployeeSalaries;
        private System.Windows.Forms.DataGridViewTextBoxColumn llll;
    }
}