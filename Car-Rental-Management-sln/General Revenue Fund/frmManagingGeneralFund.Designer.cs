namespace CarRental.Rental_Fund.General_Revenue_Fund
{
    partial class frmManagingGeneralFund
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
            this.lblTitle = new System.Windows.Forms.Label();
            this.btnFundSupport = new Guna.UI2.WinForms.Guna2Button();
            this.btnMoneyWithdrawal = new Guna.UI2.WinForms.Guna2Button();
            this.btnSave = new Guna.UI2.WinForms.Guna2Button();
            this.btnClose = new Guna.UI2.WinForms.Guna2Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtAmount = new Guna.UI2.WinForms.Guna2TextBox();
            this.rbBankToCash = new System.Windows.Forms.RadioButton();
            this.rbCashToBank = new System.Windows.Forms.RadioButton();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.ctrldgvMoneyWithdrawalTransaction1 = new CarRental.Amounts_Spent.Money_Withdrawal_Transactions.ctrldgvMoneyWithdrawalTransaction();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.ctrldgvSalaryPayments1 = new CarRental.Amounts_Spent.Salary_Payments.ctrldgvSalariesPaid();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.ctrldgvListDailyIncomeFunds1 = new CarRental.Daily_Income_Fund.ctrldgvListDailyIncomeFunds();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.ctrldgvGeneralFundSupportTransactions1 = new CarRental.General_Revenue_Fund.ctrldgvGeneralFundSupportTransactions();
            this.tabListMaintenanceTransactions = new System.Windows.Forms.TabPage();
            this.ctrlListMaintenanceTransactions1 = new CarRental.Maintenance_Management.ctrlListMaintenanceTransactions();
            this.btnCloseGeneralFund = new Guna.UI2.WinForms.Guna2Button();
            this.ctrlGeneralRevenueFundCardWithIncomeDetails1 = new CarRental.General_Revenue_Fund.ctrlGeneralRevenueFundCardWithIncomeDetails();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.tabPage4.SuspendLayout();
            this.tabListMaintenanceTransactions.SuspendLayout();
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
            this.lblTitle.Size = new System.Drawing.Size(1420, 49);
            this.lblTitle.TabIndex = 256;
            this.lblTitle.Text = "General Fund";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnFundSupport
            // 
            this.btnFundSupport.BackColor = System.Drawing.Color.Black;
            this.btnFundSupport.BorderColor = System.Drawing.Color.White;
            this.btnFundSupport.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnFundSupport.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnFundSupport.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnFundSupport.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnFundSupport.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnFundSupport.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnFundSupport.ForeColor = System.Drawing.Color.White;
            this.btnFundSupport.Location = new System.Drawing.Point(1276, 188);
            this.btnFundSupport.Margin = new System.Windows.Forms.Padding(2);
            this.btnFundSupport.Name = "btnFundSupport";
            this.btnFundSupport.PressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnFundSupport.Size = new System.Drawing.Size(135, 33);
            this.btnFundSupport.TabIndex = 257;
            this.btnFundSupport.Text = "Fund Support";
            this.btnFundSupport.Click += new System.EventHandler(this.btnFundSupport_Click);
            // 
            // btnMoneyWithdrawal
            // 
            this.btnMoneyWithdrawal.BackColor = System.Drawing.Color.Black;
            this.btnMoneyWithdrawal.BorderColor = System.Drawing.Color.White;
            this.btnMoneyWithdrawal.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnMoneyWithdrawal.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnMoneyWithdrawal.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnMoneyWithdrawal.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnMoneyWithdrawal.FillColor = System.Drawing.Color.Brown;
            this.btnMoneyWithdrawal.Font = new System.Drawing.Font("Segoe UI", 11.25F);
            this.btnMoneyWithdrawal.ForeColor = System.Drawing.Color.White;
            this.btnMoneyWithdrawal.Location = new System.Drawing.Point(1276, 225);
            this.btnMoneyWithdrawal.Margin = new System.Windows.Forms.Padding(2);
            this.btnMoneyWithdrawal.Name = "btnMoneyWithdrawal";
            this.btnMoneyWithdrawal.PressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnMoneyWithdrawal.Size = new System.Drawing.Size(135, 63);
            this.btnMoneyWithdrawal.TabIndex = 258;
            this.btnMoneyWithdrawal.Text = "Money Withdrawal";
            this.btnMoneyWithdrawal.Click += new System.EventHandler(this.btnMoneyWithdrawal_Click);
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.Black;
            this.btnSave.BorderColor = System.Drawing.Color.White;
            this.btnSave.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnSave.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnSave.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnSave.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnSave.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnSave.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnSave.ForeColor = System.Drawing.Color.White;
            this.btnSave.Location = new System.Drawing.Point(1276, 151);
            this.btnSave.Margin = new System.Windows.Forms.Padding(2);
            this.btnSave.Name = "btnSave";
            this.btnSave.PressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnSave.Size = new System.Drawing.Size(135, 33);
            this.btnSave.TabIndex = 263;
            this.btnSave.Text = "Transfer";
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
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
            this.btnClose.Location = new System.Drawing.Point(955, 255);
            this.btnClose.Margin = new System.Windows.Forms.Padding(2);
            this.btnClose.Name = "btnClose";
            this.btnClose.PressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnClose.Size = new System.Drawing.Size(135, 33);
            this.btnClose.TabIndex = 261;
            this.btnClose.Text = "Close";
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.SlateBlue;
            this.label1.Location = new System.Drawing.Point(1042, 65);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(194, 26);
            this.label1.TabIndex = 264;
            this.label1.Text = "Internal transfer :";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtAmount
            // 
            this.txtAmount.BackColor = System.Drawing.Color.White;
            this.txtAmount.BorderColor = System.Drawing.Color.SlateBlue;
            this.txtAmount.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtAmount.DefaultText = "";
            this.txtAmount.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtAmount.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtAmount.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtAmount.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtAmount.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtAmount.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtAmount.ForeColor = System.Drawing.Color.Black;
            this.txtAmount.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtAmount.Location = new System.Drawing.Point(1232, 59);
            this.txtAmount.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.txtAmount.Name = "txtAmount";
            this.txtAmount.PasswordChar = '\0';
            this.txtAmount.PlaceholderText = "";
            this.txtAmount.SelectedText = "";
            this.txtAmount.Size = new System.Drawing.Size(179, 39);
            this.txtAmount.TabIndex = 266;
            this.txtAmount.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtAmount_KeyPress);
            // 
            // rbBankToCash
            // 
            this.rbBankToCash.AutoSize = true;
            this.rbBankToCash.Location = new System.Drawing.Point(1326, 113);
            this.rbBankToCash.Margin = new System.Windows.Forms.Padding(2);
            this.rbBankToCash.Name = "rbBankToCash";
            this.rbBankToCash.Size = new System.Drawing.Size(93, 17);
            this.rbBankToCash.TabIndex = 267;
            this.rbBankToCash.Text = "Bank To Cash";
            this.rbBankToCash.UseVisualStyleBackColor = true;
            // 
            // rbCashToBank
            // 
            this.rbCashToBank.AutoSize = true;
            this.rbCashToBank.Checked = true;
            this.rbCashToBank.Location = new System.Drawing.Point(1232, 113);
            this.rbCashToBank.Margin = new System.Windows.Forms.Padding(2);
            this.rbCashToBank.Name = "rbCashToBank";
            this.rbCashToBank.Size = new System.Drawing.Size(93, 17);
            this.rbCashToBank.TabIndex = 268;
            this.rbCashToBank.TabStop = true;
            this.rbCashToBank.Text = "Cash To Bank";
            this.rbCashToBank.UseVisualStyleBackColor = true;
            this.rbCashToBank.CheckedChanged += new System.EventHandler(this.rbCashToBank_CheckedChanged);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Controls.Add(this.tabListMaintenanceTransactions);
            this.tabControl1.Location = new System.Drawing.Point(16, 293);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1395, 458);
            this.tabControl1.TabIndex = 269;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.ctrldgvMoneyWithdrawalTransaction1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1387, 432);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Money Withdrawal Transaction";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // ctrldgvMoneyWithdrawalTransaction1
            // 
            this.ctrldgvMoneyWithdrawalTransaction1.AutoSize = true;
            this.ctrldgvMoneyWithdrawalTransaction1.BackColor = System.Drawing.Color.White;
            this.ctrldgvMoneyWithdrawalTransaction1.Location = new System.Drawing.Point(5, 5);
            this.ctrldgvMoneyWithdrawalTransaction1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.ctrldgvMoneyWithdrawalTransaction1.Name = "ctrldgvMoneyWithdrawalTransaction1";
            this.ctrldgvMoneyWithdrawalTransaction1.Size = new System.Drawing.Size(1372, 399);
            this.ctrldgvMoneyWithdrawalTransaction1.TabIndex = 0;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.ctrldgvSalaryPayments1);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1387, 404);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Salary Payments";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // ctrldgvSalaryPayments1
            // 
            this.ctrldgvSalaryPayments1.AutoSize = true;
            this.ctrldgvSalaryPayments1.BackColor = System.Drawing.Color.White;
            this.ctrldgvSalaryPayments1.Location = new System.Drawing.Point(5, 5);
            this.ctrldgvSalaryPayments1.Margin = new System.Windows.Forms.Padding(2);
            this.ctrldgvSalaryPayments1.Name = "ctrldgvSalaryPayments1";
            this.ctrldgvSalaryPayments1.Size = new System.Drawing.Size(1829, 486);
            this.ctrldgvSalaryPayments1.TabIndex = 0;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.ctrldgvListDailyIncomeFunds1);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(1387, 404);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "List Daily Income Funds";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // ctrldgvListDailyIncomeFunds1
            // 
            this.ctrldgvListDailyIncomeFunds1.AutoSize = true;
            this.ctrldgvListDailyIncomeFunds1.BackColor = System.Drawing.Color.White;
            this.ctrldgvListDailyIncomeFunds1.Location = new System.Drawing.Point(0, 6);
            this.ctrldgvListDailyIncomeFunds1.Margin = new System.Windows.Forms.Padding(4);
            this.ctrldgvListDailyIncomeFunds1.Name = "ctrldgvListDailyIncomeFunds1";
            this.ctrldgvListDailyIncomeFunds1.Size = new System.Drawing.Size(1833, 484);
            this.ctrldgvListDailyIncomeFunds1.TabIndex = 0;
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.ctrldgvGeneralFundSupportTransactions1);
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(1387, 404);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "General Fund Support Transactions";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // ctrldgvGeneralFundSupportTransactions1
            // 
            this.ctrldgvGeneralFundSupportTransactions1.AutoSize = true;
            this.ctrldgvGeneralFundSupportTransactions1.BackColor = System.Drawing.Color.White;
            this.ctrldgvGeneralFundSupportTransactions1.Location = new System.Drawing.Point(2, 2);
            this.ctrldgvGeneralFundSupportTransactions1.Margin = new System.Windows.Forms.Padding(2);
            this.ctrldgvGeneralFundSupportTransactions1.Name = "ctrldgvGeneralFundSupportTransactions1";
            this.ctrldgvGeneralFundSupportTransactions1.Size = new System.Drawing.Size(1829, 491);
            this.ctrldgvGeneralFundSupportTransactions1.TabIndex = 0;
            this.ctrldgvGeneralFundSupportTransactions1.OnUpdateGeneralFundSupportTransactions += new System.Action<bool>(this.ctrldgvGeneralFundSupportTransactions1_OnUpdateGeneralFundSupportTransactions);
            // 
            // tabListMaintenanceTransactions
            // 
            this.tabListMaintenanceTransactions.Controls.Add(this.ctrlListMaintenanceTransactions1);
            this.tabListMaintenanceTransactions.Location = new System.Drawing.Point(4, 22);
            this.tabListMaintenanceTransactions.Name = "tabListMaintenanceTransactions";
            this.tabListMaintenanceTransactions.Padding = new System.Windows.Forms.Padding(3);
            this.tabListMaintenanceTransactions.Size = new System.Drawing.Size(1387, 404);
            this.tabListMaintenanceTransactions.TabIndex = 4;
            this.tabListMaintenanceTransactions.Text = "List Maintenance Transactions";
            this.tabListMaintenanceTransactions.UseVisualStyleBackColor = true;
            // 
            // ctrlListMaintenanceTransactions1
            // 
            this.ctrlListMaintenanceTransactions1.AutoSize = true;
            this.ctrlListMaintenanceTransactions1.BackColor = System.Drawing.Color.White;
            this.ctrlListMaintenanceTransactions1.Location = new System.Drawing.Point(5, 31);
            this.ctrlListMaintenanceTransactions1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.ctrlListMaintenanceTransactions1.Name = "ctrlListMaintenanceTransactions1";
            this.ctrlListMaintenanceTransactions1.Size = new System.Drawing.Size(1348, 357);
            this.ctrlListMaintenanceTransactions1.TabIndex = 0;
            // 
            // btnCloseGeneralFund
            // 
            this.btnCloseGeneralFund.BackColor = System.Drawing.Color.Black;
            this.btnCloseGeneralFund.BorderColor = System.Drawing.Color.White;
            this.btnCloseGeneralFund.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnCloseGeneralFund.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnCloseGeneralFund.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnCloseGeneralFund.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnCloseGeneralFund.FillColor = System.Drawing.Color.Red;
            this.btnCloseGeneralFund.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnCloseGeneralFund.ForeColor = System.Drawing.Color.White;
            this.btnCloseGeneralFund.Location = new System.Drawing.Point(1113, 255);
            this.btnCloseGeneralFund.Margin = new System.Windows.Forms.Padding(2);
            this.btnCloseGeneralFund.Name = "btnCloseGeneralFund";
            this.btnCloseGeneralFund.PressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnCloseGeneralFund.Size = new System.Drawing.Size(135, 33);
            this.btnCloseGeneralFund.TabIndex = 270;
            this.btnCloseGeneralFund.Text = "Close General Fund";
            this.btnCloseGeneralFund.Click += new System.EventHandler(this.btnCloseGeneralFund_Click);
            // 
            // ctrlGeneralRevenueFundCardWithIncomeDetails1
            // 
            this.ctrlGeneralRevenueFundCardWithIncomeDetails1.AutoSize = true;
            this.ctrlGeneralRevenueFundCardWithIncomeDetails1.BackColor = System.Drawing.Color.White;
            this.ctrlGeneralRevenueFundCardWithIncomeDetails1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ctrlGeneralRevenueFundCardWithIncomeDetails1.Location = new System.Drawing.Point(16, 105);
            this.ctrlGeneralRevenueFundCardWithIncomeDetails1.Name = "ctrlGeneralRevenueFundCardWithIncomeDetails1";
            this.ctrlGeneralRevenueFundCardWithIncomeDetails1.Size = new System.Drawing.Size(707, 133);
            this.ctrlGeneralRevenueFundCardWithIncomeDetails1.TabIndex = 271;
            // 
            // frmManagingGeneralFund
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1420, 763);
            this.Controls.Add(this.ctrlGeneralRevenueFundCardWithIncomeDetails1);
            this.Controls.Add(this.btnCloseGeneralFund);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.rbCashToBank);
            this.Controls.Add(this.rbBankToCash);
            this.Controls.Add(this.txtAmount);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnMoneyWithdrawal);
            this.Controls.Add(this.btnFundSupport);
            this.Controls.Add(this.lblTitle);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frmManagingGeneralFund";
            this.Text = "Managing General Fund";
            this.Load += new System.EventHandler(this.frmManagingGeneralFund_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.tabPage4.ResumeLayout(false);
            this.tabPage4.PerformLayout();
            this.tabListMaintenanceTransactions.ResumeLayout(false);
            this.tabListMaintenanceTransactions.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblTitle;
        private Guna.UI2.WinForms.Guna2Button btnFundSupport;
        private Guna.UI2.WinForms.Guna2Button btnMoneyWithdrawal;
        private Guna.UI2.WinForms.Guna2Button btnSave;
        private Guna.UI2.WinForms.Guna2Button btnClose;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2TextBox txtAmount;
        private System.Windows.Forms.RadioButton rbBankToCash;
        private System.Windows.Forms.RadioButton rbCashToBank;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private Amounts_Spent.Money_Withdrawal_Transactions.ctrldgvMoneyWithdrawalTransaction ctrldgvMoneyWithdrawalTransaction1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.TabPage tabListMaintenanceTransactions;
        private Amounts_Spent.Salary_Payments.ctrldgvSalariesPaid ctrldgvSalaryPayments1;
        private Daily_Income_Fund.ctrldgvListDailyIncomeFunds ctrldgvListDailyIncomeFunds1;
        private CarRental.General_Revenue_Fund.ctrldgvGeneralFundSupportTransactions ctrldgvGeneralFundSupportTransactions1;
        private Maintenance_Management.ctrlListMaintenanceTransactions ctrlListMaintenanceTransactions1;
        private Guna.UI2.WinForms.Guna2Button btnCloseGeneralFund;
        private CarRental.General_Revenue_Fund.ctrlGeneralRevenueFundCardWithIncomeDetails ctrlGeneralRevenueFundCardWithIncomeDetails1;
    }
}