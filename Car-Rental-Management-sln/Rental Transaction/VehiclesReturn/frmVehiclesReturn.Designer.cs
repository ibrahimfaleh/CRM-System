namespace CarRental.Vehicles
{
    partial class frmVehiclesReturn
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
            this.btnClose = new System.Windows.Forms.Button();
            this.btnReturn = new System.Windows.Forms.Button();
            this.txtNewMileage = new Guna.UI2.WinForms.Guna2TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.lblModeTitle = new System.Windows.Forms.Label();
            this.txtAdditionalhours = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtAdditionalCharges = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtActualRentalDays = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtActualReturnDate = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtConsumedMileage = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtTotalRemaining = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtTotalHourlyCharge = new Guna.UI2.WinForms.Guna2TextBox();
            this.lable = new System.Windows.Forms.Label();
            this.lable2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.cmbPayMentDetails = new Guna.UI2.WinForms.Guna2ComboBox();
            this.btnAddUpdateFinallyCheck = new System.Windows.Forms.Button();
            this.txtAdditionalkilometerCharges = new Guna.UI2.WinForms.Guna2TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtAdditionalkilometer = new Guna.UI2.WinForms.Guna2TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.lblTotalRemaining = new System.Windows.Forms.Label();
            this.lblTotalRefundedAmount = new System.Windows.Forms.Label();
            this.lblActualTotalDueAmount = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.lblPaidInitialTotalDueAmount = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.txtActualRentalMonths = new Guna.UI2.WinForms.Guna2TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.ctrlRentalTransactionWithFilter1 = new CarRental.Rental_Transaction.Controls.ctrlRentalTransactionWithFilter();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
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
            this.btnClose.Location = new System.Drawing.Point(1047, 626);
            this.btnClose.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(127, 34);
            this.btnClose.TabIndex = 128;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnReturn
            // 
            this.btnReturn.BackColor = System.Drawing.Color.Red;
            this.btnReturn.FlatAppearance.BorderSize = 2;
            this.btnReturn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.btnReturn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.btnReturn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReturn.ForeColor = System.Drawing.Color.White;
            this.btnReturn.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnReturn.Location = new System.Drawing.Point(917, 626);
            this.btnReturn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnReturn.Name = "btnReturn";
            this.btnReturn.Size = new System.Drawing.Size(127, 34);
            this.btnReturn.TabIndex = 129;
            this.btnReturn.Text = "Return";
            this.btnReturn.UseVisualStyleBackColor = false;
            this.btnReturn.Click += new System.EventHandler(this.btnReturn_Click);
            // 
            // txtNewMileage
            // 
            this.txtNewMileage.BorderColor = System.Drawing.Color.SlateBlue;
            this.txtNewMileage.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtNewMileage.DefaultText = "";
            this.txtNewMileage.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtNewMileage.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtNewMileage.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtNewMileage.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtNewMileage.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtNewMileage.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtNewMileage.ForeColor = System.Drawing.Color.Black;
            this.txtNewMileage.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtNewMileage.Location = new System.Drawing.Point(997, 472);
            this.txtNewMileage.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtNewMileage.MaxLength = 10;
            this.txtNewMileage.Name = "txtNewMileage";
            this.txtNewMileage.PasswordChar = '\0';
            this.txtNewMileage.PlaceholderText = "";
            this.txtNewMileage.SelectedText = "";
            this.txtNewMileage.Size = new System.Drawing.Size(174, 27);
            this.txtNewMileage.TabIndex = 131;
            this.txtNewMileage.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtNewMileage.TextChanged += new System.EventHandler(this.txtNewMileage_TextChanged);
            this.txtNewMileage.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtValidatePositiveNumbers_KeyPress);
            this.txtNewMileage.Validating += new System.ComponentModel.CancelEventHandler(this.ValidateEmptyTextBoxGuna2);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(788, 459);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(105, 16);
            this.label2.TabIndex = 132;
            this.label2.Text = "New Mileage :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(789, 308);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(147, 16);
            this.label6.TabIndex = 173;
            this.label6.Text = "Additional Charges :";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label14.Location = new System.Drawing.Point(789, 208);
            this.label14.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(127, 16);
            this.label14.TabIndex = 172;
            this.label14.Text = "Additional hours :";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label16.Location = new System.Drawing.Point(789, 115);
            this.label16.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(147, 16);
            this.label16.TabIndex = 171;
            this.label16.Text = "Actual Rental Days :";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label17.Location = new System.Drawing.Point(789, 59);
            this.label17.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(144, 16);
            this.label17.TabIndex = 170;
            this.label17.Text = "Actual Return Date :";
            // 
            // lblModeTitle
            // 
            this.lblModeTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblModeTitle.Font = new System.Drawing.Font("Microsoft Tai Le", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblModeTitle.ForeColor = System.Drawing.Color.SlateBlue;
            this.lblModeTitle.Location = new System.Drawing.Point(0, 0);
            this.lblModeTitle.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblModeTitle.Name = "lblModeTitle";
            this.lblModeTitle.Size = new System.Drawing.Size(1190, 36);
            this.lblModeTitle.TabIndex = 178;
            this.lblModeTitle.Text = "Vehicles Return";
            this.lblModeTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtAdditionalhours
            // 
            this.txtAdditionalhours.BorderColor = System.Drawing.Color.SlateBlue;
            this.txtAdditionalhours.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtAdditionalhours.DefaultText = "";
            this.txtAdditionalhours.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtAdditionalhours.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtAdditionalhours.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtAdditionalhours.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtAdditionalhours.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtAdditionalhours.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtAdditionalhours.ForeColor = System.Drawing.Color.Black;
            this.txtAdditionalhours.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtAdditionalhours.Location = new System.Drawing.Point(1000, 202);
            this.txtAdditionalhours.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtAdditionalhours.Name = "txtAdditionalhours";
            this.txtAdditionalhours.PasswordChar = '\0';
            this.txtAdditionalhours.PlaceholderText = "";
            this.txtAdditionalhours.ReadOnly = true;
            this.txtAdditionalhours.SelectedText = "";
            this.txtAdditionalhours.Size = new System.Drawing.Size(172, 27);
            this.txtAdditionalhours.TabIndex = 179;
            this.txtAdditionalhours.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtAdditionalCharges
            // 
            this.txtAdditionalCharges.BorderColor = System.Drawing.Color.SlateBlue;
            this.txtAdditionalCharges.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtAdditionalCharges.DefaultText = "";
            this.txtAdditionalCharges.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtAdditionalCharges.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtAdditionalCharges.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtAdditionalCharges.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtAdditionalCharges.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtAdditionalCharges.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtAdditionalCharges.ForeColor = System.Drawing.Color.Black;
            this.txtAdditionalCharges.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtAdditionalCharges.Location = new System.Drawing.Point(1000, 297);
            this.txtAdditionalCharges.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtAdditionalCharges.Name = "txtAdditionalCharges";
            this.txtAdditionalCharges.PasswordChar = '\0';
            this.txtAdditionalCharges.PlaceholderText = "";
            this.txtAdditionalCharges.ReadOnly = true;
            this.txtAdditionalCharges.SelectedText = "";
            this.txtAdditionalCharges.Size = new System.Drawing.Size(174, 27);
            this.txtAdditionalCharges.TabIndex = 180;
            this.txtAdditionalCharges.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtAdditionalCharges.Validating += new System.ComponentModel.CancelEventHandler(this.txtAdditionalCharges_Validating);
            // 
            // txtActualRentalDays
            // 
            this.txtActualRentalDays.BorderColor = System.Drawing.Color.SlateBlue;
            this.txtActualRentalDays.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtActualRentalDays.DefaultText = "";
            this.txtActualRentalDays.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtActualRentalDays.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtActualRentalDays.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtActualRentalDays.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtActualRentalDays.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtActualRentalDays.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtActualRentalDays.ForeColor = System.Drawing.Color.Black;
            this.txtActualRentalDays.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtActualRentalDays.Location = new System.Drawing.Point(1002, 109);
            this.txtActualRentalDays.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtActualRentalDays.Name = "txtActualRentalDays";
            this.txtActualRentalDays.PasswordChar = '\0';
            this.txtActualRentalDays.PlaceholderText = "";
            this.txtActualRentalDays.ReadOnly = true;
            this.txtActualRentalDays.SelectedText = "";
            this.txtActualRentalDays.Size = new System.Drawing.Size(172, 27);
            this.txtActualRentalDays.TabIndex = 181;
            this.txtActualRentalDays.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtActualReturnDate
            // 
            this.txtActualReturnDate.BorderColor = System.Drawing.Color.SlateBlue;
            this.txtActualReturnDate.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtActualReturnDate.DefaultText = "";
            this.txtActualReturnDate.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtActualReturnDate.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtActualReturnDate.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtActualReturnDate.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtActualReturnDate.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtActualReturnDate.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtActualReturnDate.ForeColor = System.Drawing.Color.Black;
            this.txtActualReturnDate.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtActualReturnDate.Location = new System.Drawing.Point(1000, 59);
            this.txtActualReturnDate.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtActualReturnDate.Name = "txtActualReturnDate";
            this.txtActualReturnDate.PasswordChar = '\0';
            this.txtActualReturnDate.PlaceholderText = "";
            this.txtActualReturnDate.ReadOnly = true;
            this.txtActualReturnDate.SelectedText = "";
            this.txtActualReturnDate.Size = new System.Drawing.Size(172, 27);
            this.txtActualReturnDate.TabIndex = 182;
            this.txtActualReturnDate.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtConsumedMileage
            // 
            this.txtConsumedMileage.BorderColor = System.Drawing.Color.SlateBlue;
            this.txtConsumedMileage.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtConsumedMileage.DefaultText = "";
            this.txtConsumedMileage.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtConsumedMileage.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtConsumedMileage.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtConsumedMileage.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtConsumedMileage.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtConsumedMileage.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtConsumedMileage.ForeColor = System.Drawing.Color.Black;
            this.txtConsumedMileage.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtConsumedMileage.Location = new System.Drawing.Point(1000, 518);
            this.txtConsumedMileage.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtConsumedMileage.Name = "txtConsumedMileage";
            this.txtConsumedMileage.PasswordChar = '\0';
            this.txtConsumedMileage.PlaceholderText = "";
            this.txtConsumedMileage.ReadOnly = true;
            this.txtConsumedMileage.SelectedText = "";
            this.txtConsumedMileage.Size = new System.Drawing.Size(174, 27);
            this.txtConsumedMileage.TabIndex = 192;
            this.txtConsumedMileage.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtTotalRemaining
            // 
            this.txtTotalRemaining.BorderColor = System.Drawing.Color.SlateBlue;
            this.txtTotalRemaining.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtTotalRemaining.DefaultText = "";
            this.txtTotalRemaining.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtTotalRemaining.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtTotalRemaining.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtTotalRemaining.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtTotalRemaining.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtTotalRemaining.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtTotalRemaining.ForeColor = System.Drawing.Color.Black;
            this.txtTotalRemaining.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtTotalRemaining.Location = new System.Drawing.Point(476, 622);
            this.txtTotalRemaining.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtTotalRemaining.Name = "txtTotalRemaining";
            this.txtTotalRemaining.PasswordChar = '\0';
            this.txtTotalRemaining.PlaceholderText = "";
            this.txtTotalRemaining.ReadOnly = true;
            this.txtTotalRemaining.SelectedText = "";
            this.txtTotalRemaining.Size = new System.Drawing.Size(340, 38);
            this.txtTotalRemaining.TabIndex = 191;
            this.txtTotalRemaining.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtTotalHourlyCharge
            // 
            this.txtTotalHourlyCharge.BorderColor = System.Drawing.Color.SlateBlue;
            this.txtTotalHourlyCharge.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtTotalHourlyCharge.DefaultText = "";
            this.txtTotalHourlyCharge.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtTotalHourlyCharge.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtTotalHourlyCharge.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtTotalHourlyCharge.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtTotalHourlyCharge.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtTotalHourlyCharge.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtTotalHourlyCharge.ForeColor = System.Drawing.Color.Black;
            this.txtTotalHourlyCharge.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtTotalHourlyCharge.Location = new System.Drawing.Point(1000, 242);
            this.txtTotalHourlyCharge.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtTotalHourlyCharge.Name = "txtTotalHourlyCharge";
            this.txtTotalHourlyCharge.PasswordChar = '\0';
            this.txtTotalHourlyCharge.PlaceholderText = "";
            this.txtTotalHourlyCharge.ReadOnly = true;
            this.txtTotalHourlyCharge.SelectedText = "";
            this.txtTotalHourlyCharge.Size = new System.Drawing.Size(172, 27);
            this.txtTotalHourlyCharge.TabIndex = 189;
            this.txtTotalHourlyCharge.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lable
            // 
            this.lable.AutoSize = true;
            this.lable.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lable.Location = new System.Drawing.Point(789, 249);
            this.lable.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lable.Name = "lable";
            this.lable.Size = new System.Drawing.Size(141, 16);
            this.lable.TabIndex = 187;
            this.lable.Text = "Total hourly charge";
            // 
            // lable2
            // 
            this.lable2.AutoSize = true;
            this.lable2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lable2.Location = new System.Drawing.Point(303, 633);
            this.lable2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lable2.Name = "lable2";
            this.lable2.Size = new System.Drawing.Size(129, 16);
            this.lable2.TabIndex = 186;
            this.lable2.Text = "Total Remaining :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(789, 522);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(140, 16);
            this.label5.TabIndex = 185;
            this.label5.Text = "Consumed Mileage";
            // 
            // cmbPayMentDetails
            // 
            this.cmbPayMentDetails.BackColor = System.Drawing.Color.Transparent;
            this.cmbPayMentDetails.BorderColor = System.Drawing.Color.SlateBlue;
            this.cmbPayMentDetails.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbPayMentDetails.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbPayMentDetails.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cmbPayMentDetails.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cmbPayMentDetails.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cmbPayMentDetails.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cmbPayMentDetails.ItemHeight = 30;
            this.cmbPayMentDetails.Items.AddRange(new object[] {
            "Cash",
            "Mada Pay"});
            this.cmbPayMentDetails.Location = new System.Drawing.Point(1000, 559);
            this.cmbPayMentDetails.Margin = new System.Windows.Forms.Padding(2);
            this.cmbPayMentDetails.Name = "cmbPayMentDetails";
            this.cmbPayMentDetails.Size = new System.Drawing.Size(174, 36);
            this.cmbPayMentDetails.TabIndex = 195;
            this.cmbPayMentDetails.Validating += new System.ComponentModel.CancelEventHandler(this.cmbBayMentDetails_Validating);
            // 
            // btnAddUpdateFinallyCheck
            // 
            this.btnAddUpdateFinallyCheck.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(42)))), ((int)(((byte)(57)))));
            this.btnAddUpdateFinallyCheck.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAddUpdateFinallyCheck.ForeColor = System.Drawing.Color.White;
            this.btnAddUpdateFinallyCheck.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAddUpdateFinallyCheck.Location = new System.Drawing.Point(1002, 325);
            this.btnAddUpdateFinallyCheck.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnAddUpdateFinallyCheck.Name = "btnAddUpdateFinallyCheck";
            this.btnAddUpdateFinallyCheck.Size = new System.Drawing.Size(170, 26);
            this.btnAddUpdateFinallyCheck.TabIndex = 197;
            this.btnAddUpdateFinallyCheck.Text = "Add Finally Check";
            this.btnAddUpdateFinallyCheck.UseVisualStyleBackColor = false;
            this.btnAddUpdateFinallyCheck.Click += new System.EventHandler(this.btnAddUpdateFinallyCheck_Click);
            // 
            // txtAdditionalkilometerCharges
            // 
            this.txtAdditionalkilometerCharges.BorderColor = System.Drawing.Color.SlateBlue;
            this.txtAdditionalkilometerCharges.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtAdditionalkilometerCharges.DefaultText = "";
            this.txtAdditionalkilometerCharges.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtAdditionalkilometerCharges.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtAdditionalkilometerCharges.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtAdditionalkilometerCharges.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtAdditionalkilometerCharges.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtAdditionalkilometerCharges.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtAdditionalkilometerCharges.ForeColor = System.Drawing.Color.Black;
            this.txtAdditionalkilometerCharges.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtAdditionalkilometerCharges.Location = new System.Drawing.Point(1001, 411);
            this.txtAdditionalkilometerCharges.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtAdditionalkilometerCharges.Name = "txtAdditionalkilometerCharges";
            this.txtAdditionalkilometerCharges.PasswordChar = '\0';
            this.txtAdditionalkilometerCharges.PlaceholderText = "";
            this.txtAdditionalkilometerCharges.ReadOnly = true;
            this.txtAdditionalkilometerCharges.SelectedText = "";
            this.txtAdditionalkilometerCharges.Size = new System.Drawing.Size(172, 27);
            this.txtAdditionalkilometerCharges.TabIndex = 200;
            this.txtAdditionalkilometerCharges.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(788, 417);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(205, 16);
            this.label1.TabIndex = 199;
            this.label1.Text = "Additional kilometer charges";
            // 
            // txtAdditionalkilometer
            // 
            this.txtAdditionalkilometer.BorderColor = System.Drawing.Color.SlateBlue;
            this.txtAdditionalkilometer.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtAdditionalkilometer.DefaultText = "";
            this.txtAdditionalkilometer.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtAdditionalkilometer.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtAdditionalkilometer.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtAdditionalkilometer.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtAdditionalkilometer.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtAdditionalkilometer.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtAdditionalkilometer.ForeColor = System.Drawing.Color.Black;
            this.txtAdditionalkilometer.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtAdditionalkilometer.Location = new System.Drawing.Point(1002, 359);
            this.txtAdditionalkilometer.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtAdditionalkilometer.Name = "txtAdditionalkilometer";
            this.txtAdditionalkilometer.PasswordChar = '\0';
            this.txtAdditionalkilometer.PlaceholderText = "";
            this.txtAdditionalkilometer.ReadOnly = true;
            this.txtAdditionalkilometer.SelectedText = "";
            this.txtAdditionalkilometer.Size = new System.Drawing.Size(172, 27);
            this.txtAdditionalkilometer.TabIndex = 202;
            this.txtAdditionalkilometer.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(789, 362);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(149, 16);
            this.label4.TabIndex = 201;
            this.label4.Text = "Additional kilometer ";
            // 
            // lblTotalRemaining
            // 
            this.lblTotalRemaining.AutoSize = true;
            this.lblTotalRemaining.CausesValidation = false;
            this.lblTotalRemaining.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblTotalRemaining.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.lblTotalRemaining.Location = new System.Drawing.Point(536, 532);
            this.lblTotalRemaining.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTotalRemaining.Name = "lblTotalRemaining";
            this.lblTotalRemaining.Size = new System.Drawing.Size(123, 18);
            this.lblTotalRemaining.TabIndex = 211;
            this.lblTotalRemaining.Text = "Total Remaining :";
            // 
            // lblTotalRefundedAmount
            // 
            this.lblTotalRefundedAmount.AutoSize = true;
            this.lblTotalRefundedAmount.CausesValidation = false;
            this.lblTotalRefundedAmount.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblTotalRefundedAmount.ForeColor = System.Drawing.Color.Red;
            this.lblTotalRefundedAmount.Location = new System.Drawing.Point(589, 571);
            this.lblTotalRefundedAmount.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTotalRefundedAmount.Name = "lblTotalRefundedAmount";
            this.lblTotalRefundedAmount.Size = new System.Drawing.Size(171, 18);
            this.lblTotalRefundedAmount.TabIndex = 210;
            this.lblTotalRefundedAmount.Text = "Total Refunded Amount :";
            // 
            // lblActualTotalDueAmount
            // 
            this.lblActualTotalDueAmount.AutoSize = true;
            this.lblActualTotalDueAmount.CausesValidation = false;
            this.lblActualTotalDueAmount.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblActualTotalDueAmount.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.lblActualTotalDueAmount.Location = new System.Drawing.Point(213, 570);
            this.lblActualTotalDueAmount.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblActualTotalDueAmount.Name = "lblActualTotalDueAmount";
            this.lblActualTotalDueAmount.Size = new System.Drawing.Size(179, 18);
            this.lblActualTotalDueAmount.TabIndex = 209;
            this.lblActualTotalDueAmount.Text = "Actual Total Due Amount :";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.CausesValidation = false;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.Location = new System.Drawing.Point(396, 531);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(136, 17);
            this.label7.TabIndex = 208;
            this.label7.Text = "Total Remaining :";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.CausesValidation = false;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label8.Location = new System.Drawing.Point(396, 571);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(189, 17);
            this.label8.TabIndex = 207;
            this.label8.Text = "Total Refunded Amount :";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.CausesValidation = false;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label9.Location = new System.Drawing.Point(11, 569);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(198, 17);
            this.label9.TabIndex = 206;
            this.label9.Text = "Actual Total Due Amount :";
            // 
            // lblPaidInitialTotalDueAmount
            // 
            this.lblPaidInitialTotalDueAmount.AutoSize = true;
            this.lblPaidInitialTotalDueAmount.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblPaidInitialTotalDueAmount.ForeColor = System.Drawing.Color.Black;
            this.lblPaidInitialTotalDueAmount.Location = new System.Drawing.Point(260, 531);
            this.lblPaidInitialTotalDueAmount.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPaidInitialTotalDueAmount.Name = "lblPaidInitialTotalDueAmount";
            this.lblPaidInitialTotalDueAmount.Size = new System.Drawing.Size(40, 18);
            this.lblPaidInitialTotalDueAmount.TabIndex = 205;
            this.lblPaidInitialTotalDueAmount.Text = "9999";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label15.Location = new System.Drawing.Point(11, 531);
            this.label15.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(229, 17);
            this.label15.TabIndex = 204;
            this.label15.Text = "Paid Initial Total Due Amount :";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.CausesValidation = false;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label10.Location = new System.Drawing.Point(789, 568);
            this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(135, 17);
            this.label10.TabIndex = 212;
            this.label10.Text = "Payment Details :";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // txtActualRentalMonths
            // 
            this.txtActualRentalMonths.BorderColor = System.Drawing.Color.SlateBlue;
            this.txtActualRentalMonths.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtActualRentalMonths.DefaultText = "";
            this.txtActualRentalMonths.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtActualRentalMonths.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtActualRentalMonths.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtActualRentalMonths.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtActualRentalMonths.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtActualRentalMonths.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtActualRentalMonths.ForeColor = System.Drawing.Color.Black;
            this.txtActualRentalMonths.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtActualRentalMonths.Location = new System.Drawing.Point(1002, 144);
            this.txtActualRentalMonths.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtActualRentalMonths.Name = "txtActualRentalMonths";
            this.txtActualRentalMonths.PasswordChar = '\0';
            this.txtActualRentalMonths.PlaceholderText = "";
            this.txtActualRentalMonths.ReadOnly = true;
            this.txtActualRentalMonths.SelectedText = "";
            this.txtActualRentalMonths.Size = new System.Drawing.Size(172, 27);
            this.txtActualRentalMonths.TabIndex = 214;
            this.txtActualRentalMonths.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label11.Location = new System.Drawing.Point(789, 150);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(148, 16);
            this.label11.TabIndex = 213;
            this.label11.Text = "ActualRentalMonths:";
            // 
            // ctrlRentalTransactionWithFilter1
            // 
            this.ctrlRentalTransactionWithFilter1.AutoSize = true;
            this.ctrlRentalTransactionWithFilter1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ctrlRentalTransactionWithFilter1.FilterEnabled = true;
            this.ctrlRentalTransactionWithFilter1.Location = new System.Drawing.Point(14, 57);
            this.ctrlRentalTransactionWithFilter1.Name = "ctrlRentalTransactionWithFilter1";
            this.ctrlRentalTransactionWithFilter1.Size = new System.Drawing.Size(754, 460);
            this.ctrlRentalTransactionWithFilter1.TabIndex = 215;
            this.ctrlRentalTransactionWithFilter1.VehicleEditedVisible = false;
            this.ctrlRentalTransactionWithFilter1.OnRentalTransactionSelected += new System.Action<bool>(this.ctrlRentalTransactionWithFilter1_OnRentalTransactionSelected);
            // 
            // frmVehiclesReturn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1190, 675);
            this.Controls.Add(this.ctrlRentalTransactionWithFilter1);
            this.Controls.Add(this.txtActualRentalMonths);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.lblTotalRemaining);
            this.Controls.Add(this.lblTotalRefundedAmount);
            this.Controls.Add(this.lblActualTotalDueAmount);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.lblPaidInitialTotalDueAmount);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.txtAdditionalkilometer);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtAdditionalkilometerCharges);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnAddUpdateFinallyCheck);
            this.Controls.Add(this.cmbPayMentDetails);
            this.Controls.Add(this.txtConsumedMileage);
            this.Controls.Add(this.txtTotalRemaining);
            this.Controls.Add(this.txtTotalHourlyCharge);
            this.Controls.Add(this.lable);
            this.Controls.Add(this.lable2);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtActualReturnDate);
            this.Controls.Add(this.txtActualRentalDays);
            this.Controls.Add(this.txtAdditionalCharges);
            this.Controls.Add(this.txtAdditionalhours);
            this.Controls.Add(this.lblModeTitle);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtNewMileage);
            this.Controls.Add(this.btnReturn);
            this.Controls.Add(this.btnClose);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frmVehiclesReturn";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Vehicl Return";
            this.Load += new System.EventHandler(this.frmVehiclesReturn_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnReturn;
        private Guna.UI2.WinForms.Guna2TextBox txtNewMileage;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label lblModeTitle;
        private Guna.UI2.WinForms.Guna2TextBox txtAdditionalhours;
        private Guna.UI2.WinForms.Guna2TextBox txtAdditionalCharges;
        private Guna.UI2.WinForms.Guna2TextBox txtActualRentalDays;
        private Guna.UI2.WinForms.Guna2TextBox txtActualReturnDate;
        private Guna.UI2.WinForms.Guna2TextBox txtConsumedMileage;
        private Guna.UI2.WinForms.Guna2TextBox txtTotalRemaining;
        private Guna.UI2.WinForms.Guna2TextBox txtTotalHourlyCharge;
        private System.Windows.Forms.Label lable;
        private System.Windows.Forms.Label lable2;
        private System.Windows.Forms.Label label5;
        private Guna.UI2.WinForms.Guna2ComboBox cmbPayMentDetails;
        private System.Windows.Forms.Button btnAddUpdateFinallyCheck;
        private Guna.UI2.WinForms.Guna2TextBox txtAdditionalkilometerCharges;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2TextBox txtAdditionalkilometer;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblTotalRemaining;
        private System.Windows.Forms.Label lblTotalRefundedAmount;
        private System.Windows.Forms.Label lblActualTotalDueAmount;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label lblPaidInitialTotalDueAmount;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private Guna.UI2.WinForms.Guna2TextBox txtActualRentalMonths;
        private System.Windows.Forms.Label label11;
        private Rental_Transaction.Controls.ctrlRentalTransactionWithFilter ctrlRentalTransactionWithFilter1;
    }
}