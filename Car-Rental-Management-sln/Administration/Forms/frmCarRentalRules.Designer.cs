namespace CarRental.Administration.Forms
{
    partial class frmCarRentalRules
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.nudDailyRent = new System.Windows.Forms.NumericUpDown();
            this.nudMonthlyRent = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.nudAnnualRent = new System.Windows.Forms.NumericUpDown();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.txtRentalRules = new Guna.UI2.WinForms.Guna2TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.btnClose = new Guna.UI2.WinForms.Guna2Button();
            this.btnSave = new Guna.UI2.WinForms.Guna2Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.tsTypeOfMonth = new Guna.UI2.WinForms.Guna2ToggleSwitch();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.lblTitleNumberOfDaysMonth = new System.Windows.Forms.Label();
            this.txtNumberOfDaysMonth = new Guna.UI2.WinForms.Guna2TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.nudDailyRent)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudMonthlyRent)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudAnnualRent)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(1183, 75);
            this.label1.TabIndex = 0;
            this.label1.Text = "Car Rental Rules";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(90, 94);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 18);
            this.label2.TabIndex = 1;
            this.label2.Text = "Daily Rent :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(68, 186);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(117, 18);
            this.label3.TabIndex = 2;
            this.label3.Text = "Monthly Rent :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(123, 220);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(326, 18);
            this.label4.TabIndex = 4;
            this.label4.Text = "Down payment percentage of total Monthly rent :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(123, 131);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(303, 18);
            this.label5.TabIndex = 3;
            this.label5.Text = "Down payment percentage of total daily rent :";
            // 
            // nudDailyRent
            // 
            this.nudDailyRent.Location = new System.Drawing.Point(432, 130);
            this.nudDailyRent.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudDailyRent.Name = "nudDailyRent";
            this.nudDailyRent.Size = new System.Drawing.Size(43, 20);
            this.nudDailyRent.TabIndex = 5;
            this.nudDailyRent.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // nudMonthlyRent
            // 
            this.nudMonthlyRent.Location = new System.Drawing.Point(457, 220);
            this.nudMonthlyRent.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudMonthlyRent.Name = "nudMonthlyRent";
            this.nudMonthlyRent.Size = new System.Drawing.Size(43, 20);
            this.nudMonthlyRent.TabIndex = 6;
            this.nudMonthlyRent.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(506, 220);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(21, 18);
            this.label6.TabIndex = 7;
            this.label6.Text = "%";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.Location = new System.Drawing.Point(481, 130);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(21, 18);
            this.label7.TabIndex = 8;
            this.label7.Text = "%";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label8.Location = new System.Drawing.Point(495, 302);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(21, 18);
            this.label8.TabIndex = 12;
            this.label8.Text = "%";
            // 
            // nudAnnualRent
            // 
            this.nudAnnualRent.Location = new System.Drawing.Point(446, 302);
            this.nudAnnualRent.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudAnnualRent.Name = "nudAnnualRent";
            this.nudAnnualRent.Size = new System.Drawing.Size(43, 20);
            this.nudAnnualRent.TabIndex = 11;
            this.nudAnnualRent.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label9.Location = new System.Drawing.Point(123, 302);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(317, 18);
            this.label9.TabIndex = 10;
            this.label9.Text = "Down payment percentage of total annual rent :";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label10.Location = new System.Drawing.Point(68, 268);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(108, 18);
            this.label10.TabIndex = 9;
            this.label10.Text = "Annual Rent :";
            // 
            // txtRentalRules
            // 
            this.txtRentalRules.BorderColor = System.Drawing.Color.Black;
            this.txtRentalRules.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtRentalRules.DefaultText = "";
            this.txtRentalRules.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtRentalRules.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtRentalRules.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtRentalRules.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtRentalRules.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.txtRentalRules.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtRentalRules.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold);
            this.txtRentalRules.ForeColor = System.Drawing.Color.Black;
            this.txtRentalRules.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtRentalRules.Location = new System.Drawing.Point(0, 383);
            this.txtRentalRules.Margin = new System.Windows.Forms.Padding(4);
            this.txtRentalRules.Multiline = true;
            this.txtRentalRules.Name = "txtRentalRules";
            this.txtRentalRules.PasswordChar = '\0';
            this.txtRentalRules.PlaceholderText = "";
            this.txtRentalRules.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtRentalRules.SelectedText = "";
            this.txtRentalRules.Size = new System.Drawing.Size(1183, 237);
            this.txtRentalRules.TabIndex = 13;
            this.txtRentalRules.Validating += new System.ComponentModel.CancelEventHandler(this.txtRentalRules_Validating);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label11.Location = new System.Drawing.Point(68, 343);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(114, 18);
            this.label11.TabIndex = 14;
            this.label11.Text = "Rental Rules :";
            // 
            // btnClose
            // 
            this.btnClose.AutoRoundedCorners = true;
            this.btnClose.BorderRadius = 15;
            this.btnClose.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnClose.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnClose.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnClose.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnClose.FillColor = System.Drawing.Color.Black;
            this.btnClose.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnClose.ForeColor = System.Drawing.Color.White;
            this.btnClose.Location = new System.Drawing.Point(1038, 343);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(133, 33);
            this.btnClose.TabIndex = 119;
            this.btnClose.Text = "Close";
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnSave
            // 
            this.btnSave.AutoRoundedCorners = true;
            this.btnSave.BorderRadius = 15;
            this.btnSave.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnSave.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnSave.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnSave.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnSave.FillColor = System.Drawing.Color.Black;
            this.btnSave.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnSave.ForeColor = System.Drawing.Color.White;
            this.btnSave.Location = new System.Drawing.Point(899, 343);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(133, 33);
            this.btnSave.TabIndex = 118;
            this.btnSave.Text = "Save";
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // tsTypeOfMonth
            // 
            this.tsTypeOfMonth.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tsTypeOfMonth.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tsTypeOfMonth.CheckedState.InnerBorderColor = System.Drawing.Color.White;
            this.tsTypeOfMonth.CheckedState.InnerColor = System.Drawing.Color.White;
            this.tsTypeOfMonth.Location = new System.Drawing.Point(916, 181);
            this.tsTypeOfMonth.Name = "tsTypeOfMonth";
            this.tsTypeOfMonth.Size = new System.Drawing.Size(79, 20);
            this.tsTypeOfMonth.TabIndex = 164;
            this.tsTypeOfMonth.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.tsTypeOfMonth.UncheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.tsTypeOfMonth.UncheckedState.InnerBorderColor = System.Drawing.Color.White;
            this.tsTypeOfMonth.UncheckedState.InnerColor = System.Drawing.Color.White;
            this.tsTypeOfMonth.CheckedChanged += new System.EventHandler(this.tsTypeOfMonth_CheckedChanged);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label12.Location = new System.Drawing.Point(1000, 181);
            this.label12.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(91, 17);
            this.label12.TabIndex = 163;
            this.label12.Text = "Solar Months";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label13.Location = new System.Drawing.Point(856, 181);
            this.label13.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(55, 17);
            this.label13.TabIndex = 162;
            this.label13.Text = "Custom";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Bold);
            this.label14.ForeColor = System.Drawing.Color.Black;
            this.label14.Location = new System.Drawing.Point(750, 131);
            this.label14.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(239, 21);
            this.label14.TabIndex = 161;
            this.label14.Text = "Type of months for car rental :";
            // 
            // lblTitleNumberOfDaysMonth
            // 
            this.lblTitleNumberOfDaysMonth.AutoSize = true;
            this.lblTitleNumberOfDaysMonth.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblTitleNumberOfDaysMonth.Location = new System.Drawing.Point(691, 226);
            this.lblTitleNumberOfDaysMonth.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTitleNumberOfDaysMonth.Name = "lblTitleNumberOfDaysMonth";
            this.lblTitleNumberOfDaysMonth.Size = new System.Drawing.Size(215, 17);
            this.lblTitleNumberOfDaysMonth.TabIndex = 166;
            this.lblTitleNumberOfDaysMonth.Text = "Number of Days in a Month :";
            // 
            // txtNumberOfDaysMonth
            // 
            this.txtNumberOfDaysMonth.BorderColor = System.Drawing.Color.SlateBlue;
            this.txtNumberOfDaysMonth.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtNumberOfDaysMonth.DefaultText = "";
            this.txtNumberOfDaysMonth.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtNumberOfDaysMonth.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtNumberOfDaysMonth.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtNumberOfDaysMonth.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtNumberOfDaysMonth.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtNumberOfDaysMonth.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtNumberOfDaysMonth.ForeColor = System.Drawing.Color.Black;
            this.txtNumberOfDaysMonth.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtNumberOfDaysMonth.Location = new System.Drawing.Point(916, 222);
            this.txtNumberOfDaysMonth.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.txtNumberOfDaysMonth.Name = "txtNumberOfDaysMonth";
            this.txtNumberOfDaysMonth.PasswordChar = '\0';
            this.txtNumberOfDaysMonth.PlaceholderText = "";
            this.txtNumberOfDaysMonth.SelectedText = "";
            this.txtNumberOfDaysMonth.Size = new System.Drawing.Size(172, 27);
            this.txtNumberOfDaysMonth.TabIndex = 165;
            // 
            // frmCarRentalRules
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange;
            this.ClientSize = new System.Drawing.Size(1183, 620);
            this.Controls.Add(this.lblTitleNumberOfDaysMonth);
            this.Controls.Add(this.txtNumberOfDaysMonth);
            this.Controls.Add(this.tsTypeOfMonth);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.txtRentalRules);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.nudAnnualRent);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.nudMonthlyRent);
            this.Controls.Add(this.nudDailyRent);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frmCarRentalRules";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Car Rental Rules";
            this.Load += new System.EventHandler(this.frmCarRentalRules_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nudDailyRent)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudMonthlyRent)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudAnnualRent)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown nudDailyRent;
        private System.Windows.Forms.NumericUpDown nudMonthlyRent;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.NumericUpDown nudAnnualRent;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private Guna.UI2.WinForms.Guna2TextBox txtRentalRules;
        private System.Windows.Forms.Label label11;
        private Guna.UI2.WinForms.Guna2Button btnClose;
        private Guna.UI2.WinForms.Guna2Button btnSave;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private Guna.UI2.WinForms.Guna2ToggleSwitch tsTypeOfMonth;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label lblTitleNumberOfDaysMonth;
        private Guna.UI2.WinForms.Guna2TextBox txtNumberOfDaysMonth;
    }
}