namespace CarRental.Rental_Fund
{
    partial class frmSupportingFundLiquidity
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
            this.lblModeTitle = new System.Windows.Forms.Label();
            this.txtAmount = new Guna.UI2.WinForms.Guna2TextBox();
            this.btnSupportingFundLiquidity = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.ctrlRentalTransactionDetails1 = new CarRental.Rental_Transaction.ctrlRentalTransactionDetails();
            this.SuspendLayout();
            // 
            // lblModeTitle
            // 
            this.lblModeTitle.AutoSize = true;
            this.lblModeTitle.Font = new System.Drawing.Font("Microsoft Tai Le", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblModeTitle.ForeColor = System.Drawing.Color.SlateBlue;
            this.lblModeTitle.Location = new System.Drawing.Point(279, 7);
            this.lblModeTitle.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblModeTitle.Name = "lblModeTitle";
            this.lblModeTitle.Size = new System.Drawing.Size(351, 34);
            this.lblModeTitle.TabIndex = 224;
            this.lblModeTitle.Text = "Supporting Fund Liquidity";
            // 
            // txtAmount
            // 
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
            this.txtAmount.Location = new System.Drawing.Point(748, 543);
            this.txtAmount.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtAmount.Name = "txtAmount";
            this.txtAmount.PasswordChar = '\0';
            this.txtAmount.PlaceholderText = "";
            this.txtAmount.ReadOnly = true;
            this.txtAmount.SelectedText = "";
            this.txtAmount.Size = new System.Drawing.Size(172, 31);
            this.txtAmount.TabIndex = 234;
            this.txtAmount.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnSupportingFundLiquidity
            // 
            this.btnSupportingFundLiquidity.BackColor = System.Drawing.Color.Green;
            this.btnSupportingFundLiquidity.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnSupportingFundLiquidity.FlatAppearance.BorderSize = 2;
            this.btnSupportingFundLiquidity.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.btnSupportingFundLiquidity.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.btnSupportingFundLiquidity.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSupportingFundLiquidity.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnSupportingFundLiquidity.ForeColor = System.Drawing.Color.White;
            this.btnSupportingFundLiquidity.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSupportingFundLiquidity.Location = new System.Drawing.Point(616, 608);
            this.btnSupportingFundLiquidity.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnSupportingFundLiquidity.Name = "btnSupportingFundLiquidity";
            this.btnSupportingFundLiquidity.Size = new System.Drawing.Size(170, 34);
            this.btnSupportingFundLiquidity.TabIndex = 233;
            this.btnSupportingFundLiquidity.Text = "Supporting Fund Liquidity";
            this.btnSupportingFundLiquidity.UseVisualStyleBackColor = false;
            this.btnSupportingFundLiquidity.Click += new System.EventHandler(this.btnSupportingFundLiquidity_Click);
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
            this.btnClose.Location = new System.Drawing.Point(802, 608);
            this.btnClose.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(127, 34);
            this.btnClose.TabIndex = 239;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.CausesValidation = false;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(666, 551);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 17);
            this.label1.TabIndex = 240;
            this.label1.Text = "Amount :";
            // 
            // ctrlRentalTransactionDetails1
            // 
            this.ctrlRentalTransactionDetails1.AutoSize = true;
            this.ctrlRentalTransactionDetails1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ctrlRentalTransactionDetails1.Location = new System.Drawing.Point(2, 55);
            this.ctrlRentalTransactionDetails1.Margin = new System.Windows.Forms.Padding(4);
            this.ctrlRentalTransactionDetails1.Name = "ctrlRentalTransactionDetails1";
            this.ctrlRentalTransactionDetails1.Size = new System.Drawing.Size(928, 480);
            this.ctrlRentalTransactionDetails1.TabIndex = 238;
            // 
            // frmSupportingFundLiquidity
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(932, 646);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.ctrlRentalTransactionDetails1);
            this.Controls.Add(this.txtAmount);
            this.Controls.Add(this.btnSupportingFundLiquidity);
            this.Controls.Add(this.lblModeTitle);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frmSupportingFundLiquidity";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Supporting Fund Liquidity";
            this.Load += new System.EventHandler(this.frmSupportingFundLiquidity_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblModeTitle;
        private Guna.UI2.WinForms.Guna2TextBox txtAmount;
        private System.Windows.Forms.Button btnSupportingFundLiquidity;
        private Rental_Transaction.ctrlRentalTransactionDetails ctrlRentalTransactionDetails1;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Label label1;
    }
}