namespace CarRental.Rental_Fund.General_Revenue_Fund
{
    partial class frmAddUpdateAmountSpent
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
            this.cmbPayment = new Guna.UI2.WinForms.Guna2ComboBox();
            this.txtwithdrawalsDetails = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtAmount = new Guna.UI2.WinForms.Guna2TextBox();
            this.btnClose = new Guna.UI2.WinForms.Guna2Button();
            this.label8 = new System.Windows.Forms.Label();
            this.btnSave = new Guna.UI2.WinForms.Guna2Button();
            this.lbltitleTransaction = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.lable = new System.Windows.Forms.Label();
            this.lblPreviousAmount = new System.Windows.Forms.Label();
            this.txtAmountVBR = new Guna.UI2.WinForms.Guna2TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtFromAnotherIncome = new Guna.UI2.WinForms.Guna2TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtFromActualProfits = new Guna.UI2.WinForms.Guna2TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtFromExpectedProfit = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtFromVehicleSales = new Guna.UI2.WinForms.Guna2TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.ctrlGeneralRevenueFundCardWithIncomeDetails1 = new CarRental.General_Revenue_Fund.ctrlGeneralRevenueFundCardWithIncomeDetails();
            this.lblNotMoreThan = new System.Windows.Forms.Label();
            this.lblTitleNotMoreThan = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
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
            this.cmbPayment.Location = new System.Drawing.Point(17, 304);
            this.cmbPayment.Name = "cmbPayment";
            this.cmbPayment.Size = new System.Drawing.Size(200, 36);
            this.cmbPayment.StartIndex = 0;
            this.cmbPayment.TabIndex = 160;
            // 
            // txtwithdrawalsDetails
            // 
            this.txtwithdrawalsDetails.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.txtwithdrawalsDetails.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtwithdrawalsDetails.DefaultText = "";
            this.txtwithdrawalsDetails.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtwithdrawalsDetails.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtwithdrawalsDetails.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtwithdrawalsDetails.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtwithdrawalsDetails.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtwithdrawalsDetails.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtwithdrawalsDetails.ForeColor = System.Drawing.Color.Black;
            this.txtwithdrawalsDetails.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtwithdrawalsDetails.Location = new System.Drawing.Point(290, 304);
            this.txtwithdrawalsDetails.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtwithdrawalsDetails.Multiline = true;
            this.txtwithdrawalsDetails.Name = "txtwithdrawalsDetails";
            this.txtwithdrawalsDetails.PasswordChar = '\0';
            this.txtwithdrawalsDetails.PlaceholderForeColor = System.Drawing.Color.Gray;
            this.txtwithdrawalsDetails.PlaceholderText = "Details";
            this.txtwithdrawalsDetails.SelectedText = "";
            this.txtwithdrawalsDetails.Size = new System.Drawing.Size(444, 94);
            this.txtwithdrawalsDetails.TabIndex = 159;
            this.txtwithdrawalsDetails.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtAmount
            // 
            this.txtAmount.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.txtAmount.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtAmount.DefaultText = "0";
            this.txtAmount.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtAmount.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtAmount.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtAmount.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtAmount.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtAmount.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtAmount.ForeColor = System.Drawing.Color.Black;
            this.txtAmount.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtAmount.Location = new System.Drawing.Point(535, 260);
            this.txtAmount.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtAmount.Name = "txtAmount";
            this.txtAmount.PasswordChar = '\0';
            this.txtAmount.PlaceholderForeColor = System.Drawing.Color.Gray;
            this.txtAmount.PlaceholderText = "Amount ";
            this.txtAmount.ReadOnly = true;
            this.txtAmount.SelectedText = "";
            this.txtAmount.Size = new System.Drawing.Size(199, 36);
            this.txtAmount.TabIndex = 158;
            this.txtAmount.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtAmount_KeyPress);
            this.txtAmount.Validating += new System.ComponentModel.CancelEventHandler(this.txtFromAnotherIncome_Validating);
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.Black;
            this.btnClose.BorderColor = System.Drawing.Color.White;
            this.btnClose.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnClose.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnClose.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnClose.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnClose.FillColor = System.Drawing.Color.Black;
            this.btnClose.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnClose.ForeColor = System.Drawing.Color.White;
            this.btnClose.Location = new System.Drawing.Point(599, 574);
            this.btnClose.Margin = new System.Windows.Forms.Padding(2);
            this.btnClose.Name = "btnClose";
            this.btnClose.PressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnClose.Size = new System.Drawing.Size(135, 33);
            this.btnClose.TabIndex = 166;
            this.btnClose.Text = "Close";
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label8.ForeColor = System.Drawing.Color.SlateBlue;
            this.label8.Location = new System.Drawing.Point(12, 77);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(271, 26);
            this.label8.TabIndex = 245;
            this.label8.Text = "General Revenue Fund :";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.Black;
            this.btnSave.BorderColor = System.Drawing.Color.White;
            this.btnSave.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnSave.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnSave.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnSave.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnSave.FillColor = System.Drawing.Color.Black;
            this.btnSave.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnSave.ForeColor = System.Drawing.Color.White;
            this.btnSave.Location = new System.Drawing.Point(599, 530);
            this.btnSave.Margin = new System.Windows.Forms.Padding(2);
            this.btnSave.Name = "btnSave";
            this.btnSave.PressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnSave.Size = new System.Drawing.Size(135, 33);
            this.btnSave.TabIndex = 246;
            this.btnSave.Text = "Save";
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // lbltitleTransaction
            // 
            this.lbltitleTransaction.Dock = System.Windows.Forms.DockStyle.Top;
            this.lbltitleTransaction.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbltitleTransaction.ForeColor = System.Drawing.Color.SlateBlue;
            this.lbltitleTransaction.Location = new System.Drawing.Point(0, 0);
            this.lbltitleTransaction.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbltitleTransaction.Name = "lbltitleTransaction";
            this.lbltitleTransaction.Size = new System.Drawing.Size(754, 44);
            this.lbltitleTransaction.TabIndex = 260;
            this.lbltitleTransaction.Text = "Add New / Update";
            this.lbltitleTransaction.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lbltitleTransaction.Click += new System.EventHandler(this.lbltitleTransaction_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(476, 479);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(143, 17);
            this.label4.TabIndex = 261;
            this.label4.Text = "From Vehicle.B.R :";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // lable
            // 
            this.lable.AutoSize = true;
            this.lable.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lable.Location = new System.Drawing.Point(13, 268);
            this.lable.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lable.Name = "lable";
            this.lable.Size = new System.Drawing.Size(140, 17);
            this.lable.TabIndex = 263;
            this.lable.Text = "Previous Amount :";
            // 
            // lblPreviousAmount
            // 
            this.lblPreviousAmount.AutoSize = true;
            this.lblPreviousAmount.Location = new System.Drawing.Point(154, 270);
            this.lblPreviousAmount.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPreviousAmount.Name = "lblPreviousAmount";
            this.lblPreviousAmount.Size = new System.Drawing.Size(22, 13);
            this.lblPreviousAmount.TabIndex = 264;
            this.lblPreviousAmount.Text = "0.0";
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
            this.txtAmountVBR.Location = new System.Drawing.Point(629, 471);
            this.txtAmountVBR.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtAmountVBR.Name = "txtAmountVBR";
            this.txtAmountVBR.PasswordChar = '\0';
            this.txtAmountVBR.PlaceholderForeColor = System.Drawing.Color.Gray;
            this.txtAmountVBR.PlaceholderText = "Amount ";
            this.txtAmountVBR.SelectedText = "";
            this.txtAmountVBR.Size = new System.Drawing.Size(105, 36);
            this.txtAmountVBR.TabIndex = 265;
            this.txtAmountVBR.TextChanged += new System.EventHandler(this.txtAmountVBR_TextChanged);
            this.txtAmountVBR.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtAmount_KeyPress);
            this.txtAmountVBR.Validating += new System.ComponentModel.CancelEventHandler(this.txtFromAnotherIncome_Validating);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(413, 269);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(114, 17);
            this.label1.TabIndex = 267;
            this.label1.Text = "Total Amount :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(10, 479);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(172, 17);
            this.label2.TabIndex = 269;
            this.label2.Text = "From Another Income :";
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
            this.txtFromAnotherIncome.Location = new System.Drawing.Point(185, 471);
            this.txtFromAnotherIncome.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtFromAnotherIncome.Name = "txtFromAnotherIncome";
            this.txtFromAnotherIncome.PasswordChar = '\0';
            this.txtFromAnotherIncome.PlaceholderForeColor = System.Drawing.Color.Gray;
            this.txtFromAnotherIncome.PlaceholderText = "Amount ";
            this.txtFromAnotherIncome.SelectedText = "";
            this.txtFromAnotherIncome.Size = new System.Drawing.Size(105, 36);
            this.txtFromAnotherIncome.TabIndex = 268;
            this.txtFromAnotherIncome.TextChanged += new System.EventHandler(this.txtFromAnotherIncome_TextChanged);
            this.txtFromAnotherIncome.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtAmount_KeyPress);
            this.txtFromAnotherIncome.Validating += new System.ComponentModel.CancelEventHandler(this.txtFromAnotherIncome_Validating);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(464, 417);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(156, 17);
            this.label3.TabIndex = 271;
            this.label3.Text = "From Actual Profits :";
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
            this.txtFromActualProfits.Location = new System.Drawing.Point(629, 406);
            this.txtFromActualProfits.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtFromActualProfits.Name = "txtFromActualProfits";
            this.txtFromActualProfits.PasswordChar = '\0';
            this.txtFromActualProfits.PlaceholderForeColor = System.Drawing.Color.Gray;
            this.txtFromActualProfits.PlaceholderText = "Amount ";
            this.txtFromActualProfits.SelectedText = "";
            this.txtFromActualProfits.Size = new System.Drawing.Size(105, 36);
            this.txtFromActualProfits.TabIndex = 270;
            this.txtFromActualProfits.TextChanged += new System.EventHandler(this.txtFromActualProfits_TextChanged);
            this.txtFromActualProfits.Validating += new System.ComponentModel.CancelEventHandler(this.txtFromAnotherIncome_Validating);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(9, 417);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(169, 17);
            this.label5.TabIndex = 273;
            this.label5.Text = "From Expected Profit :";
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
            this.txtFromExpectedProfit.Location = new System.Drawing.Point(185, 406);
            this.txtFromExpectedProfit.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtFromExpectedProfit.Name = "txtFromExpectedProfit";
            this.txtFromExpectedProfit.PasswordChar = '\0';
            this.txtFromExpectedProfit.PlaceholderForeColor = System.Drawing.Color.Gray;
            this.txtFromExpectedProfit.PlaceholderText = "Amount ";
            this.txtFromExpectedProfit.SelectedText = "";
            this.txtFromExpectedProfit.Size = new System.Drawing.Size(104, 36);
            this.txtFromExpectedProfit.TabIndex = 272;
            this.txtFromExpectedProfit.TextChanged += new System.EventHandler(this.txtFromExpectedProfit_TextChanged);
            this.txtFromExpectedProfit.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtAmount_KeyPress);
            this.txtFromExpectedProfit.Validating += new System.ComponentModel.CancelEventHandler(this.txtFromAnotherIncome_Validating);
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
            this.txtFromVehicleSales.Location = new System.Drawing.Point(185, 527);
            this.txtFromVehicleSales.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtFromVehicleSales.Name = "txtFromVehicleSales";
            this.txtFromVehicleSales.PasswordChar = '\0';
            this.txtFromVehicleSales.PlaceholderForeColor = System.Drawing.Color.Gray;
            this.txtFromVehicleSales.PlaceholderText = "Amount ";
            this.txtFromVehicleSales.SelectedText = "";
            this.txtFromVehicleSales.Size = new System.Drawing.Size(105, 36);
            this.txtFromVehicleSales.TabIndex = 275;
            this.txtFromVehicleSales.TextChanged += new System.EventHandler(this.txtFromVehicleSales_TextChanged);
            this.txtFromVehicleSales.Validating += new System.ComponentModel.CancelEventHandler(this.txtFromVehicleSales_Validating);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(15, 535);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(159, 18);
            this.label6.TabIndex = 274;
            this.label6.Text = "From VehicleSales :";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ctrlGeneralRevenueFundCardWithIncomeDetails1
            // 
            this.ctrlGeneralRevenueFundCardWithIncomeDetails1.AutoSize = true;
            this.ctrlGeneralRevenueFundCardWithIncomeDetails1.BackColor = System.Drawing.Color.White;
            this.ctrlGeneralRevenueFundCardWithIncomeDetails1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ctrlGeneralRevenueFundCardWithIncomeDetails1.Location = new System.Drawing.Point(12, 112);
            this.ctrlGeneralRevenueFundCardWithIncomeDetails1.Margin = new System.Windows.Forms.Padding(4);
            this.ctrlGeneralRevenueFundCardWithIncomeDetails1.Name = "ctrlGeneralRevenueFundCardWithIncomeDetails1";
            this.ctrlGeneralRevenueFundCardWithIncomeDetails1.Size = new System.Drawing.Size(590, 134);
            this.ctrlGeneralRevenueFundCardWithIncomeDetails1.TabIndex = 266;
            // 
            // lblNotMoreThan
            // 
            this.lblNotMoreThan.AutoSize = true;
            this.lblNotMoreThan.Location = new System.Drawing.Point(538, 88);
            this.lblNotMoreThan.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblNotMoreThan.Name = "lblNotMoreThan";
            this.lblNotMoreThan.Size = new System.Drawing.Size(22, 13);
            this.lblNotMoreThan.TabIndex = 277;
            this.lblNotMoreThan.Text = "0.0";
            // 
            // lblTitleNotMoreThan
            // 
            this.lblTitleNotMoreThan.AutoSize = true;
            this.lblTitleNotMoreThan.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblTitleNotMoreThan.Location = new System.Drawing.Point(413, 84);
            this.lblTitleNotMoreThan.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTitleNotMoreThan.Name = "lblTitleNotMoreThan";
            this.lblTitleNotMoreThan.Size = new System.Drawing.Size(121, 17);
            this.lblTitleNotMoreThan.TabIndex = 276;
            this.lblTitleNotMoreThan.Text = "Not more than :";
            this.lblTitleNotMoreThan.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // frmAddUpdateAmountSpent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(754, 618);
            this.Controls.Add(this.lblNotMoreThan);
            this.Controls.Add(this.lblTitleNotMoreThan);
            this.Controls.Add(this.txtFromVehicleSales);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtFromExpectedProfit);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtFromActualProfits);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtFromAnotherIncome);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ctrlGeneralRevenueFundCardWithIncomeDetails1);
            this.Controls.Add(this.txtAmountVBR);
            this.Controls.Add(this.lblPreviousAmount);
            this.Controls.Add(this.lable);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lbltitleTransaction);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.cmbPayment);
            this.Controls.Add(this.txtwithdrawalsDetails);
            this.Controls.Add(this.txtAmount);
            this.Controls.Add(this.btnClose);
            this.Name = "frmAddUpdateAmountSpent";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add Update Amount Spent";
            this.Load += new System.EventHandler(this.frmAddUpdateAmountSpent_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Guna.UI2.WinForms.Guna2ComboBox cmbPayment;
        private Guna.UI2.WinForms.Guna2TextBox txtwithdrawalsDetails;
        private Guna.UI2.WinForms.Guna2TextBox txtAmount;
        private Guna.UI2.WinForms.Guna2Button btnClose;
        private System.Windows.Forms.Label label8;
        private Guna.UI2.WinForms.Guna2Button btnSave;
        private System.Windows.Forms.Label lbltitleTransaction;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Label lable;
        private System.Windows.Forms.Label lblPreviousAmount;
        private Guna.UI2.WinForms.Guna2TextBox txtAmountVBR;
        private CarRental.General_Revenue_Fund.ctrlGeneralRevenueFundCardWithIncomeDetails ctrlGeneralRevenueFundCardWithIncomeDetails1;
        private System.Windows.Forms.Label label2;
        private Guna.UI2.WinForms.Guna2TextBox txtFromAnotherIncome;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private Guna.UI2.WinForms.Guna2TextBox txtFromExpectedProfit;
        private System.Windows.Forms.Label label3;
        private Guna.UI2.WinForms.Guna2TextBox txtFromActualProfits;
        private Guna.UI2.WinForms.Guna2TextBox txtFromVehicleSales;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblNotMoreThan;
        private System.Windows.Forms.Label lblTitleNotMoreThan;
    }
}