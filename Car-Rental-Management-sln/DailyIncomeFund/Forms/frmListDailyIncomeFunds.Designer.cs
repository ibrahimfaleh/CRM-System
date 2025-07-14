namespace CarRental
{
    partial class frmListDailyIncomeFunds
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
            this.btnClose = new Guna.UI2.WinForms.Guna2Button();
            this.lblModeTitle = new System.Windows.Forms.Label();
            this.ctrldgvListDailyIncomeFunds1 = new CarRental.Daily_Income_Fund.ctrldgvListDailyIncomeFunds();
            this.SuspendLayout();
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.BackColor = System.Drawing.Color.Black;
            this.btnClose.BorderColor = System.Drawing.Color.White;
            this.btnClose.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnClose.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnClose.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnClose.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnClose.FillColor = System.Drawing.Color.Black;
            this.btnClose.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnClose.ForeColor = System.Drawing.Color.White;
            this.btnClose.Location = new System.Drawing.Point(1277, 558);
            this.btnClose.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnClose.Name = "btnClose";
            this.btnClose.PressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnClose.Size = new System.Drawing.Size(129, 33);
            this.btnClose.TabIndex = 119;
            this.btnClose.Text = "Close";
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // lblModeTitle
            // 
            this.lblModeTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblModeTitle.Font = new System.Drawing.Font("Microsoft Tai Le", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblModeTitle.ForeColor = System.Drawing.Color.Black;
            this.lblModeTitle.Location = new System.Drawing.Point(0, 0);
            this.lblModeTitle.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblModeTitle.Name = "lblModeTitle";
            this.lblModeTitle.Size = new System.Drawing.Size(1411, 36);
            this.lblModeTitle.TabIndex = 180;
            this.lblModeTitle.Text = "List Daily Income Funds";
            this.lblModeTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ctrldgvListDailyIncomeFunds1
            // 
            this.ctrldgvListDailyIncomeFunds1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ctrldgvListDailyIncomeFunds1.AutoSize = true;
            this.ctrldgvListDailyIncomeFunds1.BackColor = System.Drawing.Color.White;
            this.ctrldgvListDailyIncomeFunds1.Location = new System.Drawing.Point(12, 144);
            this.ctrldgvListDailyIncomeFunds1.Margin = new System.Windows.Forms.Padding(4);
            this.ctrldgvListDailyIncomeFunds1.Name = "ctrldgvListDailyIncomeFunds1";
            this.ctrldgvListDailyIncomeFunds1.Size = new System.Drawing.Size(1397, 393);
            this.ctrldgvListDailyIncomeFunds1.TabIndex = 181;
            this.ctrldgvListDailyIncomeFunds1.Load += new System.EventHandler(this.ctrldgvListDailyIncomeFunds1_Load);
            // 
            // frmListDailyIncomeFunds
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1411, 595);
            this.Controls.Add(this.ctrldgvListDailyIncomeFunds1);
            this.Controls.Add(this.lblModeTitle);
            this.Controls.Add(this.btnClose);
            this.Name = "frmListDailyIncomeFunds";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "List Daily Income Funds";
            this.Load += new System.EventHandler(this.frmListDailyIncomeFunds_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Guna.UI2.WinForms.Guna2Button btnClose;
        private System.Windows.Forms.Label lblModeTitle;
        private Daily_Income_Fund.ctrldgvListDailyIncomeFunds ctrldgvListDailyIncomeFunds1;
    }
}