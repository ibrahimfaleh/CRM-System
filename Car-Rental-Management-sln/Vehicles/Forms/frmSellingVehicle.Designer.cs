namespace CarRental
{
    partial class frmSellingVehicle
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
            this.txtPrice = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtDescription = new Guna.UI2.WinForms.Guna2TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbPaymentDetails = new Guna.UI2.WinForms.Guna2ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnClose = new Guna.UI2.WinForms.Guna2Button();
            this.btnSave = new Guna.UI2.WinForms.Guna2Button();
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblTitleSellingDate = new System.Windows.Forms.Label();
            this.lblSellingDate = new System.Windows.Forms.Label();
            this.lblTitleSellingID = new System.Windows.Forms.Label();
            this.llSellingID = new System.Windows.Forms.LinkLabel();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.lblUpdatedDate = new System.Windows.Forms.Label();
            this.lblTitleUpdatedDate = new System.Windows.Forms.Label();
            this.ctrlVehicleWithFilter1 = new CarRental.Vehicles.ctrlVehicleWithFilter();
            this.lblTitleUpdatedByUserID = new System.Windows.Forms.Label();
            this.lblTitleCreatedByUserID = new System.Windows.Forms.Label();
            this.llCreatedByUserID = new System.Windows.Forms.LinkLabel();
            this.llUpdatedByUserID = new System.Windows.Forms.LinkLabel();
            this.btnReset = new Guna.UI2.WinForms.Guna2Button();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtPrice
            // 
            this.txtPrice.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtPrice.DefaultText = "";
            this.txtPrice.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtPrice.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtPrice.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtPrice.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtPrice.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtPrice.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtPrice.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtPrice.Location = new System.Drawing.Point(172, 610);
            this.txtPrice.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.PasswordChar = '\0';
            this.txtPrice.PlaceholderText = "";
            this.txtPrice.SelectedText = "";
            this.txtPrice.Size = new System.Drawing.Size(199, 40);
            this.txtPrice.TabIndex = 1;
            this.txtPrice.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPrice_KeyPress);
            this.txtPrice.Validating += new System.ComponentModel.CancelEventHandler(this.txtPrice_Validating);
            // 
            // txtDescription
            // 
            this.txtDescription.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtDescription.DefaultText = "";
            this.txtDescription.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtDescription.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtDescription.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtDescription.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtDescription.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtDescription.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtDescription.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtDescription.Location = new System.Drawing.Point(172, 659);
            this.txtDescription.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtDescription.MaxLength = 250;
            this.txtDescription.Multiline = true;
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.PasswordChar = '\0';
            this.txtDescription.PlaceholderText = "";
            this.txtDescription.SelectedText = "";
            this.txtDescription.Size = new System.Drawing.Size(606, 97);
            this.txtDescription.TabIndex = 2;
            this.txtDescription.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtDescription.Validating += new System.ComponentModel.CancelEventHandler(this.ValidateEmptyTextBox);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(80, 618);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "Price :";
            // 
            // cmbPaymentDetails
            // 
            this.cmbPaymentDetails.BackColor = System.Drawing.Color.Transparent;
            this.cmbPaymentDetails.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbPaymentDetails.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbPaymentDetails.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cmbPaymentDetails.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cmbPaymentDetails.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cmbPaymentDetails.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cmbPaymentDetails.ItemHeight = 30;
            this.cmbPaymentDetails.Items.AddRange(new object[] {
            "Cash",
            "Bank Transfer"});
            this.cmbPaymentDetails.Location = new System.Drawing.Point(610, 610);
            this.cmbPaymentDetails.Name = "cmbPaymentDetails";
            this.cmbPaymentDetails.Size = new System.Drawing.Size(189, 36);
            this.cmbPaymentDetails.StartIndex = 0;
            this.cmbPaymentDetails.TabIndex = 4;
            this.cmbPaymentDetails.Validating += new System.ComponentModel.CancelEventHandler(this.ValidateEmptyComboBox);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(449, 618);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(142, 20);
            this.label2.TabIndex = 5;
            this.label2.Text = "Payment Details :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(33, 694);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(105, 20);
            this.label3.TabIndex = 6;
            this.label3.Text = "Description :";
            // 
            // btnClose
            // 
            this.btnClose.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnClose.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnClose.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnClose.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnClose.FillColor = System.Drawing.Color.Black;
            this.btnClose.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnClose.ForeColor = System.Drawing.Color.White;
            this.btnClose.Location = new System.Drawing.Point(831, 726);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(124, 30);
            this.btnClose.TabIndex = 7;
            this.btnClose.Text = "Close";
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnSave
            // 
            this.btnSave.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnSave.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnSave.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnSave.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnSave.FillColor = System.Drawing.Color.Black;
            this.btnSave.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnSave.ForeColor = System.Drawing.Color.White;
            this.btnSave.Location = new System.Drawing.Point(831, 694);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(124, 30);
            this.btnSave.TabIndex = 8;
            this.btnSave.Text = "Save";
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // lblTitle
            // 
            this.lblTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblTitle.Location = new System.Drawing.Point(0, 0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(967, 48);
            this.lblTitle.TabIndex = 9;
            this.lblTitle.Text = "Selling Vehicle";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblTitleSellingDate
            // 
            this.lblTitleSellingDate.AutoSize = true;
            this.lblTitleSellingDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblTitleSellingDate.Location = new System.Drawing.Point(12, 70);
            this.lblTitleSellingDate.Name = "lblTitleSellingDate";
            this.lblTitleSellingDate.Size = new System.Drawing.Size(110, 20);
            this.lblTitleSellingDate.TabIndex = 10;
            this.lblTitleSellingDate.Text = "Selling Date :";
            // 
            // lblSellingDate
            // 
            this.lblSellingDate.AutoSize = true;
            this.lblSellingDate.Location = new System.Drawing.Point(126, 73);
            this.lblSellingDate.Name = "lblSellingDate";
            this.lblSellingDate.Size = new System.Drawing.Size(42, 16);
            this.lblSellingDate.TabIndex = 11;
            this.lblSellingDate.Text = "?????";
            // 
            // lblTitleSellingID
            // 
            this.lblTitleSellingID.AutoSize = true;
            this.lblTitleSellingID.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblTitleSellingID.Location = new System.Drawing.Point(721, 70);
            this.lblTitleSellingID.Name = "lblTitleSellingID";
            this.lblTitleSellingID.Size = new System.Drawing.Size(91, 20);
            this.lblTitleSellingID.TabIndex = 12;
            this.lblTitleSellingID.Text = "Selling ID :";
            // 
            // llSellingID
            // 
            this.llSellingID.AutoSize = true;
            this.llSellingID.Location = new System.Drawing.Point(816, 72);
            this.llSellingID.Name = "llSellingID";
            this.llSellingID.Size = new System.Drawing.Size(68, 16);
            this.llSellingID.TabIndex = 13;
            this.llSellingID.TabStop = true;
            this.llSellingID.Text = "linkLabel1";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // lblUpdatedDate
            // 
            this.lblUpdatedDate.AutoSize = true;
            this.lblUpdatedDate.Location = new System.Drawing.Point(465, 73);
            this.lblUpdatedDate.Name = "lblUpdatedDate";
            this.lblUpdatedDate.Size = new System.Drawing.Size(42, 16);
            this.lblUpdatedDate.TabIndex = 15;
            this.lblUpdatedDate.Text = "?????";
            // 
            // lblTitleUpdatedDate
            // 
            this.lblTitleUpdatedDate.AutoSize = true;
            this.lblTitleUpdatedDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblTitleUpdatedDate.Location = new System.Drawing.Point(337, 70);
            this.lblTitleUpdatedDate.Name = "lblTitleUpdatedDate";
            this.lblTitleUpdatedDate.Size = new System.Drawing.Size(122, 20);
            this.lblTitleUpdatedDate.TabIndex = 14;
            this.lblTitleUpdatedDate.Text = "Updated Date :";
            // 
            // ctrlVehicleWithFilter1
            // 
            this.ctrlVehicleWithFilter1.AutoSize = true;
            this.ctrlVehicleWithFilter1.BackColor = System.Drawing.Color.White;
            this.ctrlVehicleWithFilter1.FilterEnabled = true;
            this.ctrlVehicleWithFilter1.Location = new System.Drawing.Point(37, 147);
            this.ctrlVehicleWithFilter1.Name = "ctrlVehicleWithFilter1";
            this.ctrlVehicleWithFilter1.Size = new System.Drawing.Size(841, 456);
            this.ctrlVehicleWithFilter1.TabIndex = 0;
            this.ctrlVehicleWithFilter1.OnVehicleSelected += new System.Action<int>(this.ctrlVehicleWithFilter1_OnVehicleSelected);
            this.ctrlVehicleWithFilter1.Validating += new System.ComponentModel.CancelEventHandler(this.ctrlVehicleWithFilter1_Validating);
            // 
            // lblTitleUpdatedByUserID
            // 
            this.lblTitleUpdatedByUserID.AutoSize = true;
            this.lblTitleUpdatedByUserID.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblTitleUpdatedByUserID.Location = new System.Drawing.Point(338, 111);
            this.lblTitleUpdatedByUserID.Name = "lblTitleUpdatedByUserID";
            this.lblTitleUpdatedByUserID.Size = new System.Drawing.Size(169, 20);
            this.lblTitleUpdatedByUserID.TabIndex = 18;
            this.lblTitleUpdatedByUserID.Text = "Updated By User ID :";
            // 
            // lblTitleCreatedByUserID
            // 
            this.lblTitleCreatedByUserID.AutoSize = true;
            this.lblTitleCreatedByUserID.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblTitleCreatedByUserID.Location = new System.Drawing.Point(12, 111);
            this.lblTitleCreatedByUserID.Name = "lblTitleCreatedByUserID";
            this.lblTitleCreatedByUserID.Size = new System.Drawing.Size(161, 20);
            this.lblTitleCreatedByUserID.TabIndex = 16;
            this.lblTitleCreatedByUserID.Text = "Created By User ID:";
            // 
            // llCreatedByUserID
            // 
            this.llCreatedByUserID.AutoSize = true;
            this.llCreatedByUserID.Location = new System.Drawing.Point(179, 114);
            this.llCreatedByUserID.Name = "llCreatedByUserID";
            this.llCreatedByUserID.Size = new System.Drawing.Size(68, 16);
            this.llCreatedByUserID.TabIndex = 20;
            this.llCreatedByUserID.TabStop = true;
            this.llCreatedByUserID.Text = "linkLabel1";
            // 
            // llUpdatedByUserID
            // 
            this.llUpdatedByUserID.AutoSize = true;
            this.llUpdatedByUserID.Location = new System.Drawing.Point(518, 114);
            this.llUpdatedByUserID.Name = "llUpdatedByUserID";
            this.llUpdatedByUserID.Size = new System.Drawing.Size(68, 16);
            this.llUpdatedByUserID.TabIndex = 21;
            this.llUpdatedByUserID.TabStop = true;
            this.llUpdatedByUserID.Text = "linkLabel1";
            // 
            // btnReset
            // 
            this.btnReset.BorderColor = System.Drawing.Color.White;
            this.btnReset.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnReset.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnReset.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnReset.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnReset.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btnReset.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnReset.ForeColor = System.Drawing.Color.White;
            this.btnReset.Location = new System.Drawing.Point(831, 658);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(124, 30);
            this.btnReset.TabIndex = 22;
            this.btnReset.Text = "Reset";
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // frmSellingVehicle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(967, 763);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.llUpdatedByUserID);
            this.Controls.Add(this.llCreatedByUserID);
            this.Controls.Add(this.lblTitleUpdatedByUserID);
            this.Controls.Add(this.lblTitleCreatedByUserID);
            this.Controls.Add(this.lblUpdatedDate);
            this.Controls.Add(this.lblTitleUpdatedDate);
            this.Controls.Add(this.llSellingID);
            this.Controls.Add(this.lblTitleSellingID);
            this.Controls.Add(this.lblSellingDate);
            this.Controls.Add(this.lblTitleSellingDate);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cmbPaymentDetails);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtDescription);
            this.Controls.Add(this.txtPrice);
            this.Controls.Add(this.ctrlVehicleWithFilter1);
            this.Name = "frmSellingVehicle";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Selling Vehicle";
            this.Load += new System.EventHandler(this.frmSellingVehicle_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Vehicles.ctrlVehicleWithFilter ctrlVehicleWithFilter1;
        private Guna.UI2.WinForms.Guna2TextBox txtPrice;
        private Guna.UI2.WinForms.Guna2TextBox txtDescription;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2ComboBox cmbPaymentDetails;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private Guna.UI2.WinForms.Guna2Button btnClose;
        private Guna.UI2.WinForms.Guna2Button btnSave;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblTitleSellingDate;
        private System.Windows.Forms.Label lblSellingDate;
        private System.Windows.Forms.Label lblTitleSellingID;
        private System.Windows.Forms.LinkLabel llSellingID;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Label lblUpdatedDate;
        private System.Windows.Forms.Label lblTitleUpdatedDate;
        private System.Windows.Forms.Label lblTitleUpdatedByUserID;
        private System.Windows.Forms.Label lblTitleCreatedByUserID;
        private System.Windows.Forms.LinkLabel llUpdatedByUserID;
        private System.Windows.Forms.LinkLabel llCreatedByUserID;
        private Guna.UI2.WinForms.Guna2Button btnReset;
    }
}