namespace CarRental.Rental_Fund
{
    partial class frmDailyIncomeFund
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
            this.lblModeTitle = new System.Windows.Forms.Label();
            this.txtTotalAvailableTransformationAmount = new Guna.UI2.WinForms.Guna2TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblTotalIncome = new System.Windows.Forms.Label();
            this.btnFundClose = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.label2 = new System.Windows.Forms.Label();
            this.lblIsCLose = new System.Windows.Forms.Label();
            this.lblTotalIncomeCashAmount = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lblTransformation = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtTotalAvailableCashAmount = new Guna.UI2.WinForms.Guna2TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lblstatus = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.lblTotalRevenueDeficitOrSurplus = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblStartAmount = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.guna2TabControl1 = new Guna.UI2.WinForms.Guna2TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabBills = new System.Windows.Forms.TabPage();
            this.label17 = new System.Windows.Forms.Label();
            this.txtCost = new Guna.UI2.WinForms.Guna2TextBox();
            this.lblAmountVBR = new System.Windows.Forms.Label();
            this.lblActualProfits = new System.Windows.Forms.Label();
            this.lblExpectedProfit = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txtFromExpectedProfit = new Guna.UI2.WinForms.Guna2TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.txtFromActualProfits = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtAmountVBR = new Guna.UI2.WinForms.Guna2TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.btnPay = new Guna.UI2.WinForms.Guna2Button();
            this.errorProviderPayBill = new System.Windows.Forms.ErrorProvider(this.components);
            this.lblSratDate = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.ctrlDgvDailyFundTransaction1 = new CarRental.Rental_Fund.ctrlDgvDailyFundTransaction();
            this.ctrlBillCardWithFilter1 = new CarRental.Bill.Controls.ctrlBillCardWithFilter();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.guna2TabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabBills.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderPayBill)).BeginInit();
            this.SuspendLayout();
            // 
            // lblModeTitle
            // 
            this.lblModeTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblModeTitle.Font = new System.Drawing.Font("Microsoft Tai Le", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblModeTitle.ForeColor = System.Drawing.Color.SlateBlue;
            this.lblModeTitle.Location = new System.Drawing.Point(0, 0);
            this.lblModeTitle.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblModeTitle.Name = "lblModeTitle";
            this.lblModeTitle.Size = new System.Drawing.Size(1171, 52);
            this.lblModeTitle.TabIndex = 179;
            this.lblModeTitle.Text = "Daily Fund Management";
            this.lblModeTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtTotalAvailableTransformationAmount
            // 
            this.txtTotalAvailableTransformationAmount.BorderColor = System.Drawing.Color.SlateBlue;
            this.txtTotalAvailableTransformationAmount.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtTotalAvailableTransformationAmount.DefaultText = "";
            this.txtTotalAvailableTransformationAmount.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtTotalAvailableTransformationAmount.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtTotalAvailableTransformationAmount.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtTotalAvailableTransformationAmount.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtTotalAvailableTransformationAmount.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtTotalAvailableTransformationAmount.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtTotalAvailableTransformationAmount.ForeColor = System.Drawing.Color.Black;
            this.txtTotalAvailableTransformationAmount.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtTotalAvailableTransformationAmount.Location = new System.Drawing.Point(236, 289);
            this.txtTotalAvailableTransformationAmount.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtTotalAvailableTransformationAmount.Name = "txtTotalAvailableTransformationAmount";
            this.txtTotalAvailableTransformationAmount.PasswordChar = '\0';
            this.txtTotalAvailableTransformationAmount.PlaceholderText = "";
            this.txtTotalAvailableTransformationAmount.SelectedText = "";
            this.txtTotalAvailableTransformationAmount.Size = new System.Drawing.Size(172, 27);
            this.txtTotalAvailableTransformationAmount.TabIndex = 190;
            this.txtTotalAvailableTransformationAmount.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtTotalAvailableTransformationAmount.TextChanged += new System.EventHandler(this.txtTotalAvailableTransformationAmount_TextChanged);
            this.txtTotalAvailableTransformationAmount.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtValidatePositiveDecimalNumbers_KeyPress);
            this.txtTotalAvailableTransformationAmount.Validating += new System.ComponentModel.CancelEventHandler(this.ValidateEmptyTextBox);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(83, 129);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 16);
            this.label1.TabIndex = 203;
            this.label1.Text = "Total Income :";
            // 
            // lblTotalIncome
            // 
            this.lblTotalIncome.AutoSize = true;
            this.lblTotalIncome.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblTotalIncome.Location = new System.Drawing.Point(194, 130);
            this.lblTotalIncome.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTotalIncome.Name = "lblTotalIncome";
            this.lblTotalIncome.Size = new System.Drawing.Size(49, 16);
            this.lblTotalIncome.TabIndex = 204;
            this.lblTotalIncome.Text = "??????";
            // 
            // btnFundClose
            // 
            this.btnFundClose.BackColor = System.Drawing.Color.Red;
            this.btnFundClose.FlatAppearance.BorderSize = 2;
            this.btnFundClose.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.btnFundClose.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.btnFundClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFundClose.ForeColor = System.Drawing.Color.White;
            this.btnFundClose.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnFundClose.Location = new System.Drawing.Point(901, 710);
            this.btnFundClose.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnFundClose.Name = "btnFundClose";
            this.btnFundClose.Size = new System.Drawing.Size(127, 34);
            this.btnFundClose.TabIndex = 206;
            this.btnFundClose.Text = "Fund Close";
            this.btnFundClose.UseVisualStyleBackColor = false;
            this.btnFundClose.Click += new System.EventHandler(this.btnFundClose_Click);
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.Black;
            this.btnClose.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnClose.FlatAppearance.BorderSize = 2;
            this.btnClose.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.btnClose.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.ForeColor = System.Drawing.Color.White;
            this.btnClose.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnClose.Location = new System.Drawing.Point(1031, 710);
            this.btnClose.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(127, 34);
            this.btnClose.TabIndex = 205;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(953, 249);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 16);
            this.label2.TabIndex = 207;
            this.label2.Text = "Is Close :";
            // 
            // lblIsCLose
            // 
            this.lblIsCLose.AutoSize = true;
            this.lblIsCLose.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblIsCLose.Location = new System.Drawing.Point(1027, 250);
            this.lblIsCLose.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblIsCLose.Name = "lblIsCLose";
            this.lblIsCLose.Size = new System.Drawing.Size(35, 16);
            this.lblIsCLose.TabIndex = 208;
            this.lblIsCLose.Text = "????";
            // 
            // lblTotalIncomeCashAmount
            // 
            this.lblTotalIncomeCashAmount.AutoSize = true;
            this.lblTotalIncomeCashAmount.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblTotalIncomeCashAmount.Location = new System.Drawing.Point(773, 129);
            this.lblTotalIncomeCashAmount.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTotalIncomeCashAmount.Name = "lblTotalIncomeCashAmount";
            this.lblTotalIncomeCashAmount.Size = new System.Drawing.Size(49, 16);
            this.lblTotalIncomeCashAmount.TabIndex = 211;
            this.lblTotalIncomeCashAmount.Text = "??????";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(566, 129);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(203, 16);
            this.label5.TabIndex = 210;
            this.label5.Text = "Total Income  Cash Amount :";
            // 
            // lblTransformation
            // 
            this.lblTransformation.AutoSize = true;
            this.lblTransformation.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblTransformation.Location = new System.Drawing.Point(773, 189);
            this.lblTransformation.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTransformation.Name = "lblTransformation";
            this.lblTransformation.Size = new System.Drawing.Size(49, 16);
            this.lblTransformation.TabIndex = 213;
            this.lblTransformation.Text = "??????";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.Location = new System.Drawing.Point(556, 189);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(213, 16);
            this.label7.TabIndex = 212;
            this.label7.Text = "Total Income Transformation :";
            // 
            // txtTotalAvailableCashAmount
            // 
            this.txtTotalAvailableCashAmount.BorderColor = System.Drawing.Color.SlateBlue;
            this.txtTotalAvailableCashAmount.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtTotalAvailableCashAmount.DefaultText = "";
            this.txtTotalAvailableCashAmount.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtTotalAvailableCashAmount.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtTotalAvailableCashAmount.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtTotalAvailableCashAmount.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtTotalAvailableCashAmount.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtTotalAvailableCashAmount.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtTotalAvailableCashAmount.ForeColor = System.Drawing.Color.Black;
            this.txtTotalAvailableCashAmount.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtTotalAvailableCashAmount.Location = new System.Drawing.Point(236, 240);
            this.txtTotalAvailableCashAmount.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtTotalAvailableCashAmount.Name = "txtTotalAvailableCashAmount";
            this.txtTotalAvailableCashAmount.PasswordChar = '\0';
            this.txtTotalAvailableCashAmount.PlaceholderText = "";
            this.txtTotalAvailableCashAmount.SelectedText = "";
            this.txtTotalAvailableCashAmount.Size = new System.Drawing.Size(172, 27);
            this.txtTotalAvailableCashAmount.TabIndex = 216;
            this.txtTotalAvailableCashAmount.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtTotalAvailableCashAmount.TextChanged += new System.EventHandler(this.txtTotalAvailableCashAmount_TextChanged);
            this.txtTotalAvailableCashAmount.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtValidatePositiveDecimalNumbers_KeyPress);
            this.txtTotalAvailableCashAmount.Validating += new System.ComponentModel.CancelEventHandler(this.ValidateEmptyTextBox);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(170, 245);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 16);
            this.label3.TabIndex = 217;
            this.label3.Text = "Cash :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(101, 294);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(119, 16);
            this.label6.TabIndex = 218;
            this.label6.Text = "Transformation :";
            // 
            // lblstatus
            // 
            this.lblstatus.AutoSize = true;
            this.lblstatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblstatus.Location = new System.Drawing.Point(1027, 190);
            this.lblstatus.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblstatus.Name = "lblstatus";
            this.lblstatus.Size = new System.Drawing.Size(35, 16);
            this.lblstatus.TabIndex = 220;
            this.lblstatus.Text = "????";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label10.Location = new System.Drawing.Point(966, 189);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(58, 16);
            this.label10.TabIndex = 219;
            this.label10.Text = "Status :";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label8.Location = new System.Drawing.Point(528, 249);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(241, 16);
            this.label8.TabIndex = 221;
            this.label8.Text = "Total Revenue Deficit Or Surplus :";
            // 
            // lblTotalRevenueDeficitOrSurplus
            // 
            this.lblTotalRevenueDeficitOrSurplus.AutoSize = true;
            this.lblTotalRevenueDeficitOrSurplus.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblTotalRevenueDeficitOrSurplus.Location = new System.Drawing.Point(773, 249);
            this.lblTotalRevenueDeficitOrSurplus.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTotalRevenueDeficitOrSurplus.Name = "lblTotalRevenueDeficitOrSurplus";
            this.lblTotalRevenueDeficitOrSurplus.Size = new System.Drawing.Size(28, 16);
            this.lblTotalRevenueDeficitOrSurplus.TabIndex = 222;
            this.lblTotalRevenueDeficitOrSurplus.Text = "???";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(83, 189);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(257, 16);
            this.label4.TabIndex = 202;
            this.label4.Text = "Total Available Fund  Cash Amount :";
            // 
            // lblStartAmount
            // 
            this.lblStartAmount.AutoSize = true;
            this.lblStartAmount.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblStartAmount.Location = new System.Drawing.Point(1027, 130);
            this.lblStartAmount.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblStartAmount.Name = "lblStartAmount";
            this.lblStartAmount.Size = new System.Drawing.Size(35, 16);
            this.lblStartAmount.TabIndex = 224;
            this.lblStartAmount.Text = "????";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label11.ForeColor = System.Drawing.Color.Red;
            this.label11.Location = new System.Drawing.Point(922, 129);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(102, 16);
            this.label11.TabIndex = 223;
            this.label11.Text = "Start Amount :";
            // 
            // guna2TabControl1
            // 
            this.guna2TabControl1.Controls.Add(this.tabPage1);
            this.guna2TabControl1.Controls.Add(this.tabBills);
            this.guna2TabControl1.ItemSize = new System.Drawing.Size(180, 40);
            this.guna2TabControl1.Location = new System.Drawing.Point(12, 341);
            this.guna2TabControl1.Name = "guna2TabControl1";
            this.guna2TabControl1.SelectedIndex = 0;
            this.guna2TabControl1.Size = new System.Drawing.Size(1146, 366);
            this.guna2TabControl1.TabButtonHoverState.BorderColor = System.Drawing.Color.Empty;
            this.guna2TabControl1.TabButtonHoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(52)))), ((int)(((byte)(70)))));
            this.guna2TabControl1.TabButtonHoverState.Font = new System.Drawing.Font("Segoe UI Semibold", 10F);
            this.guna2TabControl1.TabButtonHoverState.ForeColor = System.Drawing.Color.White;
            this.guna2TabControl1.TabButtonHoverState.InnerColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(52)))), ((int)(((byte)(70)))));
            this.guna2TabControl1.TabButtonIdleState.BorderColor = System.Drawing.Color.Empty;
            this.guna2TabControl1.TabButtonIdleState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(42)))), ((int)(((byte)(57)))));
            this.guna2TabControl1.TabButtonIdleState.Font = new System.Drawing.Font("Segoe UI Semibold", 10F);
            this.guna2TabControl1.TabButtonIdleState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(156)))), ((int)(((byte)(160)))), ((int)(((byte)(167)))));
            this.guna2TabControl1.TabButtonIdleState.InnerColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(42)))), ((int)(((byte)(57)))));
            this.guna2TabControl1.TabButtonSelectedState.BorderColor = System.Drawing.Color.Empty;
            this.guna2TabControl1.TabButtonSelectedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(37)))), ((int)(((byte)(49)))));
            this.guna2TabControl1.TabButtonSelectedState.Font = new System.Drawing.Font("Segoe UI Semibold", 10F);
            this.guna2TabControl1.TabButtonSelectedState.ForeColor = System.Drawing.Color.White;
            this.guna2TabControl1.TabButtonSelectedState.InnerColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(132)))), ((int)(((byte)(255)))));
            this.guna2TabControl1.TabButtonSize = new System.Drawing.Size(180, 40);
            this.guna2TabControl1.TabIndex = 227;
            this.guna2TabControl1.TabMenuBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(42)))), ((int)(((byte)(57)))));
            this.guna2TabControl1.TabMenuOrientation = Guna.UI2.WinForms.TabMenuOrientation.HorizontalTop;
            // 
            // tabPage1
            // 
            this.tabPage1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tabPage1.Controls.Add(this.ctrlDgvDailyFundTransaction1);
            this.tabPage1.Location = new System.Drawing.Point(4, 44);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1138, 318);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Transactions";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabBills
            // 
            this.tabBills.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tabBills.Controls.Add(this.label17);
            this.tabBills.Controls.Add(this.txtCost);
            this.tabBills.Controls.Add(this.lblAmountVBR);
            this.tabBills.Controls.Add(this.lblActualProfits);
            this.tabBills.Controls.Add(this.lblExpectedProfit);
            this.tabBills.Controls.Add(this.label16);
            this.tabBills.Controls.Add(this.label15);
            this.tabBills.Controls.Add(this.label14);
            this.tabBills.Controls.Add(this.label9);
            this.tabBills.Controls.Add(this.txtFromExpectedProfit);
            this.tabBills.Controls.Add(this.label12);
            this.tabBills.Controls.Add(this.txtFromActualProfits);
            this.tabBills.Controls.Add(this.txtAmountVBR);
            this.tabBills.Controls.Add(this.label13);
            this.tabBills.Controls.Add(this.btnPay);
            this.tabBills.Controls.Add(this.ctrlBillCardWithFilter1);
            this.tabBills.Location = new System.Drawing.Point(4, 44);
            this.tabBills.Name = "tabBills";
            this.tabBills.Padding = new System.Windows.Forms.Padding(3);
            this.tabBills.Size = new System.Drawing.Size(1138, 318);
            this.tabBills.TabIndex = 1;
            this.tabBills.Text = "Pay Daily Fund Bill";
            this.tabBills.UseVisualStyleBackColor = true;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label17.Location = new System.Drawing.Point(853, 250);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(46, 16);
            this.label17.TabIndex = 287;
            this.label17.Text = "Cost :";
            // 
            // txtCost
            // 
            this.txtCost.AutoRoundedCorners = true;
            this.txtCost.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.txtCost.BorderRadius = 13;
            this.txtCost.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtCost.DefaultText = "";
            this.txtCost.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtCost.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtCost.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtCost.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtCost.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtCost.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtCost.ForeColor = System.Drawing.Color.Black;
            this.txtCost.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtCost.Location = new System.Drawing.Point(908, 243);
            this.txtCost.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtCost.Name = "txtCost";
            this.txtCost.PasswordChar = '\0';
            this.txtCost.PlaceholderForeColor = System.Drawing.Color.Gray;
            this.txtCost.PlaceholderText = "";
            this.txtCost.ReadOnly = true;
            this.txtCost.SelectedText = "";
            this.txtCost.Size = new System.Drawing.Size(151, 28);
            this.txtCost.TabIndex = 286;
            this.txtCost.Validating += new System.ComponentModel.CancelEventHandler(this.txtCost_Validating);
            // 
            // lblAmountVBR
            // 
            this.lblAmountVBR.AutoSize = true;
            this.lblAmountVBR.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblAmountVBR.Location = new System.Drawing.Point(1039, 173);
            this.lblAmountVBR.Name = "lblAmountVBR";
            this.lblAmountVBR.Size = new System.Drawing.Size(42, 16);
            this.lblAmountVBR.TabIndex = 285;
            this.lblAmountVBR.Text = "00000";
            // 
            // lblActualProfits
            // 
            this.lblActualProfits.AutoSize = true;
            this.lblActualProfits.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblActualProfits.Location = new System.Drawing.Point(1039, 97);
            this.lblActualProfits.Name = "lblActualProfits";
            this.lblActualProfits.Size = new System.Drawing.Size(42, 16);
            this.lblActualProfits.TabIndex = 284;
            this.lblActualProfits.Text = "00000";
            // 
            // lblExpectedProfit
            // 
            this.lblExpectedProfit.AutoSize = true;
            this.lblExpectedProfit.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblExpectedProfit.Location = new System.Drawing.Point(1039, 21);
            this.lblExpectedProfit.Name = "lblExpectedProfit";
            this.lblExpectedProfit.Size = new System.Drawing.Size(42, 16);
            this.lblExpectedProfit.TabIndex = 283;
            this.lblExpectedProfit.Text = "00000";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label16.Location = new System.Drawing.Point(952, 173);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(81, 16);
            this.label16.TabIndex = 282;
            this.label16.Text = "Available :";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label15.Location = new System.Drawing.Point(952, 97);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(81, 16);
            this.label15.TabIndex = 281;
            this.label15.Text = "Available :";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label14.Location = new System.Drawing.Point(952, 21);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(81, 16);
            this.label14.TabIndex = 280;
            this.label14.Text = "Available :";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label9.Location = new System.Drawing.Point(659, 23);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(169, 17);
            this.label9.TabIndex = 279;
            this.label9.Text = "From Expected Profit :";
            // 
            // txtFromExpectedProfit
            // 
            this.txtFromExpectedProfit.AutoRoundedCorners = true;
            this.txtFromExpectedProfit.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.txtFromExpectedProfit.BorderRadius = 17;
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
            this.txtFromExpectedProfit.Location = new System.Drawing.Point(835, 12);
            this.txtFromExpectedProfit.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtFromExpectedProfit.Name = "txtFromExpectedProfit";
            this.txtFromExpectedProfit.PasswordChar = '\0';
            this.txtFromExpectedProfit.PlaceholderForeColor = System.Drawing.Color.Gray;
            this.txtFromExpectedProfit.PlaceholderText = "Amount ";
            this.txtFromExpectedProfit.SelectedText = "";
            this.txtFromExpectedProfit.Size = new System.Drawing.Size(104, 36);
            this.txtFromExpectedProfit.TabIndex = 278;
            this.txtFromExpectedProfit.TextChanged += new System.EventHandler(this.txtFromExpectedProfit_TextChanged);
            this.txtFromExpectedProfit.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtValidatePositiveDecimalNumbers_KeyPress);
            this.txtFromExpectedProfit.Validating += new System.ComponentModel.CancelEventHandler(this.txtFromExpectedProfit_Validating);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label12.Location = new System.Drawing.Point(670, 97);
            this.label12.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(156, 17);
            this.label12.TabIndex = 277;
            this.label12.Text = "From Actual Profits :";
            // 
            // txtFromActualProfits
            // 
            this.txtFromActualProfits.AutoRoundedCorners = true;
            this.txtFromActualProfits.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.txtFromActualProfits.BorderRadius = 17;
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
            this.txtFromActualProfits.Location = new System.Drawing.Point(835, 87);
            this.txtFromActualProfits.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtFromActualProfits.Name = "txtFromActualProfits";
            this.txtFromActualProfits.PasswordChar = '\0';
            this.txtFromActualProfits.PlaceholderForeColor = System.Drawing.Color.Gray;
            this.txtFromActualProfits.PlaceholderText = "Amount ";
            this.txtFromActualProfits.SelectedText = "";
            this.txtFromActualProfits.Size = new System.Drawing.Size(105, 36);
            this.txtFromActualProfits.TabIndex = 276;
            this.txtFromActualProfits.TextChanged += new System.EventHandler(this.txtFromActualProfits_TextChanged);
            this.txtFromActualProfits.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtValidatePositiveDecimalNumbers_KeyPress);
            this.txtFromActualProfits.Validating += new System.ComponentModel.CancelEventHandler(this.txtFromActualProfits_Validating);
            // 
            // txtAmountVBR
            // 
            this.txtAmountVBR.AutoRoundedCorners = true;
            this.txtAmountVBR.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.txtAmountVBR.BorderRadius = 17;
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
            this.txtAmountVBR.Location = new System.Drawing.Point(835, 162);
            this.txtAmountVBR.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtAmountVBR.Name = "txtAmountVBR";
            this.txtAmountVBR.PasswordChar = '\0';
            this.txtAmountVBR.PlaceholderForeColor = System.Drawing.Color.Gray;
            this.txtAmountVBR.PlaceholderText = "Amount ";
            this.txtAmountVBR.SelectedText = "";
            this.txtAmountVBR.Size = new System.Drawing.Size(105, 36);
            this.txtAmountVBR.TabIndex = 275;
            this.txtAmountVBR.TextChanged += new System.EventHandler(this.txtAmountVBR_TextChanged);
            this.txtAmountVBR.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtValidatePositiveDecimalNumbers_KeyPress);
            this.txtAmountVBR.Validating += new System.ComponentModel.CancelEventHandler(this.txtAmountVBR_Validating);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label13.ForeColor = System.Drawing.Color.Black;
            this.label13.Location = new System.Drawing.Point(682, 171);
            this.label13.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(143, 17);
            this.label13.TabIndex = 274;
            this.label13.Text = "From Vehicle.B.R :";
            this.label13.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnPay
            // 
            this.btnPay.AutoRoundedCorners = true;
            this.btnPay.BorderRadius = 13;
            this.btnPay.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnPay.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnPay.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnPay.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnPay.FillColor = System.Drawing.Color.Black;
            this.btnPay.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnPay.ForeColor = System.Drawing.Color.White;
            this.btnPay.Location = new System.Drawing.Point(661, 243);
            this.btnPay.Name = "btnPay";
            this.btnPay.Size = new System.Drawing.Size(148, 28);
            this.btnPay.TabIndex = 4;
            this.btnPay.Text = "Pay";
            this.btnPay.Click += new System.EventHandler(this.btnPay_Click);
            // 
            // errorProviderPayBill
            // 
            this.errorProviderPayBill.ContainerControl = this;
            // 
            // lblSratDate
            // 
            this.lblSratDate.AutoSize = true;
            this.lblSratDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblSratDate.Location = new System.Drawing.Point(175, 73);
            this.lblSratDate.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSratDate.Name = "lblSratDate";
            this.lblSratDate.Size = new System.Drawing.Size(49, 16);
            this.lblSratDate.TabIndex = 229;
            this.lblSratDate.Text = "??????";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label19.Location = new System.Drawing.Point(83, 72);
            this.label19.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(84, 16);
            this.label19.TabIndex = 228;
            this.label19.Text = "Start Date :";
            // 
            // ctrlDgvDailyFundTransaction1
            // 
            this.ctrlDgvDailyFundTransaction1.BackColor = System.Drawing.Color.White;
            this.ctrlDgvDailyFundTransaction1.Location = new System.Drawing.Point(9, 15);
            this.ctrlDgvDailyFundTransaction1.Margin = new System.Windows.Forms.Padding(2);
            this.ctrlDgvDailyFundTransaction1.Name = "ctrlDgvDailyFundTransaction1";
            this.ctrlDgvDailyFundTransaction1.Size = new System.Drawing.Size(1112, 296);
            this.ctrlDgvDailyFundTransaction1.SupportingFundLiquidityStripMenuItem = true;
            this.ctrlDgvDailyFundTransaction1.TabIndex = 0;
            // 
            // ctrlBillCardWithFilter1
            // 
            this.ctrlBillCardWithFilter1.AutoSize = true;
            this.ctrlBillCardWithFilter1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ctrlBillCardWithFilter1.FilterEnabled = true;
            this.ctrlBillCardWithFilter1.Location = new System.Drawing.Point(6, 6);
            this.ctrlBillCardWithFilter1.Name = "ctrlBillCardWithFilter1";
            this.ctrlBillCardWithFilter1.Size = new System.Drawing.Size(636, 265);
            this.ctrlBillCardWithFilter1.TabIndex = 0;
            this.ctrlBillCardWithFilter1.UpdateVisible = false;
            this.ctrlBillCardWithFilter1.OnBillSelected += new System.Action<int>(this.ctrlBillCardWithFilter1_OnBillSelected);
            // 
            // frmDailyIncomeFund
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange;
            this.BackColor = System.Drawing.Color.White;
            this.CancelButton = this.btnClose;
            this.ClientSize = new System.Drawing.Size(1171, 761);
            this.Controls.Add(this.lblSratDate);
            this.Controls.Add(this.label19);
            this.Controls.Add(this.guna2TabControl1);
            this.Controls.Add(this.lblStartAmount);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.lblTotalRevenueDeficitOrSurplus);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.lblstatus);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtTotalAvailableCashAmount);
            this.Controls.Add(this.lblTransformation);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.lblTotalIncomeCashAmount);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lblIsCLose);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnFundClose);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.lblTotalIncome);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtTotalAvailableTransformationAmount);
            this.Controls.Add(this.lblModeTitle);
            this.Name = "frmDailyIncomeFund";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Daily Fund Management";
            this.Load += new System.EventHandler(this.frmDailyFundManagement_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.guna2TabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabBills.ResumeLayout(false);
            this.tabBills.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderPayBill)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblModeTitle;
        private Guna.UI2.WinForms.Guna2TextBox txtTotalAvailableTransformationAmount;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblTotalIncome;
        private System.Windows.Forms.Button btnFundClose;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Label lblIsCLose;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblTotalIncomeCashAmount;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblTransformation;
        private System.Windows.Forms.Label label7;
        private Guna.UI2.WinForms.Guna2TextBox txtTotalAvailableCashAmount;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblstatus;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label lblTotalRevenueDeficitOrSurplus;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblStartAmount;
        private System.Windows.Forms.Label label11;
        private Guna.UI2.WinForms.Guna2TabControl guna2TabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabBills;
        private Bill.Controls.ctrlBillCardWithFilter ctrlBillCardWithFilter1;
        private Guna.UI2.WinForms.Guna2Button btnPay;
        private ctrlDgvDailyFundTransaction ctrlDgvDailyFundTransaction1;
        private System.Windows.Forms.Label label9;
        private Guna.UI2.WinForms.Guna2TextBox txtFromExpectedProfit;
        private System.Windows.Forms.Label label12;
        private Guna.UI2.WinForms.Guna2TextBox txtFromActualProfits;
        private Guna.UI2.WinForms.Guna2TextBox txtAmountVBR;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label lblAmountVBR;
        private System.Windows.Forms.Label lblActualProfits;
        private System.Windows.Forms.Label lblExpectedProfit;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.ErrorProvider errorProviderPayBill;
        private System.Windows.Forms.Label label17;
        private Guna.UI2.WinForms.Guna2TextBox txtCost;
        private System.Windows.Forms.Label lblSratDate;
        private System.Windows.Forms.Label label19;
    }
}