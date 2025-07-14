namespace CarRental
{
    partial class ctrlStatisticsWithBranchCard
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
            this.ctrlStatistics1 = new CarRental.ctrlBranchStatistics();
            this.SuspendLayout();
            // 
            // ctrlBranchCard1
            // 
            this.ctrlBranchCard1.AutoScroll = true;
            this.ctrlBranchCard1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(42)))), ((int)(((byte)(57)))));
            this.ctrlBranchCard1.Location = new System.Drawing.Point(0, 12);
            this.ctrlBranchCard1.Name = "ctrlBranchCard1";
            this.ctrlBranchCard1.Size = new System.Drawing.Size(246, 161);
            this.ctrlBranchCard1.TabIndex = 0;
            // 
            // ctrlStatistics1
            // 
            this.ctrlStatistics1.AutoSize = true;
            this.ctrlStatistics1.BackColor = System.Drawing.Color.White;
            this.ctrlStatistics1.Location = new System.Drawing.Point(252, 0);
            this.ctrlStatistics1.Name = "ctrlStatistics1";
            this.ctrlStatistics1.Size = new System.Drawing.Size(869, 190);
            this.ctrlStatistics1.TabIndex = 1;
            // 
            // ctrlStatisticsWithBranchCard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.ctrlStatistics1);
            this.Controls.Add(this.ctrlBranchCard1);
            this.Name = "ctrlStatisticsWithBranchCard";
            this.Size = new System.Drawing.Size(1124, 193);
            this.Load += new System.EventHandler(this.ctrlStatisticsWithName_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ctrlBranchCard ctrlBranchCard1;
        private ctrlBranchStatistics ctrlStatistics1;
    }
}
