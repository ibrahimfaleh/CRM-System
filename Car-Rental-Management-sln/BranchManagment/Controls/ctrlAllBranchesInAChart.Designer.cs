namespace CarRental
{
    partial class ctrlAllBranchesInAChart
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.guna2NumericUpDown1 = new Guna.UI2.WinForms.Guna2NumericUpDown();
            this.rbEarnings = new System.Windows.Forms.RadioButton();
            this.rbBranchChartForNumOfRental = new System.Windows.Forms.RadioButton();
            this.rbSalaryPayments = new System.Windows.Forms.RadioButton();
            this.dgv = new Guna.UI2.WinForms.Guna2DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.rbTotalIncomeChart = new System.Windows.Forms.RadioButton();
            this.rbExpectedNewProfitsChart = new System.Windows.Forms.RadioButton();
            this.rbTotalContractAmounts = new System.Windows.Forms.RadioButton();
            this.rbTotalBillPaidAmounts = new System.Windows.Forms.RadioButton();
            this.ctrlBranchChart2 = new CarRental.ctrlBranchChart();
            ((System.ComponentModel.ISupportInitialize)(this.guna2NumericUpDown1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).BeginInit();
            this.SuspendLayout();
            // 
            // guna2NumericUpDown1
            // 
            this.guna2NumericUpDown1.BackColor = System.Drawing.Color.Transparent;
            this.guna2NumericUpDown1.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.guna2NumericUpDown1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2NumericUpDown1.Location = new System.Drawing.Point(971, 8);
            this.guna2NumericUpDown1.Maximum = new decimal(new int[] {
            2040,
            0,
            0,
            0});
            this.guna2NumericUpDown1.Minimum = new decimal(new int[] {
            2015,
            0,
            0,
            0});
            this.guna2NumericUpDown1.Name = "guna2NumericUpDown1";
            this.guna2NumericUpDown1.Size = new System.Drawing.Size(105, 24);
            this.guna2NumericUpDown1.TabIndex = 10;
            this.guna2NumericUpDown1.Value = new decimal(new int[] {
            2015,
            0,
            0,
            0});
            this.guna2NumericUpDown1.ValueChanged += new System.EventHandler(this.guna2NumericUpDown1_ValueChanged);
            // 
            // rbEarnings
            // 
            this.rbEarnings.AutoSize = true;
            this.rbEarnings.Location = new System.Drawing.Point(266, 13);
            this.rbEarnings.Name = "rbEarnings";
            this.rbEarnings.Size = new System.Drawing.Size(66, 17);
            this.rbEarnings.TabIndex = 9;
            this.rbEarnings.Text = "Earnings";
            this.rbEarnings.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.rbEarnings.UseVisualStyleBackColor = true;
            this.rbEarnings.CheckedChanged += new System.EventHandler(this.rbEarnings_CheckedChanged);
            // 
            // rbBranchChartForNumOfRental
            // 
            this.rbBranchChartForNumOfRental.AutoSize = true;
            this.rbBranchChartForNumOfRental.Location = new System.Drawing.Point(142, 13);
            this.rbBranchChartForNumOfRental.Name = "rbBranchChartForNumOfRental";
            this.rbBranchChartForNumOfRental.Size = new System.Drawing.Size(110, 17);
            this.rbBranchChartForNumOfRental.TabIndex = 8;
            this.rbBranchChartForNumOfRental.Text = "Number Of Rental";
            this.rbBranchChartForNumOfRental.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.rbBranchChartForNumOfRental.UseVisualStyleBackColor = true;
            this.rbBranchChartForNumOfRental.CheckedChanged += new System.EventHandler(this.rbBranchChartForNumOfRental_CheckedChanged);
            // 
            // rbSalaryPayments
            // 
            this.rbSalaryPayments.AutoSize = true;
            this.rbSalaryPayments.Checked = true;
            this.rbSalaryPayments.Location = new System.Drawing.Point(25, 12);
            this.rbSalaryPayments.Name = "rbSalaryPayments";
            this.rbSalaryPayments.Size = new System.Drawing.Size(103, 17);
            this.rbSalaryPayments.TabIndex = 6;
            this.rbSalaryPayments.TabStop = true;
            this.rbSalaryPayments.Text = "Salary Payments";
            this.rbSalaryPayments.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.rbSalaryPayments.UseVisualStyleBackColor = true;
            this.rbSalaryPayments.CheckedChanged += new System.EventHandler(this.rbSalaryPayments_CheckedChanged);
            // 
            // dgv
            // 
            this.dgv.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dgv.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgv.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgv.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgv.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgv.Location = new System.Drawing.Point(3, 414);
            this.dgv.Name = "dgv";
            this.dgv.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgv.RowHeadersVisible = false;
            this.dgv.RowTemplate.Height = 19;
            this.dgv.Size = new System.Drawing.Size(1072, 187);
            this.dgv.TabIndex = 13;
            this.dgv.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dgv.ThemeStyle.AlternatingRowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dgv.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.SystemColors.ControlText;
            this.dgv.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgv.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dgv.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.dgv.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgv.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.dgv.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgv.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dgv.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dgv.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dgv.ThemeStyle.HeaderStyle.Height = 23;
            this.dgv.ThemeStyle.ReadOnly = false;
            this.dgv.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dgv.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgv.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dgv.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dgv.ThemeStyle.RowsStyle.Height = 19;
            this.dgv.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgv.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(933, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 13);
            this.label1.TabIndex = 14;
            this.label1.Text = "Year ";
            // 
            // rbTotalIncomeChart
            // 
            this.rbTotalIncomeChart.AutoSize = true;
            this.rbTotalIncomeChart.Location = new System.Drawing.Point(346, 12);
            this.rbTotalIncomeChart.Name = "rbTotalIncomeChart";
            this.rbTotalIncomeChart.Size = new System.Drawing.Size(87, 17);
            this.rbTotalIncomeChart.TabIndex = 15;
            this.rbTotalIncomeChart.Text = "Total Income";
            this.rbTotalIncomeChart.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.rbTotalIncomeChart.UseVisualStyleBackColor = true;
            this.rbTotalIncomeChart.CheckedChanged += new System.EventHandler(this.rbTotalIncomeChart_CheckedChanged);
            // 
            // rbExpectedNewProfitsChart
            // 
            this.rbExpectedNewProfitsChart.AutoSize = true;
            this.rbExpectedNewProfitsChart.Location = new System.Drawing.Point(447, 12);
            this.rbExpectedNewProfitsChart.Name = "rbExpectedNewProfitsChart";
            this.rbExpectedNewProfitsChart.Size = new System.Drawing.Size(127, 17);
            this.rbExpectedNewProfitsChart.TabIndex = 16;
            this.rbExpectedNewProfitsChart.Text = "Expected New Profits";
            this.rbExpectedNewProfitsChart.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.rbExpectedNewProfitsChart.UseVisualStyleBackColor = true;
            this.rbExpectedNewProfitsChart.CheckedChanged += new System.EventHandler(this.rbExpectedNewProfits_CheckedChanged);
            // 
            // rbTotalContractAmounts
            // 
            this.rbTotalContractAmounts.AutoSize = true;
            this.rbTotalContractAmounts.Location = new System.Drawing.Point(588, 13);
            this.rbTotalContractAmounts.Name = "rbTotalContractAmounts";
            this.rbTotalContractAmounts.Size = new System.Drawing.Size(139, 17);
            this.rbTotalContractAmounts.TabIndex = 17;
            this.rbTotalContractAmounts.Text = "Total  Contract Amounts";
            this.rbTotalContractAmounts.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.rbTotalContractAmounts.UseVisualStyleBackColor = true;
            this.rbTotalContractAmounts.CheckedChanged += new System.EventHandler(this.rbTotalContractAmounts_CheckedChanged);
            // 
            // rbTotalBillPaidAmounts
            // 
            this.rbTotalBillPaidAmounts.AutoSize = true;
            this.rbTotalBillPaidAmounts.Location = new System.Drawing.Point(741, 13);
            this.rbTotalBillPaidAmounts.Name = "rbTotalBillPaidAmounts";
            this.rbTotalBillPaidAmounts.Size = new System.Drawing.Size(133, 17);
            this.rbTotalBillPaidAmounts.TabIndex = 18;
            this.rbTotalBillPaidAmounts.Text = "Total Bill Paid Amounts";
            this.rbTotalBillPaidAmounts.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.rbTotalBillPaidAmounts.UseVisualStyleBackColor = true;
            this.rbTotalBillPaidAmounts.CheckedChanged += new System.EventHandler(this.rbTotalBillPaidAmounts_CheckedChanged);
            // 
            // ctrlBranchChart2
            // 
            this.ctrlBranchChart2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ctrlBranchChart2.AutoScroll = true;
            this.ctrlBranchChart2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ctrlBranchChart2.Location = new System.Drawing.Point(0, 38);
            this.ctrlBranchChart2.Name = "ctrlBranchChart2";
            this.ctrlBranchChart2.Size = new System.Drawing.Size(1075, 370);
            this.ctrlBranchChart2.TabIndex = 12;
            // 
            // ctrlAllBranchesInAChart
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.rbTotalBillPaidAmounts);
            this.Controls.Add(this.rbTotalContractAmounts);
            this.Controls.Add(this.rbExpectedNewProfitsChart);
            this.Controls.Add(this.rbTotalIncomeChart);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgv);
            this.Controls.Add(this.ctrlBranchChart2);
            this.Controls.Add(this.guna2NumericUpDown1);
            this.Controls.Add(this.rbEarnings);
            this.Controls.Add(this.rbBranchChartForNumOfRental);
            this.Controls.Add(this.rbSalaryPayments);
            this.Name = "ctrlAllBranchesInAChart";
            this.Size = new System.Drawing.Size(1085, 609);
            ((System.ComponentModel.ISupportInitialize)(this.guna2NumericUpDown1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2NumericUpDown guna2NumericUpDown1;
        private System.Windows.Forms.RadioButton rbEarnings;
        private System.Windows.Forms.RadioButton rbBranchChartForNumOfRental;
        private System.Windows.Forms.RadioButton rbSalaryPayments;
        private ctrlBranchChart ctrlBranchChart2;
        private Guna.UI2.WinForms.Guna2DataGridView dgv;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton rbTotalIncomeChart;
        private System.Windows.Forms.RadioButton rbExpectedNewProfitsChart;
        private System.Windows.Forms.RadioButton rbTotalContractAmounts;
        private System.Windows.Forms.RadioButton rbTotalBillPaidAmounts;
    }
}
