namespace CarRental
{
    partial class ctrlBranchChartWithBranchCard
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.ctrlBranchCard1 = new CarRental.ctrlBranchCard();
            this.ctrlBranchChart2 = new CarRental.ctrlBranchChart();
            this.SuspendLayout();
            // 
            // ctrlBranchCard1
            // 
            this.ctrlBranchCard1.AutoScroll = true;
            this.ctrlBranchCard1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(42)))), ((int)(((byte)(57)))));
            this.ctrlBranchCard1.Location = new System.Drawing.Point(3, 53);
            this.ctrlBranchCard1.Name = "ctrlBranchCard1";
            this.ctrlBranchCard1.Size = new System.Drawing.Size(209, 165);
            this.ctrlBranchCard1.TabIndex = 2;
            // 
            // ctrlBranchChart2
            // 
            this.ctrlBranchChart2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.ctrlBranchChart2.AutoScroll = true;
            this.ctrlBranchChart2.Location = new System.Drawing.Point(218, 2);
            this.ctrlBranchChart2.Name = "ctrlBranchChart2";
            this.ctrlBranchChart2.Size = new System.Drawing.Size(881, 274);
            this.ctrlBranchChart2.TabIndex = 1;
            // 
            // ctrlBranchChartWithBranchCard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.ctrlBranchCard1);
            this.Controls.Add(this.ctrlBranchChart2);
            this.Name = "ctrlBranchChartWithBranchCard";
            this.Size = new System.Drawing.Size(1102, 274);
            this.ResumeLayout(false);

        }

        #endregion

        private ctrlBranchChart ctrlBranchChart2;
        private ctrlBranchCard ctrlBranchCard1;
    }
}
