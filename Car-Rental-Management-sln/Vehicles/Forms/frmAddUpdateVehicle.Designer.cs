namespace CarRental.Vehicles.Forms
{
    partial class frmAddUpdateVehicle
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
            this.txtPurchasingPrice = new Guna.UI2.WinForms.Guna2TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.guna2TextBox1 = new Guna.UI2.WinForms.Guna2TextBox();
            this.lblAfterTax = new System.Windows.Forms.Label();
            this.txtRentalPricePerYear = new Guna.UI2.WinForms.Guna2TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.txtRentalPricePerMonth = new Guna.UI2.WinForms.Guna2TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.txtRentalPricePerHour = new Guna.UI2.WinForms.Guna2TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.cbIsActive = new Guna.UI2.WinForms.Guna2CustomCheckBox();
            this.label11 = new System.Windows.Forms.Label();
            this.cmbDriveTypes = new Guna.UI2.WinForms.Guna2ComboBox();
            this.label12 = new System.Windows.Forms.Label();
            this.cmbBodies = new Guna.UI2.WinForms.Guna2ComboBox();
            this.pbVehicleImage = new System.Windows.Forms.PictureBox();
            this.txtRentalPricePerDay = new Guna.UI2.WinForms.Guna2TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.lblPlateNumber = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.cbIsAvailableForRental = new Guna.UI2.WinForms.Guna2CustomCheckBox();
            this.llRemoveImage = new System.Windows.Forms.LinkLabel();
            this.llSetImage = new System.Windows.Forms.LinkLabel();
            this.lblPlatChar = new System.Windows.Forms.Label();
            this.txtPlateNumber = new Guna.UI2.WinForms.Guna2TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.cmbFuelType = new Guna.UI2.WinForms.Guna2ComboBox();
            this.txtMileage = new Guna.UI2.WinForms.Guna2TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtYear = new Guna.UI2.WinForms.Guna2TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtRentalPricePerMileage = new Guna.UI2.WinForms.Guna2TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtPlateChar = new Guna.UI2.WinForms.Guna2TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtVehiclName = new Guna.UI2.WinForms.Guna2TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lblTitleModel = new System.Windows.Forms.Label();
            this.cmbModel = new Guna.UI2.WinForms.Guna2ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbMake = new Guna.UI2.WinForms.Guna2ComboBox();
            this.btnPurchase = new Guna.UI2.WinForms.Guna2Button();
            this.btnClose = new Guna.UI2.WinForms.Guna2Button();
            this.btnSave = new Guna.UI2.WinForms.Guna2Button();
            this.llVehicleID = new System.Windows.Forms.LinkLabel();
            this.label17 = new System.Windows.Forms.Label();
            this.dtptxtPurchasing = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.lblMode = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.label18 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pbVehicleImage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtPurchasingPrice
            // 
            this.txtPurchasingPrice.AutoRoundedCorners = true;
            this.txtPurchasingPrice.BorderColor = System.Drawing.Color.Black;
            this.txtPurchasingPrice.BorderRadius = 16;
            this.txtPurchasingPrice.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtPurchasingPrice.DefaultText = "";
            this.txtPurchasingPrice.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtPurchasingPrice.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtPurchasingPrice.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtPurchasingPrice.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtPurchasingPrice.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtPurchasingPrice.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtPurchasingPrice.ForeColor = System.Drawing.Color.Black;
            this.txtPurchasingPrice.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtPurchasingPrice.Location = new System.Drawing.Point(971, 461);
            this.txtPurchasingPrice.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.txtPurchasingPrice.Name = "txtPurchasingPrice";
            this.txtPurchasingPrice.PasswordChar = '\0';
            this.txtPurchasingPrice.PlaceholderText = "";
            this.txtPurchasingPrice.SelectedText = "";
            this.txtPurchasingPrice.Size = new System.Drawing.Size(146, 34);
            this.txtPurchasingPrice.TabIndex = 335;
            this.txtPurchasingPrice.Validating += new System.ComponentModel.CancelEventHandler(this.ValidateEmptyTextBoxGuna2);
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label16.Location = new System.Drawing.Point(818, 472);
            this.label16.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(141, 17);
            this.label16.TabIndex = 334;
            this.label16.Text = "Purchasing Price :";
            // 
            // guna2TextBox1
            // 
            this.guna2TextBox1.AutoRoundedCorners = true;
            this.guna2TextBox1.BorderColor = System.Drawing.Color.Black;
            this.guna2TextBox1.BorderRadius = 17;
            this.guna2TextBox1.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.guna2TextBox1.DefaultText = "";
            this.guna2TextBox1.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.guna2TextBox1.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.guna2TextBox1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.guna2TextBox1.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.guna2TextBox1.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2TextBox1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.guna2TextBox1.ForeColor = System.Drawing.Color.Black;
            this.guna2TextBox1.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2TextBox1.Location = new System.Drawing.Point(576, 562);
            this.guna2TextBox1.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.guna2TextBox1.Name = "guna2TextBox1";
            this.guna2TextBox1.PasswordChar = '\0';
            this.guna2TextBox1.PlaceholderText = "";
            this.guna2TextBox1.ReadOnly = true;
            this.guna2TextBox1.SelectedText = "";
            this.guna2TextBox1.Size = new System.Drawing.Size(203, 37);
            this.guna2TextBox1.TabIndex = 333;
            // 
            // lblAfterTax
            // 
            this.lblAfterTax.AutoSize = true;
            this.lblAfterTax.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblAfterTax.ForeColor = System.Drawing.Color.Red;
            this.lblAfterTax.Location = new System.Drawing.Point(424, 574);
            this.lblAfterTax.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblAfterTax.Name = "lblAfterTax";
            this.lblAfterTax.Size = new System.Drawing.Size(35, 16);
            this.lblAfterTax.TabIndex = 332;
            this.lblAfterTax.Text = "????";
            // 
            // txtRentalPricePerYear
            // 
            this.txtRentalPricePerYear.AutoRoundedCorners = true;
            this.txtRentalPricePerYear.BorderColor = System.Drawing.Color.Black;
            this.txtRentalPricePerYear.BorderRadius = 16;
            this.txtRentalPricePerYear.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtRentalPricePerYear.DefaultText = "";
            this.txtRentalPricePerYear.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtRentalPricePerYear.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtRentalPricePerYear.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtRentalPricePerYear.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtRentalPricePerYear.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtRentalPricePerYear.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtRentalPricePerYear.ForeColor = System.Drawing.Color.Black;
            this.txtRentalPricePerYear.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtRentalPricePerYear.Location = new System.Drawing.Point(225, 427);
            this.txtRentalPricePerYear.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.txtRentalPricePerYear.MaxLength = 8;
            this.txtRentalPricePerYear.Name = "txtRentalPricePerYear";
            this.txtRentalPricePerYear.PasswordChar = '\0';
            this.txtRentalPricePerYear.PlaceholderText = "";
            this.txtRentalPricePerYear.SelectedText = "";
            this.txtRentalPricePerYear.Size = new System.Drawing.Size(235, 34);
            this.txtRentalPricePerYear.TabIndex = 331;
            this.txtRentalPricePerYear.Tag = "Price Year";
            this.txtRentalPricePerYear.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtValidatePositiveNumbers_KeyPress);
            this.txtRentalPricePerYear.MouseHover += new System.EventHandler(this.txtRentalPricePerDay_TextChanged);
            this.txtRentalPricePerYear.Validating += new System.ComponentModel.CancelEventHandler(this.ValidateEmptyTextBoxGuna2);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label14.Location = new System.Drawing.Point(41, 434);
            this.label14.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(171, 17);
            this.label14.TabIndex = 330;
            this.label14.Text = "Rental Price Per Year:";
            // 
            // txtRentalPricePerMonth
            // 
            this.txtRentalPricePerMonth.AutoRoundedCorners = true;
            this.txtRentalPricePerMonth.BorderColor = System.Drawing.Color.Black;
            this.txtRentalPricePerMonth.BorderRadius = 16;
            this.txtRentalPricePerMonth.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtRentalPricePerMonth.DefaultText = "";
            this.txtRentalPricePerMonth.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtRentalPricePerMonth.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtRentalPricePerMonth.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtRentalPricePerMonth.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtRentalPricePerMonth.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtRentalPricePerMonth.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtRentalPricePerMonth.ForeColor = System.Drawing.Color.Black;
            this.txtRentalPricePerMonth.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtRentalPricePerMonth.Location = new System.Drawing.Point(226, 358);
            this.txtRentalPricePerMonth.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.txtRentalPricePerMonth.MaxLength = 6;
            this.txtRentalPricePerMonth.Name = "txtRentalPricePerMonth";
            this.txtRentalPricePerMonth.PasswordChar = '\0';
            this.txtRentalPricePerMonth.PlaceholderText = "";
            this.txtRentalPricePerMonth.SelectedText = "";
            this.txtRentalPricePerMonth.Size = new System.Drawing.Size(235, 34);
            this.txtRentalPricePerMonth.TabIndex = 329;
            this.txtRentalPricePerMonth.Tag = "Price Month";
            this.txtRentalPricePerMonth.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtValidatePositiveNumbers_KeyPress);
            this.txtRentalPricePerMonth.MouseHover += new System.EventHandler(this.txtRentalPricePerDay_TextChanged);
            this.txtRentalPricePerMonth.Validating += new System.ComponentModel.CancelEventHandler(this.ValidateEmptyTextBoxGuna2);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label15.Location = new System.Drawing.Point(26, 365);
            this.label15.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(186, 17);
            this.label15.TabIndex = 328;
            this.label15.Text = "Rental Price Per Month :";
            // 
            // txtRentalPricePerHour
            // 
            this.txtRentalPricePerHour.AutoRoundedCorners = true;
            this.txtRentalPricePerHour.BorderColor = System.Drawing.Color.Black;
            this.txtRentalPricePerHour.BorderRadius = 16;
            this.txtRentalPricePerHour.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtRentalPricePerHour.DefaultText = "";
            this.txtRentalPricePerHour.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtRentalPricePerHour.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtRentalPricePerHour.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtRentalPricePerHour.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtRentalPricePerHour.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtRentalPricePerHour.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtRentalPricePerHour.ForeColor = System.Drawing.Color.Black;
            this.txtRentalPricePerHour.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtRentalPricePerHour.Location = new System.Drawing.Point(226, 496);
            this.txtRentalPricePerHour.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.txtRentalPricePerHour.MaxLength = 4;
            this.txtRentalPricePerHour.Name = "txtRentalPricePerHour";
            this.txtRentalPricePerHour.PasswordChar = '\0';
            this.txtRentalPricePerHour.PlaceholderText = "";
            this.txtRentalPricePerHour.SelectedText = "";
            this.txtRentalPricePerHour.Size = new System.Drawing.Size(235, 34);
            this.txtRentalPricePerHour.TabIndex = 327;
            this.txtRentalPricePerHour.Tag = "Price Hour";
            this.txtRentalPricePerHour.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtValidatePositiveNumbers_KeyPress);
            this.txtRentalPricePerHour.MouseHover += new System.EventHandler(this.txtRentalPricePerDay_TextChanged);
            this.txtRentalPricePerHour.Validating += new System.ComponentModel.CancelEventHandler(this.ValidateEmptyTextBoxGuna2);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label8.Location = new System.Drawing.Point(35, 503);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(177, 17);
            this.label8.TabIndex = 326;
            this.label8.Text = "Rental Price Per Hour :";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label13.Location = new System.Drawing.Point(932, 335);
            this.label13.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(59, 15);
            this.label13.TabIndex = 324;
            this.label13.Text = "Is Active";
            // 
            // cbIsActive
            // 
            this.cbIsActive.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbIsActive.CheckedState.BorderRadius = 2;
            this.cbIsActive.CheckedState.BorderThickness = 0;
            this.cbIsActive.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbIsActive.Location = new System.Drawing.Point(1097, 334);
            this.cbIsActive.Margin = new System.Windows.Forms.Padding(2);
            this.cbIsActive.Name = "cbIsActive";
            this.cbIsActive.Size = new System.Drawing.Size(15, 16);
            this.cbIsActive.TabIndex = 323;
            this.cbIsActive.Text = "guna2CustomCheckBox1";
            this.cbIsActive.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.cbIsActive.UncheckedState.BorderRadius = 2;
            this.cbIsActive.UncheckedState.BorderThickness = 0;
            this.cbIsActive.UncheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.cbIsActive.Click += new System.EventHandler(this.cbIsActive_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label11.Location = new System.Drawing.Point(478, 368);
            this.label11.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(87, 17);
            this.label11.TabIndex = 322;
            this.label11.Text = "Drive Type";
            // 
            // cmbDriveTypes
            // 
            this.cmbDriveTypes.AutoRoundedCorners = true;
            this.cmbDriveTypes.BackColor = System.Drawing.Color.Transparent;
            this.cmbDriveTypes.BorderColor = System.Drawing.Color.Black;
            this.cmbDriveTypes.BorderRadius = 17;
            this.cmbDriveTypes.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbDriveTypes.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbDriveTypes.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cmbDriveTypes.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cmbDriveTypes.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cmbDriveTypes.ForeColor = System.Drawing.Color.Black;
            this.cmbDriveTypes.ItemHeight = 30;
            this.cmbDriveTypes.Location = new System.Drawing.Point(576, 356);
            this.cmbDriveTypes.Margin = new System.Windows.Forms.Padding(2);
            this.cmbDriveTypes.Name = "cmbDriveTypes";
            this.cmbDriveTypes.Size = new System.Drawing.Size(168, 36);
            this.cmbDriveTypes.TabIndex = 321;
            this.cmbDriveTypes.Validating += new System.ComponentModel.CancelEventHandler(this.ComboBoxEmpty_Validating);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label12.Location = new System.Drawing.Point(508, 290);
            this.label12.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(57, 17);
            this.label12.TabIndex = 320;
            this.label12.Text = "Bodies";
            // 
            // cmbBodies
            // 
            this.cmbBodies.AutoRoundedCorners = true;
            this.cmbBodies.BackColor = System.Drawing.Color.Transparent;
            this.cmbBodies.BorderColor = System.Drawing.Color.Black;
            this.cmbBodies.BorderRadius = 17;
            this.cmbBodies.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbBodies.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbBodies.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cmbBodies.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cmbBodies.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cmbBodies.ForeColor = System.Drawing.Color.Black;
            this.cmbBodies.ItemHeight = 30;
            this.cmbBodies.Location = new System.Drawing.Point(577, 280);
            this.cmbBodies.Margin = new System.Windows.Forms.Padding(2);
            this.cmbBodies.Name = "cmbBodies";
            this.cmbBodies.Size = new System.Drawing.Size(168, 36);
            this.cmbBodies.TabIndex = 319;
            this.cmbBodies.Validating += new System.ComponentModel.CancelEventHandler(this.ComboBoxEmpty_Validating);
            // 
            // pbVehicleImage
            // 
            this.pbVehicleImage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pbVehicleImage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbVehicleImage.Image = global::CarRental.Properties.Resources.Car;
            this.pbVehicleImage.InitialImage = null;
            this.pbVehicleImage.Location = new System.Drawing.Point(915, 103);
            this.pbVehicleImage.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pbVehicleImage.Name = "pbVehicleImage";
            this.pbVehicleImage.Size = new System.Drawing.Size(202, 175);
            this.pbVehicleImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbVehicleImage.TabIndex = 318;
            this.pbVehicleImage.TabStop = false;
            // 
            // txtRentalPricePerDay
            // 
            this.txtRentalPricePerDay.AutoRoundedCorners = true;
            this.txtRentalPricePerDay.BorderColor = System.Drawing.Color.Black;
            this.txtRentalPricePerDay.BorderRadius = 16;
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
            this.txtRentalPricePerDay.Location = new System.Drawing.Point(226, 289);
            this.txtRentalPricePerDay.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.txtRentalPricePerDay.MaxLength = 5;
            this.txtRentalPricePerDay.Name = "txtRentalPricePerDay";
            this.txtRentalPricePerDay.PasswordChar = '\0';
            this.txtRentalPricePerDay.PlaceholderText = "";
            this.txtRentalPricePerDay.SelectedText = "";
            this.txtRentalPricePerDay.Size = new System.Drawing.Size(235, 34);
            this.txtRentalPricePerDay.TabIndex = 317;
            this.txtRentalPricePerDay.Tag = "Price Day";
            this.txtRentalPricePerDay.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtValidatePositiveNumbers_KeyPress);
            this.txtRentalPricePerDay.MouseHover += new System.EventHandler(this.txtRentalPricePerDay_TextChanged);
            this.txtRentalPricePerDay.Validating += new System.ComponentModel.CancelEventHandler(this.ValidateEmptyTextBoxGuna2);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label9.Location = new System.Drawing.Point(42, 296);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(170, 17);
            this.label9.TabIndex = 316;
            this.label9.Text = "Rental Price Per Day :";
            // 
            // lblPlateNumber
            // 
            this.lblPlateNumber.AutoSize = true;
            this.lblPlateNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblPlateNumber.ForeColor = System.Drawing.Color.Red;
            this.lblPlateNumber.Location = new System.Drawing.Point(331, 192);
            this.lblPlateNumber.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPlateNumber.Name = "lblPlateNumber";
            this.lblPlateNumber.Size = new System.Drawing.Size(82, 13);
            this.lblPlateNumber.TabIndex = 315;
            this.lblPlateNumber.Text = "From left to rihgt";
            this.lblPlateNumber.Visible = false;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label10.Location = new System.Drawing.Point(932, 377);
            this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(155, 15);
            this.label10.TabIndex = 313;
            this.label10.Text = "Is A vailable For Rental";
            // 
            // cbIsAvailableForRental
            // 
            this.cbIsAvailableForRental.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbIsAvailableForRental.CheckedState.BorderRadius = 2;
            this.cbIsAvailableForRental.CheckedState.BorderThickness = 0;
            this.cbIsAvailableForRental.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbIsAvailableForRental.Enabled = false;
            this.cbIsAvailableForRental.Location = new System.Drawing.Point(1097, 375);
            this.cbIsAvailableForRental.Margin = new System.Windows.Forms.Padding(2);
            this.cbIsAvailableForRental.Name = "cbIsAvailableForRental";
            this.cbIsAvailableForRental.Size = new System.Drawing.Size(15, 16);
            this.cbIsAvailableForRental.TabIndex = 312;
            this.cbIsAvailableForRental.Text = "guna2CustomCheckBox1";
            this.cbIsAvailableForRental.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.cbIsAvailableForRental.UncheckedState.BorderRadius = 2;
            this.cbIsAvailableForRental.UncheckedState.BorderThickness = 0;
            this.cbIsAvailableForRental.UncheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            // 
            // llRemoveImage
            // 
            this.llRemoveImage.AutoSize = true;
            this.llRemoveImage.Location = new System.Drawing.Point(990, 305);
            this.llRemoveImage.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.llRemoveImage.Name = "llRemoveImage";
            this.llRemoveImage.Size = new System.Drawing.Size(47, 13);
            this.llRemoveImage.TabIndex = 311;
            this.llRemoveImage.TabStop = true;
            this.llRemoveImage.Text = "Remove";
            this.llRemoveImage.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.llRemoveImage_LinkClicked);
            // 
            // llSetImage
            // 
            this.llSetImage.AutoSize = true;
            this.llSetImage.Location = new System.Drawing.Point(987, 282);
            this.llSetImage.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.llSetImage.Name = "llSetImage";
            this.llSetImage.Size = new System.Drawing.Size(55, 13);
            this.llSetImage.TabIndex = 310;
            this.llSetImage.TabStop = true;
            this.llSetImage.Text = "Set Image";
            this.llSetImage.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.llSetImage_LinkClicked);
            // 
            // lblPlatChar
            // 
            this.lblPlatChar.AutoSize = true;
            this.lblPlatChar.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblPlatChar.ForeColor = System.Drawing.Color.Red;
            this.lblPlatChar.Location = new System.Drawing.Point(227, 192);
            this.lblPlatChar.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPlatChar.Name = "lblPlatChar";
            this.lblPlatChar.Size = new System.Drawing.Size(82, 13);
            this.lblPlatChar.TabIndex = 309;
            this.lblPlatChar.Text = "From left to rihgt";
            this.lblPlatChar.Visible = false;
            // 
            // txtPlateNumber
            // 
            this.txtPlateNumber.AutoRoundedCorners = true;
            this.txtPlateNumber.BorderColor = System.Drawing.Color.Black;
            this.txtPlateNumber.BorderRadius = 16;
            this.txtPlateNumber.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtPlateNumber.DefaultText = "";
            this.txtPlateNumber.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtPlateNumber.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtPlateNumber.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtPlateNumber.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtPlateNumber.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtPlateNumber.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtPlateNumber.ForeColor = System.Drawing.Color.Black;
            this.txtPlateNumber.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtPlateNumber.Location = new System.Drawing.Point(333, 154);
            this.txtPlateNumber.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.txtPlateNumber.Name = "txtPlateNumber";
            this.txtPlateNumber.PasswordChar = '\0';
            this.txtPlateNumber.PlaceholderForeColor = System.Drawing.Color.Gray;
            this.txtPlateNumber.PlaceholderText = "Plate Number";
            this.txtPlateNumber.SelectedText = "";
            this.txtPlateNumber.Size = new System.Drawing.Size(82, 34);
            this.txtPlateNumber.TabIndex = 308;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(485, 201);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(80, 17);
            this.label6.TabIndex = 307;
            this.label6.Text = "Fuel Type";
            // 
            // cmbFuelType
            // 
            this.cmbFuelType.AutoRoundedCorners = true;
            this.cmbFuelType.BackColor = System.Drawing.Color.Transparent;
            this.cmbFuelType.BorderColor = System.Drawing.Color.Black;
            this.cmbFuelType.BorderRadius = 17;
            this.cmbFuelType.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbFuelType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbFuelType.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cmbFuelType.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cmbFuelType.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cmbFuelType.ForeColor = System.Drawing.Color.Black;
            this.cmbFuelType.ItemHeight = 30;
            this.cmbFuelType.Location = new System.Drawing.Point(577, 192);
            this.cmbFuelType.Margin = new System.Windows.Forms.Padding(2);
            this.cmbFuelType.Name = "cmbFuelType";
            this.cmbFuelType.Size = new System.Drawing.Size(168, 36);
            this.cmbFuelType.TabIndex = 306;
            this.cmbFuelType.Validating += new System.ComponentModel.CancelEventHandler(this.ComboBoxEmpty_Validating);
            // 
            // txtMileage
            // 
            this.txtMileage.AutoRoundedCorners = true;
            this.txtMileage.BorderColor = System.Drawing.Color.Black;
            this.txtMileage.BorderRadius = 17;
            this.txtMileage.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtMileage.DefaultText = "";
            this.txtMileage.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtMileage.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtMileage.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtMileage.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtMileage.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtMileage.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtMileage.ForeColor = System.Drawing.Color.Black;
            this.txtMileage.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtMileage.Location = new System.Drawing.Point(577, 496);
            this.txtMileage.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.txtMileage.MaxLength = 6;
            this.txtMileage.Name = "txtMileage";
            this.txtMileage.PasswordChar = '\0';
            this.txtMileage.PlaceholderText = "";
            this.txtMileage.SelectedText = "";
            this.txtMileage.Size = new System.Drawing.Size(167, 36);
            this.txtMileage.TabIndex = 305;
            this.txtMileage.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtYear_KeyPress);
            this.txtMileage.Validating += new System.ComponentModel.CancelEventHandler(this.ValidateEmptyTextBoxGuna2);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.Location = new System.Drawing.Point(501, 506);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(64, 17);
            this.label7.TabIndex = 304;
            this.label7.Text = "Mileage";
            // 
            // txtYear
            // 
            this.txtYear.AutoRoundedCorners = true;
            this.txtYear.BorderColor = System.Drawing.Color.Black;
            this.txtYear.BorderRadius = 17;
            this.txtYear.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtYear.DefaultText = "";
            this.txtYear.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtYear.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtYear.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtYear.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtYear.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtYear.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtYear.ForeColor = System.Drawing.Color.Black;
            this.txtYear.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtYear.Location = new System.Drawing.Point(577, 427);
            this.txtYear.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.txtYear.MaxLength = 4;
            this.txtYear.Name = "txtYear";
            this.txtYear.PasswordChar = '\0';
            this.txtYear.PlaceholderText = "";
            this.txtYear.SelectedText = "";
            this.txtYear.Size = new System.Drawing.Size(167, 36);
            this.txtYear.TabIndex = 303;
            this.txtYear.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtYear_KeyPress);
            this.txtYear.Validating += new System.ComponentModel.CancelEventHandler(this.txtYear_Validating);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(523, 437);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(42, 17);
            this.label5.TabIndex = 302;
            this.label5.Text = "Year";
            // 
            // txtRentalPricePerMileage
            // 
            this.txtRentalPricePerMileage.AutoRoundedCorners = true;
            this.txtRentalPricePerMileage.BorderColor = System.Drawing.Color.Black;
            this.txtRentalPricePerMileage.BorderRadius = 16;
            this.txtRentalPricePerMileage.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtRentalPricePerMileage.DefaultText = "";
            this.txtRentalPricePerMileage.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtRentalPricePerMileage.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtRentalPricePerMileage.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtRentalPricePerMileage.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtRentalPricePerMileage.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtRentalPricePerMileage.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtRentalPricePerMileage.ForeColor = System.Drawing.Color.Black;
            this.txtRentalPricePerMileage.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtRentalPricePerMileage.Location = new System.Drawing.Point(226, 565);
            this.txtRentalPricePerMileage.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.txtRentalPricePerMileage.MaxLength = 3;
            this.txtRentalPricePerMileage.Name = "txtRentalPricePerMileage";
            this.txtRentalPricePerMileage.PasswordChar = '\0';
            this.txtRentalPricePerMileage.PlaceholderText = "";
            this.txtRentalPricePerMileage.SelectedText = "";
            this.txtRentalPricePerMileage.Size = new System.Drawing.Size(167, 34);
            this.txtRentalPricePerMileage.TabIndex = 301;
            this.txtRentalPricePerMileage.Tag = "Price Mileage";
            this.txtRentalPricePerMileage.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtValidatePositiveNumbers_KeyPress);
            this.txtRentalPricePerMileage.MouseHover += new System.EventHandler(this.txtRentalPricePerDay_TextChanged);
            this.txtRentalPricePerMileage.Validating += new System.ComponentModel.CancelEventHandler(this.ValidateEmptyTextBoxGuna2);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(14, 572);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(198, 17);
            this.label4.TabIndex = 300;
            this.label4.Text = "Rental Price Per Mileage :";
            // 
            // txtPlateChar
            // 
            this.txtPlateChar.AutoRoundedCorners = true;
            this.txtPlateChar.BorderColor = System.Drawing.Color.Black;
            this.txtPlateChar.BorderRadius = 16;
            this.txtPlateChar.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtPlateChar.DefaultText = "";
            this.txtPlateChar.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtPlateChar.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtPlateChar.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtPlateChar.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtPlateChar.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtPlateChar.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtPlateChar.ForeColor = System.Drawing.Color.Black;
            this.txtPlateChar.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtPlateChar.Location = new System.Drawing.Point(226, 154);
            this.txtPlateChar.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.txtPlateChar.Name = "txtPlateChar";
            this.txtPlateChar.PasswordChar = '\0';
            this.txtPlateChar.PlaceholderForeColor = System.Drawing.Color.Gray;
            this.txtPlateChar.PlaceholderText = "Plate Char\r\n";
            this.txtPlateChar.SelectedText = "";
            this.txtPlateChar.Size = new System.Drawing.Size(82, 34);
            this.txtPlateChar.TabIndex = 299;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(106, 163);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(106, 17);
            this.label3.TabIndex = 298;
            this.label3.Text = "Plate Number";
            // 
            // txtVehiclName
            // 
            this.txtVehiclName.AutoRoundedCorners = true;
            this.txtVehiclName.BorderColor = System.Drawing.Color.Black;
            this.txtVehiclName.BorderRadius = 16;
            this.txtVehiclName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtVehiclName.DefaultText = "";
            this.txtVehiclName.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtVehiclName.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtVehiclName.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtVehiclName.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtVehiclName.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtVehiclName.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtVehiclName.ForeColor = System.Drawing.Color.Black;
            this.txtVehiclName.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtVehiclName.Location = new System.Drawing.Point(226, 220);
            this.txtVehiclName.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.txtVehiclName.MaxLength = 150;
            this.txtVehiclName.Name = "txtVehiclName";
            this.txtVehiclName.PasswordChar = '\0';
            this.txtVehiclName.PlaceholderText = "";
            this.txtVehiclName.SelectedText = "";
            this.txtVehiclName.Size = new System.Drawing.Size(235, 34);
            this.txtVehiclName.TabIndex = 297;
            this.txtVehiclName.Validating += new System.ComponentModel.CancelEventHandler(this.ValidateEmptyTextBoxGuna2);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(105, 227);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(107, 17);
            this.label2.TabIndex = 296;
            this.label2.Text = "Vehicle Name";
            // 
            // lblTitleModel
            // 
            this.lblTitleModel.AutoSize = true;
            this.lblTitleModel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblTitleModel.Location = new System.Drawing.Point(464, 95);
            this.lblTitleModel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTitleModel.Name = "lblTitleModel";
            this.lblTitleModel.Size = new System.Drawing.Size(101, 17);
            this.lblTitleModel.TabIndex = 295;
            this.lblTitleModel.Text = "Shose Model";
            // 
            // cmbModel
            // 
            this.cmbModel.AutoRoundedCorners = true;
            this.cmbModel.BackColor = System.Drawing.Color.Transparent;
            this.cmbModel.BorderColor = System.Drawing.Color.Black;
            this.cmbModel.BorderRadius = 17;
            this.cmbModel.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbModel.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbModel.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cmbModel.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cmbModel.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cmbModel.ForeColor = System.Drawing.Color.Black;
            this.cmbModel.ItemHeight = 30;
            this.cmbModel.Location = new System.Drawing.Point(577, 86);
            this.cmbModel.Margin = new System.Windows.Forms.Padding(2);
            this.cmbModel.Name = "cmbModel";
            this.cmbModel.Size = new System.Drawing.Size(168, 36);
            this.cmbModel.TabIndex = 294;
            this.cmbModel.Validating += new System.ComponentModel.CancelEventHandler(this.ComboBoxEmpty_Validating);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(116, 96);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 17);
            this.label1.TabIndex = 293;
            this.label1.Text = "Shose Make";
            // 
            // cmbMake
            // 
            this.cmbMake.AccessibleRole = System.Windows.Forms.AccessibleRole.TitleBar;
            this.cmbMake.AutoRoundedCorners = true;
            this.cmbMake.BackColor = System.Drawing.Color.Transparent;
            this.cmbMake.BorderColor = System.Drawing.Color.Black;
            this.cmbMake.BorderRadius = 17;
            this.cmbMake.DisplayMember = "6";
            this.cmbMake.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbMake.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbMake.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cmbMake.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cmbMake.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cmbMake.ForeColor = System.Drawing.Color.Black;
            this.cmbMake.ItemHeight = 30;
            this.cmbMake.Items.AddRange(new object[] {
            "none"});
            this.cmbMake.Location = new System.Drawing.Point(226, 87);
            this.cmbMake.Margin = new System.Windows.Forms.Padding(2);
            this.cmbMake.Name = "cmbMake";
            this.cmbMake.Size = new System.Drawing.Size(235, 36);
            this.cmbMake.StartIndex = 0;
            this.cmbMake.TabIndex = 292;
            this.cmbMake.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault;
            this.cmbMake.Validating += new System.ComponentModel.CancelEventHandler(this.ComboBoxEmpty_Validating);
            // 
            // btnPurchase
            // 
            this.btnPurchase.AutoRoundedCorners = true;
            this.btnPurchase.BorderRadius = 16;
            this.btnPurchase.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnPurchase.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnPurchase.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnPurchase.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnPurchase.FillColor = System.Drawing.Color.Black;
            this.btnPurchase.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnPurchase.ForeColor = System.Drawing.Color.White;
            this.btnPurchase.Location = new System.Drawing.Point(971, 505);
            this.btnPurchase.Name = "btnPurchase";
            this.btnPurchase.Size = new System.Drawing.Size(146, 34);
            this.btnPurchase.TabIndex = 337;
            this.btnPurchase.Text = "Purchase";
            this.btnPurchase.Click += new System.EventHandler(this.btnPurchase_Click);
            // 
            // btnClose
            // 
            this.btnClose.AutoRoundedCorners = true;
            this.btnClose.BorderRadius = 16;
            this.btnClose.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnClose.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnClose.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnClose.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnClose.FillColor = System.Drawing.Color.Black;
            this.btnClose.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnClose.ForeColor = System.Drawing.Color.White;
            this.btnClose.Location = new System.Drawing.Point(971, 562);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(146, 34);
            this.btnClose.TabIndex = 338;
            this.btnClose.Text = "Close";
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click_1);
            // 
            // btnSave
            // 
            this.btnSave.AutoRoundedCorners = true;
            this.btnSave.BorderRadius = 16;
            this.btnSave.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnSave.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnSave.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnSave.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnSave.FillColor = System.Drawing.Color.Black;
            this.btnSave.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnSave.ForeColor = System.Drawing.Color.White;
            this.btnSave.Location = new System.Drawing.Point(799, 562);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(146, 34);
            this.btnSave.TabIndex = 339;
            this.btnSave.Text = "Save";
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // llVehicleID
            // 
            this.llVehicleID.Location = new System.Drawing.Point(915, 86);
            this.llVehicleID.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.llVehicleID.Name = "llVehicleID";
            this.llVehicleID.Size = new System.Drawing.Size(202, 13);
            this.llVehicleID.TabIndex = 340;
            this.llVehicleID.TabStop = true;
            this.llVehicleID.Text = "Vehicle ID";
            this.llVehicleID.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label17.Location = new System.Drawing.Point(818, 430);
            this.label17.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(138, 17);
            this.label17.TabIndex = 341;
            this.label17.Text = "Purchasing Date :";
            // 
            // dtptxtPurchasing
            // 
            this.dtptxtPurchasing.AutoRoundedCorners = true;
            this.dtptxtPurchasing.BorderRadius = 17;
            this.dtptxtPurchasing.Checked = true;
            this.dtptxtPurchasing.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.dtptxtPurchasing.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtptxtPurchasing.Location = new System.Drawing.Point(971, 419);
            this.dtptxtPurchasing.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dtptxtPurchasing.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dtptxtPurchasing.Name = "dtptxtPurchasing";
            this.dtptxtPurchasing.Size = new System.Drawing.Size(146, 36);
            this.dtptxtPurchasing.TabIndex = 342;
            this.dtptxtPurchasing.Value = new System.DateTime(2024, 6, 3, 5, 25, 51, 274);
            // 
            // lblMode
            // 
            this.lblMode.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblMode.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMode.ForeColor = System.Drawing.Color.Black;
            this.lblMode.Location = new System.Drawing.Point(0, 0);
            this.lblMode.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblMode.Name = "lblMode";
            this.lblMode.Size = new System.Drawing.Size(1134, 58);
            this.lblMode.TabIndex = 343;
            this.lblMode.Text = "Add Update Vehicle";
            this.lblMode.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label18.ForeColor = System.Drawing.Color.Red;
            this.label18.Location = new System.Drawing.Point(501, 574);
            this.label18.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(66, 16);
            this.label18.TabIndex = 344;
            this.label18.Text = "After Vat : ";
            // 
            // frmAddUpdateVehicle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange;
            this.ClientSize = new System.Drawing.Size(1134, 613);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.lblMode);
            this.Controls.Add(this.dtptxtPurchasing);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.llVehicleID);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnPurchase);
            this.Controls.Add(this.txtPurchasingPrice);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.guna2TextBox1);
            this.Controls.Add(this.lblAfterTax);
            this.Controls.Add(this.txtRentalPricePerYear);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.txtRentalPricePerMonth);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.txtRentalPricePerHour);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.cbIsActive);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.cmbDriveTypes);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.cmbBodies);
            this.Controls.Add(this.pbVehicleImage);
            this.Controls.Add(this.txtRentalPricePerDay);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.lblPlateNumber);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.cbIsAvailableForRental);
            this.Controls.Add(this.llRemoveImage);
            this.Controls.Add(this.llSetImage);
            this.Controls.Add(this.lblPlatChar);
            this.Controls.Add(this.txtPlateNumber);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.cmbFuelType);
            this.Controls.Add(this.txtMileage);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtYear);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtRentalPricePerMileage);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtPlateChar);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtVehiclName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblTitleModel);
            this.Controls.Add(this.cmbModel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmbMake);
            this.Name = "frmAddUpdateVehicle";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add Update Vehicle";
            this.Load += new System.EventHandler(this.frmAddUpdateVehicle_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbVehicleImage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Guna.UI2.WinForms.Guna2TextBox txtPurchasingPrice;
        private System.Windows.Forms.Label label16;
        private Guna.UI2.WinForms.Guna2TextBox guna2TextBox1;
        private System.Windows.Forms.Label lblAfterTax;
        private Guna.UI2.WinForms.Guna2TextBox txtRentalPricePerYear;
        private System.Windows.Forms.Label label14;
        private Guna.UI2.WinForms.Guna2TextBox txtRentalPricePerMonth;
        private System.Windows.Forms.Label label15;
        private Guna.UI2.WinForms.Guna2TextBox txtRentalPricePerHour;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label13;
        private Guna.UI2.WinForms.Guna2CustomCheckBox cbIsActive;
        private System.Windows.Forms.Label label11;
        private Guna.UI2.WinForms.Guna2ComboBox cmbDriveTypes;
        private System.Windows.Forms.Label label12;
        private Guna.UI2.WinForms.Guna2ComboBox cmbBodies;
        private System.Windows.Forms.PictureBox pbVehicleImage;
        private Guna.UI2.WinForms.Guna2TextBox txtRentalPricePerDay;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label lblPlateNumber;
        private System.Windows.Forms.Label label10;
        private Guna.UI2.WinForms.Guna2CustomCheckBox cbIsAvailableForRental;
        private System.Windows.Forms.LinkLabel llRemoveImage;
        private System.Windows.Forms.LinkLabel llSetImage;
        private System.Windows.Forms.Label lblPlatChar;
        private Guna.UI2.WinForms.Guna2TextBox txtPlateNumber;
        private System.Windows.Forms.Label label6;
        private Guna.UI2.WinForms.Guna2ComboBox cmbFuelType;
        private Guna.UI2.WinForms.Guna2TextBox txtMileage;
        private System.Windows.Forms.Label label7;
        private Guna.UI2.WinForms.Guna2TextBox txtYear;
        private System.Windows.Forms.Label label5;
        private Guna.UI2.WinForms.Guna2TextBox txtRentalPricePerMileage;
        private System.Windows.Forms.Label label4;
        private Guna.UI2.WinForms.Guna2TextBox txtPlateChar;
        private System.Windows.Forms.Label label3;
        private Guna.UI2.WinForms.Guna2TextBox txtVehiclName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblTitleModel;
        private Guna.UI2.WinForms.Guna2ComboBox cmbModel;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2ComboBox cmbMake;
        private Guna.UI2.WinForms.Guna2Button btnPurchase;
        private Guna.UI2.WinForms.Guna2Button btnClose;
        private Guna.UI2.WinForms.Guna2Button btnSave;
        private System.Windows.Forms.LinkLabel llVehicleID;
        private System.Windows.Forms.Label label17;
        private Guna.UI2.WinForms.Guna2DateTimePicker dtptxtPurchasing;
        private System.Windows.Forms.Label lblMode;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Label label18;
    }
}