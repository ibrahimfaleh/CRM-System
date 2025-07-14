namespace CarRental.Amounts_Spent.Money_Withdrawal_Transactions
{
    partial class frmMoneyWithdrawalTransaction
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
            this.btnReset = new Guna.UI2.WinForms.Guna2Button();
            this.btnClose = new Guna.UI2.WinForms.Guna2Button();
            this.btnSave = new Guna.UI2.WinForms.Guna2Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.ctrlAmountSpentDetails1 = new CarRental.Amounts_Spent.ctrlAmountSpentDetails();
            this.ctrlGeneralRevenueFundCardWithIncomeDetails1 = new CarRental.General_Revenue_Fund.ctrlGeneralRevenueFundCardWithIncomeDetails();
            this.ctrldgvMoneyWithdrawalTransaction1 = new CarRental.Amounts_Spent.Money_Withdrawal_Transactions.ctrldgvMoneyWithdrawalTransaction();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
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
            this.lblTitle.Size = new System.Drawing.Size(1389, 48);
            this.lblTitle.TabIndex = 264;
            this.lblTitle.Text = "Add New / Update";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnReset
            // 
            this.btnReset.BackColor = System.Drawing.Color.White;
            this.btnReset.BorderColor = System.Drawing.Color.White;
            this.btnReset.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnReset.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnReset.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnReset.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnReset.FillColor = System.Drawing.Color.Green;
            this.btnReset.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnReset.ForeColor = System.Drawing.Color.White;
            this.btnReset.Location = new System.Drawing.Point(1228, 647);
            this.btnReset.Margin = new System.Windows.Forms.Padding(2);
            this.btnReset.Name = "btnReset";
            this.btnReset.PressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnReset.Size = new System.Drawing.Size(153, 29);
            this.btnReset.TabIndex = 275;
            this.btnReset.Text = "Reset";
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
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
            this.btnClose.Location = new System.Drawing.Point(1045, 647);
            this.btnClose.Margin = new System.Windows.Forms.Padding(2);
            this.btnClose.Name = "btnClose";
            this.btnClose.PressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnClose.Size = new System.Drawing.Size(153, 29);
            this.btnClose.TabIndex = 274;
            this.btnClose.Text = "Close";
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.Black;
            this.btnSave.BorderColor = System.Drawing.Color.White;
            this.btnSave.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnSave.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnSave.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnSave.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnSave.FillColor = System.Drawing.Color.Red;
            this.btnSave.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnSave.ForeColor = System.Drawing.Color.White;
            this.btnSave.Location = new System.Drawing.Point(1150, 204);
            this.btnSave.Margin = new System.Windows.Forms.Padding(2);
            this.btnSave.Name = "btnSave";
            this.btnSave.PressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnSave.Size = new System.Drawing.Size(214, 25);
            this.btnSave.TabIndex = 279;
            this.btnSave.Text = "Money Withdrawal";
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // ctrlAmountSpentDetails1
            // 
            this.ctrlAmountSpentDetails1.AutoSize = true;
            this.ctrlAmountSpentDetails1.BackColor = System.Drawing.Color.White;
            this.ctrlAmountSpentDetails1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ctrlAmountSpentDetails1.Location = new System.Drawing.Point(12, 51);
            this.ctrlAmountSpentDetails1.Name = "ctrlAmountSpentDetails1";
            this.ctrlAmountSpentDetails1.Size = new System.Drawing.Size(425, 185);
            this.ctrlAmountSpentDetails1.TabIndex = 282;
            // 
            // ctrlGeneralRevenueFundCardWithIncomeDetails1
            // 
            this.ctrlGeneralRevenueFundCardWithIncomeDetails1.AutoSize = true;
            this.ctrlGeneralRevenueFundCardWithIncomeDetails1.BackColor = System.Drawing.Color.White;
            this.ctrlGeneralRevenueFundCardWithIncomeDetails1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ctrlGeneralRevenueFundCardWithIncomeDetails1.Location = new System.Drawing.Point(774, 66);
            this.ctrlGeneralRevenueFundCardWithIncomeDetails1.Name = "ctrlGeneralRevenueFundCardWithIncomeDetails1";
            this.ctrlGeneralRevenueFundCardWithIncomeDetails1.Size = new System.Drawing.Size(590, 133);
            this.ctrlGeneralRevenueFundCardWithIncomeDetails1.TabIndex = 281;
            // 
            // ctrldgvMoneyWithdrawalTransaction1
            // 
            this.ctrldgvMoneyWithdrawalTransaction1.AutoSize = true;
            this.ctrldgvMoneyWithdrawalTransaction1.BackColor = System.Drawing.Color.White;
            this.ctrldgvMoneyWithdrawalTransaction1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ctrldgvMoneyWithdrawalTransaction1.Location = new System.Drawing.Point(8, 243);
            this.ctrldgvMoneyWithdrawalTransaction1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.ctrldgvMoneyWithdrawalTransaction1.Name = "ctrldgvMoneyWithdrawalTransaction1";
            this.ctrldgvMoneyWithdrawalTransaction1.Size = new System.Drawing.Size(1374, 401);
            this.ctrldgvMoneyWithdrawalTransaction1.TabIndex = 263;
            this.ctrldgvMoneyWithdrawalTransaction1.OnMoneyWithdrawalTransactionID += new System.Action<int>(this.ctrldgvMoneyWithdrawalTransaction1_OnMoneyWithdrawalTransactionID);
            // 
            // frmMoneyWithdrawalTransaction
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1389, 687);
            this.Controls.Add(this.ctrlAmountSpentDetails1);
            this.Controls.Add(this.ctrlGeneralRevenueFundCardWithIncomeDetails1);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.ctrldgvMoneyWithdrawalTransaction1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frmMoneyWithdrawalTransaction";
            this.Text = "Money Withdrawal Transaction";
            this.Load += new System.EventHandler(this.frmMoneyWithdrawalTransaction_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private ctrldgvMoneyWithdrawalTransaction ctrldgvMoneyWithdrawalTransaction1;
        private System.Windows.Forms.Label lblTitle;
        private Guna.UI2.WinForms.Guna2Button btnReset;
        private Guna.UI2.WinForms.Guna2Button btnClose;
        private Guna.UI2.WinForms.Guna2Button btnSave;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private General_Revenue_Fund.ctrlGeneralRevenueFundCardWithIncomeDetails ctrlGeneralRevenueFundCardWithIncomeDetails1;
        private ctrlAmountSpentDetails ctrlAmountSpentDetails1;
    }
}