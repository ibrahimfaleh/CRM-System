namespace CarRental
{
    partial class frmAddUpdateContract
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
            this.dtpStartContract = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.dtpEndContract = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtContractAmount = new Guna.UI2.WinForms.Guna2TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cmbTypeContract = new Guna.UI2.WinForms.Guna2ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cmbMethodPayment = new Guna.UI2.WinForms.Guna2ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtFinalPayment = new Guna.UI2.WinForms.Guna2TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.gbContractInfo = new System.Windows.Forms.GroupBox();
            this.nudNumberOfMonthsOfFinalPaymentInstallments = new Guna.UI2.WinForms.Guna2NumericUpDown();
            this.label13 = new System.Windows.Forms.Label();
            this.nudPaymentEveryYears = new Guna.UI2.WinForms.Guna2NumericUpDown();
            this.cbAllowingFinalpaymentInstallments = new System.Windows.Forms.CheckBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.nudPaymentEveryMonths = new Guna.UI2.WinForms.Guna2NumericUpDown();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtInitialPayment = new Guna.UI2.WinForms.Guna2TextBox();
            this.btnClose = new Guna.UI2.WinForms.Guna2Button();
            this.btnSave = new Guna.UI2.WinForms.Guna2Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.label14 = new System.Windows.Forms.Label();
            this.dtpDeferredPaymentDueDate = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblTitleCreatedDate = new System.Windows.Forms.Label();
            this.lblCreatedDate = new System.Windows.Forms.Label();
            this.lblTitleContractID = new System.Windows.Forms.Label();
            this.lblTitleCreatedByUserId = new System.Windows.Forms.Label();
            this.lblTitleUpdatebyUserId = new System.Windows.Forms.Label();
            this.lblUpdatedDate = new System.Windows.Forms.Label();
            this.lblTitleUpdatedDate = new System.Windows.Forms.Label();
            this.llContractID = new System.Windows.Forms.LinkLabel();
            this.llCreatedByUserID = new System.Windows.Forms.LinkLabel();
            this.llUpdatedByUserID = new System.Windows.Forms.LinkLabel();
            this.lblNumberOfYears = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.lblNumberOfMonths = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.lblTotalAmountPaid = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.lblPaymenStatus = new System.Windows.Forms.Label();
            this.txttBranchID = new Guna.UI2.WinForms.Guna2TextBox();
            this.btnSelectBranchID = new Guna.UI2.WinForms.Guna2Button();
            this.gbContractInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudNumberOfMonthsOfFinalPaymentInstallments)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudPaymentEveryYears)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudPaymentEveryMonths)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // dtpStartContract
            // 
            this.dtpStartContract.AutoRoundedCorners = true;
            this.dtpStartContract.BorderRadius = 10;
            this.dtpStartContract.Checked = true;
            this.dtpStartContract.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.dtpStartContract.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpStartContract.Location = new System.Drawing.Point(116, 218);
            this.dtpStartContract.Margin = new System.Windows.Forms.Padding(2);
            this.dtpStartContract.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dtpStartContract.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dtpStartContract.Name = "dtpStartContract";
            this.dtpStartContract.Size = new System.Drawing.Size(171, 22);
            this.dtpStartContract.TabIndex = 0;
            this.dtpStartContract.Value = new System.DateTime(2024, 5, 3, 22, 12, 52, 520);
            this.dtpStartContract.ValueChanged += new System.EventHandler(this.dtpStartContract_ValueChanged);
            this.dtpStartContract.Validating += new System.ComponentModel.CancelEventHandler(this.dtpStartContract_Validating);
            // 
            // dtpEndContract
            // 
            this.dtpEndContract.AutoRoundedCorners = true;
            this.dtpEndContract.BackColor = System.Drawing.Color.Transparent;
            this.dtpEndContract.BorderRadius = 10;
            this.dtpEndContract.Checked = true;
            this.dtpEndContract.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.dtpEndContract.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpEndContract.Location = new System.Drawing.Point(116, 256);
            this.dtpEndContract.Margin = new System.Windows.Forms.Padding(2);
            this.dtpEndContract.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dtpEndContract.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dtpEndContract.Name = "dtpEndContract";
            this.dtpEndContract.Size = new System.Drawing.Size(171, 22);
            this.dtpEndContract.TabIndex = 1;
            this.dtpEndContract.Value = new System.DateTime(2024, 5, 3, 22, 12, 54, 255);
            this.dtpEndContract.ValueChanged += new System.EventHandler(this.dtpEndContract_ValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(49, 224);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Start Date :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(51, 262);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "End Date :";
            // 
            // txtContractAmount
            // 
            this.txtContractAmount.AutoRoundedCorners = true;
            this.txtContractAmount.BorderRadius = 10;
            this.txtContractAmount.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtContractAmount.DefaultText = "";
            this.txtContractAmount.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtContractAmount.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtContractAmount.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtContractAmount.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtContractAmount.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtContractAmount.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtContractAmount.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtContractAmount.Location = new System.Drawing.Point(116, 315);
            this.txtContractAmount.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.txtContractAmount.Name = "txtContractAmount";
            this.txtContractAmount.PasswordChar = '\0';
            this.txtContractAmount.PlaceholderText = "";
            this.txtContractAmount.SelectedText = "";
            this.txtContractAmount.Size = new System.Drawing.Size(171, 22);
            this.txtContractAmount.TabIndex = 4;
            this.txtContractAmount.TextChanged += new System.EventHandler(this.txtContractAmount_TextChanged);
            this.txtContractAmount.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtContractAmount_KeyPress);
            this.txtContractAmount.Validating += new System.ComponentModel.CancelEventHandler(this.txtContractAmount_Validating);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(20, 320);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(92, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Contract Amount :";
            // 
            // cmbTypeContract
            // 
            this.cmbTypeContract.AutoRoundedCorners = true;
            this.cmbTypeContract.BackColor = System.Drawing.Color.Transparent;
            this.cmbTypeContract.BorderRadius = 17;
            this.cmbTypeContract.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbTypeContract.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTypeContract.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cmbTypeContract.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cmbTypeContract.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cmbTypeContract.ForeColor = System.Drawing.Color.Black;
            this.cmbTypeContract.ItemHeight = 30;
            this.cmbTypeContract.Location = new System.Drawing.Point(446, 218);
            this.cmbTypeContract.Margin = new System.Windows.Forms.Padding(2);
            this.cmbTypeContract.Name = "cmbTypeContract";
            this.cmbTypeContract.Size = new System.Drawing.Size(233, 36);
            this.cmbTypeContract.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(397, 226);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Type :";
            // 
            // cmbMethodPayment
            // 
            this.cmbMethodPayment.AutoRoundedCorners = true;
            this.cmbMethodPayment.BackColor = System.Drawing.Color.Transparent;
            this.cmbMethodPayment.BorderRadius = 17;
            this.cmbMethodPayment.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbMethodPayment.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbMethodPayment.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cmbMethodPayment.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cmbMethodPayment.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cmbMethodPayment.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cmbMethodPayment.ItemHeight = 30;
            this.cmbMethodPayment.Items.AddRange(new object[] {
            "Partial",
            "Full",
            "One Payment Later"});
            this.cmbMethodPayment.Location = new System.Drawing.Point(446, 260);
            this.cmbMethodPayment.Margin = new System.Windows.Forms.Padding(2);
            this.cmbMethodPayment.Name = "cmbMethodPayment";
            this.cmbMethodPayment.Size = new System.Drawing.Size(233, 36);
            this.cmbMethodPayment.StartIndex = 0;
            this.cmbMethodPayment.TabIndex = 8;
            this.cmbMethodPayment.SelectedIndexChanged += new System.EventHandler(this.cmbMethodPayment_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(336, 268);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(105, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Method of Payment :";
            // 
            // txtFinalPayment
            // 
            this.txtFinalPayment.AutoRoundedCorners = true;
            this.txtFinalPayment.BorderRadius = 10;
            this.txtFinalPayment.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtFinalPayment.DefaultText = "";
            this.txtFinalPayment.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtFinalPayment.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtFinalPayment.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtFinalPayment.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtFinalPayment.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtFinalPayment.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtFinalPayment.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtFinalPayment.Location = new System.Drawing.Point(117, 73);
            this.txtFinalPayment.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.txtFinalPayment.Name = "txtFinalPayment";
            this.txtFinalPayment.PasswordChar = '\0';
            this.txtFinalPayment.PlaceholderText = "";
            this.txtFinalPayment.SelectedText = "";
            this.txtFinalPayment.Size = new System.Drawing.Size(101, 22);
            this.txtFinalPayment.TabIndex = 10;
            this.txtFinalPayment.TextChanged += new System.EventHandler(this.txtFinalPayment_TextChanged);
            this.txtFinalPayment.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtContractAmount_KeyPress);
            this.txtFinalPayment.Validating += new System.ComponentModel.CancelEventHandler(this.txtFinalPayment_Validating);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(24, 78);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(79, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "Final Payment :";
            // 
            // gbContractInfo
            // 
            this.gbContractInfo.Controls.Add(this.nudNumberOfMonthsOfFinalPaymentInstallments);
            this.gbContractInfo.Controls.Add(this.label13);
            this.gbContractInfo.Controls.Add(this.nudPaymentEveryYears);
            this.gbContractInfo.Controls.Add(this.label6);
            this.gbContractInfo.Controls.Add(this.cbAllowingFinalpaymentInstallments);
            this.gbContractInfo.Controls.Add(this.label10);
            this.gbContractInfo.Controls.Add(this.label12);
            this.gbContractInfo.Controls.Add(this.txtFinalPayment);
            this.gbContractInfo.Controls.Add(this.label11);
            this.gbContractInfo.Controls.Add(this.nudPaymentEveryMonths);
            this.gbContractInfo.Controls.Add(this.label9);
            this.gbContractInfo.Controls.Add(this.label8);
            this.gbContractInfo.Controls.Add(this.label7);
            this.gbContractInfo.Controls.Add(this.txtInitialPayment);
            this.gbContractInfo.Location = new System.Drawing.Point(22, 388);
            this.gbContractInfo.Margin = new System.Windows.Forms.Padding(2);
            this.gbContractInfo.Name = "gbContractInfo";
            this.gbContractInfo.Padding = new System.Windows.Forms.Padding(2);
            this.gbContractInfo.Size = new System.Drawing.Size(656, 147);
            this.gbContractInfo.TabIndex = 12;
            this.gbContractInfo.TabStop = false;
            this.gbContractInfo.Text = "Contract Info";
            this.gbContractInfo.Enter += new System.EventHandler(this.rbContractInfo_Enter);
            // 
            // nudNumberOfMonthsOfFinalPaymentInstallments
            // 
            this.nudNumberOfMonthsOfFinalPaymentInstallments.AutoRoundedCorners = true;
            this.nudNumberOfMonthsOfFinalPaymentInstallments.BackColor = System.Drawing.Color.Transparent;
            this.nudNumberOfMonthsOfFinalPaymentInstallments.BorderColor = System.Drawing.Color.Black;
            this.nudNumberOfMonthsOfFinalPaymentInstallments.BorderRadius = 13;
            this.nudNumberOfMonthsOfFinalPaymentInstallments.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.nudNumberOfMonthsOfFinalPaymentInstallments.Enabled = false;
            this.nudNumberOfMonthsOfFinalPaymentInstallments.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.nudNumberOfMonthsOfFinalPaymentInstallments.Location = new System.Drawing.Point(480, 106);
            this.nudNumberOfMonthsOfFinalPaymentInstallments.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.nudNumberOfMonthsOfFinalPaymentInstallments.Maximum = new decimal(new int[] {
            11,
            0,
            0,
            0});
            this.nudNumberOfMonthsOfFinalPaymentInstallments.Name = "nudNumberOfMonthsOfFinalPaymentInstallments";
            this.nudNumberOfMonthsOfFinalPaymentInstallments.Size = new System.Drawing.Size(56, 29);
            this.nudNumberOfMonthsOfFinalPaymentInstallments.TabIndex = 22;
            this.nudNumberOfMonthsOfFinalPaymentInstallments.Validating += new System.ComponentModel.CancelEventHandler(this.nudNumberOfMonthsOfFinalPaymentInstallments_Validating);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(366, 116);
            this.label13.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(110, 13);
            this.label13.TabIndex = 21;
            this.label13.Text = "In how many months?";
            // 
            // nudPaymentEveryYears
            // 
            this.nudPaymentEveryYears.AutoRoundedCorners = true;
            this.nudPaymentEveryYears.BackColor = System.Drawing.Color.Transparent;
            this.nudPaymentEveryYears.BorderColor = System.Drawing.Color.Black;
            this.nudPaymentEveryYears.BorderRadius = 17;
            this.nudPaymentEveryYears.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.nudPaymentEveryYears.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.nudPaymentEveryYears.Location = new System.Drawing.Point(480, 18);
            this.nudPaymentEveryYears.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.nudPaymentEveryYears.Name = "nudPaymentEveryYears";
            this.nudPaymentEveryYears.Size = new System.Drawing.Size(56, 36);
            this.nudPaymentEveryYears.TabIndex = 20;
            this.nudPaymentEveryYears.ValueChanged += new System.EventHandler(this.nudPaymentEveryYears_ValueChanged);
            this.nudPaymentEveryYears.Validating += new System.ComponentModel.CancelEventHandler(this.nudPaymentEveryYears_Validating);
            // 
            // cbAllowingFinalpaymentInstallments
            // 
            this.cbAllowingFinalpaymentInstallments.AutoSize = true;
            this.cbAllowingFinalpaymentInstallments.Location = new System.Drawing.Point(273, 117);
            this.cbAllowingFinalpaymentInstallments.Margin = new System.Windows.Forms.Padding(2);
            this.cbAllowingFinalpaymentInstallments.Name = "cbAllowingFinalpaymentInstallments";
            this.cbAllowingFinalpaymentInstallments.Size = new System.Drawing.Size(15, 14);
            this.cbAllowingFinalpaymentInstallments.TabIndex = 14;
            this.cbAllowingFinalpaymentInstallments.UseVisualStyleBackColor = true;
            this.cbAllowingFinalpaymentInstallments.CheckedChanged += new System.EventHandler(this.cbAllowingFinalpaymentInstallments_CheckedChanged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(556, 29);
            this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(40, 13);
            this.label10.TabIndex = 19;
            this.label10.Text = "Year(s)";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(21, 117);
            this.label12.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(253, 13);
            this.label12.TabIndex = 13;
            this.label12.Text = "Allowing the final payment to be paid in installments :";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(388, 32);
            this.label11.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(84, 13);
            this.label11.TabIndex = 18;
            this.label11.Text = "Payment Every :";
            // 
            // nudPaymentEveryMonths
            // 
            this.nudPaymentEveryMonths.AutoRoundedCorners = true;
            this.nudPaymentEveryMonths.BackColor = System.Drawing.Color.Transparent;
            this.nudPaymentEveryMonths.BorderColor = System.Drawing.Color.Black;
            this.nudPaymentEveryMonths.BorderRadius = 16;
            this.nudPaymentEveryMonths.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.nudPaymentEveryMonths.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.nudPaymentEveryMonths.Location = new System.Drawing.Point(480, 60);
            this.nudPaymentEveryMonths.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.nudPaymentEveryMonths.Maximum = new decimal(new int[] {
            11,
            0,
            0,
            0});
            this.nudPaymentEveryMonths.Name = "nudPaymentEveryMonths";
            this.nudPaymentEveryMonths.Size = new System.Drawing.Size(56, 35);
            this.nudPaymentEveryMonths.TabIndex = 17;
            this.nudPaymentEveryMonths.ValueChanged += new System.EventHandler(this.nudPaymentEveryMonths_ValueChanged);
            this.nudPaymentEveryMonths.Validating += new System.ComponentModel.CancelEventHandler(this.nudPaymentEveryMonths_Validating);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(556, 71);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(48, 13);
            this.label9.TabIndex = 16;
            this.label9.Text = "Month(s)";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(388, 73);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(84, 13);
            this.label8.TabIndex = 15;
            this.label8.Text = "Payment Every :";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(24, 37);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(81, 13);
            this.label7.TabIndex = 14;
            this.label7.Text = "Initial Payment :";
            // 
            // txtInitialPayment
            // 
            this.txtInitialPayment.AutoRoundedCorners = true;
            this.txtInitialPayment.BorderRadius = 10;
            this.txtInitialPayment.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtInitialPayment.DefaultText = "";
            this.txtInitialPayment.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtInitialPayment.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtInitialPayment.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtInitialPayment.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtInitialPayment.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtInitialPayment.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtInitialPayment.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtInitialPayment.Location = new System.Drawing.Point(117, 32);
            this.txtInitialPayment.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.txtInitialPayment.Name = "txtInitialPayment";
            this.txtInitialPayment.PasswordChar = '\0';
            this.txtInitialPayment.PlaceholderText = "";
            this.txtInitialPayment.SelectedText = "";
            this.txtInitialPayment.Size = new System.Drawing.Size(101, 22);
            this.txtInitialPayment.TabIndex = 13;
            this.txtInitialPayment.TextChanged += new System.EventHandler(this.txtInitialPayment_TextChanged);
            this.txtInitialPayment.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtContractAmount_KeyPress);
            this.txtInitialPayment.Validating += new System.ComponentModel.CancelEventHandler(this.txtInitialPayment_Validating);
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
            this.btnClose.Location = new System.Drawing.Point(571, 551);
            this.btnClose.Margin = new System.Windows.Forms.Padding(2);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(107, 30);
            this.btnClose.TabIndex = 15;
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
            this.btnSave.Location = new System.Drawing.Point(446, 551);
            this.btnSave.Margin = new System.Windows.Forms.Padding(2);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(107, 30);
            this.btnSave.TabIndex = 16;
            this.btnSave.Text = "Save";
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(345, 321);
            this.label14.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(147, 13);
            this.label14.TabIndex = 18;
            this.label14.Text = "Deferred Payment Due Date :";
            // 
            // dtpDeferredPaymentDueDate
            // 
            this.dtpDeferredPaymentDueDate.AutoRoundedCorners = true;
            this.dtpDeferredPaymentDueDate.BorderRadius = 10;
            this.dtpDeferredPaymentDueDate.Checked = true;
            this.dtpDeferredPaymentDueDate.Enabled = false;
            this.dtpDeferredPaymentDueDate.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.dtpDeferredPaymentDueDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDeferredPaymentDueDate.Location = new System.Drawing.Point(507, 315);
            this.dtpDeferredPaymentDueDate.Margin = new System.Windows.Forms.Padding(2);
            this.dtpDeferredPaymentDueDate.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dtpDeferredPaymentDueDate.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dtpDeferredPaymentDueDate.Name = "dtpDeferredPaymentDueDate";
            this.dtpDeferredPaymentDueDate.Size = new System.Drawing.Size(171, 22);
            this.dtpDeferredPaymentDueDate.TabIndex = 17;
            this.dtpDeferredPaymentDueDate.Value = new System.DateTime(2024, 5, 3, 22, 12, 52, 520);
            // 
            // lblTitle
            // 
            this.lblTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblTitle.Location = new System.Drawing.Point(0, 0);
            this.lblTitle.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(700, 41);
            this.lblTitle.TabIndex = 19;
            this.lblTitle.Text = "Add Update Contract";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblTitleCreatedDate
            // 
            this.lblTitleCreatedDate.AutoSize = true;
            this.lblTitleCreatedDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblTitleCreatedDate.Location = new System.Drawing.Point(29, 121);
            this.lblTitleCreatedDate.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTitleCreatedDate.Name = "lblTitleCreatedDate";
            this.lblTitleCreatedDate.Size = new System.Drawing.Size(99, 15);
            this.lblTitleCreatedDate.TabIndex = 20;
            this.lblTitleCreatedDate.Text = "Created Date :";
            // 
            // lblCreatedDate
            // 
            this.lblCreatedDate.AutoSize = true;
            this.lblCreatedDate.Location = new System.Drawing.Point(135, 123);
            this.lblCreatedDate.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCreatedDate.Name = "lblCreatedDate";
            this.lblCreatedDate.Size = new System.Drawing.Size(76, 13);
            this.lblCreatedDate.TabIndex = 21;
            this.lblCreatedDate.Text = "Created Date :";
            // 
            // lblTitleContractID
            // 
            this.lblTitleContractID.AutoSize = true;
            this.lblTitleContractID.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblTitleContractID.Location = new System.Drawing.Point(267, 73);
            this.lblTitleContractID.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTitleContractID.Name = "lblTitleContractID";
            this.lblTitleContractID.Size = new System.Drawing.Size(86, 15);
            this.lblTitleContractID.TabIndex = 22;
            this.lblTitleContractID.Text = "Contract ID :";
            // 
            // lblTitleCreatedByUserId
            // 
            this.lblTitleCreatedByUserId.AutoSize = true;
            this.lblTitleCreatedByUserId.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblTitleCreatedByUserId.Location = new System.Drawing.Point(267, 121);
            this.lblTitleCreatedByUserId.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTitleCreatedByUserId.Name = "lblTitleCreatedByUserId";
            this.lblTitleCreatedByUserId.Size = new System.Drawing.Size(136, 15);
            this.lblTitleCreatedByUserId.TabIndex = 23;
            this.lblTitleCreatedByUserId.Text = "Created By User ID :";
            // 
            // lblTitleUpdatebyUserId
            // 
            this.lblTitleUpdatebyUserId.AutoSize = true;
            this.lblTitleUpdatebyUserId.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblTitleUpdatebyUserId.Location = new System.Drawing.Point(267, 170);
            this.lblTitleUpdatebyUserId.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTitleUpdatebyUserId.Name = "lblTitleUpdatebyUserId";
            this.lblTitleUpdatebyUserId.Size = new System.Drawing.Size(140, 15);
            this.lblTitleUpdatebyUserId.TabIndex = 25;
            this.lblTitleUpdatebyUserId.Text = "Updated By User ID :";
            // 
            // lblUpdatedDate
            // 
            this.lblUpdatedDate.AutoSize = true;
            this.lblUpdatedDate.Location = new System.Drawing.Point(135, 171);
            this.lblUpdatedDate.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblUpdatedDate.Name = "lblUpdatedDate";
            this.lblUpdatedDate.Size = new System.Drawing.Size(76, 13);
            this.lblUpdatedDate.TabIndex = 28;
            this.lblUpdatedDate.Text = "Created Date :";
            // 
            // lblTitleUpdatedDate
            // 
            this.lblTitleUpdatedDate.AutoSize = true;
            this.lblTitleUpdatedDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblTitleUpdatedDate.Location = new System.Drawing.Point(29, 170);
            this.lblTitleUpdatedDate.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTitleUpdatedDate.Name = "lblTitleUpdatedDate";
            this.lblTitleUpdatedDate.Size = new System.Drawing.Size(103, 15);
            this.lblTitleUpdatedDate.TabIndex = 27;
            this.lblTitleUpdatedDate.Text = "Updated Date :";
            // 
            // llContractID
            // 
            this.llContractID.AutoSize = true;
            this.llContractID.Location = new System.Drawing.Point(360, 75);
            this.llContractID.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.llContractID.Name = "llContractID";
            this.llContractID.Size = new System.Drawing.Size(55, 13);
            this.llContractID.TabIndex = 29;
            this.llContractID.TabStop = true;
            this.llContractID.Text = "linkLabel1";
            // 
            // llCreatedByUserID
            // 
            this.llCreatedByUserID.AutoSize = true;
            this.llCreatedByUserID.Location = new System.Drawing.Point(406, 123);
            this.llCreatedByUserID.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.llCreatedByUserID.Name = "llCreatedByUserID";
            this.llCreatedByUserID.Size = new System.Drawing.Size(55, 13);
            this.llCreatedByUserID.TabIndex = 31;
            this.llCreatedByUserID.TabStop = true;
            this.llCreatedByUserID.Text = "linkLabel1";
            this.llCreatedByUserID.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.llCreatedByUserID_LinkClicked);
            // 
            // llUpdatedByUserID
            // 
            this.llUpdatedByUserID.AutoSize = true;
            this.llUpdatedByUserID.Location = new System.Drawing.Point(413, 172);
            this.llUpdatedByUserID.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.llUpdatedByUserID.Name = "llUpdatedByUserID";
            this.llUpdatedByUserID.Size = new System.Drawing.Size(55, 13);
            this.llUpdatedByUserID.TabIndex = 32;
            this.llUpdatedByUserID.TabStop = true;
            this.llUpdatedByUserID.Text = "linkLabel1";
            this.llUpdatedByUserID.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.llUpdatedByUserID_LinkClicked);
            // 
            // lblNumberOfYears
            // 
            this.lblNumberOfYears.AutoSize = true;
            this.lblNumberOfYears.Location = new System.Drawing.Point(638, 76);
            this.lblNumberOfYears.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblNumberOfYears.Name = "lblNumberOfYears";
            this.lblNumberOfYears.Size = new System.Drawing.Size(13, 13);
            this.lblNumberOfYears.TabIndex = 34;
            this.lblNumberOfYears.Text = "0";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label16.Location = new System.Drawing.Point(511, 73);
            this.label16.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(124, 15);
            this.label16.TabIndex = 33;
            this.label16.Text = "Number Of Years :";
            // 
            // lblNumberOfMonths
            // 
            this.lblNumberOfMonths.AutoSize = true;
            this.lblNumberOfMonths.Location = new System.Drawing.Point(646, 126);
            this.lblNumberOfMonths.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblNumberOfMonths.Name = "lblNumberOfMonths";
            this.lblNumberOfMonths.Size = new System.Drawing.Size(13, 13);
            this.lblNumberOfMonths.TabIndex = 36;
            this.lblNumberOfMonths.Text = "0";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label18.Location = new System.Drawing.Point(511, 123);
            this.label18.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(135, 15);
            this.label18.TabIndex = 35;
            this.label18.Text = "Number Of Months :";
            // 
            // lblTotalAmountPaid
            // 
            this.lblTotalAmountPaid.AutoSize = true;
            this.lblTotalAmountPaid.ForeColor = System.Drawing.Color.Green;
            this.lblTotalAmountPaid.Location = new System.Drawing.Point(646, 174);
            this.lblTotalAmountPaid.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTotalAmountPaid.Name = "lblTotalAmountPaid";
            this.lblTotalAmountPaid.Size = new System.Drawing.Size(13, 13);
            this.lblTotalAmountPaid.TabIndex = 38;
            this.lblTotalAmountPaid.Text = "0";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label20.Location = new System.Drawing.Point(511, 172);
            this.label20.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(132, 15);
            this.label20.TabIndex = 37;
            this.label20.Text = "Total Amount Paid :";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label15.Location = new System.Drawing.Point(29, 71);
            this.label15.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(110, 15);
            this.label15.TabIndex = 39;
            this.label15.Text = "Pyment Status : ";
            // 
            // lblPaymenStatus
            // 
            this.lblPaymenStatus.AutoSize = true;
            this.lblPaymenStatus.Location = new System.Drawing.Point(139, 73);
            this.lblPaymenStatus.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPaymenStatus.Name = "lblPaymenStatus";
            this.lblPaymenStatus.Size = new System.Drawing.Size(76, 13);
            this.lblPaymenStatus.TabIndex = 40;
            this.lblPaymenStatus.Text = "Created Date :";
            // 
            // txttBranchID
            // 
            this.txttBranchID.AutoRoundedCorners = true;
            this.txttBranchID.BorderRadius = 10;
            this.txttBranchID.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txttBranchID.DefaultText = "";
            this.txttBranchID.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txttBranchID.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txttBranchID.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txttBranchID.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txttBranchID.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txttBranchID.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txttBranchID.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txttBranchID.Location = new System.Drawing.Point(502, 361);
            this.txttBranchID.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.txttBranchID.Name = "txttBranchID";
            this.txttBranchID.PasswordChar = '\0';
            this.txttBranchID.PlaceholderText = "";
            this.txttBranchID.ReadOnly = true;
            this.txttBranchID.SelectedText = "";
            this.txttBranchID.Size = new System.Drawing.Size(171, 22);
            this.txttBranchID.TabIndex = 41;
            this.txttBranchID.Validating += new System.ComponentModel.CancelEventHandler(this.guna2TextBox1_Validating);
            // 
            // btnSelectBranchID
            // 
            this.btnSelectBranchID.AutoRoundedCorners = true;
            this.btnSelectBranchID.BorderRadius = 10;
            this.btnSelectBranchID.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnSelectBranchID.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnSelectBranchID.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnSelectBranchID.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnSelectBranchID.FillColor = System.Drawing.Color.Black;
            this.btnSelectBranchID.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnSelectBranchID.ForeColor = System.Drawing.Color.White;
            this.btnSelectBranchID.Location = new System.Drawing.Point(385, 361);
            this.btnSelectBranchID.Margin = new System.Windows.Forms.Padding(2);
            this.btnSelectBranchID.Name = "btnSelectBranchID";
            this.btnSelectBranchID.Size = new System.Drawing.Size(107, 22);
            this.btnSelectBranchID.TabIndex = 43;
            this.btnSelectBranchID.Text = "Select Branch";
            this.btnSelectBranchID.Click += new System.EventHandler(this.btnSelectBranchID_Click);
            // 
            // frmAddUpdateContract
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(700, 591);
            this.Controls.Add(this.btnSelectBranchID);
            this.Controls.Add(this.txttBranchID);
            this.Controls.Add(this.lblPaymenStatus);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.lblTotalAmountPaid);
            this.Controls.Add(this.label20);
            this.Controls.Add(this.lblNumberOfMonths);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.lblNumberOfYears);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.llUpdatedByUserID);
            this.Controls.Add(this.llCreatedByUserID);
            this.Controls.Add(this.llContractID);
            this.Controls.Add(this.lblUpdatedDate);
            this.Controls.Add(this.lblTitleUpdatedDate);
            this.Controls.Add(this.lblTitleUpdatebyUserId);
            this.Controls.Add(this.lblTitleCreatedByUserId);
            this.Controls.Add(this.lblTitleContractID);
            this.Controls.Add(this.lblCreatedDate);
            this.Controls.Add(this.lblTitleCreatedDate);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.dtpDeferredPaymentDueDate);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.gbContractInfo);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cmbMethodPayment);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cmbTypeContract);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtContractAmount);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dtpEndContract);
            this.Controls.Add(this.dtpStartContract);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frmAddUpdateContract";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add Update Contract";
            this.Load += new System.EventHandler(this.frmAddUpdateContract_Load);
            this.gbContractInfo.ResumeLayout(false);
            this.gbContractInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudNumberOfMonthsOfFinalPaymentInstallments)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudPaymentEveryYears)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudPaymentEveryMonths)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2DateTimePicker dtpStartContract;
        private Guna.UI2.WinForms.Guna2DateTimePicker dtpEndContract;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private Guna.UI2.WinForms.Guna2TextBox txtContractAmount;
        private System.Windows.Forms.Label label3;
        private Guna.UI2.WinForms.Guna2ComboBox cmbTypeContract;
        private System.Windows.Forms.Label label4;
        private Guna.UI2.WinForms.Guna2ComboBox cmbMethodPayment;
        private System.Windows.Forms.Label label5;
        private Guna.UI2.WinForms.Guna2TextBox txtFinalPayment;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox gbContractInfo;
        private System.Windows.Forms.Label label7;
        private Guna.UI2.WinForms.Guna2TextBox txtInitialPayment;
        private Guna.UI2.WinForms.Guna2NumericUpDown nudPaymentEveryMonths;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private Guna.UI2.WinForms.Guna2NumericUpDown nudPaymentEveryYears;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.CheckBox cbAllowingFinalpaymentInstallments;
        private Guna.UI2.WinForms.Guna2Button btnClose;
        private Guna.UI2.WinForms.Guna2Button btnSave;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private Guna.UI2.WinForms.Guna2NumericUpDown nudNumberOfMonthsOfFinalPaymentInstallments;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private Guna.UI2.WinForms.Guna2DateTimePicker dtpDeferredPaymentDueDate;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblTitleCreatedDate;
        private System.Windows.Forms.Label lblUpdatedDate;
        private System.Windows.Forms.Label lblTitleUpdatedDate;
        private System.Windows.Forms.Label lblTitleUpdatebyUserId;
        private System.Windows.Forms.Label lblTitleCreatedByUserId;
        private System.Windows.Forms.Label lblTitleContractID;
        private System.Windows.Forms.Label lblCreatedDate;
        private System.Windows.Forms.LinkLabel llContractID;
        private System.Windows.Forms.LinkLabel llUpdatedByUserID;
        private System.Windows.Forms.LinkLabel llCreatedByUserID;
        private System.Windows.Forms.Label lblTotalAmountPaid;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label lblNumberOfMonths;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label lblNumberOfYears;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label lblPaymenStatus;
        private Guna.UI2.WinForms.Guna2Button btnSelectBranchID;
        private Guna.UI2.WinForms.Guna2TextBox txttBranchID;
    }
}