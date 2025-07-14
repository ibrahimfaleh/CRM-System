namespace CarRental
{
    partial class frmAddUpdateMaintenanceTransaction
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
            this.lblTitle = new System.Windows.Forms.Label();
            this.txtNewMileage = new Guna.UI2.WinForms.Guna2TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnSelectVehicleTransferredByEmployeeID = new Guna.UI2.WinForms.Guna2Button();
            this.txtTransferredEmployeeID = new Guna.UI2.WinForms.Guna2TextBox();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.txtSelectReturnByEmployeeID = new Guna.UI2.WinForms.Guna2TextBox();
            this.btnSelectReturnByEmployeeID = new Guna.UI2.WinForms.Guna2Button();
            this.gbVehicleReturn = new System.Windows.Forms.GroupBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtConsumedMileage = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtCost = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtDescription = new Guna.UI2.WinForms.Guna2TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lblReturnDate = new System.Windows.Forms.Label();
            this.lblTransferredDate = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lblStatus = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.llCreatedByUserID = new System.Windows.Forms.LinkLabel();
            this.llUpdateByUserID = new System.Windows.Forms.LinkLabel();
            this.btnSave = new Guna.UI2.WinForms.Guna2Button();
            this.btnClose = new Guna.UI2.WinForms.Guna2Button();
            this.llAmountSpent = new System.Windows.Forms.LinkLabel();
            this.lable = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.llMaintenanceID = new System.Windows.Forms.LinkLabel();
            this.ctrlVehicleWithFilter1 = new CarRental.Vehicles.ctrlVehicleWithFilter();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.gbVehicleReturn.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.BackColor = System.Drawing.Color.White;
            this.lblTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblTitle.ForeColor = System.Drawing.Color.SlateBlue;
            this.lblTitle.Location = new System.Drawing.Point(0, 0);
            this.lblTitle.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(1180, 43);
            this.lblTitle.TabIndex = 263;
            this.lblTitle.Text = "Maintenance Add / Update";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.TopCenter;
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
            this.txtNewMileage.Location = new System.Drawing.Point(278, 11);
            this.txtNewMileage.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtNewMileage.Name = "txtNewMileage";
            this.txtNewMileage.PasswordChar = '\0';
            this.txtNewMileage.PlaceholderText = "";
            this.txtNewMileage.SelectedText = "";
            this.txtNewMileage.Size = new System.Drawing.Size(214, 25);
            this.txtNewMileage.TabIndex = 269;
            this.txtNewMileage.TextChanged += new System.EventHandler(this.txtNewMileage_TextChanged);
            this.txtNewMileage.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNewMileage_KeyPress);
            this.txtNewMileage.Validating += new System.ComponentModel.CancelEventHandler(this.txtNewMileage_Validating);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(154, 15);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(109, 17);
            this.label3.TabIndex = 271;
            this.label3.Text = "New Mileage :";
            // 
            // btnSelectVehicleTransferredByEmployeeID
            // 
            this.btnSelectVehicleTransferredByEmployeeID.BackColor = System.Drawing.Color.Black;
            this.btnSelectVehicleTransferredByEmployeeID.BorderColor = System.Drawing.Color.White;
            this.btnSelectVehicleTransferredByEmployeeID.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnSelectVehicleTransferredByEmployeeID.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnSelectVehicleTransferredByEmployeeID.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnSelectVehicleTransferredByEmployeeID.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnSelectVehicleTransferredByEmployeeID.FillColor = System.Drawing.Color.Black;
            this.btnSelectVehicleTransferredByEmployeeID.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnSelectVehicleTransferredByEmployeeID.ForeColor = System.Drawing.Color.White;
            this.btnSelectVehicleTransferredByEmployeeID.Location = new System.Drawing.Point(286, 216);
            this.btnSelectVehicleTransferredByEmployeeID.Margin = new System.Windows.Forms.Padding(2);
            this.btnSelectVehicleTransferredByEmployeeID.Name = "btnSelectVehicleTransferredByEmployeeID";
            this.btnSelectVehicleTransferredByEmployeeID.PressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnSelectVehicleTransferredByEmployeeID.Size = new System.Drawing.Size(214, 29);
            this.btnSelectVehicleTransferredByEmployeeID.TabIndex = 273;
            this.btnSelectVehicleTransferredByEmployeeID.Text = "Transferred By EmployeeID";
            this.btnSelectVehicleTransferredByEmployeeID.Click += new System.EventHandler(this.btnSelectVehicleTransferredByEmployeeID_Click);
            // 
            // txtTransferredEmployeeID
            // 
            this.txtTransferredEmployeeID.BorderColor = System.Drawing.Color.SlateBlue;
            this.txtTransferredEmployeeID.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtTransferredEmployeeID.DefaultText = "";
            this.txtTransferredEmployeeID.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtTransferredEmployeeID.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtTransferredEmployeeID.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtTransferredEmployeeID.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtTransferredEmployeeID.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtTransferredEmployeeID.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtTransferredEmployeeID.ForeColor = System.Drawing.Color.Black;
            this.txtTransferredEmployeeID.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtTransferredEmployeeID.Location = new System.Drawing.Point(286, 185);
            this.txtTransferredEmployeeID.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtTransferredEmployeeID.Name = "txtTransferredEmployeeID";
            this.txtTransferredEmployeeID.PasswordChar = '\0';
            this.txtTransferredEmployeeID.PlaceholderText = "";
            this.txtTransferredEmployeeID.ReadOnly = true;
            this.txtTransferredEmployeeID.SelectedText = "";
            this.txtTransferredEmployeeID.Size = new System.Drawing.Size(214, 25);
            this.txtTransferredEmployeeID.TabIndex = 274;
            this.txtTransferredEmployeeID.Validating += new System.ComponentModel.CancelEventHandler(this.ValidateEmptyTextBox);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // txtSelectReturnByEmployeeID
            // 
            this.txtSelectReturnByEmployeeID.BorderColor = System.Drawing.Color.SlateBlue;
            this.txtSelectReturnByEmployeeID.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtSelectReturnByEmployeeID.DefaultText = "";
            this.txtSelectReturnByEmployeeID.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtSelectReturnByEmployeeID.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtSelectReturnByEmployeeID.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtSelectReturnByEmployeeID.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtSelectReturnByEmployeeID.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtSelectReturnByEmployeeID.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtSelectReturnByEmployeeID.ForeColor = System.Drawing.Color.Black;
            this.txtSelectReturnByEmployeeID.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtSelectReturnByEmployeeID.Location = new System.Drawing.Point(278, 110);
            this.txtSelectReturnByEmployeeID.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtSelectReturnByEmployeeID.Name = "txtSelectReturnByEmployeeID";
            this.txtSelectReturnByEmployeeID.PasswordChar = '\0';
            this.txtSelectReturnByEmployeeID.PlaceholderText = "";
            this.txtSelectReturnByEmployeeID.ReadOnly = true;
            this.txtSelectReturnByEmployeeID.SelectedText = "";
            this.txtSelectReturnByEmployeeID.Size = new System.Drawing.Size(214, 25);
            this.txtSelectReturnByEmployeeID.TabIndex = 277;
            this.txtSelectReturnByEmployeeID.Validating += new System.ComponentModel.CancelEventHandler(this.txtSelectReturnByEmployeeID_Validating);
            // 
            // btnSelectReturnByEmployeeID
            // 
            this.btnSelectReturnByEmployeeID.BackColor = System.Drawing.Color.Black;
            this.btnSelectReturnByEmployeeID.BorderColor = System.Drawing.Color.White;
            this.btnSelectReturnByEmployeeID.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnSelectReturnByEmployeeID.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnSelectReturnByEmployeeID.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnSelectReturnByEmployeeID.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnSelectReturnByEmployeeID.FillColor = System.Drawing.Color.Black;
            this.btnSelectReturnByEmployeeID.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnSelectReturnByEmployeeID.ForeColor = System.Drawing.Color.White;
            this.btnSelectReturnByEmployeeID.Location = new System.Drawing.Point(278, 138);
            this.btnSelectReturnByEmployeeID.Margin = new System.Windows.Forms.Padding(2);
            this.btnSelectReturnByEmployeeID.Name = "btnSelectReturnByEmployeeID";
            this.btnSelectReturnByEmployeeID.PressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnSelectReturnByEmployeeID.Size = new System.Drawing.Size(213, 29);
            this.btnSelectReturnByEmployeeID.TabIndex = 276;
            this.btnSelectReturnByEmployeeID.Text = "Return By EmployeeID";
            this.btnSelectReturnByEmployeeID.Click += new System.EventHandler(this.btnSelectReturnByEmployeeID_Click);
            // 
            // gbVehicleReturn
            // 
            this.gbVehicleReturn.Controls.Add(this.label8);
            this.gbVehicleReturn.Controls.Add(this.label4);
            this.gbVehicleReturn.Controls.Add(this.txtConsumedMileage);
            this.gbVehicleReturn.Controls.Add(this.txtCost);
            this.gbVehicleReturn.Controls.Add(this.txtSelectReturnByEmployeeID);
            this.gbVehicleReturn.Controls.Add(this.btnSelectReturnByEmployeeID);
            this.gbVehicleReturn.Controls.Add(this.txtNewMileage);
            this.gbVehicleReturn.Controls.Add(this.label3);
            this.gbVehicleReturn.Enabled = false;
            this.gbVehicleReturn.Location = new System.Drawing.Point(9, 249);
            this.gbVehicleReturn.Margin = new System.Windows.Forms.Padding(2);
            this.gbVehicleReturn.Name = "gbVehicleReturn";
            this.gbVehicleReturn.Padding = new System.Windows.Forms.Padding(2);
            this.gbVehicleReturn.Size = new System.Drawing.Size(518, 181);
            this.gbVehicleReturn.TabIndex = 278;
            this.gbVehicleReturn.TabStop = false;
            this.gbVehicleReturn.Text = "Vehicle Return Info";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label8.ForeColor = System.Drawing.Color.Black;
            this.label8.Location = new System.Drawing.Point(204, 50);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(59, 17);
            this.label8.TabIndex = 285;
            this.label8.Text = "Coust :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(115, 84);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(154, 17);
            this.label4.TabIndex = 283;
            this.label4.Text = "Consumed Mileage :";
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
            this.txtConsumedMileage.Location = new System.Drawing.Point(278, 78);
            this.txtConsumedMileage.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtConsumedMileage.Name = "txtConsumedMileage";
            this.txtConsumedMileage.PasswordChar = '\0';
            this.txtConsumedMileage.PlaceholderText = "";
            this.txtConsumedMileage.ReadOnly = true;
            this.txtConsumedMileage.SelectedText = "";
            this.txtConsumedMileage.Size = new System.Drawing.Size(214, 25);
            this.txtConsumedMileage.TabIndex = 282;
            // 
            // txtCost
            // 
            this.txtCost.BorderColor = System.Drawing.Color.SlateBlue;
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
            this.txtCost.Location = new System.Drawing.Point(278, 45);
            this.txtCost.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtCost.Name = "txtCost";
            this.txtCost.PasswordChar = '\0';
            this.txtCost.PlaceholderText = "";
            this.txtCost.SelectedText = "";
            this.txtCost.Size = new System.Drawing.Size(214, 25);
            this.txtCost.TabIndex = 280;
            this.txtCost.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCost_KeyPress);
            this.txtCost.Validating += new System.ComponentModel.CancelEventHandler(this.txtCost_Validating);
            // 
            // txtDescription
            // 
            this.txtDescription.BorderColor = System.Drawing.Color.SlateBlue;
            this.txtDescription.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtDescription.DefaultText = "";
            this.txtDescription.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtDescription.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtDescription.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtDescription.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtDescription.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtDescription.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtDescription.ForeColor = System.Drawing.Color.Black;
            this.txtDescription.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtDescription.Location = new System.Drawing.Point(10, 431);
            this.txtDescription.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtDescription.Multiline = true;
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.PasswordChar = '\0';
            this.txtDescription.PlaceholderForeColor = System.Drawing.Color.DimGray;
            this.txtDescription.PlaceholderText = "Description";
            this.txtDescription.SelectedText = "";
            this.txtDescription.Size = new System.Drawing.Size(517, 92);
            this.txtDescription.TabIndex = 279;
            this.txtDescription.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtDescription.Validating += new System.ComponentModel.CancelEventHandler(this.ValidateEmptyTextBox);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(27, 122);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(143, 17);
            this.label1.TabIndex = 280;
            this.label1.Text = "Transferred Date :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(27, 162);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(106, 17);
            this.label5.TabIndex = 281;
            this.label5.Text = "Return Date :";
            // 
            // lblReturnDate
            // 
            this.lblReturnDate.AutoSize = true;
            this.lblReturnDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblReturnDate.ForeColor = System.Drawing.Color.Black;
            this.lblReturnDate.Location = new System.Drawing.Point(147, 163);
            this.lblReturnDate.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblReturnDate.Name = "lblReturnDate";
            this.lblReturnDate.Size = new System.Drawing.Size(57, 17);
            this.lblReturnDate.TabIndex = 283;
            this.lblReturnDate.Text = "Mileage";
            // 
            // lblTransferredDate
            // 
            this.lblTransferredDate.AutoSize = true;
            this.lblTransferredDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblTransferredDate.ForeColor = System.Drawing.Color.Black;
            this.lblTransferredDate.Location = new System.Drawing.Point(179, 122);
            this.lblTransferredDate.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTransferredDate.Name = "lblTransferredDate";
            this.lblTransferredDate.Size = new System.Drawing.Size(57, 17);
            this.lblTransferredDate.TabIndex = 282;
            this.lblTransferredDate.Text = "Mileage";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(332, 122);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(64, 17);
            this.label6.TabIndex = 284;
            this.label6.Text = "Status :";
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblStatus.ForeColor = System.Drawing.Color.Black;
            this.lblStatus.Location = new System.Drawing.Point(398, 123);
            this.lblStatus.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(40, 17);
            this.lblStatus.TabIndex = 285;
            this.lblStatus.Text = "????";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(332, 80);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(157, 17);
            this.label7.TabIndex = 288;
            this.label7.Text = "Created By User ID :";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label9.ForeColor = System.Drawing.Color.Black;
            this.label9.Location = new System.Drawing.Point(605, 83);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(147, 17);
            this.label9.TabIndex = 286;
            this.label9.Text = "Update By User ID:";
            // 
            // llCreatedByUserID
            // 
            this.llCreatedByUserID.AutoSize = true;
            this.llCreatedByUserID.Location = new System.Drawing.Point(488, 83);
            this.llCreatedByUserID.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.llCreatedByUserID.Name = "llCreatedByUserID";
            this.llCreatedByUserID.Size = new System.Drawing.Size(31, 13);
            this.llCreatedByUserID.TabIndex = 291;
            this.llCreatedByUserID.TabStop = true;
            this.llCreatedByUserID.Text = "????";
            // 
            // llUpdateByUserID
            // 
            this.llUpdateByUserID.AutoSize = true;
            this.llUpdateByUserID.Location = new System.Drawing.Point(752, 85);
            this.llUpdateByUserID.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.llUpdateByUserID.Name = "llUpdateByUserID";
            this.llUpdateByUserID.Size = new System.Drawing.Size(31, 13);
            this.llUpdateByUserID.TabIndex = 292;
            this.llUpdateByUserID.TabStop = true;
            this.llUpdateByUserID.Text = "????";
            // 
            // btnSave
            // 
            this.btnSave.AutoRoundedCorners = true;
            this.btnSave.BackColor = System.Drawing.Color.Transparent;
            this.btnSave.BorderColor = System.Drawing.Color.White;
            this.btnSave.BorderRadius = 13;
            this.btnSave.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnSave.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnSave.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnSave.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnSave.FillColor = System.Drawing.Color.Black;
            this.btnSave.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnSave.ForeColor = System.Drawing.Color.White;
            this.btnSave.Location = new System.Drawing.Point(812, 538);
            this.btnSave.Margin = new System.Windows.Forms.Padding(2);
            this.btnSave.Name = "btnSave";
            this.btnSave.PressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnSave.Size = new System.Drawing.Size(168, 28);
            this.btnSave.TabIndex = 294;
            this.btnSave.Text = "Save";
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnClose
            // 
            this.btnClose.AutoRoundedCorners = true;
            this.btnClose.BackColor = System.Drawing.Color.Transparent;
            this.btnClose.BorderColor = System.Drawing.Color.White;
            this.btnClose.BorderRadius = 12;
            this.btnClose.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnClose.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnClose.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnClose.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnClose.FillColor = System.Drawing.Color.Black;
            this.btnClose.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnClose.ForeColor = System.Drawing.Color.White;
            this.btnClose.Location = new System.Drawing.Point(994, 539);
            this.btnClose.Margin = new System.Windows.Forms.Padding(2);
            this.btnClose.Name = "btnClose";
            this.btnClose.PressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnClose.Size = new System.Drawing.Size(168, 27);
            this.btnClose.TabIndex = 293;
            this.btnClose.Text = "Close";
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click_1);
            // 
            // llAmountSpent
            // 
            this.llAmountSpent.AutoSize = true;
            this.llAmountSpent.Location = new System.Drawing.Point(1022, 84);
            this.llAmountSpent.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.llAmountSpent.Name = "llAmountSpent";
            this.llAmountSpent.Size = new System.Drawing.Size(31, 13);
            this.llAmountSpent.TabIndex = 296;
            this.llAmountSpent.TabStop = true;
            this.llAmountSpent.Text = "????";
            // 
            // lable
            // 
            this.lable.AutoSize = true;
            this.lable.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lable.ForeColor = System.Drawing.Color.Black;
            this.lable.Location = new System.Drawing.Point(875, 82);
            this.lable.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lable.Name = "lable";
            this.lable.Size = new System.Drawing.Size(139, 17);
            this.lable.TabIndex = 295;
            this.lable.Text = "Amount Spent ID :";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label10.Location = new System.Drawing.Point(27, 81);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(122, 16);
            this.label10.TabIndex = 298;
            this.label10.Text = "Maintenance ID :";
            // 
            // llMaintenanceID
            // 
            this.llMaintenanceID.AutoSize = true;
            this.llMaintenanceID.Location = new System.Drawing.Point(155, 83);
            this.llMaintenanceID.Name = "llMaintenanceID";
            this.llMaintenanceID.Size = new System.Drawing.Size(55, 13);
            this.llMaintenanceID.TabIndex = 299;
            this.llMaintenanceID.TabStop = true;
            this.llMaintenanceID.Text = "linkLabel1";
            // 
            // ctrlVehicleWithFilter1
            // 
            this.ctrlVehicleWithFilter1.AutoSize = true;
            this.ctrlVehicleWithFilter1.BackColor = System.Drawing.Color.White;
            this.ctrlVehicleWithFilter1.EditedVisible = false;
            this.ctrlVehicleWithFilter1.FilterEnabled = true;
            this.ctrlVehicleWithFilter1.Location = new System.Drawing.Point(532, 152);
            this.ctrlVehicleWithFilter1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.ctrlVehicleWithFilter1.Name = "ctrlVehicleWithFilter1";
            this.ctrlVehicleWithFilter1.Size = new System.Drawing.Size(631, 371);
            this.ctrlVehicleWithFilter1.TabIndex = 300;
            this.ctrlVehicleWithFilter1.OnVehicleSelected += new System.Action<int>(this.ctrlVehicleWithFilter1_OnVehicleSelected);
            this.ctrlVehicleWithFilter1.Validating += new System.ComponentModel.CancelEventHandler(this.ctrlVehicleWithFilter1_Validating);
            // 
            // frmAddUpdateMaintenanceTransaction
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1180, 575);
            this.Controls.Add(this.ctrlVehicleWithFilter1);
            this.Controls.Add(this.llMaintenanceID);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.llAmountSpent);
            this.Controls.Add(this.txtDescription);
            this.Controls.Add(this.lable);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.llUpdateByUserID);
            this.Controls.Add(this.llCreatedByUserID);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.lblReturnDate);
            this.Controls.Add(this.lblTransferredDate);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.gbVehicleReturn);
            this.Controls.Add(this.txtTransferredEmployeeID);
            this.Controls.Add(this.btnSelectVehicleTransferredByEmployeeID);
            this.Controls.Add(this.lblTitle);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frmAddUpdateMaintenanceTransaction";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Maintenance Add / Update";
            this.Load += new System.EventHandler(this.frmMaintenanceManagement_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.gbVehicleReturn.ResumeLayout(false);
            this.gbVehicleReturn.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblTitle;
        private Guna.UI2.WinForms.Guna2TextBox txtNewMileage;
        private System.Windows.Forms.Label label3;
        private Guna.UI2.WinForms.Guna2Button btnSelectVehicleTransferredByEmployeeID;
        private Guna.UI2.WinForms.Guna2TextBox txtTransferredEmployeeID;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private Guna.UI2.WinForms.Guna2TextBox txtSelectReturnByEmployeeID;
        private Guna.UI2.WinForms.Guna2Button btnSelectReturnByEmployeeID;
        private System.Windows.Forms.GroupBox gbVehicleReturn;
        private Guna.UI2.WinForms.Guna2TextBox txtDescription;
        private Guna.UI2.WinForms.Guna2TextBox txtCost;
        private System.Windows.Forms.Label label4;
        private Guna.UI2.WinForms.Guna2TextBox txtConsumedMileage;
        private System.Windows.Forms.Label lblReturnDate;
        private System.Windows.Forms.Label lblTransferredDate;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.Label label6;
        private Guna.UI2.WinForms.Guna2Button btnSave;
        private Guna.UI2.WinForms.Guna2Button btnClose;
        private System.Windows.Forms.LinkLabel llUpdateByUserID;
        private System.Windows.Forms.LinkLabel llCreatedByUserID;
        private System.Windows.Forms.LinkLabel llAmountSpent;
        private System.Windows.Forms.Label lable;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.LinkLabel llMaintenanceID;
        private Vehicles.ctrlVehicleWithFilter ctrlVehicleWithFilter1;
    }
}