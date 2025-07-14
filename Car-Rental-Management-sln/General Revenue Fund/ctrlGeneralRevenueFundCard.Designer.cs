namespace CarRental.General_Revenue_Fund
{
    partial class ctrlGeneralRevenueFundCard
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
            this.lblStartDate = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblEndDate = new System.Windows.Forms.Label();
            this.lblIsClosed = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.llGeneralID = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // lblStartDate
            // 
            this.lblStartDate.AutoSize = true;
            this.lblStartDate.ForeColor = System.Drawing.Color.White;
            this.lblStartDate.Location = new System.Drawing.Point(70, 41);
            this.lblStartDate.Name = "lblStartDate";
            this.lblStartDate.Size = new System.Drawing.Size(35, 13);
            this.lblStartDate.TabIndex = 0;
            this.lblStartDate.Text = "label1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(3, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Start Date :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(3, 73);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "End Date :";
            // 
            // lblEndDate
            // 
            this.lblEndDate.AutoSize = true;
            this.lblEndDate.ForeColor = System.Drawing.Color.White;
            this.lblEndDate.Location = new System.Drawing.Point(70, 73);
            this.lblEndDate.Name = "lblEndDate";
            this.lblEndDate.Size = new System.Drawing.Size(35, 13);
            this.lblEndDate.TabIndex = 2;
            this.lblEndDate.Text = "label4";
            // 
            // lblIsClosed
            // 
            this.lblIsClosed.AutoSize = true;
            this.lblIsClosed.ForeColor = System.Drawing.Color.White;
            this.lblIsClosed.Location = new System.Drawing.Point(70, 105);
            this.lblIsClosed.Name = "lblIsClosed";
            this.lblIsClosed.Size = new System.Drawing.Size(35, 13);
            this.lblIsClosed.TabIndex = 5;
            this.lblIsClosed.Text = "label5";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(3, 105);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(56, 13);
            this.label6.TabIndex = 4;
            this.label6.Text = "Is Closed :";
            // 
            // llGeneralID
            // 
            this.llGeneralID.Dock = System.Windows.Forms.DockStyle.Top;
            this.llGeneralID.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.llGeneralID.LinkColor = System.Drawing.Color.Aqua;
            this.llGeneralID.Location = new System.Drawing.Point(0, 0);
            this.llGeneralID.Name = "llGeneralID";
            this.llGeneralID.Size = new System.Drawing.Size(218, 33);
            this.llGeneralID.TabIndex = 6;
            this.llGeneralID.TabStop = true;
            this.llGeneralID.Text = "ID";
            this.llGeneralID.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ctrlGeneralRevenueFundInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(42)))), ((int)(((byte)(57)))));
            this.Controls.Add(this.llGeneralID);
            this.Controls.Add(this.lblIsClosed);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblEndDate);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblStartDate);
            this.Name = "ctrlGeneralRevenueFundInfo";
            this.Size = new System.Drawing.Size(218, 131);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblStartDate;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblEndDate;
        private System.Windows.Forms.Label lblIsClosed;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.LinkLabel llGeneralID;
    }
}
