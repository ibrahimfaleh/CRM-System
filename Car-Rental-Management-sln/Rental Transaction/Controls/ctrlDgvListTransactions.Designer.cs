namespace CarRental.Rental_Transaction
{
    partial class ctrlDgvListTransactions
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPrice = new System.Windows.Forms.TabPage();
            this.label11 = new System.Windows.Forms.Label();
            this.cmbRentalPrice = new Guna.UI2.WinForms.Guna2ComboBox();
            this.txtToRentalPrice = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cbRentalPrice = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtFromRentalPrice = new System.Windows.Forms.TextBox();
            this.tabNumberOfDaysMonths = new System.Windows.Forms.TabPage();
            this.cmbNumberOfRentedDaysMonths = new Guna.UI2.WinForms.Guna2ComboBox();
            this.cbNumberOfRentedDaysMonths = new System.Windows.Forms.CheckBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.nudToNumberOfRentedDaysMonths = new Guna.UI2.WinForms.Guna2NumericUpDown();
            this.nudFromNumberOfRentedDaysMonths = new Guna.UI2.WinForms.Guna2NumericUpDown();
            this.tabTotalRentalIncome = new System.Windows.Forms.TabPage();
            this.label5 = new System.Windows.Forms.Label();
            this.cmbRentalAmounts = new Guna.UI2.WinForms.Guna2ComboBox();
            this.cbRentalAmounts = new System.Windows.Forms.CheckBox();
            this.txtToTotalRentalIncome = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.txtFromTotalRentalincome = new System.Windows.Forms.TextBox();
            this.tabStatus = new System.Windows.Forms.TabPage();
            this.cbRentalStatus = new System.Windows.Forms.CheckBox();
            this.lblTitleAvailable = new System.Windows.Forms.Label();
            this.cmbRentalStatus = new Guna.UI2.WinForms.Guna2ComboBox();
            this.tabBranches = new System.Windows.Forms.TabPage();
            this.label7 = new System.Windows.Forms.Label();
            this.cmbCityName = new Guna.UI2.WinForms.Guna2ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.cmbBranches = new Guna.UI2.WinForms.Guna2ComboBox();
            this.cbFilterBy = new Guna.UI2.WinForms.Guna2ComboBox();
            this.txtFilterValue = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dgv = new Guna.UI2.WinForms.Guna2DataGridView();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.showTransactionDetailsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.showCreatedByUserIDToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.showUpdatedByUserIDToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.showCustomerDetaiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.vehiclleReturnToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label4 = new System.Windows.Forms.Label();
            this.lblRecordsCount = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabPrice.SuspendLayout();
            this.tabNumberOfDaysMonths.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudToNumberOfRentedDaysMonths)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudFromNumberOfRentedDaysMonths)).BeginInit();
            this.tabTotalRentalIncome.SuspendLayout();
            this.tabStatus.SuspendLayout();
            this.tabBranches.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPrice);
            this.tabControl1.Controls.Add(this.tabNumberOfDaysMonths);
            this.tabControl1.Controls.Add(this.tabTotalRentalIncome);
            this.tabControl1.Controls.Add(this.tabStatus);
            this.tabControl1.Controls.Add(this.tabBranches);
            this.tabControl1.Location = new System.Drawing.Point(709, 3);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(681, 72);
            this.tabControl1.TabIndex = 256;
            // 
            // tabPrice
            // 
            this.tabPrice.Controls.Add(this.label11);
            this.tabPrice.Controls.Add(this.cmbRentalPrice);
            this.tabPrice.Controls.Add(this.txtToRentalPrice);
            this.tabPrice.Controls.Add(this.label3);
            this.tabPrice.Controls.Add(this.cbRentalPrice);
            this.tabPrice.Controls.Add(this.label2);
            this.tabPrice.Controls.Add(this.txtFromRentalPrice);
            this.tabPrice.Location = new System.Drawing.Point(4, 22);
            this.tabPrice.Name = "tabPrice";
            this.tabPrice.Padding = new System.Windows.Forms.Padding(3);
            this.tabPrice.Size = new System.Drawing.Size(673, 46);
            this.tabPrice.TabIndex = 1;
            this.tabPrice.Text = "Price";
            this.tabPrice.UseVisualStyleBackColor = true;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label11.ForeColor = System.Drawing.Color.Black;
            this.label11.Location = new System.Drawing.Point(398, 11);
            this.label11.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(66, 17);
            this.label11.TabIndex = 254;
            this.label11.Text = "Pric Per :";
            // 
            // cmbRentalPrice
            // 
            this.cmbRentalPrice.BackColor = System.Drawing.Color.Transparent;
            this.cmbRentalPrice.BorderColor = System.Drawing.Color.Black;
            this.cmbRentalPrice.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbRentalPrice.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbRentalPrice.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cmbRentalPrice.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cmbRentalPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F);
            this.cmbRentalPrice.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cmbRentalPrice.ItemHeight = 30;
            this.cmbRentalPrice.Items.AddRange(new object[] {
            "Day",
            "Month"});
            this.cmbRentalPrice.Location = new System.Drawing.Point(487, 4);
            this.cmbRentalPrice.Margin = new System.Windows.Forms.Padding(2);
            this.cmbRentalPrice.Name = "cmbRentalPrice";
            this.cmbRentalPrice.Size = new System.Drawing.Size(117, 36);
            this.cmbRentalPrice.TabIndex = 253;
            this.cmbRentalPrice.TextChanged += new System.EventHandler(this.cbFilterBy_SelectedIndexChanged);
            // 
            // txtToRentalPrice
            // 
            this.txtToRentalPrice.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtToRentalPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtToRentalPrice.ForeColor = System.Drawing.Color.Black;
            this.txtToRentalPrice.Location = new System.Drawing.Point(235, 4);
            this.txtToRentalPrice.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtToRentalPrice.Multiline = true;
            this.txtToRentalPrice.Name = "txtToRentalPrice";
            this.txtToRentalPrice.Size = new System.Drawing.Size(138, 30);
            this.txtToRentalPrice.TabIndex = 246;
            this.txtToRentalPrice.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtToRentalPrice.TextChanged += new System.EventHandler(this.cbFilterBy_SelectedIndexChanged);
            this.txtToRentalPrice.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtFromRentalPrice_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(201, 11);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(33, 17);
            this.label3.TabIndex = 244;
            this.label3.Text = "To :";
            // 
            // cbRentalPrice
            // 
            this.cbRentalPrice.AutoSize = true;
            this.cbRentalPrice.Checked = true;
            this.cbRentalPrice.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbRentalPrice.ForeColor = System.Drawing.Color.Black;
            this.cbRentalPrice.Location = new System.Drawing.Point(608, 14);
            this.cbRentalPrice.Name = "cbRentalPrice";
            this.cbRentalPrice.Size = new System.Drawing.Size(37, 17);
            this.cbRentalPrice.TabIndex = 245;
            this.cbRentalPrice.Text = "All";
            this.cbRentalPrice.UseVisualStyleBackColor = true;
            this.cbRentalPrice.TextChanged += new System.EventHandler(this.cbFilterBy_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(3, 11);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 17);
            this.label2.TabIndex = 245;
            this.label2.Text = "From ";
            // 
            // txtFromRentalPrice
            // 
            this.txtFromRentalPrice.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtFromRentalPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtFromRentalPrice.ForeColor = System.Drawing.Color.Black;
            this.txtFromRentalPrice.Location = new System.Drawing.Point(52, 4);
            this.txtFromRentalPrice.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtFromRentalPrice.Multiline = true;
            this.txtFromRentalPrice.Name = "txtFromRentalPrice";
            this.txtFromRentalPrice.Size = new System.Drawing.Size(125, 30);
            this.txtFromRentalPrice.TabIndex = 160;
            this.txtFromRentalPrice.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtFromRentalPrice.TextChanged += new System.EventHandler(this.cbFilterBy_SelectedIndexChanged);
            this.txtFromRentalPrice.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtFromRentalPrice_KeyPress);
            // 
            // tabNumberOfDaysMonths
            // 
            this.tabNumberOfDaysMonths.Controls.Add(this.cmbNumberOfRentedDaysMonths);
            this.tabNumberOfDaysMonths.Controls.Add(this.cbNumberOfRentedDaysMonths);
            this.tabNumberOfDaysMonths.Controls.Add(this.label9);
            this.tabNumberOfDaysMonths.Controls.Add(this.label10);
            this.tabNumberOfDaysMonths.Controls.Add(this.nudToNumberOfRentedDaysMonths);
            this.tabNumberOfDaysMonths.Controls.Add(this.nudFromNumberOfRentedDaysMonths);
            this.tabNumberOfDaysMonths.Location = new System.Drawing.Point(4, 22);
            this.tabNumberOfDaysMonths.Name = "tabNumberOfDaysMonths";
            this.tabNumberOfDaysMonths.Size = new System.Drawing.Size(673, 46);
            this.tabNumberOfDaysMonths.TabIndex = 4;
            this.tabNumberOfDaysMonths.Text = "Number Times Of Days & Months";
            this.tabNumberOfDaysMonths.UseVisualStyleBackColor = true;
            this.tabNumberOfDaysMonths.Click += new System.EventHandler(this.tabNumberOfDaysMonths_Click);
            // 
            // cmbNumberOfRentedDaysMonths
            // 
            this.cmbNumberOfRentedDaysMonths.BackColor = System.Drawing.Color.Transparent;
            this.cmbNumberOfRentedDaysMonths.BorderColor = System.Drawing.Color.Black;
            this.cmbNumberOfRentedDaysMonths.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbNumberOfRentedDaysMonths.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbNumberOfRentedDaysMonths.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cmbNumberOfRentedDaysMonths.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cmbNumberOfRentedDaysMonths.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F);
            this.cmbNumberOfRentedDaysMonths.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cmbNumberOfRentedDaysMonths.ItemHeight = 30;
            this.cmbNumberOfRentedDaysMonths.Items.AddRange(new object[] {
            "Days",
            "Months"});
            this.cmbNumberOfRentedDaysMonths.Location = new System.Drawing.Point(421, 9);
            this.cmbNumberOfRentedDaysMonths.Margin = new System.Windows.Forms.Padding(2);
            this.cmbNumberOfRentedDaysMonths.Name = "cmbNumberOfRentedDaysMonths";
            this.cmbNumberOfRentedDaysMonths.Size = new System.Drawing.Size(158, 36);
            this.cmbNumberOfRentedDaysMonths.StartIndex = 0;
            this.cmbNumberOfRentedDaysMonths.TabIndex = 261;
            this.cmbNumberOfRentedDaysMonths.SelectedIndexChanged += new System.EventHandler(this.guna2ComboBox1_SelectedIndexChanged);
            // 
            // cbNumberOfRentedDaysMonths
            // 
            this.cbNumberOfRentedDaysMonths.AutoSize = true;
            this.cbNumberOfRentedDaysMonths.Checked = true;
            this.cbNumberOfRentedDaysMonths.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbNumberOfRentedDaysMonths.Location = new System.Drawing.Point(583, 17);
            this.cbNumberOfRentedDaysMonths.Name = "cbNumberOfRentedDaysMonths";
            this.cbNumberOfRentedDaysMonths.Size = new System.Drawing.Size(37, 17);
            this.cbNumberOfRentedDaysMonths.TabIndex = 260;
            this.cbNumberOfRentedDaysMonths.Text = "Of";
            this.cbNumberOfRentedDaysMonths.UseVisualStyleBackColor = true;
            this.cbNumberOfRentedDaysMonths.CheckedChanged += new System.EventHandler(this.cbNumberOfRentedDaysMonths_CheckedChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label9.ForeColor = System.Drawing.Color.Black;
            this.label9.Location = new System.Drawing.Point(212, 14);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(29, 17);
            this.label9.TabIndex = 258;
            this.label9.Text = "To ";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label10.ForeColor = System.Drawing.Color.Black;
            this.label10.Location = new System.Drawing.Point(9, 15);
            this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(44, 17);
            this.label10.TabIndex = 259;
            this.label10.Text = "From ";
            // 
            // nudToNumberOfRentedDaysMonths
            // 
            this.nudToNumberOfRentedDaysMonths.BackColor = System.Drawing.Color.Transparent;
            this.nudToNumberOfRentedDaysMonths.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.nudToNumberOfRentedDaysMonths.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.nudToNumberOfRentedDaysMonths.Location = new System.Drawing.Point(257, 9);
            this.nudToNumberOfRentedDaysMonths.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.nudToNumberOfRentedDaysMonths.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.nudToNumberOfRentedDaysMonths.Name = "nudToNumberOfRentedDaysMonths";
            this.nudToNumberOfRentedDaysMonths.Size = new System.Drawing.Size(147, 27);
            this.nudToNumberOfRentedDaysMonths.TabIndex = 257;
            this.nudToNumberOfRentedDaysMonths.ValueChanged += new System.EventHandler(this.nudToNumberOfRentedDaysMonths_ValueChanged);
            // 
            // nudFromNumberOfRentedDaysMonths
            // 
            this.nudFromNumberOfRentedDaysMonths.BackColor = System.Drawing.Color.Transparent;
            this.nudFromNumberOfRentedDaysMonths.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.nudFromNumberOfRentedDaysMonths.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.nudFromNumberOfRentedDaysMonths.Location = new System.Drawing.Point(59, 9);
            this.nudFromNumberOfRentedDaysMonths.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.nudFromNumberOfRentedDaysMonths.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.nudFromNumberOfRentedDaysMonths.Name = "nudFromNumberOfRentedDaysMonths";
            this.nudFromNumberOfRentedDaysMonths.Size = new System.Drawing.Size(147, 27);
            this.nudFromNumberOfRentedDaysMonths.TabIndex = 256;
            this.nudFromNumberOfRentedDaysMonths.ValueChanged += new System.EventHandler(this.nudFromNumberOfRentedDaysMonths_ValueChanged);
            // 
            // tabTotalRentalIncome
            // 
            this.tabTotalRentalIncome.Controls.Add(this.label5);
            this.tabTotalRentalIncome.Controls.Add(this.cmbRentalAmounts);
            this.tabTotalRentalIncome.Controls.Add(this.cbRentalAmounts);
            this.tabTotalRentalIncome.Controls.Add(this.txtToTotalRentalIncome);
            this.tabTotalRentalIncome.Controls.Add(this.label8);
            this.tabTotalRentalIncome.Controls.Add(this.label15);
            this.tabTotalRentalIncome.Controls.Add(this.txtFromTotalRentalincome);
            this.tabTotalRentalIncome.Location = new System.Drawing.Point(4, 22);
            this.tabTotalRentalIncome.Name = "tabTotalRentalIncome";
            this.tabTotalRentalIncome.Padding = new System.Windows.Forms.Padding(3);
            this.tabTotalRentalIncome.Size = new System.Drawing.Size(673, 46);
            this.tabTotalRentalIncome.TabIndex = 3;
            this.tabTotalRentalIncome.Text = "Total Rental Income";
            this.tabTotalRentalIncome.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(376, 16);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(32, 17);
            this.label5.TabIndex = 263;
            this.label5.Text = "By :";
            // 
            // cmbRentalAmounts
            // 
            this.cmbRentalAmounts.BackColor = System.Drawing.Color.Transparent;
            this.cmbRentalAmounts.BorderColor = System.Drawing.Color.Black;
            this.cmbRentalAmounts.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbRentalAmounts.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbRentalAmounts.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cmbRentalAmounts.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cmbRentalAmounts.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F);
            this.cmbRentalAmounts.ForeColor = System.Drawing.Color.Black;
            this.cmbRentalAmounts.ItemHeight = 30;
            this.cmbRentalAmounts.Items.AddRange(new object[] {
            "Initial Total Due Amount",
            "Paid Initial Total Due Amount",
            "Actual Total Due Amount",
            "Total Remaining",
            "Total Refunded Amount"});
            this.cmbRentalAmounts.Location = new System.Drawing.Point(422, 10);
            this.cmbRentalAmounts.Margin = new System.Windows.Forms.Padding(2);
            this.cmbRentalAmounts.Name = "cmbRentalAmounts";
            this.cmbRentalAmounts.Size = new System.Drawing.Size(213, 36);
            this.cmbRentalAmounts.TabIndex = 262;
            this.cmbRentalAmounts.SelectedIndexChanged += new System.EventHandler(this.cmbRentalAmounts_SelectedIndexChanged);
            this.cmbRentalAmounts.TextChanged += new System.EventHandler(this.txtFromTotalRentalincome_TextChanged);
            // 
            // cbRentalAmounts
            // 
            this.cbRentalAmounts.AutoSize = true;
            this.cbRentalAmounts.Checked = true;
            this.cbRentalAmounts.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbRentalAmounts.ForeColor = System.Drawing.Color.Black;
            this.cbRentalAmounts.Location = new System.Drawing.Point(639, 18);
            this.cbRentalAmounts.Name = "cbRentalAmounts";
            this.cbRentalAmounts.Size = new System.Drawing.Size(37, 17);
            this.cbRentalAmounts.TabIndex = 261;
            this.cbRentalAmounts.Text = "Of";
            this.cbRentalAmounts.UseVisualStyleBackColor = true;
            this.cbRentalAmounts.CheckedChanged += new System.EventHandler(this.cbRentalAmounts_CheckedChanged);
            this.cbRentalAmounts.TextChanged += new System.EventHandler(this.txtFromTotalRentalincome_TextChanged);
            // 
            // txtToTotalRentalIncome
            // 
            this.txtToTotalRentalIncome.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtToTotalRentalIncome.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtToTotalRentalIncome.ForeColor = System.Drawing.Color.Black;
            this.txtToTotalRentalIncome.Location = new System.Drawing.Point(223, 10);
            this.txtToTotalRentalIncome.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtToTotalRentalIncome.Multiline = true;
            this.txtToTotalRentalIncome.Name = "txtToTotalRentalIncome";
            this.txtToTotalRentalIncome.Size = new System.Drawing.Size(138, 30);
            this.txtToTotalRentalIncome.TabIndex = 250;
            this.txtToTotalRentalIncome.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtToTotalRentalIncome.TextChanged += new System.EventHandler(this.txtFromTotalRentalincome_TextChanged);
            this.txtToTotalRentalIncome.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtFromRentalPrice_KeyPress);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label8.ForeColor = System.Drawing.Color.Black;
            this.label8.Location = new System.Drawing.Point(189, 16);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(33, 17);
            this.label8.TabIndex = 248;
            this.label8.Text = "To :";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label15.ForeColor = System.Drawing.Color.Black;
            this.label15.Location = new System.Drawing.Point(10, 16);
            this.label15.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(44, 17);
            this.label15.TabIndex = 249;
            this.label15.Text = "From ";
            // 
            // txtFromTotalRentalincome
            // 
            this.txtFromTotalRentalincome.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtFromTotalRentalincome.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtFromTotalRentalincome.ForeColor = System.Drawing.Color.Black;
            this.txtFromTotalRentalincome.Location = new System.Drawing.Point(59, 10);
            this.txtFromTotalRentalincome.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtFromTotalRentalincome.Multiline = true;
            this.txtFromTotalRentalincome.Name = "txtFromTotalRentalincome";
            this.txtFromTotalRentalincome.Size = new System.Drawing.Size(125, 30);
            this.txtFromTotalRentalincome.TabIndex = 247;
            this.txtFromTotalRentalincome.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtFromTotalRentalincome.TextChanged += new System.EventHandler(this.txtFromTotalRentalincome_TextChanged);
            this.txtFromTotalRentalincome.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtFromRentalPrice_KeyPress);
            // 
            // tabStatus
            // 
            this.tabStatus.Controls.Add(this.cbRentalStatus);
            this.tabStatus.Controls.Add(this.lblTitleAvailable);
            this.tabStatus.Controls.Add(this.cmbRentalStatus);
            this.tabStatus.Location = new System.Drawing.Point(4, 22);
            this.tabStatus.Margin = new System.Windows.Forms.Padding(2);
            this.tabStatus.Name = "tabStatus";
            this.tabStatus.Size = new System.Drawing.Size(673, 46);
            this.tabStatus.TabIndex = 7;
            this.tabStatus.Text = "Status";
            this.tabStatus.UseVisualStyleBackColor = true;
            // 
            // cbRentalStatus
            // 
            this.cbRentalStatus.AutoSize = true;
            this.cbRentalStatus.Checked = true;
            this.cbRentalStatus.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbRentalStatus.Location = new System.Drawing.Point(305, 15);
            this.cbRentalStatus.Name = "cbRentalStatus";
            this.cbRentalStatus.Size = new System.Drawing.Size(37, 17);
            this.cbRentalStatus.TabIndex = 252;
            this.cbRentalStatus.Text = "Of";
            this.cbRentalStatus.UseVisualStyleBackColor = true;
            this.cbRentalStatus.CheckedChanged += new System.EventHandler(this.cbRentalStatus_CheckedChanged);
            // 
            // lblTitleAvailable
            // 
            this.lblTitleAvailable.AutoSize = true;
            this.lblTitleAvailable.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblTitleAvailable.ForeColor = System.Drawing.Color.Black;
            this.lblTitleAvailable.Location = new System.Drawing.Point(56, 14);
            this.lblTitleAvailable.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTitleAvailable.Name = "lblTitleAvailable";
            this.lblTitleAvailable.Size = new System.Drawing.Size(56, 17);
            this.lblTitleAvailable.TabIndex = 109;
            this.lblTitleAvailable.Text = "Status :";
            // 
            // cmbRentalStatus
            // 
            this.cmbRentalStatus.BackColor = System.Drawing.Color.Transparent;
            this.cmbRentalStatus.BorderColor = System.Drawing.Color.Black;
            this.cmbRentalStatus.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbRentalStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbRentalStatus.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cmbRentalStatus.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cmbRentalStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F);
            this.cmbRentalStatus.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cmbRentalStatus.ItemHeight = 30;
            this.cmbRentalStatus.Items.AddRange(new object[] {
            "New",
            "Completed"});
            this.cmbRentalStatus.Location = new System.Drawing.Point(127, 8);
            this.cmbRentalStatus.Margin = new System.Windows.Forms.Padding(2);
            this.cmbRentalStatus.Name = "cmbRentalStatus";
            this.cmbRentalStatus.Size = new System.Drawing.Size(158, 36);
            this.cmbRentalStatus.StartIndex = 0;
            this.cmbRentalStatus.TabIndex = 112;
            this.cmbRentalStatus.SelectedIndexChanged += new System.EventHandler(this.cmbRentalStatus_SelectedIndexChanged);
            // 
            // tabBranches
            // 
            this.tabBranches.Controls.Add(this.label7);
            this.tabBranches.Controls.Add(this.cmbCityName);
            this.tabBranches.Controls.Add(this.label6);
            this.tabBranches.Controls.Add(this.cmbBranches);
            this.tabBranches.Location = new System.Drawing.Point(4, 22);
            this.tabBranches.Name = "tabBranches";
            this.tabBranches.Padding = new System.Windows.Forms.Padding(3);
            this.tabBranches.Size = new System.Drawing.Size(673, 46);
            this.tabBranches.TabIndex = 8;
            this.tabBranches.Text = "Branches ";
            this.tabBranches.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.Location = new System.Drawing.Point(53, 15);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(86, 16);
            this.label7.TabIndex = 191;
            this.label7.Text = "City Name :";
            // 
            // cmbCityName
            // 
            this.cmbCityName.AutoRoundedCorners = true;
            this.cmbCityName.BackColor = System.Drawing.Color.Transparent;
            this.cmbCityName.BorderRadius = 17;
            this.cmbCityName.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbCityName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCityName.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cmbCityName.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cmbCityName.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cmbCityName.ForeColor = System.Drawing.Color.Black;
            this.cmbCityName.ItemHeight = 30;
            this.cmbCityName.Items.AddRange(new object[] {
            "All"});
            this.cmbCityName.Location = new System.Drawing.Point(149, 5);
            this.cmbCityName.Name = "cmbCityName";
            this.cmbCityName.Size = new System.Drawing.Size(165, 36);
            this.cmbCityName.StartIndex = 0;
            this.cmbCityName.TabIndex = 190;
            this.cmbCityName.SelectedIndexChanged += new System.EventHandler(this.cmbCityName_SelectedIndexChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(362, 16);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(80, 16);
            this.label6.TabIndex = 173;
            this.label6.Text = "Branches :";
            // 
            // cmbBranches
            // 
            this.cmbBranches.AutoRoundedCorners = true;
            this.cmbBranches.BackColor = System.Drawing.Color.Transparent;
            this.cmbBranches.BorderRadius = 17;
            this.cmbBranches.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbBranches.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbBranches.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cmbBranches.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cmbBranches.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cmbBranches.ForeColor = System.Drawing.Color.Black;
            this.cmbBranches.ItemHeight = 30;
            this.cmbBranches.Items.AddRange(new object[] {
            "All"});
            this.cmbBranches.Location = new System.Drawing.Point(472, 5);
            this.cmbBranches.Name = "cmbBranches";
            this.cmbBranches.Size = new System.Drawing.Size(164, 36);
            this.cmbBranches.StartIndex = 0;
            this.cmbBranches.TabIndex = 172;
            this.cmbBranches.SelectedIndexChanged += new System.EventHandler(this.cmbBranches_SelectedIndexChanged);
            // 
            // cbFilterBy
            // 
            this.cbFilterBy.BackColor = System.Drawing.Color.Transparent;
            this.cbFilterBy.BorderColor = System.Drawing.Color.Black;
            this.cbFilterBy.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbFilterBy.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbFilterBy.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbFilterBy.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbFilterBy.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F);
            this.cbFilterBy.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cbFilterBy.ItemHeight = 30;
            this.cbFilterBy.Items.AddRange(new object[] {
            "None",
            "Transaction ID",
            "Name",
            "Plate Number",
            "Full Name"});
            this.cbFilterBy.Location = new System.Drawing.Point(78, 32);
            this.cbFilterBy.Margin = new System.Windows.Forms.Padding(2);
            this.cbFilterBy.Name = "cbFilterBy";
            this.cbFilterBy.Size = new System.Drawing.Size(158, 36);
            this.cbFilterBy.StartIndex = 0;
            this.cbFilterBy.TabIndex = 255;
            this.cbFilterBy.SelectedIndexChanged += new System.EventHandler(this.cbFilterBy_SelectedIndexChanged);
            // 
            // txtFilterValue
            // 
            this.txtFilterValue.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtFilterValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtFilterValue.Location = new System.Drawing.Point(241, 32);
            this.txtFilterValue.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtFilterValue.Multiline = true;
            this.txtFilterValue.Name = "txtFilterValue";
            this.txtFilterValue.Size = new System.Drawing.Size(206, 30);
            this.txtFilterValue.TabIndex = 254;
            this.txtFilterValue.Visible = false;
            this.txtFilterValue.TextChanged += new System.EventHandler(this.txtFilterValue_TextChanged);
            this.txtFilterValue.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtFilterValue_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(12, 37);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 17);
            this.label1.TabIndex = 253;
            this.label1.Text = "Filter By:";
            // 
            // dgv
            // 
            this.dgv.AllowUserToAddRows = false;
            this.dgv.AllowUserToDeleteRows = false;
            this.dgv.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black;
            this.dgv.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgv.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgv.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.None;
            this.dgv.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgv.ColumnHeadersHeight = 44;
            this.dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dgv.ContextMenuStrip = this.contextMenuStrip1;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgv.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgv.Location = new System.Drawing.Point(7, 79);
            this.dgv.Margin = new System.Windows.Forms.Padding(2);
            this.dgv.Name = "dgv";
            this.dgv.ReadOnly = true;
            this.dgv.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgv.RowHeadersVisible = false;
            this.dgv.RowHeadersWidth = 51;
            this.dgv.RowTemplate.Height = 29;
            this.dgv.Size = new System.Drawing.Size(1383, 283);
            this.dgv.TabIndex = 257;
            this.dgv.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dgv.ThemeStyle.AlternatingRowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dgv.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Black;
            this.dgv.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgv.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dgv.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.dgv.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgv.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.Black;
            this.dgv.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgv.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dgv.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dgv.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dgv.ThemeStyle.HeaderStyle.Height = 44;
            this.dgv.ThemeStyle.ReadOnly = true;
            this.dgv.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dgv.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgv.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dgv.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dgv.ThemeStyle.RowsStyle.Height = 29;
            this.dgv.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgv.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.showTransactionDetailsToolStripMenuItem,
            this.showCreatedByUserIDToolStripMenuItem,
            this.showUpdatedByUserIDToolStripMenuItem,
            this.showCustomerDetaiToolStripMenuItem,
            this.vehiclleReturnToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(208, 114);
            this.contextMenuStrip1.Opening += new System.ComponentModel.CancelEventHandler(this.contextMenuStrip1_Opening);
            // 
            // showTransactionDetailsToolStripMenuItem
            // 
            this.showTransactionDetailsToolStripMenuItem.Name = "showTransactionDetailsToolStripMenuItem";
            this.showTransactionDetailsToolStripMenuItem.Size = new System.Drawing.Size(207, 22);
            this.showTransactionDetailsToolStripMenuItem.Text = "Show Transaction Details";
            this.showTransactionDetailsToolStripMenuItem.Click += new System.EventHandler(this.showTransactionDetailsToolStripMenuItem_Click);
            // 
            // showCreatedByUserIDToolStripMenuItem
            // 
            this.showCreatedByUserIDToolStripMenuItem.Name = "showCreatedByUserIDToolStripMenuItem";
            this.showCreatedByUserIDToolStripMenuItem.Size = new System.Drawing.Size(207, 22);
            this.showCreatedByUserIDToolStripMenuItem.Text = "Show Created By User ID";
            this.showCreatedByUserIDToolStripMenuItem.Click += new System.EventHandler(this.showCreatedByUserIDToolStripMenuItem_Click);
            // 
            // showUpdatedByUserIDToolStripMenuItem
            // 
            this.showUpdatedByUserIDToolStripMenuItem.Name = "showUpdatedByUserIDToolStripMenuItem";
            this.showUpdatedByUserIDToolStripMenuItem.Size = new System.Drawing.Size(207, 22);
            this.showUpdatedByUserIDToolStripMenuItem.Text = "Show Updated By User ID";
            this.showUpdatedByUserIDToolStripMenuItem.Click += new System.EventHandler(this.showUpdatedByUserIDToolStripMenuItem_Click);
            // 
            // showCustomerDetaiToolStripMenuItem
            // 
            this.showCustomerDetaiToolStripMenuItem.Name = "showCustomerDetaiToolStripMenuItem";
            this.showCustomerDetaiToolStripMenuItem.Size = new System.Drawing.Size(207, 22);
            this.showCustomerDetaiToolStripMenuItem.Text = "Show Customer Details";
            this.showCustomerDetaiToolStripMenuItem.Click += new System.EventHandler(this.showCustomerDetaiToolStripMenuItem_Click);
            // 
            // vehiclleReturnToolStripMenuItem
            // 
            this.vehiclleReturnToolStripMenuItem.Name = "vehiclleReturnToolStripMenuItem";
            this.vehiclleReturnToolStripMenuItem.Size = new System.Drawing.Size(207, 22);
            this.vehiclleReturnToolStripMenuItem.Text = "Vehiclle Return";
            this.vehiclleReturnToolStripMenuItem.Click += new System.EventHandler(this.vehiclleReturnToolStripMenuItem_Click);
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Tai Le", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.SlateBlue;
            this.label4.Location = new System.Drawing.Point(3, 366);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(102, 23);
            this.label4.TabIndex = 259;
            this.label4.Text = "# Records:";
            // 
            // lblRecordsCount
            // 
            this.lblRecordsCount.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblRecordsCount.AutoSize = true;
            this.lblRecordsCount.Font = new System.Drawing.Font("Microsoft Tai Le", 10.8F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRecordsCount.ForeColor = System.Drawing.Color.SlateBlue;
            this.lblRecordsCount.Location = new System.Drawing.Point(102, 368);
            this.lblRecordsCount.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblRecordsCount.Name = "lblRecordsCount";
            this.lblRecordsCount.Size = new System.Drawing.Size(133, 19);
            this.lblRecordsCount.TabIndex = 258;
            this.lblRecordsCount.Text = "Add Update Check";
            // 
            // ctrlDgvListTransactions
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lblRecordsCount);
            this.Controls.Add(this.dgv);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.cbFilterBy);
            this.Controls.Add(this.txtFilterValue);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "ctrlDgvListTransactions";
            this.Size = new System.Drawing.Size(1403, 392);
            this.Load += new System.EventHandler(this.ctrlDgvListTransactions_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPrice.ResumeLayout(false);
            this.tabPrice.PerformLayout();
            this.tabNumberOfDaysMonths.ResumeLayout(false);
            this.tabNumberOfDaysMonths.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudToNumberOfRentedDaysMonths)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudFromNumberOfRentedDaysMonths)).EndInit();
            this.tabTotalRentalIncome.ResumeLayout(false);
            this.tabTotalRentalIncome.PerformLayout();
            this.tabStatus.ResumeLayout(false);
            this.tabStatus.PerformLayout();
            this.tabBranches.ResumeLayout(false);
            this.tabBranches.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPrice;
        private System.Windows.Forms.Label label11;
        private Guna.UI2.WinForms.Guna2ComboBox cmbRentalPrice;
        private System.Windows.Forms.TextBox txtToRentalPrice;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckBox cbRentalPrice;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtFromRentalPrice;
        private System.Windows.Forms.TabPage tabNumberOfDaysMonths;
        private System.Windows.Forms.CheckBox cbNumberOfRentedDaysMonths;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private Guna.UI2.WinForms.Guna2NumericUpDown nudToNumberOfRentedDaysMonths;
        private Guna.UI2.WinForms.Guna2NumericUpDown nudFromNumberOfRentedDaysMonths;
        private System.Windows.Forms.TabPage tabTotalRentalIncome;
        private System.Windows.Forms.CheckBox cbRentalAmounts;
        private System.Windows.Forms.TextBox txtToTotalRentalIncome;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox txtFromTotalRentalincome;
        private System.Windows.Forms.TabPage tabStatus;
        private System.Windows.Forms.Label lblTitleAvailable;
        private Guna.UI2.WinForms.Guna2ComboBox cmbRentalStatus;
        private Guna.UI2.WinForms.Guna2ComboBox cbFilterBy;
        private System.Windows.Forms.TextBox txtFilterValue;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2DataGridView dgv;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblRecordsCount;
        private System.Windows.Forms.Label label5;
        private Guna.UI2.WinForms.Guna2ComboBox cmbRentalAmounts;
        private System.Windows.Forms.CheckBox cbRentalStatus;
        private Guna.UI2.WinForms.Guna2ComboBox cmbNumberOfRentedDaysMonths;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem showTransactionDetailsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem showCreatedByUserIDToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem showUpdatedByUserIDToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem showCustomerDetaiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem vehiclleReturnToolStripMenuItem;
        private System.Windows.Forms.TabPage tabBranches;
        private System.Windows.Forms.Label label6;
        private Guna.UI2.WinForms.Guna2ComboBox cmbBranches;
        private System.Windows.Forms.Label label7;
        private Guna.UI2.WinForms.Guna2ComboBox cmbCityName;
    }
}
