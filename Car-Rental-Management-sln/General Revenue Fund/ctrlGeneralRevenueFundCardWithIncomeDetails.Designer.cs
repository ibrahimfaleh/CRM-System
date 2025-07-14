namespace CarRental.General_Revenue_Fund
{
    partial class ctrlGeneralRevenueFundCardWithIncomeDetails
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
            this.ctrlGeneralRevenueFundCard1 = new CarRental.General_Revenue_Fund.ctrlGeneralRevenueFundCard();
            this.ctrlGeneralRevenueFundIncomeDetails1 = new CarRental.Rental_Fund.General_Revenue_Fund.ctrlGeneralRevenueFundIncomeDetails();
            this.SuspendLayout();
            // 
            // ctrlGeneralRevenueFundCard1
            // 
            this.ctrlGeneralRevenueFundCard1.AutoSize = true;
            this.ctrlGeneralRevenueFundCard1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(42)))), ((int)(((byte)(57)))));
            this.ctrlGeneralRevenueFundCard1.Location = new System.Drawing.Point(3, 2);
            this.ctrlGeneralRevenueFundCard1.Name = "ctrlGeneralRevenueFundCard1";
            this.ctrlGeneralRevenueFundCard1.Size = new System.Drawing.Size(166, 126);
            this.ctrlGeneralRevenueFundCard1.TabIndex = 0;
            // 
            // ctrlGeneralRevenueFundIncomeDetails1
            // 
            this.ctrlGeneralRevenueFundIncomeDetails1.AutoSize = true;
            this.ctrlGeneralRevenueFundIncomeDetails1.BackColor = System.Drawing.Color.White;
            this.ctrlGeneralRevenueFundIncomeDetails1.Location = new System.Drawing.Point(174, 2);
            this.ctrlGeneralRevenueFundIncomeDetails1.Margin = new System.Windows.Forms.Padding(2);
            this.ctrlGeneralRevenueFundIncomeDetails1.Name = "ctrlGeneralRevenueFundIncomeDetails1";
            this.ctrlGeneralRevenueFundIncomeDetails1.Size = new System.Drawing.Size(412, 126);
            this.ctrlGeneralRevenueFundIncomeDetails1.TabIndex = 1;
            // 
            // ctrlGeneralRevenueFundCardWithIncomeDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.ctrlGeneralRevenueFundIncomeDetails1);
            this.Controls.Add(this.ctrlGeneralRevenueFundCard1);
            this.Name = "ctrlGeneralRevenueFundCardWithIncomeDetails";
            this.Size = new System.Drawing.Size(588, 131);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ctrlGeneralRevenueFundCard ctrlGeneralRevenueFundCard1;
        private Rental_Fund.General_Revenue_Fund.ctrlGeneralRevenueFundIncomeDetails ctrlGeneralRevenueFundIncomeDetails1;
    }
}
