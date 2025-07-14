namespace CarRental
{
    partial class frmAddNewBooking
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
            this.TabTransAcitonBooking = new Guna.UI2.WinForms.Guna2TabControl();
            this.tabShoseVehicle = new System.Windows.Forms.TabPage();
            this.ctrlVehicleWithFilter1 = new CarRental.Vehicles.ctrlVehicleWithFilter();
            this.tabBookingInfo = new System.Windows.Forms.TabPage();
            this.dtpEndDate = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.gbMonthlyCustomRent = new System.Windows.Forms.GroupBox();
            this.lblTitleNumberOfDaysInMonths = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.txtNumberOfDaysInMonths = new Guna.UI2.WinForms.Guna2TextBox();
            this.NUDNumberOfMonths = new System.Windows.Forms.NumericUpDown();
            this.label19 = new System.Windows.Forms.Label();
            this.tsMonthly = new Guna.UI2.WinForms.Guna2ToggleSwitch();
            this.label17 = new System.Windows.Forms.Label();
            this.txtPricePerMonth = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtInitialTotalDueAmountAfterTax = new Guna.UI2.WinForms.Guna2TextBox();
            this.label18 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.txtFreeKilometersCredit = new Guna.UI2.WinForms.Guna2TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtRentalPricePerDay = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtInitialTotalDueAmount = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtInitialRental = new Guna.UI2.WinForms.Guna2TextBox();
            this.tabCustomerInfo = new System.Windows.Forms.TabPage();
            this.ctrlCustomerCardWithFilter1 = new CarRental.ctrlCustomerCardWithFilter();
            this.tapInitialPaymentMethodID = new System.Windows.Forms.TabPage();
            this.lblRentalPricePerMonth = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.lblInitialRentalMonths = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.txtPaidInitialTotalDueAmount = new Guna.UI2.WinForms.Guna2TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.txtCheckID = new Guna.UI2.WinForms.Guna2TextBox();
            this.btnAddInitialCheck = new System.Windows.Forms.Button();
            this.lblTax = new System.Windows.Forms.Label();
            this.lable30 = new System.Windows.Forms.Label();
            this.lblInitialTotalDueAmountAfterTax = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.lblInitialRentalDays = new System.Windows.Forms.Label();
            this.lblEndDate = new System.Windows.Forms.Label();
            this.lblStartDate = new System.Windows.Forms.Label();
            this.lblInitialTotalDueAmount = new System.Windows.Forms.Label();
            this.lblRentalPricePerDay = new System.Windows.Forms.Label();
            this.lblPickupLocation = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.cmPayMentDetails = new Guna.UI2.WinForms.Guna2ComboBox();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.guna2BorderlessForm1 = new Guna.UI2.WinForms.Guna2BorderlessForm(this.components);
            this.btnClose = new System.Windows.Forms.Button();
            this.btnNext = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.lblTitle = new System.Windows.Forms.Label();
            this.ctrlPrintContract1 = new CarRental.Rental_Transaction.Controls.ctrlPrintContract();
            this.TabTransAcitonBooking.SuspendLayout();
            this.tabShoseVehicle.SuspendLayout();
            this.tabBookingInfo.SuspendLayout();
            this.gbMonthlyCustomRent.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NUDNumberOfMonths)).BeginInit();
            this.tabCustomerInfo.SuspendLayout();
            this.tapInitialPaymentMethodID.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // TabTransAcitonBooking
            // 
            this.TabTransAcitonBooking.Alignment = System.Windows.Forms.TabAlignment.Left;
            this.TabTransAcitonBooking.Controls.Add(this.tabShoseVehicle);
            this.TabTransAcitonBooking.Controls.Add(this.tabBookingInfo);
            this.TabTransAcitonBooking.Controls.Add(this.tabCustomerInfo);
            this.TabTransAcitonBooking.Controls.Add(this.tapInitialPaymentMethodID);
            this.TabTransAcitonBooking.ItemSize = new System.Drawing.Size(185, 40);
            this.TabTransAcitonBooking.Location = new System.Drawing.Point(0, 41);
            this.TabTransAcitonBooking.Margin = new System.Windows.Forms.Padding(2);
            this.TabTransAcitonBooking.Name = "TabTransAcitonBooking";
            this.TabTransAcitonBooking.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.TabTransAcitonBooking.SelectedIndex = 0;
            this.TabTransAcitonBooking.Size = new System.Drawing.Size(1065, 513);
            this.TabTransAcitonBooking.TabButtonHoverState.BorderColor = System.Drawing.Color.Empty;
            this.TabTransAcitonBooking.TabButtonHoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(52)))), ((int)(((byte)(70)))));
            this.TabTransAcitonBooking.TabButtonHoverState.Font = new System.Drawing.Font("Segoe UI Semibold", 10F);
            this.TabTransAcitonBooking.TabButtonHoverState.ForeColor = System.Drawing.Color.White;
            this.TabTransAcitonBooking.TabButtonHoverState.InnerColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(52)))), ((int)(((byte)(70)))));
            this.TabTransAcitonBooking.TabButtonIdleState.BorderColor = System.Drawing.Color.Empty;
            this.TabTransAcitonBooking.TabButtonIdleState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(42)))), ((int)(((byte)(57)))));
            this.TabTransAcitonBooking.TabButtonIdleState.Font = new System.Drawing.Font("Segoe UI Semibold", 10F);
            this.TabTransAcitonBooking.TabButtonIdleState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(156)))), ((int)(((byte)(160)))), ((int)(((byte)(167)))));
            this.TabTransAcitonBooking.TabButtonIdleState.InnerColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(42)))), ((int)(((byte)(57)))));
            this.TabTransAcitonBooking.TabButtonSelectedState.BorderColor = System.Drawing.Color.Empty;
            this.TabTransAcitonBooking.TabButtonSelectedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(37)))), ((int)(((byte)(49)))));
            this.TabTransAcitonBooking.TabButtonSelectedState.Font = new System.Drawing.Font("Segoe UI Semibold", 10F);
            this.TabTransAcitonBooking.TabButtonSelectedState.ForeColor = System.Drawing.Color.White;
            this.TabTransAcitonBooking.TabButtonSelectedState.InnerColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(132)))), ((int)(((byte)(255)))));
            this.TabTransAcitonBooking.TabButtonSize = new System.Drawing.Size(185, 40);
            this.TabTransAcitonBooking.TabIndex = 0;
            this.TabTransAcitonBooking.TabMenuBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(42)))), ((int)(((byte)(57)))));
            this.TabTransAcitonBooking.SelectedIndexChanged += new System.EventHandler(this.TabTransAcitonBooking_SelectedIndexChanged);
            // 
            // tabShoseVehicle
            // 
            this.tabShoseVehicle.Controls.Add(this.ctrlVehicleWithFilter1);
            this.tabShoseVehicle.Location = new System.Drawing.Point(189, 4);
            this.tabShoseVehicle.Margin = new System.Windows.Forms.Padding(2);
            this.tabShoseVehicle.Name = "tabShoseVehicle";
            this.tabShoseVehicle.Padding = new System.Windows.Forms.Padding(2);
            this.tabShoseVehicle.Size = new System.Drawing.Size(872, 505);
            this.tabShoseVehicle.TabIndex = 1;
            this.tabShoseVehicle.Text = "Shose Vehicle";
            this.tabShoseVehicle.UseVisualStyleBackColor = true;
            this.tabShoseVehicle.Click += new System.EventHandler(this.TabBookingInfo_Click);
            // 
            // ctrlVehicleWithFilter1
            // 
            this.ctrlVehicleWithFilter1.AutoSize = true;
            this.ctrlVehicleWithFilter1.BackColor = System.Drawing.Color.White;
            this.ctrlVehicleWithFilter1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ctrlVehicleWithFilter1.EditedVisible = false;
            this.ctrlVehicleWithFilter1.FilterEnabled = true;
            this.ctrlVehicleWithFilter1.Location = new System.Drawing.Point(109, 49);
            this.ctrlVehicleWithFilter1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.ctrlVehicleWithFilter1.Name = "ctrlVehicleWithFilter1";
            this.ctrlVehicleWithFilter1.Size = new System.Drawing.Size(633, 373);
            this.ctrlVehicleWithFilter1.TabIndex = 0;
            this.ctrlVehicleWithFilter1.OnVehicleSelected += new System.Action<int>(this.ctrlVehicleWithFilter1_OnVehicleSelected);
            // 
            // tabBookingInfo
            // 
            this.tabBookingInfo.Controls.Add(this.dtpEndDate);
            this.tabBookingInfo.Controls.Add(this.label6);
            this.tabBookingInfo.Controls.Add(this.gbMonthlyCustomRent);
            this.tabBookingInfo.Controls.Add(this.label19);
            this.tabBookingInfo.Controls.Add(this.tsMonthly);
            this.tabBookingInfo.Controls.Add(this.label17);
            this.tabBookingInfo.Controls.Add(this.txtPricePerMonth);
            this.tabBookingInfo.Controls.Add(this.txtInitialTotalDueAmountAfterTax);
            this.tabBookingInfo.Controls.Add(this.label18);
            this.tabBookingInfo.Controls.Add(this.label14);
            this.tabBookingInfo.Controls.Add(this.txtFreeKilometersCredit);
            this.tabBookingInfo.Controls.Add(this.label7);
            this.tabBookingInfo.Controls.Add(this.label3);
            this.tabBookingInfo.Controls.Add(this.label2);
            this.tabBookingInfo.Controls.Add(this.txtRentalPricePerDay);
            this.tabBookingInfo.Controls.Add(this.txtInitialTotalDueAmount);
            this.tabBookingInfo.Controls.Add(this.txtInitialRental);
            this.tabBookingInfo.Location = new System.Drawing.Point(189, 4);
            this.tabBookingInfo.Margin = new System.Windows.Forms.Padding(2);
            this.tabBookingInfo.Name = "tabBookingInfo";
            this.tabBookingInfo.Padding = new System.Windows.Forms.Padding(2);
            this.tabBookingInfo.Size = new System.Drawing.Size(872, 505);
            this.tabBookingInfo.TabIndex = 3;
            this.tabBookingInfo.Text = " Booking Information";
            this.tabBookingInfo.UseVisualStyleBackColor = true;
            this.tabBookingInfo.Click += new System.EventHandler(this.tabBookingInfo_Click_1);
            // 
            // dtpEndDate
            // 
            this.dtpEndDate.CustomFormat = "   dd/M/yyyy";
            this.dtpEndDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpEndDate.Location = new System.Drawing.Point(178, 118);
            this.dtpEndDate.Margin = new System.Windows.Forms.Padding(2);
            this.dtpEndDate.MinDate = new System.DateTime(2023, 12, 25, 0, 0, 0, 0);
            this.dtpEndDate.Name = "dtpEndDate";
            this.dtpEndDate.Size = new System.Drawing.Size(165, 20);
            this.dtpEndDate.TabIndex = 37;
            this.dtpEndDate.Value = new System.DateTime(2023, 12, 25, 0, 0, 0, 0);
            this.dtpEndDate.ValueChanged += new System.EventHandler(this.dtpEndDate_ValueChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.CausesValidation = false;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(100, 122);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(69, 16);
            this.label6.TabIndex = 38;
            this.label6.Text = "End Date :";
            // 
            // gbMonthlyCustomRent
            // 
            this.gbMonthlyCustomRent.Controls.Add(this.lblTitleNumberOfDaysInMonths);
            this.gbMonthlyCustomRent.Controls.Add(this.label20);
            this.gbMonthlyCustomRent.Controls.Add(this.txtNumberOfDaysInMonths);
            this.gbMonthlyCustomRent.Controls.Add(this.NUDNumberOfMonths);
            this.gbMonthlyCustomRent.Location = new System.Drawing.Point(436, 153);
            this.gbMonthlyCustomRent.Margin = new System.Windows.Forms.Padding(2);
            this.gbMonthlyCustomRent.Name = "gbMonthlyCustomRent";
            this.gbMonthlyCustomRent.Padding = new System.Windows.Forms.Padding(2);
            this.gbMonthlyCustomRent.Size = new System.Drawing.Size(365, 80);
            this.gbMonthlyCustomRent.TabIndex = 36;
            this.gbMonthlyCustomRent.TabStop = false;
            this.gbMonthlyCustomRent.Visible = false;
            // 
            // lblTitleNumberOfDaysInMonths
            // 
            this.lblTitleNumberOfDaysInMonths.AutoSize = true;
            this.lblTitleNumberOfDaysInMonths.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblTitleNumberOfDaysInMonths.Location = new System.Drawing.Point(10, 55);
            this.lblTitleNumberOfDaysInMonths.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTitleNumberOfDaysInMonths.Name = "lblTitleNumberOfDaysInMonths";
            this.lblTitleNumberOfDaysInMonths.Size = new System.Drawing.Size(171, 16);
            this.lblTitleNumberOfDaysInMonths.TabIndex = 40;
            this.lblTitleNumberOfDaysInMonths.Text = "Number Of Days In Months :";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.CausesValidation = false;
            this.label20.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label20.Location = new System.Drawing.Point(59, 15);
            this.label20.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(56, 16);
            this.label20.TabIndex = 37;
            this.label20.Text = "Months :";
            this.label20.Click += new System.EventHandler(this.label20_Click_1);
            // 
            // txtNumberOfDaysInMonths
            // 
            this.txtNumberOfDaysInMonths.BorderColor = System.Drawing.Color.SlateBlue;
            this.txtNumberOfDaysInMonths.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtNumberOfDaysInMonths.DefaultText = "";
            this.txtNumberOfDaysInMonths.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtNumberOfDaysInMonths.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtNumberOfDaysInMonths.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtNumberOfDaysInMonths.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtNumberOfDaysInMonths.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtNumberOfDaysInMonths.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtNumberOfDaysInMonths.ForeColor = System.Drawing.Color.Black;
            this.txtNumberOfDaysInMonths.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtNumberOfDaysInMonths.Location = new System.Drawing.Point(189, 51);
            this.txtNumberOfDaysInMonths.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.txtNumberOfDaysInMonths.Name = "txtNumberOfDaysInMonths";
            this.txtNumberOfDaysInMonths.PasswordChar = '\0';
            this.txtNumberOfDaysInMonths.PlaceholderText = "";
            this.txtNumberOfDaysInMonths.ReadOnly = true;
            this.txtNumberOfDaysInMonths.SelectedText = "";
            this.txtNumberOfDaysInMonths.Size = new System.Drawing.Size(172, 24);
            this.txtNumberOfDaysInMonths.TabIndex = 39;
            // 
            // NUDNumberOfMonths
            // 
            this.NUDNumberOfMonths.Location = new System.Drawing.Point(138, 14);
            this.NUDNumberOfMonths.Margin = new System.Windows.Forms.Padding(2);
            this.NUDNumberOfMonths.Maximum = new decimal(new int[] {
            11,
            0,
            0,
            0});
            this.NUDNumberOfMonths.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.NUDNumberOfMonths.Name = "NUDNumberOfMonths";
            this.NUDNumberOfMonths.Size = new System.Drawing.Size(160, 20);
            this.NUDNumberOfMonths.TabIndex = 0;
            this.NUDNumberOfMonths.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.NUDNumberOfMonths.ValueChanged += new System.EventHandler(this.numericUpDown1_ValueChanged);
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.CausesValidation = false;
            this.label19.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label19.Location = new System.Drawing.Point(108, 72);
            this.label19.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(59, 16);
            this.label19.TabIndex = 35;
            this.label19.Text = "Monthly :";
            // 
            // tsMonthly
            // 
            this.tsMonthly.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tsMonthly.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tsMonthly.CheckedState.InnerBorderColor = System.Drawing.Color.White;
            this.tsMonthly.CheckedState.InnerColor = System.Drawing.Color.White;
            this.tsMonthly.Location = new System.Drawing.Point(178, 70);
            this.tsMonthly.Name = "tsMonthly";
            this.tsMonthly.Size = new System.Drawing.Size(35, 20);
            this.tsMonthly.TabIndex = 34;
            this.tsMonthly.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.tsMonthly.UncheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.tsMonthly.UncheckedState.InnerBorderColor = System.Drawing.Color.White;
            this.tsMonthly.UncheckedState.InnerColor = System.Drawing.Color.White;
            this.tsMonthly.CheckedChanged += new System.EventHandler(this.guna2ToggleSwitch1_CheckedChanged);
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label17.Location = new System.Drawing.Point(60, 222);
            this.label17.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(107, 16);
            this.label17.TabIndex = 33;
            this.label17.Text = "Price Per Month :";
            // 
            // txtPricePerMonth
            // 
            this.txtPricePerMonth.BorderColor = System.Drawing.Color.SlateBlue;
            this.txtPricePerMonth.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtPricePerMonth.DefaultText = "";
            this.txtPricePerMonth.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtPricePerMonth.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtPricePerMonth.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtPricePerMonth.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtPricePerMonth.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtPricePerMonth.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtPricePerMonth.ForeColor = System.Drawing.Color.Black;
            this.txtPricePerMonth.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtPricePerMonth.Location = new System.Drawing.Point(178, 218);
            this.txtPricePerMonth.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.txtPricePerMonth.Name = "txtPricePerMonth";
            this.txtPricePerMonth.PasswordChar = '\0';
            this.txtPricePerMonth.PlaceholderText = "";
            this.txtPricePerMonth.ReadOnly = true;
            this.txtPricePerMonth.SelectedText = "";
            this.txtPricePerMonth.Size = new System.Drawing.Size(172, 24);
            this.txtPricePerMonth.TabIndex = 32;
            // 
            // txtInitialTotalDueAmountAfterTax
            // 
            this.txtInitialTotalDueAmountAfterTax.BorderColor = System.Drawing.Color.SlateBlue;
            this.txtInitialTotalDueAmountAfterTax.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtInitialTotalDueAmountAfterTax.DefaultText = "";
            this.txtInitialTotalDueAmountAfterTax.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtInitialTotalDueAmountAfterTax.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtInitialTotalDueAmountAfterTax.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtInitialTotalDueAmountAfterTax.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtInitialTotalDueAmountAfterTax.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtInitialTotalDueAmountAfterTax.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtInitialTotalDueAmountAfterTax.ForeColor = System.Drawing.Color.Black;
            this.txtInitialTotalDueAmountAfterTax.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtInitialTotalDueAmountAfterTax.Location = new System.Drawing.Point(332, 402);
            this.txtInitialTotalDueAmountAfterTax.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.txtInitialTotalDueAmountAfterTax.Name = "txtInitialTotalDueAmountAfterTax";
            this.txtInitialTotalDueAmountAfterTax.PasswordChar = '\0';
            this.txtInitialTotalDueAmountAfterTax.PlaceholderText = "";
            this.txtInitialTotalDueAmountAfterTax.ReadOnly = true;
            this.txtInitialTotalDueAmountAfterTax.SelectedText = "";
            this.txtInitialTotalDueAmountAfterTax.Size = new System.Drawing.Size(172, 33);
            this.txtInitialTotalDueAmountAfterTax.TabIndex = 31;
            this.txtInitialTotalDueAmountAfterTax.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtInitialTotalDueAmountAfterTax.TextChanged += new System.EventHandler(this.txtInitialTotalDueAmountAfterTax_TextChanged);
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label18.Location = new System.Drawing.Point(61, 411);
            this.label18.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(257, 17);
            this.label18.TabIndex = 30;
            this.label18.Text = "Initial Total Due Amount after tax :";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label14.Location = new System.Drawing.Point(22, 272);
            this.label14.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(145, 16);
            this.label14.TabIndex = 16;
            this.label14.Text = "Free Kilometers Credit :";
            // 
            // txtFreeKilometersCredit
            // 
            this.txtFreeKilometersCredit.BorderColor = System.Drawing.Color.SlateBlue;
            this.txtFreeKilometersCredit.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtFreeKilometersCredit.DefaultText = "";
            this.txtFreeKilometersCredit.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtFreeKilometersCredit.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtFreeKilometersCredit.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtFreeKilometersCredit.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtFreeKilometersCredit.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtFreeKilometersCredit.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtFreeKilometersCredit.ForeColor = System.Drawing.Color.Black;
            this.txtFreeKilometersCredit.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtFreeKilometersCredit.Location = new System.Drawing.Point(178, 270);
            this.txtFreeKilometersCredit.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.txtFreeKilometersCredit.Name = "txtFreeKilometersCredit";
            this.txtFreeKilometersCredit.PasswordChar = '\0';
            this.txtFreeKilometersCredit.PlaceholderText = "";
            this.txtFreeKilometersCredit.SelectedText = "";
            this.txtFreeKilometersCredit.Size = new System.Drawing.Size(172, 24);
            this.txtFreeKilometersCredit.TabIndex = 15;
            this.txtFreeKilometersCredit.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtFreeKilometersCredit_KeyPress);
            this.txtFreeKilometersCredit.Validating += new System.ComponentModel.CancelEventHandler(this.ValidateEmptyTextBoxGuna2);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.Location = new System.Drawing.Point(489, 117);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(120, 16);
            this.label7.TabIndex = 14;
            this.label7.Text = "Initial Rental Days :";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(152, 367);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(166, 17);
            this.label3.TabIndex = 7;
            this.label3.Text = "Initial Total Due Amount :";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(71, 172);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 16);
            this.label2.TabIndex = 6;
            this.label2.Text = "Price Per Day :";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // txtRentalPricePerDay
            // 
            this.txtRentalPricePerDay.BorderColor = System.Drawing.Color.SlateBlue;
            this.txtRentalPricePerDay.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtRentalPricePerDay.DefaultText = "";
            this.txtRentalPricePerDay.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtRentalPricePerDay.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtRentalPricePerDay.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtRentalPricePerDay.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtRentalPricePerDay.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtRentalPricePerDay.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtRentalPricePerDay.ForeColor = System.Drawing.Color.Black;
            this.txtRentalPricePerDay.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtRentalPricePerDay.Location = new System.Drawing.Point(178, 166);
            this.txtRentalPricePerDay.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.txtRentalPricePerDay.Name = "txtRentalPricePerDay";
            this.txtRentalPricePerDay.PasswordChar = '\0';
            this.txtRentalPricePerDay.PlaceholderText = "";
            this.txtRentalPricePerDay.ReadOnly = true;
            this.txtRentalPricePerDay.SelectedText = "";
            this.txtRentalPricePerDay.Size = new System.Drawing.Size(172, 24);
            this.txtRentalPricePerDay.TabIndex = 3;
            // 
            // txtInitialTotalDueAmount
            // 
            this.txtInitialTotalDueAmount.BorderColor = System.Drawing.Color.SlateBlue;
            this.txtInitialTotalDueAmount.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtInitialTotalDueAmount.DefaultText = "";
            this.txtInitialTotalDueAmount.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtInitialTotalDueAmount.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtInitialTotalDueAmount.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtInitialTotalDueAmount.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtInitialTotalDueAmount.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtInitialTotalDueAmount.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtInitialTotalDueAmount.ForeColor = System.Drawing.Color.Black;
            this.txtInitialTotalDueAmount.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtInitialTotalDueAmount.Location = new System.Drawing.Point(332, 358);
            this.txtInitialTotalDueAmount.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.txtInitialTotalDueAmount.Name = "txtInitialTotalDueAmount";
            this.txtInitialTotalDueAmount.PasswordChar = '\0';
            this.txtInitialTotalDueAmount.PlaceholderText = "";
            this.txtInitialTotalDueAmount.ReadOnly = true;
            this.txtInitialTotalDueAmount.SelectedText = "";
            this.txtInitialTotalDueAmount.Size = new System.Drawing.Size(172, 33);
            this.txtInitialTotalDueAmount.TabIndex = 2;
            this.txtInitialTotalDueAmount.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtInitialTotalDueAmount.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtValidatePositiveDecimalNumbers_KeyPress);
            this.txtInitialTotalDueAmount.Validating += new System.ComponentModel.CancelEventHandler(this.ValidateEmptyTextBoxGuna2);
            // 
            // txtInitialRental
            // 
            this.txtInitialRental.BorderColor = System.Drawing.Color.SlateBlue;
            this.txtInitialRental.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtInitialRental.DefaultText = "0";
            this.txtInitialRental.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtInitialRental.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtInitialRental.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtInitialRental.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtInitialRental.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtInitialRental.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtInitialRental.ForeColor = System.Drawing.Color.Black;
            this.txtInitialRental.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtInitialRental.Location = new System.Drawing.Point(629, 114);
            this.txtInitialRental.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.txtInitialRental.Name = "txtInitialRental";
            this.txtInitialRental.PasswordChar = '\0';
            this.txtInitialRental.PlaceholderText = "";
            this.txtInitialRental.ReadOnly = true;
            this.txtInitialRental.SelectedText = "";
            this.txtInitialRental.Size = new System.Drawing.Size(172, 24);
            this.txtInitialRental.TabIndex = 0;
            this.txtInitialRental.TextChanged += new System.EventHandler(this.txtInitialRental_TextChanged);
            this.txtInitialRental.Validating += new System.ComponentModel.CancelEventHandler(this.txtInitialRentalDays_Validating);
            // 
            // tabCustomerInfo
            // 
            this.tabCustomerInfo.Controls.Add(this.ctrlCustomerCardWithFilter1);
            this.tabCustomerInfo.Location = new System.Drawing.Point(189, 4);
            this.tabCustomerInfo.Margin = new System.Windows.Forms.Padding(2);
            this.tabCustomerInfo.Name = "tabCustomerInfo";
            this.tabCustomerInfo.Padding = new System.Windows.Forms.Padding(2);
            this.tabCustomerInfo.Size = new System.Drawing.Size(872, 505);
            this.tabCustomerInfo.TabIndex = 4;
            this.tabCustomerInfo.Text = "Customer Information";
            this.tabCustomerInfo.UseVisualStyleBackColor = true;
            // 
            // ctrlCustomerCardWithFilter1
            // 
            this.ctrlCustomerCardWithFilter1.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange;
            this.ctrlCustomerCardWithFilter1.BackColor = System.Drawing.Color.White;
            this.ctrlCustomerCardWithFilter1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ctrlCustomerCardWithFilter1.FilterEnabled = true;
            this.ctrlCustomerCardWithFilter1.Location = new System.Drawing.Point(131, 50);
            this.ctrlCustomerCardWithFilter1.Margin = new System.Windows.Forms.Padding(2);
            this.ctrlCustomerCardWithFilter1.Name = "ctrlCustomerCardWithFilter1";
            this.ctrlCustomerCardWithFilter1.ShowAddCustomer = true;
            this.ctrlCustomerCardWithFilter1.Size = new System.Drawing.Size(626, 375);
            this.ctrlCustomerCardWithFilter1.TabIndex = 2;
            this.ctrlCustomerCardWithFilter1.OnCustomerSelected += new System.Action<bool>(this.ctrlCustomerCardWithFilter1_OnCustomerSelected);
            // 
            // tapInitialPaymentMethodID
            // 
            this.tapInitialPaymentMethodID.Controls.Add(this.lblRentalPricePerMonth);
            this.tapInitialPaymentMethodID.Controls.Add(this.label22);
            this.tapInitialPaymentMethodID.Controls.Add(this.lblInitialRentalMonths);
            this.tapInitialPaymentMethodID.Controls.Add(this.label21);
            this.tapInitialPaymentMethodID.Controls.Add(this.label13);
            this.tapInitialPaymentMethodID.Controls.Add(this.txtPaidInitialTotalDueAmount);
            this.tapInitialPaymentMethodID.Controls.Add(this.label16);
            this.tapInitialPaymentMethodID.Controls.Add(this.txtCheckID);
            this.tapInitialPaymentMethodID.Controls.Add(this.btnAddInitialCheck);
            this.tapInitialPaymentMethodID.Controls.Add(this.lblTax);
            this.tapInitialPaymentMethodID.Controls.Add(this.lable30);
            this.tapInitialPaymentMethodID.Controls.Add(this.lblInitialTotalDueAmountAfterTax);
            this.tapInitialPaymentMethodID.Controls.Add(this.label15);
            this.tapInitialPaymentMethodID.Controls.Add(this.lblInitialRentalDays);
            this.tapInitialPaymentMethodID.Controls.Add(this.lblEndDate);
            this.tapInitialPaymentMethodID.Controls.Add(this.lblStartDate);
            this.tapInitialPaymentMethodID.Controls.Add(this.lblInitialTotalDueAmount);
            this.tapInitialPaymentMethodID.Controls.Add(this.lblRentalPricePerDay);
            this.tapInitialPaymentMethodID.Controls.Add(this.lblPickupLocation);
            this.tapInitialPaymentMethodID.Controls.Add(this.label4);
            this.tapInitialPaymentMethodID.Controls.Add(this.label8);
            this.tapInitialPaymentMethodID.Controls.Add(this.label9);
            this.tapInitialPaymentMethodID.Controls.Add(this.label10);
            this.tapInitialPaymentMethodID.Controls.Add(this.label11);
            this.tapInitialPaymentMethodID.Controls.Add(this.label12);
            this.tapInitialPaymentMethodID.Controls.Add(this.cmPayMentDetails);
            this.tapInitialPaymentMethodID.Location = new System.Drawing.Point(189, 4);
            this.tapInitialPaymentMethodID.Margin = new System.Windows.Forms.Padding(2);
            this.tapInitialPaymentMethodID.Name = "tapInitialPaymentMethodID";
            this.tapInitialPaymentMethodID.Padding = new System.Windows.Forms.Padding(2);
            this.tapInitialPaymentMethodID.Size = new System.Drawing.Size(872, 505);
            this.tapInitialPaymentMethodID.TabIndex = 5;
            this.tapInitialPaymentMethodID.Text = "Payment Details";
            this.tapInitialPaymentMethodID.UseVisualStyleBackColor = true;
            this.tapInitialPaymentMethodID.Click += new System.EventHandler(this.tapInitialPaymentMethodID_Click);
            // 
            // lblRentalPricePerMonth
            // 
            this.lblRentalPricePerMonth.AutoSize = true;
            this.lblRentalPricePerMonth.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblRentalPricePerMonth.Location = new System.Drawing.Point(634, 284);
            this.lblRentalPricePerMonth.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblRentalPricePerMonth.Name = "lblRentalPricePerMonth";
            this.lblRentalPricePerMonth.Size = new System.Drawing.Size(44, 17);
            this.lblRentalPricePerMonth.TabIndex = 145;
            this.lblRentalPricePerMonth.Text = "9999";
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label22.Location = new System.Drawing.Point(434, 284);
            this.label22.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(186, 17);
            this.label22.TabIndex = 144;
            this.label22.Text = "Rental Price Per Month :";
            // 
            // lblInitialRentalMonths
            // 
            this.lblInitialRentalMonths.AutoSize = true;
            this.lblInitialRentalMonths.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblInitialRentalMonths.Location = new System.Drawing.Point(634, 236);
            this.lblInitialRentalMonths.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblInitialRentalMonths.Name = "lblInitialRentalMonths";
            this.lblInitialRentalMonths.Size = new System.Drawing.Size(44, 17);
            this.lblInitialRentalMonths.TabIndex = 143;
            this.lblInitialRentalMonths.Text = "0000";
            this.lblInitialRentalMonths.Click += new System.EventHandler(this.label20_Click);
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label21.Location = new System.Drawing.Point(455, 236);
            this.label21.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(161, 17);
            this.label21.TabIndex = 142;
            this.label21.Text = "Initial Rental Months:";
            this.label21.Click += new System.EventHandler(this.label21_Click);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label13.Location = new System.Drawing.Point(42, 424);
            this.label13.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(215, 16);
            this.label13.TabIndex = 141;
            this.label13.Text = "Paid Initial Total Due Amount :";
            // 
            // txtPaidInitialTotalDueAmount
            // 
            this.txtPaidInitialTotalDueAmount.BorderColor = System.Drawing.Color.SlateBlue;
            this.txtPaidInitialTotalDueAmount.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtPaidInitialTotalDueAmount.DefaultText = "";
            this.txtPaidInitialTotalDueAmount.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtPaidInitialTotalDueAmount.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtPaidInitialTotalDueAmount.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtPaidInitialTotalDueAmount.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtPaidInitialTotalDueAmount.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtPaidInitialTotalDueAmount.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtPaidInitialTotalDueAmount.ForeColor = System.Drawing.Color.Black;
            this.txtPaidInitialTotalDueAmount.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtPaidInitialTotalDueAmount.Location = new System.Drawing.Point(261, 417);
            this.txtPaidInitialTotalDueAmount.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.txtPaidInitialTotalDueAmount.Name = "txtPaidInitialTotalDueAmount";
            this.txtPaidInitialTotalDueAmount.PasswordChar = '\0';
            this.txtPaidInitialTotalDueAmount.PlaceholderText = "";
            this.txtPaidInitialTotalDueAmount.SelectedText = "";
            this.txtPaidInitialTotalDueAmount.Size = new System.Drawing.Size(172, 33);
            this.txtPaidInitialTotalDueAmount.TabIndex = 140;
            this.txtPaidInitialTotalDueAmount.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtPaidInitialTotalDueAmount.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtValidatePositiveDecimalNumbers_KeyPress);
            this.txtPaidInitialTotalDueAmount.Validating += new System.ComponentModel.CancelEventHandler(this.txtPaidInitialTotalDueAmount_Validating);
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.CausesValidation = false;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label16.Location = new System.Drawing.Point(496, 343);
            this.label16.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(135, 17);
            this.label16.TabIndex = 139;
            this.label16.Text = "Payment Details :";
            // 
            // txtCheckID
            // 
            this.txtCheckID.BorderColor = System.Drawing.Color.SlateBlue;
            this.txtCheckID.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtCheckID.DefaultText = "";
            this.txtCheckID.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtCheckID.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtCheckID.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtCheckID.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtCheckID.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtCheckID.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtCheckID.ForeColor = System.Drawing.Color.Black;
            this.txtCheckID.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtCheckID.Location = new System.Drawing.Point(637, 384);
            this.txtCheckID.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.txtCheckID.Name = "txtCheckID";
            this.txtCheckID.PasswordChar = '\0';
            this.txtCheckID.PlaceholderText = "";
            this.txtCheckID.ReadOnly = true;
            this.txtCheckID.SelectedText = "";
            this.txtCheckID.Size = new System.Drawing.Size(172, 24);
            this.txtCheckID.TabIndex = 138;
            this.txtCheckID.Validating += new System.ComponentModel.CancelEventHandler(this.ValidateEmptyTextBoxGuna2);
            // 
            // btnAddInitialCheck
            // 
            this.btnAddInitialCheck.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(42)))), ((int)(((byte)(57)))));
            this.btnAddInitialCheck.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAddInitialCheck.ForeColor = System.Drawing.Color.White;
            this.btnAddInitialCheck.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAddInitialCheck.Location = new System.Drawing.Point(635, 415);
            this.btnAddInitialCheck.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnAddInitialCheck.Name = "btnAddInitialCheck";
            this.btnAddInitialCheck.Size = new System.Drawing.Size(172, 31);
            this.btnAddInitialCheck.TabIndex = 137;
            this.btnAddInitialCheck.Text = "Add Initial Check";
            this.btnAddInitialCheck.UseVisualStyleBackColor = false;
            this.btnAddInitialCheck.Click += new System.EventHandler(this.btnAddInitialCheck_Click);
            // 
            // lblTax
            // 
            this.lblTax.AutoSize = true;
            this.lblTax.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblTax.ForeColor = System.Drawing.Color.Red;
            this.lblTax.Location = new System.Drawing.Point(272, 337);
            this.lblTax.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTax.Name = "lblTax";
            this.lblTax.Size = new System.Drawing.Size(44, 17);
            this.lblTax.TabIndex = 31;
            this.lblTax.Text = "9999";
            // 
            // lable30
            // 
            this.lable30.AutoSize = true;
            this.lable30.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lable30.Location = new System.Drawing.Point(14, 337);
            this.lable30.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lable30.Name = "lable30";
            this.lable30.Size = new System.Drawing.Size(42, 17);
            this.lable30.TabIndex = 30;
            this.lable30.Text = "Vat :";
            // 
            // lblInitialTotalDueAmountAfterTax
            // 
            this.lblInitialTotalDueAmountAfterTax.AutoSize = true;
            this.lblInitialTotalDueAmountAfterTax.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblInitialTotalDueAmountAfterTax.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.lblInitialTotalDueAmountAfterTax.Location = new System.Drawing.Point(272, 380);
            this.lblInitialTotalDueAmountAfterTax.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblInitialTotalDueAmountAfterTax.Name = "lblInitialTotalDueAmountAfterTax";
            this.lblInitialTotalDueAmountAfterTax.Size = new System.Drawing.Size(44, 17);
            this.lblInitialTotalDueAmountAfterTax.TabIndex = 29;
            this.lblInitialTotalDueAmountAfterTax.Text = "9999";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label15.Location = new System.Drawing.Point(14, 380);
            this.label15.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(257, 17);
            this.label15.TabIndex = 28;
            this.label15.Text = "Initial Total Due Amount after tax :";
            // 
            // lblInitialRentalDays
            // 
            this.lblInitialRentalDays.AutoSize = true;
            this.lblInitialRentalDays.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblInitialRentalDays.Location = new System.Drawing.Point(272, 131);
            this.lblInitialRentalDays.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblInitialRentalDays.Name = "lblInitialRentalDays";
            this.lblInitialRentalDays.Size = new System.Drawing.Size(150, 17);
            this.lblInitialRentalDays.TabIndex = 26;
            this.lblInitialRentalDays.Text = "Initial Rental Days :";
            // 
            // lblEndDate
            // 
            this.lblEndDate.AutoSize = true;
            this.lblEndDate.CausesValidation = false;
            this.lblEndDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblEndDate.Location = new System.Drawing.Point(272, 85);
            this.lblEndDate.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblEndDate.Name = "lblEndDate";
            this.lblEndDate.Size = new System.Drawing.Size(85, 17);
            this.lblEndDate.TabIndex = 25;
            this.lblEndDate.Text = "End Date :";
            // 
            // lblStartDate
            // 
            this.lblStartDate.AutoSize = true;
            this.lblStartDate.CausesValidation = false;
            this.lblStartDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblStartDate.Location = new System.Drawing.Point(272, 41);
            this.lblStartDate.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblStartDate.Name = "lblStartDate";
            this.lblStartDate.Size = new System.Drawing.Size(92, 17);
            this.lblStartDate.TabIndex = 24;
            this.lblStartDate.Text = "Start Date :";
            // 
            // lblInitialTotalDueAmount
            // 
            this.lblInitialTotalDueAmount.AutoSize = true;
            this.lblInitialTotalDueAmount.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblInitialTotalDueAmount.Location = new System.Drawing.Point(272, 288);
            this.lblInitialTotalDueAmount.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblInitialTotalDueAmount.Name = "lblInitialTotalDueAmount";
            this.lblInitialTotalDueAmount.Size = new System.Drawing.Size(44, 17);
            this.lblInitialTotalDueAmount.TabIndex = 23;
            this.lblInitialTotalDueAmount.Text = "9999";
            // 
            // lblRentalPricePerDay
            // 
            this.lblRentalPricePerDay.AutoSize = true;
            this.lblRentalPricePerDay.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblRentalPricePerDay.Location = new System.Drawing.Point(272, 236);
            this.lblRentalPricePerDay.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblRentalPricePerDay.Name = "lblRentalPricePerDay";
            this.lblRentalPricePerDay.Size = new System.Drawing.Size(44, 17);
            this.lblRentalPricePerDay.TabIndex = 22;
            this.lblRentalPricePerDay.Text = "9999";
            // 
            // lblPickupLocation
            // 
            this.lblPickupLocation.AutoSize = true;
            this.lblPickupLocation.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblPickupLocation.Location = new System.Drawing.Point(272, 182);
            this.lblPickupLocation.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPickupLocation.Name = "lblPickupLocation";
            this.lblPickupLocation.Size = new System.Drawing.Size(133, 17);
            this.lblPickupLocation.TabIndex = 21;
            this.lblPickupLocation.Text = "Pickup Location :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(14, 131);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(150, 17);
            this.label4.TabIndex = 20;
            this.label4.Text = "Initial Rental Days :";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.CausesValidation = false;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label8.Location = new System.Drawing.Point(14, 85);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(85, 17);
            this.label8.TabIndex = 19;
            this.label8.Text = "End Date :";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.CausesValidation = false;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label9.Location = new System.Drawing.Point(14, 41);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(92, 17);
            this.label9.TabIndex = 18;
            this.label9.Text = "Start Date :";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label10.Location = new System.Drawing.Point(14, 288);
            this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(192, 17);
            this.label10.TabIndex = 17;
            this.label10.Text = "Initial Total Due Amount :";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label11.Location = new System.Drawing.Point(14, 236);
            this.label11.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(170, 17);
            this.label11.TabIndex = 16;
            this.label11.Text = "Rental Price Per Day :";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label12.Location = new System.Drawing.Point(14, 182);
            this.label12.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(133, 17);
            this.label12.TabIndex = 15;
            this.label12.Text = "Pickup Location :";
            // 
            // cmPayMentDetails
            // 
            this.cmPayMentDetails.BackColor = System.Drawing.Color.Transparent;
            this.cmPayMentDetails.BorderColor = System.Drawing.Color.SlateBlue;
            this.cmPayMentDetails.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmPayMentDetails.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmPayMentDetails.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cmPayMentDetails.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cmPayMentDetails.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cmPayMentDetails.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cmPayMentDetails.ItemHeight = 30;
            this.cmPayMentDetails.Location = new System.Drawing.Point(635, 337);
            this.cmPayMentDetails.Margin = new System.Windows.Forms.Padding(2);
            this.cmPayMentDetails.Name = "cmPayMentDetails";
            this.cmPayMentDetails.Size = new System.Drawing.Size(173, 36);
            this.cmPayMentDetails.TabIndex = 0;
            this.cmPayMentDetails.Validating += new System.ComponentModel.CancelEventHandler(this.ComboBoxEmpty_Validating);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // guna2BorderlessForm1
            // 
            this.guna2BorderlessForm1.ContainerControl = this;
            this.guna2BorderlessForm1.DockIndicatorTransparencyValue = 0.6D;
            this.guna2BorderlessForm1.TransparentWhileDrag = true;
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.Black;
            this.btnClose.FlatAppearance.BorderSize = 2;
            this.btnClose.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.btnClose.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.ForeColor = System.Drawing.Color.White;
            this.btnClose.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnClose.Location = new System.Drawing.Point(736, 511);
            this.btnClose.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(106, 34);
            this.btnClose.TabIndex = 127;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click_1);
            // 
            // btnNext
            // 
            this.btnNext.BackColor = System.Drawing.Color.Black;
            this.btnNext.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnNext.ForeColor = System.Drawing.Color.White;
            this.btnNext.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnNext.Location = new System.Drawing.Point(636, 512);
            this.btnNext.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(99, 30);
            this.btnNext.TabIndex = 126;
            this.btnNext.Text = "Next";
            this.btnNext.UseVisualStyleBackColor = false;
            this.btnNext.Visible = false;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.Color.Black;
            this.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnBack.ForeColor = System.Drawing.Color.White;
            this.btnBack.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBack.Location = new System.Drawing.Point(535, 512);
            this.btnBack.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(99, 31);
            this.btnBack.TabIndex = 128;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Visible = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click_1);
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.Black;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSave.ForeColor = System.Drawing.Color.White;
            this.btnSave.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSave.Location = new System.Drawing.Point(636, 513);
            this.btnSave.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(99, 30);
            this.btnSave.TabIndex = 130;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Visible = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Tai Le", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.SlateBlue;
            this.lblTitle.Location = new System.Drawing.Point(427, 6);
            this.lblTitle.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(284, 34);
            this.lblTitle.TabIndex = 133;
            this.lblTitle.Text = "Booking Information";
            // 
            // ctrlPrintContract1
            // 
            this.ctrlPrintContract1.AutoSize = true;
            this.ctrlPrintContract1.Enabled = false;
            this.ctrlPrintContract1.Location = new System.Drawing.Point(914, 555);
            this.ctrlPrintContract1.Name = "ctrlPrintContract1";
            this.ctrlPrintContract1.Size = new System.Drawing.Size(147, 46);
            this.ctrlPrintContract1.TabIndex = 134;
            // 
            // frmAddNewBooking
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1071, 607);
            this.Controls.Add(this.ctrlPrintContract1);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnNext);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.TabTransAcitonBooking);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frmAddNewBooking";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmAddNewBooking";
            this.Load += new System.EventHandler(this.frmAddNewBooking_Load);
            this.TabTransAcitonBooking.ResumeLayout(false);
            this.tabShoseVehicle.ResumeLayout(false);
            this.tabShoseVehicle.PerformLayout();
            this.tabBookingInfo.ResumeLayout(false);
            this.tabBookingInfo.PerformLayout();
            this.gbMonthlyCustomRent.ResumeLayout(false);
            this.gbMonthlyCustomRent.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NUDNumberOfMonths)).EndInit();
            this.tabCustomerInfo.ResumeLayout(false);
            this.tapInitialPaymentMethodID.ResumeLayout(false);
            this.tapInitialPaymentMethodID.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2TabControl TabTransAcitonBooking;
        private System.Windows.Forms.TabPage tabShoseVehicle;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private Guna.UI2.WinForms.Guna2BorderlessForm guna2BorderlessForm1;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.TabPage tabBookingInfo;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.TabPage tabCustomerInfo;
        private ctrlCustomerCardWithFilter ctrlCustomerCardWithFilter1;
        private Guna.UI2.WinForms.Guna2TextBox txtRentalPricePerDay;
        private Guna.UI2.WinForms.Guna2TextBox txtInitialTotalDueAmount;
        private Guna.UI2.WinForms.Guna2TextBox txtInitialRental;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.TabPage tapInitialPaymentMethodID;
        private Guna.UI2.WinForms.Guna2ComboBox cmPayMentDetails;
        private System.Windows.Forms.Label lblInitialRentalDays;
        private System.Windows.Forms.Label lblEndDate;
        private System.Windows.Forms.Label lblStartDate;
        private System.Windows.Forms.Label lblInitialTotalDueAmount;
        private System.Windows.Forms.Label lblRentalPricePerDay;
        private System.Windows.Forms.Label lblPickupLocation;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label lblInitialTotalDueAmountAfterTax;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label lblTax;
        private System.Windows.Forms.Label lable30;
        private Guna.UI2.WinForms.Guna2TextBox txtCheckID;
        private System.Windows.Forms.Button btnAddInitialCheck;
        private System.Windows.Forms.Label label14;
        private Guna.UI2.WinForms.Guna2TextBox txtFreeKilometersCredit;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label13;
        private Guna.UI2.WinForms.Guna2TextBox txtPaidInitialTotalDueAmount;
        private Guna.UI2.WinForms.Guna2TextBox txtInitialTotalDueAmountAfterTax;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label17;
        private Guna.UI2.WinForms.Guna2TextBox txtPricePerMonth;
        private Guna.UI2.WinForms.Guna2ToggleSwitch tsMonthly;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label lblInitialRentalMonths;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label lblRentalPricePerMonth;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.GroupBox gbMonthlyCustomRent;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.NumericUpDown NUDNumberOfMonths;
        private System.Windows.Forms.DateTimePicker dtpEndDate;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblTitleNumberOfDaysInMonths;
        private Guna.UI2.WinForms.Guna2TextBox txtNumberOfDaysInMonths;
        private Vehicles.ctrlVehicleWithFilter ctrlVehicleWithFilter1;
        private Rental_Transaction.Controls.ctrlPrintContract ctrlPrintContract1;
    }
}