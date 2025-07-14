namespace CarRental
{
    partial class frmDashboard
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
            this.label2 = new System.Windows.Forms.Label();
            this.guna2TabControl2 = new Guna.UI2.WinForms.Guna2TabControl();
            this.tabMain = new System.Windows.Forms.TabPage();
            this.ctrlGeneralRevenueFundChart1 = new CarRental.General_Revenue_Fund.ctrlGeneralRevenueFundChart();
            this.label3 = new System.Windows.Forms.Label();
            this.ctrlGeneralRevenueFundCardWithIncomeDetails1 = new CarRental.General_Revenue_Fund.ctrlGeneralRevenueFundCardWithIncomeDetails();
            this.label1 = new System.Windows.Forms.Label();
            this.lblNumberOfBrances = new System.Windows.Forms.Label();
            this.ctrlStatistics1 = new CarRental.ctrlBranchStatistics();
            this.tabBranchesCards = new System.Windows.Forms.TabPage();
            this.flpListContrlols = new System.Windows.Forms.FlowLayoutPanel();
            this.tabBranchesChart = new System.Windows.Forms.TabPage();
            this.ctrlBranchesChart1 = new CarRental.ctrlBranchesChart();
            this.tabBranchesInChart = new System.Windows.Forms.TabPage();
            this.ctrlAllBranchesInAChart1 = new CarRental.ctrlAllBranchesInAChart();
            this.guna2TabControl2.SuspendLayout();
            this.tabMain.SuspendLayout();
            this.tabBranchesCards.SuspendLayout();
            this.tabBranchesChart.SuspendLayout();
            this.tabBranchesInChart.SuspendLayout();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.Dock = System.Windows.Forms.DockStyle.Top;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.Color.SlateBlue;
            this.label2.Location = new System.Drawing.Point(0, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(1710, 47);
            this.label2.TabIndex = 140;
            this.label2.Text = "Dashboard";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // guna2TabControl2
            // 
            this.guna2TabControl2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2TabControl2.Controls.Add(this.tabMain);
            this.guna2TabControl2.Controls.Add(this.tabBranchesCards);
            this.guna2TabControl2.Controls.Add(this.tabBranchesChart);
            this.guna2TabControl2.Controls.Add(this.tabBranchesInChart);
            this.guna2TabControl2.ItemSize = new System.Drawing.Size(100, 50);
            this.guna2TabControl2.Location = new System.Drawing.Point(-2, 50);
            this.guna2TabControl2.Name = "guna2TabControl2";
            this.guna2TabControl2.SelectedIndex = 0;
            this.guna2TabControl2.Size = new System.Drawing.Size(1712, 796);
            this.guna2TabControl2.TabButtonHoverState.BorderColor = System.Drawing.Color.Empty;
            this.guna2TabControl2.TabButtonHoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(52)))), ((int)(((byte)(70)))));
            this.guna2TabControl2.TabButtonHoverState.Font = new System.Drawing.Font("Segoe UI Semibold", 10F);
            this.guna2TabControl2.TabButtonHoverState.ForeColor = System.Drawing.Color.White;
            this.guna2TabControl2.TabButtonHoverState.InnerColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(52)))), ((int)(((byte)(70)))));
            this.guna2TabControl2.TabButtonIdleState.BorderColor = System.Drawing.Color.Empty;
            this.guna2TabControl2.TabButtonIdleState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(42)))), ((int)(((byte)(57)))));
            this.guna2TabControl2.TabButtonIdleState.Font = new System.Drawing.Font("Segoe UI Semibold", 10F);
            this.guna2TabControl2.TabButtonIdleState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(156)))), ((int)(((byte)(160)))), ((int)(((byte)(167)))));
            this.guna2TabControl2.TabButtonIdleState.InnerColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(42)))), ((int)(((byte)(57)))));
            this.guna2TabControl2.TabButtonSelectedState.BorderColor = System.Drawing.Color.Empty;
            this.guna2TabControl2.TabButtonSelectedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(37)))), ((int)(((byte)(49)))));
            this.guna2TabControl2.TabButtonSelectedState.Font = new System.Drawing.Font("Segoe UI Semibold", 10F);
            this.guna2TabControl2.TabButtonSelectedState.ForeColor = System.Drawing.Color.White;
            this.guna2TabControl2.TabButtonSelectedState.InnerColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(132)))), ((int)(((byte)(255)))));
            this.guna2TabControl2.TabButtonSize = new System.Drawing.Size(100, 50);
            this.guna2TabControl2.TabIndex = 141;
            this.guna2TabControl2.TabMenuBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(42)))), ((int)(((byte)(57)))));
            this.guna2TabControl2.TabMenuOrientation = Guna.UI2.WinForms.TabMenuOrientation.HorizontalTop;
            // 
            // tabMain
            // 
            this.tabMain.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tabMain.Controls.Add(this.ctrlGeneralRevenueFundChart1);
            this.tabMain.Controls.Add(this.label3);
            this.tabMain.Controls.Add(this.ctrlGeneralRevenueFundCardWithIncomeDetails1);
            this.tabMain.Controls.Add(this.label1);
            this.tabMain.Controls.Add(this.lblNumberOfBrances);
            this.tabMain.Controls.Add(this.ctrlStatistics1);
            this.tabMain.Location = new System.Drawing.Point(4, 54);
            this.tabMain.Name = "tabMain";
            this.tabMain.Padding = new System.Windows.Forms.Padding(3);
            this.tabMain.Size = new System.Drawing.Size(1704, 738);
            this.tabMain.TabIndex = 3;
            this.tabMain.Text = "Main";
            this.tabMain.UseVisualStyleBackColor = true;
            this.tabMain.Click += new System.EventHandler(this.tabMain_Click);
            // 
            // ctrlGeneralRevenueFundChart1
            // 
            this.ctrlGeneralRevenueFundChart1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ctrlGeneralRevenueFundChart1.AutoSize = true;
            this.ctrlGeneralRevenueFundChart1.BackColor = System.Drawing.Color.White;
            this.ctrlGeneralRevenueFundChart1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ctrlGeneralRevenueFundChart1.Location = new System.Drawing.Point(28, 401);
            this.ctrlGeneralRevenueFundChart1.Name = "ctrlGeneralRevenueFundChart1";
            this.ctrlGeneralRevenueFundChart1.Size = new System.Drawing.Size(776, 328);
            this.ctrlGeneralRevenueFundChart1.TabIndex = 150;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.ForeColor = System.Drawing.Color.SlateBlue;
            this.label3.Location = new System.Drawing.Point(22, 358);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(208, 31);
            this.label3.TabIndex = 149;
            this.label3.Text = "General Fund :";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ctrlGeneralRevenueFundCardWithIncomeDetails1
            // 
            this.ctrlGeneralRevenueFundCardWithIncomeDetails1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ctrlGeneralRevenueFundCardWithIncomeDetails1.AutoSize = true;
            this.ctrlGeneralRevenueFundCardWithIncomeDetails1.BackColor = System.Drawing.Color.White;
            this.ctrlGeneralRevenueFundCardWithIncomeDetails1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ctrlGeneralRevenueFundCardWithIncomeDetails1.Location = new System.Drawing.Point(810, 401);
            this.ctrlGeneralRevenueFundCardWithIncomeDetails1.Name = "ctrlGeneralRevenueFundCardWithIncomeDetails1";
            this.ctrlGeneralRevenueFundCardWithIncomeDetails1.Size = new System.Drawing.Size(743, 133);
            this.ctrlGeneralRevenueFundCardWithIncomeDetails1.TabIndex = 143;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.SlateBlue;
            this.label1.Location = new System.Drawing.Point(22, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(303, 31);
            this.label1.TabIndex = 142;
            this.label1.Text = "Number Of Branches :";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblNumberOfBrances
            // 
            this.lblNumberOfBrances.AutoSize = true;
            this.lblNumberOfBrances.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblNumberOfBrances.ForeColor = System.Drawing.Color.SlateBlue;
            this.lblNumberOfBrances.Location = new System.Drawing.Point(331, 62);
            this.lblNumberOfBrances.Name = "lblNumberOfBrances";
            this.lblNumberOfBrances.Size = new System.Drawing.Size(64, 25);
            this.lblNumberOfBrances.TabIndex = 141;
            this.lblNumberOfBrances.Text = "????";
            this.lblNumberOfBrances.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ctrlStatistics1
            // 
            this.ctrlStatistics1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ctrlStatistics1.AutoSize = true;
            this.ctrlStatistics1.BackColor = System.Drawing.Color.White;
            this.ctrlStatistics1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ctrlStatistics1.Location = new System.Drawing.Point(28, 99);
            this.ctrlStatistics1.Name = "ctrlStatistics1";
            this.ctrlStatistics1.Size = new System.Drawing.Size(989, 197);
            this.ctrlStatistics1.TabIndex = 140;
            // 
            // tabBranchesCards
            // 
            this.tabBranchesCards.AutoScroll = true;
            this.tabBranchesCards.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tabBranchesCards.Controls.Add(this.flpListContrlols);
            this.tabBranchesCards.Location = new System.Drawing.Point(4, 54);
            this.tabBranchesCards.Name = "tabBranchesCards";
            this.tabBranchesCards.Padding = new System.Windows.Forms.Padding(3);
            this.tabBranchesCards.Size = new System.Drawing.Size(1704, 738);
            this.tabBranchesCards.TabIndex = 0;
            this.tabBranchesCards.Text = "BranchesCards";
            this.tabBranchesCards.UseVisualStyleBackColor = true;
            // 
            // flpListContrlols
            // 
            this.flpListContrlols.AutoScroll = true;
            this.flpListContrlols.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flpListContrlols.Location = new System.Drawing.Point(3, 3);
            this.flpListContrlols.Name = "flpListContrlols";
            this.flpListContrlols.Size = new System.Drawing.Size(1696, 730);
            this.flpListContrlols.TabIndex = 0;
            // 
            // tabBranchesChart
            // 
            this.tabBranchesChart.Controls.Add(this.ctrlBranchesChart1);
            this.tabBranchesChart.Location = new System.Drawing.Point(4, 54);
            this.tabBranchesChart.Name = "tabBranchesChart";
            this.tabBranchesChart.Padding = new System.Windows.Forms.Padding(3);
            this.tabBranchesChart.Size = new System.Drawing.Size(1704, 738);
            this.tabBranchesChart.TabIndex = 1;
            this.tabBranchesChart.Text = "Branches Chart";
            this.tabBranchesChart.UseVisualStyleBackColor = true;
            // 
            // ctrlBranchesChart1
            // 
            this.ctrlBranchesChart1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ctrlBranchesChart1.BackColor = System.Drawing.Color.White;
            this.ctrlBranchesChart1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ctrlBranchesChart1.Location = new System.Drawing.Point(10, 3);
            this.ctrlBranchesChart1.Name = "ctrlBranchesChart1";
            this.ctrlBranchesChart1.Size = new System.Drawing.Size(1686, 567);
            this.ctrlBranchesChart1.TabIndex = 0;
            // 
            // tabBranchesInChart
            // 
            this.tabBranchesInChart.Controls.Add(this.ctrlAllBranchesInAChart1);
            this.tabBranchesInChart.Location = new System.Drawing.Point(4, 54);
            this.tabBranchesInChart.Name = "tabBranchesInChart";
            this.tabBranchesInChart.Size = new System.Drawing.Size(1704, 738);
            this.tabBranchesInChart.TabIndex = 2;
            this.tabBranchesInChart.Text = "All Branches In Chart";
            this.tabBranchesInChart.UseVisualStyleBackColor = true;
            // 
            // ctrlAllBranchesInAChart1
            // 
            this.ctrlAllBranchesInAChart1.BackColor = System.Drawing.Color.White;
            this.ctrlAllBranchesInAChart1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ctrlAllBranchesInAChart1.Location = new System.Drawing.Point(0, 0);
            this.ctrlAllBranchesInAChart1.Name = "ctrlAllBranchesInAChart1";
            this.ctrlAllBranchesInAChart1.Size = new System.Drawing.Size(1704, 738);
            this.ctrlAllBranchesInAChart1.TabIndex = 1;
            // 
            // frmDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1710, 846);
            this.Controls.Add(this.guna2TabControl2);
            this.Controls.Add(this.label2);
            this.Name = "frmDashboard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dashboard";
            this.Load += new System.EventHandler(this.frmDashboard_Load);
            this.guna2TabControl2.ResumeLayout(false);
            this.tabMain.ResumeLayout(false);
            this.tabMain.PerformLayout();
            this.tabBranchesCards.ResumeLayout(false);
            this.tabBranchesChart.ResumeLayout(false);
            this.tabBranchesInChart.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private Guna.UI2.WinForms.Guna2TabControl guna2TabControl2;
        private System.Windows.Forms.TabPage tabMain;
        private System.Windows.Forms.Label label3;
        private General_Revenue_Fund.ctrlGeneralRevenueFundCardWithIncomeDetails ctrlGeneralRevenueFundCardWithIncomeDetails1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblNumberOfBrances;
        private ctrlBranchStatistics ctrlStatistics1;
        private System.Windows.Forms.TabPage tabBranchesCards;
        private System.Windows.Forms.FlowLayoutPanel flpListContrlols;
        private System.Windows.Forms.TabPage tabBranchesChart;
        private ctrlBranchesChart ctrlBranchesChart1;
        private System.Windows.Forms.TabPage tabBranchesInChart;
        private ctrlAllBranchesInAChart ctrlAllBranchesInAChart1;
        private General_Revenue_Fund.ctrlGeneralRevenueFundChart ctrlGeneralRevenueFundChart1;
    }
}