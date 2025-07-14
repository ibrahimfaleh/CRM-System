namespace CarRental.General_Revenue_Fund
{
    partial class ctrldgvGeneralFundSupportTransactions
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabAmount = new System.Windows.Forms.TabPage();
            this.txtToAmount = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cbAmount = new System.Windows.Forms.CheckBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtFromAmount = new System.Windows.Forms.TextBox();
            this.Date = new System.Windows.Forms.TabPage();
            this.cbDate = new System.Windows.Forms.CheckBox();
            this.dtpToDate = new System.Windows.Forms.DateTimePicker();
            this.dtpFromDate = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.cbFilterBy = new Guna.UI2.WinForms.Guna2ComboBox();
            this.txtFilterValue = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblRecordsCount = new System.Windows.Forms.Label();
            this.dgvListGeneralFundSupportTransactionss = new Guna.UI2.WinForms.Guna2DataGridView();
            this.llll = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.guna2ContextMenuStrip1 = new Guna.UI2.WinForms.Guna2ContextMenuStrip();
            this.UpdateToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.showCreatedUserDetailsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.showUpdatedUserDetailsToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.tabControl1.SuspendLayout();
            this.tabAmount.SuspendLayout();
            this.Date.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListGeneralFundSupportTransactionss)).BeginInit();
            this.guna2ContextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabAmount);
            this.tabControl1.Controls.Add(this.Date);
            this.tabControl1.Location = new System.Drawing.Point(855, 6);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(513, 73);
            this.tabControl1.TabIndex = 271;
            // 
            // tabAmount
            // 
            this.tabAmount.Controls.Add(this.txtToAmount);
            this.tabAmount.Controls.Add(this.label3);
            this.tabAmount.Controls.Add(this.cbAmount);
            this.tabAmount.Controls.Add(this.label4);
            this.tabAmount.Controls.Add(this.txtFromAmount);
            this.tabAmount.Location = new System.Drawing.Point(4, 22);
            this.tabAmount.Name = "tabAmount";
            this.tabAmount.Padding = new System.Windows.Forms.Padding(3, 3, 3, 3);
            this.tabAmount.Size = new System.Drawing.Size(505, 47);
            this.tabAmount.TabIndex = 1;
            this.tabAmount.Text = "Amount";
            this.tabAmount.UseVisualStyleBackColor = true;
            // 
            // txtToAmount
            // 
            this.txtToAmount.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtToAmount.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtToAmount.ForeColor = System.Drawing.Color.Black;
            this.txtToAmount.Location = new System.Drawing.Point(265, 10);
            this.txtToAmount.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtToAmount.Multiline = true;
            this.txtToAmount.Name = "txtToAmount";
            this.txtToAmount.Size = new System.Drawing.Size(156, 30);
            this.txtToAmount.TabIndex = 246;
            this.txtToAmount.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtToAmount.TextChanged += new System.EventHandler(this.txtFilterValue_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(215, 17);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(33, 17);
            this.label3.TabIndex = 244;
            this.label3.Text = "To :";
            // 
            // cbAmount
            // 
            this.cbAmount.AutoSize = true;
            this.cbAmount.Checked = true;
            this.cbAmount.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbAmount.Location = new System.Drawing.Point(459, 17);
            this.cbAmount.Name = "cbAmount";
            this.cbAmount.Size = new System.Drawing.Size(37, 17);
            this.cbAmount.TabIndex = 245;
            this.cbAmount.Text = "All";
            this.cbAmount.UseVisualStyleBackColor = true;
            this.cbAmount.TextChanged += new System.EventHandler(this.txtFilterValue_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(5, 16);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 17);
            this.label4.TabIndex = 245;
            this.label4.Text = "From ";
            // 
            // txtFromAmount
            // 
            this.txtFromAmount.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtFromAmount.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtFromAmount.ForeColor = System.Drawing.Color.Black;
            this.txtFromAmount.Location = new System.Drawing.Point(54, 10);
            this.txtFromAmount.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtFromAmount.Multiline = true;
            this.txtFromAmount.Name = "txtFromAmount";
            this.txtFromAmount.Size = new System.Drawing.Size(142, 30);
            this.txtFromAmount.TabIndex = 160;
            this.txtFromAmount.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtFromAmount.TextChanged += new System.EventHandler(this.txtFromAmount_TextChanged);
            // 
            // Date
            // 
            this.Date.AccessibleRole = System.Windows.Forms.AccessibleRole.OutlineButton;
            this.Date.Controls.Add(this.cbDate);
            this.Date.Controls.Add(this.dtpToDate);
            this.Date.Controls.Add(this.dtpFromDate);
            this.Date.Controls.Add(this.label6);
            this.Date.Controls.Add(this.label7);
            this.Date.Location = new System.Drawing.Point(4, 22);
            this.Date.Name = "Date";
            this.Date.Padding = new System.Windows.Forms.Padding(3, 3, 3, 3);
            this.Date.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Date.Size = new System.Drawing.Size(505, 47);
            this.Date.TabIndex = 2;
            this.Date.Text = "Date";
            this.Date.UseVisualStyleBackColor = true;
            // 
            // cbDate
            // 
            this.cbDate.AutoSize = true;
            this.cbDate.Checked = true;
            this.cbDate.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbDate.Location = new System.Drawing.Point(412, 16);
            this.cbDate.Name = "cbDate";
            this.cbDate.Size = new System.Drawing.Size(37, 17);
            this.cbDate.TabIndex = 247;
            this.cbDate.Text = "All";
            this.cbDate.UseVisualStyleBackColor = true;
            this.cbDate.TextChanged += new System.EventHandler(this.txtFilterValue_TextChanged);
            // 
            // dtpToDate
            // 
            this.dtpToDate.CustomFormat = "yyyy-mm";
            this.dtpToDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpToDate.Location = new System.Drawing.Point(271, 13);
            this.dtpToDate.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dtpToDate.MinDate = new System.DateTime(2023, 12, 25, 0, 0, 0, 0);
            this.dtpToDate.Name = "dtpToDate";
            this.dtpToDate.ShowUpDown = true;
            this.dtpToDate.Size = new System.Drawing.Size(112, 20);
            this.dtpToDate.TabIndex = 249;
            this.dtpToDate.Value = new System.DateTime(2024, 3, 21, 0, 0, 0, 0);
            this.dtpToDate.ValueChanged += new System.EventHandler(this.txtFilterValue_TextChanged);
            // 
            // dtpFromDate
            // 
            this.dtpFromDate.CustomFormat = "yyyy-mm";
            this.dtpFromDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFromDate.Location = new System.Drawing.Point(102, 13);
            this.dtpFromDate.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dtpFromDate.MinDate = new System.DateTime(2023, 12, 25, 0, 0, 0, 0);
            this.dtpFromDate.Name = "dtpFromDate";
            this.dtpFromDate.ShowUpDown = true;
            this.dtpFromDate.Size = new System.Drawing.Size(112, 20);
            this.dtpFromDate.TabIndex = 248;
            this.dtpFromDate.Value = new System.DateTime(2024, 3, 21, 0, 0, 0, 0);
            this.dtpFromDate.ValueChanged += new System.EventHandler(this.txtFilterValue_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(229, 14);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(29, 17);
            this.label6.TabIndex = 246;
            this.label6.Text = "To ";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(40, 14);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(44, 17);
            this.label7.TabIndex = 247;
            this.label7.Text = "From ";
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
            "Full Name",
            "Transaction ID",
            "Created By User ID",
            "Update By User ID"});
            this.cbFilterBy.Location = new System.Drawing.Point(73, 43);
            this.cbFilterBy.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cbFilterBy.Name = "cbFilterBy";
            this.cbFilterBy.Size = new System.Drawing.Size(218, 36);
            this.cbFilterBy.StartIndex = 0;
            this.cbFilterBy.TabIndex = 270;
            this.cbFilterBy.SelectedIndexChanged += new System.EventHandler(this.cbFilterBy_SelectedIndexChanged);
            // 
            // txtFilterValue
            // 
            this.txtFilterValue.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtFilterValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtFilterValue.Location = new System.Drawing.Point(296, 42);
            this.txtFilterValue.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtFilterValue.Multiline = true;
            this.txtFilterValue.Name = "txtFilterValue";
            this.txtFilterValue.Size = new System.Drawing.Size(246, 31);
            this.txtFilterValue.TabIndex = 269;
            this.txtFilterValue.Visible = false;
            this.txtFilterValue.TextChanged += new System.EventHandler(this.txtFilterValue_TextChanged);
            this.txtFilterValue.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtFilterValue_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(0, 51);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 17);
            this.label1.TabIndex = 268;
            this.label1.Text = "Filter By:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Tai Le", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.SlateBlue;
            this.label2.Location = new System.Drawing.Point(-1, 375);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(102, 23);
            this.label2.TabIndex = 267;
            this.label2.Text = "# Records:";
            // 
            // lblRecordsCount
            // 
            this.lblRecordsCount.AutoSize = true;
            this.lblRecordsCount.Font = new System.Drawing.Font("Microsoft Tai Le", 10.8F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRecordsCount.ForeColor = System.Drawing.Color.SlateBlue;
            this.lblRecordsCount.Location = new System.Drawing.Point(97, 378);
            this.lblRecordsCount.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblRecordsCount.Name = "lblRecordsCount";
            this.lblRecordsCount.Size = new System.Drawing.Size(133, 19);
            this.lblRecordsCount.TabIndex = 266;
            this.lblRecordsCount.Text = "Add Update Check";
            // 
            // dgvListGeneralFundSupportTransactionss
            // 
            this.dgvListGeneralFundSupportTransactionss.AllowUserToAddRows = false;
            this.dgvListGeneralFundSupportTransactionss.AllowUserToDeleteRows = false;
            this.dgvListGeneralFundSupportTransactionss.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black;
            this.dgvListGeneralFundSupportTransactionss.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvListGeneralFundSupportTransactionss.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.None;
            this.dgvListGeneralFundSupportTransactionss.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvListGeneralFundSupportTransactionss.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvListGeneralFundSupportTransactionss.ColumnHeadersHeight = 44;
            this.dgvListGeneralFundSupportTransactionss.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dgvListGeneralFundSupportTransactionss.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.llll});
            this.dgvListGeneralFundSupportTransactionss.ContextMenuStrip = this.guna2ContextMenuStrip1;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvListGeneralFundSupportTransactionss.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvListGeneralFundSupportTransactionss.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvListGeneralFundSupportTransactionss.Location = new System.Drawing.Point(2, 84);
            this.dgvListGeneralFundSupportTransactionss.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dgvListGeneralFundSupportTransactionss.Name = "dgvListGeneralFundSupportTransactionss";
            this.dgvListGeneralFundSupportTransactionss.ReadOnly = true;
            this.dgvListGeneralFundSupportTransactionss.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvListGeneralFundSupportTransactionss.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvListGeneralFundSupportTransactionss.RowHeadersVisible = false;
            this.dgvListGeneralFundSupportTransactionss.RowHeadersWidth = 51;
            this.dgvListGeneralFundSupportTransactionss.RowTemplate.Height = 29;
            this.dgvListGeneralFundSupportTransactionss.Size = new System.Drawing.Size(1367, 289);
            this.dgvListGeneralFundSupportTransactionss.TabIndex = 265;
            this.dgvListGeneralFundSupportTransactionss.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvListGeneralFundSupportTransactionss.ThemeStyle.AlternatingRowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dgvListGeneralFundSupportTransactionss.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Black;
            this.dgvListGeneralFundSupportTransactionss.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvListGeneralFundSupportTransactionss.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dgvListGeneralFundSupportTransactionss.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.dgvListGeneralFundSupportTransactionss.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvListGeneralFundSupportTransactionss.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.Black;
            this.dgvListGeneralFundSupportTransactionss.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvListGeneralFundSupportTransactionss.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dgvListGeneralFundSupportTransactionss.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dgvListGeneralFundSupportTransactionss.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dgvListGeneralFundSupportTransactionss.ThemeStyle.HeaderStyle.Height = 44;
            this.dgvListGeneralFundSupportTransactionss.ThemeStyle.ReadOnly = true;
            this.dgvListGeneralFundSupportTransactionss.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvListGeneralFundSupportTransactionss.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvListGeneralFundSupportTransactionss.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dgvListGeneralFundSupportTransactionss.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dgvListGeneralFundSupportTransactionss.ThemeStyle.RowsStyle.Height = 29;
            this.dgvListGeneralFundSupportTransactionss.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvListGeneralFundSupportTransactionss.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            // 
            // llll
            // 
            this.llll.FillWeight = 20F;
            this.llll.HeaderText = " ";
            this.llll.MinimumWidth = 6;
            this.llll.Name = "llll";
            this.llll.ReadOnly = true;
            this.llll.Width = 1684;
            // 
            // guna2ContextMenuStrip1
            // 
            this.guna2ContextMenuStrip1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.guna2ContextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.guna2ContextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.UpdateToolStripMenuItem,
            this.showCreatedUserDetailsToolStripMenuItem,
            this.showUpdatedUserDetailsToolStripMenuItem1});
            this.guna2ContextMenuStrip1.Name = "guna2ContextMenuStrip1";
            this.guna2ContextMenuStrip1.RenderStyle.ArrowColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.guna2ContextMenuStrip1.RenderStyle.BorderColor = System.Drawing.Color.Gainsboro;
            this.guna2ContextMenuStrip1.RenderStyle.ColorTable = null;
            this.guna2ContextMenuStrip1.RenderStyle.RoundedEdges = true;
            this.guna2ContextMenuStrip1.RenderStyle.SelectionArrowColor = System.Drawing.Color.White;
            this.guna2ContextMenuStrip1.RenderStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.guna2ContextMenuStrip1.RenderStyle.SelectionForeColor = System.Drawing.Color.White;
            this.guna2ContextMenuStrip1.RenderStyle.SeparatorColor = System.Drawing.Color.Gainsboro;
            this.guna2ContextMenuStrip1.RenderStyle.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault;
            this.guna2ContextMenuStrip1.ShowCheckMargin = true;
            this.guna2ContextMenuStrip1.Size = new System.Drawing.Size(292, 82);
            // 
            // UpdateToolStripMenuItem
            // 
            this.UpdateToolStripMenuItem.Name = "UpdateToolStripMenuItem";
            this.UpdateToolStripMenuItem.Size = new System.Drawing.Size(291, 26);
            this.UpdateToolStripMenuItem.Text = "Update";
            this.UpdateToolStripMenuItem.Click += new System.EventHandler(this.UpdateToolStripMenuItem_Click);
            // 
            // showCreatedUserDetailsToolStripMenuItem
            // 
            this.showCreatedUserDetailsToolStripMenuItem.Name = "showCreatedUserDetailsToolStripMenuItem";
            this.showCreatedUserDetailsToolStripMenuItem.Size = new System.Drawing.Size(291, 26);
            this.showCreatedUserDetailsToolStripMenuItem.Text = "Show Created User Details";
            this.showCreatedUserDetailsToolStripMenuItem.Click += new System.EventHandler(this.showCreatedUserDetailsToolStripMenuItem_Click);
            // 
            // showUpdatedUserDetailsToolStripMenuItem1
            // 
            this.showUpdatedUserDetailsToolStripMenuItem1.Name = "showUpdatedUserDetailsToolStripMenuItem1";
            this.showUpdatedUserDetailsToolStripMenuItem1.Size = new System.Drawing.Size(291, 26);
            this.showUpdatedUserDetailsToolStripMenuItem1.Text = "Show Updated User Details";
            this.showUpdatedUserDetailsToolStripMenuItem1.Click += new System.EventHandler(this.showUpdatedUserDetailsToolStripMenuItem1_Click);
            // 
            // ctrldgvGeneralFundSupportTransactions
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.cbFilterBy);
            this.Controls.Add(this.txtFilterValue);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblRecordsCount);
            this.Controls.Add(this.dgvListGeneralFundSupportTransactionss);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "ctrldgvGeneralFundSupportTransactions";
            this.Size = new System.Drawing.Size(1371, 398);
            this.tabControl1.ResumeLayout(false);
            this.tabAmount.ResumeLayout(false);
            this.tabAmount.PerformLayout();
            this.Date.ResumeLayout(false);
            this.Date.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListGeneralFundSupportTransactionss)).EndInit();
            this.guna2ContextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabAmount;
        private System.Windows.Forms.TextBox txtToAmount;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckBox cbAmount;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtFromAmount;
        private System.Windows.Forms.TabPage Date;
        private System.Windows.Forms.CheckBox cbDate;
        private System.Windows.Forms.DateTimePicker dtpToDate;
        private System.Windows.Forms.DateTimePicker dtpFromDate;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private Guna.UI2.WinForms.Guna2ComboBox cbFilterBy;
        private System.Windows.Forms.TextBox txtFilterValue;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblRecordsCount;
        private Guna.UI2.WinForms.Guna2DataGridView dgvListGeneralFundSupportTransactionss;
        private System.Windows.Forms.DataGridViewTextBoxColumn llll;
        private Guna.UI2.WinForms.Guna2ContextMenuStrip guna2ContextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem UpdateToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem showCreatedUserDetailsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem showUpdatedUserDetailsToolStripMenuItem1;
    }
}
