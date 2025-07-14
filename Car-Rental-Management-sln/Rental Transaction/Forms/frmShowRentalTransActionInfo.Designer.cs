namespace CarRental.Rental_Transaction
{
    partial class frmShowRentalTransActionInfo
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
            this.lable = new System.Windows.Forms.Label();
            this.btnClose = new Guna.UI2.WinForms.Guna2Button();
            this.ctrlRentalTransactionDetails1 = new CarRental.Rental_Transaction.ctrlRentalTransactionDetails();
            this.SuspendLayout();
            // 
            // lable
            // 
            this.lable.AutoSize = true;
            this.lable.Font = new System.Drawing.Font("Microsoft Tai Le", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lable.ForeColor = System.Drawing.Color.SlateBlue;
            this.lable.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.lable.Location = new System.Drawing.Point(314, 17);
            this.lable.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lable.Name = "lable";
            this.lable.Size = new System.Drawing.Size(359, 41);
            this.lable.TabIndex = 149;
            this.lable.Text = "Rental booking Details";
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
            this.btnClose.Location = new System.Drawing.Point(820, 557);
            this.btnClose.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnClose.Name = "btnClose";
            this.btnClose.PressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnClose.Size = new System.Drawing.Size(107, 33);
            this.btnClose.TabIndex = 150;
            this.btnClose.Text = "Close";
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click_1);
            // 
            // ctrlRentalTransactionDetails1
            // 
            this.ctrlRentalTransactionDetails1.AutoSize = true;
            this.ctrlRentalTransactionDetails1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ctrlRentalTransactionDetails1.Location = new System.Drawing.Point(122, 79);
            this.ctrlRentalTransactionDetails1.Name = "ctrlRentalTransactionDetails1";
            this.ctrlRentalTransactionDetails1.Size = new System.Drawing.Size(748, 436);
            this.ctrlRentalTransactionDetails1.TabIndex = 0;
            // 
            // frmShowRentalTransActionInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(934, 596);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.lable);
            this.Controls.Add(this.ctrlRentalTransactionDetails1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "frmShowRentalTransActionInfo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Show Rental TransAction Details";
            this.Load += new System.EventHandler(this.frmShowRentalTransActionInfo_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ctrlRentalTransactionDetails ctrlRentalTransactionDetails1;
        private System.Windows.Forms.Label lable;
        private Guna.UI2.WinForms.Guna2Button btnClose;
    }
}