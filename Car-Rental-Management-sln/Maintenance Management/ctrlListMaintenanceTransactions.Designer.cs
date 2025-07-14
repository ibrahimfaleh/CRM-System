namespace CarRental.Maintenance_Management
{
    partial class ctrlListMaintenanceTransactions
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
            this.dgvListMaintenanceTransactions = new Guna.UI2.WinForms.Guna2DataGridView();
            this.guna2ContextMenuStrip1 = new Guna.UI2.WinForms.Guna2ContextMenuStrip();
            this.updateRetuenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.showEmployeeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.showReturnByEmployeeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.showCreatedByUserToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.showUpdatedByUserToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label2 = new System.Windows.Forms.Label();
            this.lblRecordsCount = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabTotalMaintenanceFees = new System.Windows.Forms.TabPage();
            this.txtToMaintenanceFees = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cbMaintenanceFees = new System.Windows.Forms.CheckBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtFromMaintenanceFees = new System.Windows.Forms.TextBox();
            this.tabNumberTimesOfMaintenance = new System.Windows.Forms.TabPage();
            this.cbNumberMaintenance = new System.Windows.Forms.CheckBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.nudToNumberMaintenance = new Guna.UI2.WinForms.Guna2NumericUpDown();
            this.nudFromNumberMaintenance = new Guna.UI2.WinForms.Guna2NumericUpDown();
            this.tabStatus = new System.Windows.Forms.TabPage();
            this.cmbStatus = new Guna.UI2.WinForms.Guna2ComboBox();
            this.lblTitleActive = new System.Windows.Forms.Label();
            this.tabStartDate = new System.Windows.Forms.TabPage();
            this.cbStartDate = new System.Windows.Forms.CheckBox();
            this.dtpToStartDate = new System.Windows.Forms.DateTimePicker();
            this.dtpFromStartDate = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.cbFilterBy = new Guna.UI2.WinForms.Guna2ComboBox();
            this.txtFilterValue = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListMaintenanceTransactions)).BeginInit();
            this.guna2ContextMenuStrip1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabTotalMaintenanceFees.SuspendLayout();
            this.tabNumberTimesOfMaintenance.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudToNumberMaintenance)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudFromNumberMaintenance)).BeginInit();
            this.tabStatus.SuspendLayout();
            this.tabStartDate.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvListMaintenanceTransactions
            // 
            this.dgvListMaintenanceTransactions.AllowUserToAddRows = false;
            this.dgvListMaintenanceTransactions.AllowUserToDeleteRows = false;
            this.dgvListMaintenanceTransactions.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black;
            this.dgvListMaintenanceTransactions.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvListMaintenanceTransactions.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvListMaintenanceTransactions.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.None;
            this.dgvListMaintenanceTransactions.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvListMaintenanceTransactions.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvListMaintenanceTransactions.ColumnHeadersHeight = 44;
            this.dgvListMaintenanceTransactions.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dgvListMaintenanceTransactions.ContextMenuStrip = this.guna2ContextMenuStrip1;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvListMaintenanceTransactions.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvListMaintenanceTransactions.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvListMaintenanceTransactions.Location = new System.Drawing.Point(2, 89);
            this.dgvListMaintenanceTransactions.Margin = new System.Windows.Forms.Padding(2);
            this.dgvListMaintenanceTransactions.Name = "dgvListMaintenanceTransactions";
            this.dgvListMaintenanceTransactions.ReadOnly = true;
            this.dgvListMaintenanceTransactions.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvListMaintenanceTransactions.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvListMaintenanceTransactions.RowHeadersVisible = false;
            this.dgvListMaintenanceTransactions.RowHeadersWidth = 51;
            this.dgvListMaintenanceTransactions.RowTemplate.Height = 29;
            this.dgvListMaintenanceTransactions.Size = new System.Drawing.Size(1342, 243);
            this.dgvListMaintenanceTransactions.TabIndex = 265;
            this.dgvListMaintenanceTransactions.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvListMaintenanceTransactions.ThemeStyle.AlternatingRowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dgvListMaintenanceTransactions.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Black;
            this.dgvListMaintenanceTransactions.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvListMaintenanceTransactions.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dgvListMaintenanceTransactions.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.dgvListMaintenanceTransactions.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvListMaintenanceTransactions.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.Black;
            this.dgvListMaintenanceTransactions.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvListMaintenanceTransactions.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dgvListMaintenanceTransactions.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dgvListMaintenanceTransactions.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dgvListMaintenanceTransactions.ThemeStyle.HeaderStyle.Height = 44;
            this.dgvListMaintenanceTransactions.ThemeStyle.ReadOnly = true;
            this.dgvListMaintenanceTransactions.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvListMaintenanceTransactions.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvListMaintenanceTransactions.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dgvListMaintenanceTransactions.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dgvListMaintenanceTransactions.ThemeStyle.RowsStyle.Height = 29;
            this.dgvListMaintenanceTransactions.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvListMaintenanceTransactions.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            // 
            // guna2ContextMenuStrip1
            // 
            this.guna2ContextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.guna2ContextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.updateRetuenToolStripMenuItem,
            this.showEmployeeToolStripMenuItem,
            this.showReturnByEmployeeToolStripMenuItem,
            this.showCreatedByUserToolStripMenuItem,
            this.showUpdatedByUserToolStripMenuItem});
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
            this.guna2ContextMenuStrip1.Size = new System.Drawing.Size(236, 114);
            this.guna2ContextMenuStrip1.Opening += new System.ComponentModel.CancelEventHandler(this.guna2ContextMenuStrip1_Opening);
            // 
            // updateRetuenToolStripMenuItem
            // 
            this.updateRetuenToolStripMenuItem.Name = "updateRetuenToolStripMenuItem";
            this.updateRetuenToolStripMenuItem.Size = new System.Drawing.Size(235, 22);
            this.updateRetuenToolStripMenuItem.Text = "Update & Retuen";
            this.updateRetuenToolStripMenuItem.Click += new System.EventHandler(this.updateRetuenToolStripMenuItem_Click);
            // 
            // showEmployeeToolStripMenuItem
            // 
            this.showEmployeeToolStripMenuItem.Name = "showEmployeeToolStripMenuItem";
            this.showEmployeeToolStripMenuItem.Size = new System.Drawing.Size(235, 22);
            this.showEmployeeToolStripMenuItem.Text = "Show Transferred By Employee";
            this.showEmployeeToolStripMenuItem.Click += new System.EventHandler(this.showEmployeeToolStripMenuItem_Click);
            // 
            // showReturnByEmployeeToolStripMenuItem
            // 
            this.showReturnByEmployeeToolStripMenuItem.Name = "showReturnByEmployeeToolStripMenuItem";
            this.showReturnByEmployeeToolStripMenuItem.Size = new System.Drawing.Size(235, 22);
            this.showReturnByEmployeeToolStripMenuItem.Text = "Show Return By Employee";
            // 
            // showCreatedByUserToolStripMenuItem
            // 
            this.showCreatedByUserToolStripMenuItem.Name = "showCreatedByUserToolStripMenuItem";
            this.showCreatedByUserToolStripMenuItem.Size = new System.Drawing.Size(235, 22);
            this.showCreatedByUserToolStripMenuItem.Text = "Show Created By User";
            this.showCreatedByUserToolStripMenuItem.Click += new System.EventHandler(this.showCreatedByUserToolStripMenuItem_Click);
            // 
            // showUpdatedByUserToolStripMenuItem
            // 
            this.showUpdatedByUserToolStripMenuItem.Name = "showUpdatedByUserToolStripMenuItem";
            this.showUpdatedByUserToolStripMenuItem.Size = new System.Drawing.Size(235, 22);
            this.showUpdatedByUserToolStripMenuItem.Text = "Show Updated By User";
            this.showUpdatedByUserToolStripMenuItem.Click += new System.EventHandler(this.showUpdatedByUserToolStripMenuItem_Click);
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Tai Le", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(5, 333);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(102, 23);
            this.label2.TabIndex = 270;
            this.label2.Text = "# Records:";
            // 
            // lblRecordsCount
            // 
            this.lblRecordsCount.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblRecordsCount.AutoSize = true;
            this.lblRecordsCount.Font = new System.Drawing.Font("Microsoft Tai Le", 10.8F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRecordsCount.ForeColor = System.Drawing.Color.Black;
            this.lblRecordsCount.Location = new System.Drawing.Point(104, 336);
            this.lblRecordsCount.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblRecordsCount.Name = "lblRecordsCount";
            this.lblRecordsCount.Size = new System.Drawing.Size(133, 19);
            this.lblRecordsCount.TabIndex = 269;
            this.lblRecordsCount.Text = "Add Update Check";
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Controls.Add(this.tabTotalMaintenanceFees);
            this.tabControl1.Controls.Add(this.tabNumberTimesOfMaintenance);
            this.tabControl1.Controls.Add(this.tabStatus);
            this.tabControl1.Controls.Add(this.tabStartDate);
            this.tabControl1.Location = new System.Drawing.Point(902, 6);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(442, 78);
            this.tabControl1.TabIndex = 271;
            // 
            // tabTotalMaintenanceFees
            // 
            this.tabTotalMaintenanceFees.Controls.Add(this.txtToMaintenanceFees);
            this.tabTotalMaintenanceFees.Controls.Add(this.label3);
            this.tabTotalMaintenanceFees.Controls.Add(this.cbMaintenanceFees);
            this.tabTotalMaintenanceFees.Controls.Add(this.label4);
            this.tabTotalMaintenanceFees.Controls.Add(this.txtFromMaintenanceFees);
            this.tabTotalMaintenanceFees.Location = new System.Drawing.Point(4, 22);
            this.tabTotalMaintenanceFees.Name = "tabTotalMaintenanceFees";
            this.tabTotalMaintenanceFees.Padding = new System.Windows.Forms.Padding(3);
            this.tabTotalMaintenanceFees.Size = new System.Drawing.Size(434, 52);
            this.tabTotalMaintenanceFees.TabIndex = 1;
            this.tabTotalMaintenanceFees.Text = "Maintenance Fees";
            this.tabTotalMaintenanceFees.UseVisualStyleBackColor = true;
            // 
            // txtToMaintenanceFees
            // 
            this.txtToMaintenanceFees.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtToMaintenanceFees.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtToMaintenanceFees.ForeColor = System.Drawing.Color.Black;
            this.txtToMaintenanceFees.Location = new System.Drawing.Point(223, 13);
            this.txtToMaintenanceFees.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtToMaintenanceFees.Multiline = true;
            this.txtToMaintenanceFees.Name = "txtToMaintenanceFees";
            this.txtToMaintenanceFees.Size = new System.Drawing.Size(138, 30);
            this.txtToMaintenanceFees.TabIndex = 246;
            this.txtToMaintenanceFees.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtToMaintenanceFees.TextChanged += new System.EventHandler(this.txtFilterValue_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(189, 20);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(33, 17);
            this.label3.TabIndex = 244;
            this.label3.Text = "To :";
            // 
            // cbMaintenanceFees
            // 
            this.cbMaintenanceFees.AutoSize = true;
            this.cbMaintenanceFees.Checked = true;
            this.cbMaintenanceFees.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbMaintenanceFees.ForeColor = System.Drawing.Color.Black;
            this.cbMaintenanceFees.Location = new System.Drawing.Point(367, 21);
            this.cbMaintenanceFees.Name = "cbMaintenanceFees";
            this.cbMaintenanceFees.Size = new System.Drawing.Size(37, 17);
            this.cbMaintenanceFees.TabIndex = 245;
            this.cbMaintenanceFees.Text = "All";
            this.cbMaintenanceFees.UseVisualStyleBackColor = true;
            this.cbMaintenanceFees.CheckedChanged += new System.EventHandler(this.cbMaintenanceFees_CheckedChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(11, 20);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 17);
            this.label4.TabIndex = 245;
            this.label4.Text = "From ";
            // 
            // txtFromMaintenanceFees
            // 
            this.txtFromMaintenanceFees.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtFromMaintenanceFees.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtFromMaintenanceFees.ForeColor = System.Drawing.Color.Black;
            this.txtFromMaintenanceFees.Location = new System.Drawing.Point(60, 13);
            this.txtFromMaintenanceFees.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtFromMaintenanceFees.Multiline = true;
            this.txtFromMaintenanceFees.Name = "txtFromMaintenanceFees";
            this.txtFromMaintenanceFees.Size = new System.Drawing.Size(125, 30);
            this.txtFromMaintenanceFees.TabIndex = 160;
            this.txtFromMaintenanceFees.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtFromMaintenanceFees.TextChanged += new System.EventHandler(this.txtFilterValue_TextChanged);
            // 
            // tabNumberTimesOfMaintenance
            // 
            this.tabNumberTimesOfMaintenance.Controls.Add(this.cbNumberMaintenance);
            this.tabNumberTimesOfMaintenance.Controls.Add(this.label9);
            this.tabNumberTimesOfMaintenance.Controls.Add(this.label10);
            this.tabNumberTimesOfMaintenance.Controls.Add(this.nudToNumberMaintenance);
            this.tabNumberTimesOfMaintenance.Controls.Add(this.nudFromNumberMaintenance);
            this.tabNumberTimesOfMaintenance.Location = new System.Drawing.Point(4, 22);
            this.tabNumberTimesOfMaintenance.Name = "tabNumberTimesOfMaintenance";
            this.tabNumberTimesOfMaintenance.Size = new System.Drawing.Size(434, 52);
            this.tabNumberTimesOfMaintenance.TabIndex = 4;
            this.tabNumberTimesOfMaintenance.Text = "Number Times Of Maintenance";
            this.tabNumberTimesOfMaintenance.UseVisualStyleBackColor = true;
            // 
            // cbNumberMaintenance
            // 
            this.cbNumberMaintenance.AutoSize = true;
            this.cbNumberMaintenance.Checked = true;
            this.cbNumberMaintenance.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbNumberMaintenance.Location = new System.Drawing.Point(395, 21);
            this.cbNumberMaintenance.Name = "cbNumberMaintenance";
            this.cbNumberMaintenance.Size = new System.Drawing.Size(37, 17);
            this.cbNumberMaintenance.TabIndex = 260;
            this.cbNumberMaintenance.Text = "Of";
            this.cbNumberMaintenance.UseVisualStyleBackColor = true;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label9.ForeColor = System.Drawing.Color.Black;
            this.label9.Location = new System.Drawing.Point(207, 20);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(33, 17);
            this.label9.TabIndex = 258;
            this.label9.Text = "To :";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label10.ForeColor = System.Drawing.Color.Black;
            this.label10.Location = new System.Drawing.Point(3, 20);
            this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(48, 17);
            this.label10.TabIndex = 259;
            this.label10.Text = "From :";
            // 
            // nudToNumberMaintenance
            // 
            this.nudToNumberMaintenance.BackColor = System.Drawing.Color.Transparent;
            this.nudToNumberMaintenance.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.nudToNumberMaintenance.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.nudToNumberMaintenance.Location = new System.Drawing.Point(243, 15);
            this.nudToNumberMaintenance.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.nudToNumberMaintenance.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.nudToNumberMaintenance.Name = "nudToNumberMaintenance";
            this.nudToNumberMaintenance.Size = new System.Drawing.Size(147, 27);
            this.nudToNumberMaintenance.TabIndex = 257;
            // 
            // nudFromNumberMaintenance
            // 
            this.nudFromNumberMaintenance.BackColor = System.Drawing.Color.Transparent;
            this.nudFromNumberMaintenance.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.nudFromNumberMaintenance.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.nudFromNumberMaintenance.Location = new System.Drawing.Point(52, 15);
            this.nudFromNumberMaintenance.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.nudFromNumberMaintenance.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.nudFromNumberMaintenance.Name = "nudFromNumberMaintenance";
            this.nudFromNumberMaintenance.Size = new System.Drawing.Size(147, 27);
            this.nudFromNumberMaintenance.TabIndex = 256;
            // 
            // tabStatus
            // 
            this.tabStatus.Controls.Add(this.cmbStatus);
            this.tabStatus.Controls.Add(this.lblTitleActive);
            this.tabStatus.Location = new System.Drawing.Point(4, 22);
            this.tabStatus.Margin = new System.Windows.Forms.Padding(2);
            this.tabStatus.Name = "tabStatus";
            this.tabStatus.Size = new System.Drawing.Size(434, 52);
            this.tabStatus.TabIndex = 7;
            this.tabStatus.Text = "Status";
            this.tabStatus.UseVisualStyleBackColor = true;
            // 
            // cmbStatus
            // 
            this.cmbStatus.BackColor = System.Drawing.Color.Transparent;
            this.cmbStatus.BorderColor = System.Drawing.Color.Black;
            this.cmbStatus.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbStatus.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cmbStatus.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cmbStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F);
            this.cmbStatus.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cmbStatus.ItemHeight = 30;
            this.cmbStatus.Items.AddRange(new object[] {
            "All",
            "New",
            "Completed"});
            this.cmbStatus.Location = new System.Drawing.Point(124, 10);
            this.cmbStatus.Margin = new System.Windows.Forms.Padding(2);
            this.cmbStatus.Name = "cmbStatus";
            this.cmbStatus.Size = new System.Drawing.Size(158, 36);
            this.cmbStatus.TabIndex = 111;
            this.cmbStatus.SelectedIndexChanged += new System.EventHandler(this.cmbStatus_SelectedIndexChanged);
            // 
            // lblTitleActive
            // 
            this.lblTitleActive.AutoSize = true;
            this.lblTitleActive.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblTitleActive.ForeColor = System.Drawing.Color.Black;
            this.lblTitleActive.Location = new System.Drawing.Point(70, 16);
            this.lblTitleActive.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTitleActive.Name = "lblTitleActive";
            this.lblTitleActive.Size = new System.Drawing.Size(56, 17);
            this.lblTitleActive.TabIndex = 107;
            this.lblTitleActive.Text = "Status :";
            // 
            // tabStartDate
            // 
            this.tabStartDate.Controls.Add(this.cbStartDate);
            this.tabStartDate.Controls.Add(this.dtpToStartDate);
            this.tabStartDate.Controls.Add(this.dtpFromStartDate);
            this.tabStartDate.Controls.Add(this.label6);
            this.tabStartDate.Controls.Add(this.label7);
            this.tabStartDate.Location = new System.Drawing.Point(4, 22);
            this.tabStartDate.Margin = new System.Windows.Forms.Padding(2);
            this.tabStartDate.Name = "tabStartDate";
            this.tabStartDate.Size = new System.Drawing.Size(434, 52);
            this.tabStartDate.TabIndex = 9;
            this.tabStartDate.Text = "Start Date";
            this.tabStartDate.UseVisualStyleBackColor = true;
            // 
            // cbStartDate
            // 
            this.cbStartDate.AutoSize = true;
            this.cbStartDate.Checked = true;
            this.cbStartDate.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbStartDate.Location = new System.Drawing.Point(377, 20);
            this.cbStartDate.Name = "cbStartDate";
            this.cbStartDate.Size = new System.Drawing.Size(37, 17);
            this.cbStartDate.TabIndex = 259;
            this.cbStartDate.Text = "Of";
            this.cbStartDate.UseVisualStyleBackColor = true;
            this.cbStartDate.CheckedChanged += new System.EventHandler(this.cbStartDate_CheckedChanged);
            // 
            // dtpToStartDate
            // 
            this.dtpToStartDate.CustomFormat = "yyyy";
            this.dtpToStartDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpToStartDate.Location = new System.Drawing.Point(261, 19);
            this.dtpToStartDate.Margin = new System.Windows.Forms.Padding(2);
            this.dtpToStartDate.MinDate = new System.DateTime(1990, 12, 25, 0, 0, 0, 0);
            this.dtpToStartDate.Name = "dtpToStartDate";
            this.dtpToStartDate.ShowUpDown = true;
            this.dtpToStartDate.Size = new System.Drawing.Size(112, 20);
            this.dtpToStartDate.TabIndex = 258;
            this.dtpToStartDate.Value = new System.DateTime(2024, 3, 16, 0, 0, 0, 0);
            this.dtpToStartDate.ValueChanged += new System.EventHandler(this.dtpToStartDate_ValueChanged);
            // 
            // dtpFromStartDate
            // 
            this.dtpFromStartDate.CustomFormat = "yyyy";
            this.dtpFromStartDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFromStartDate.Location = new System.Drawing.Point(92, 18);
            this.dtpFromStartDate.Margin = new System.Windows.Forms.Padding(2);
            this.dtpFromStartDate.MinDate = new System.DateTime(1990, 12, 25, 0, 0, 0, 0);
            this.dtpFromStartDate.Name = "dtpFromStartDate";
            this.dtpFromStartDate.ShowUpDown = true;
            this.dtpFromStartDate.Size = new System.Drawing.Size(112, 20);
            this.dtpFromStartDate.TabIndex = 257;
            this.dtpFromStartDate.Value = new System.DateTime(2024, 3, 16, 0, 0, 0, 0);
            this.dtpFromStartDate.ValueChanged += new System.EventHandler(this.dtpFromStartDate_ValueChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(219, 20);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(29, 17);
            this.label6.TabIndex = 255;
            this.label6.Text = "To ";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(30, 19);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(44, 17);
            this.label7.TabIndex = 256;
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
            "Vehicle ID",
            "Plate Number",
            "Transferred By Employee ID",
            "Transferred By Employee NationalNo",
            "Return By EmployeeID",
            "Return By Employee NationalNo",
            "Created By User ID",
            "Created By User NationalNo",
            "Updated By User ID",
            "Updated By User NationalNo"});
            this.cbFilterBy.Location = new System.Drawing.Point(72, 48);
            this.cbFilterBy.Margin = new System.Windows.Forms.Padding(2);
            this.cbFilterBy.Name = "cbFilterBy";
            this.cbFilterBy.Size = new System.Drawing.Size(308, 36);
            this.cbFilterBy.StartIndex = 0;
            this.cbFilterBy.TabIndex = 274;
            this.cbFilterBy.SelectedIndexChanged += new System.EventHandler(this.cbFilterBy_SelectedIndexChanged);
            // 
            // txtFilterValue
            // 
            this.txtFilterValue.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtFilterValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtFilterValue.Location = new System.Drawing.Point(384, 48);
            this.txtFilterValue.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtFilterValue.Multiline = true;
            this.txtFilterValue.Name = "txtFilterValue";
            this.txtFilterValue.Size = new System.Drawing.Size(206, 30);
            this.txtFilterValue.TabIndex = 273;
            this.txtFilterValue.Visible = false;
            this.txtFilterValue.TextChanged += new System.EventHandler(this.txtFilterValue_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(8, 53);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(63, 17);
            this.label5.TabIndex = 272;
            this.label5.Text = "Filter By:";
            // 
            // ctrlListMaintenanceTransactions
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.cbFilterBy);
            this.Controls.Add(this.txtFilterValue);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.dgvListMaintenanceTransactions);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblRecordsCount);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "ctrlListMaintenanceTransactions";
            this.Size = new System.Drawing.Size(1351, 357);
            this.Load += new System.EventHandler(this.ctrlListMaintenanceTransactions_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvListMaintenanceTransactions)).EndInit();
            this.guna2ContextMenuStrip1.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.tabTotalMaintenanceFees.ResumeLayout(false);
            this.tabTotalMaintenanceFees.PerformLayout();
            this.tabNumberTimesOfMaintenance.ResumeLayout(false);
            this.tabNumberTimesOfMaintenance.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudToNumberMaintenance)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudFromNumberMaintenance)).EndInit();
            this.tabStatus.ResumeLayout(false);
            this.tabStatus.PerformLayout();
            this.tabStartDate.ResumeLayout(false);
            this.tabStartDate.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2DataGridView dgvListMaintenanceTransactions;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblRecordsCount;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabTotalMaintenanceFees;
        private System.Windows.Forms.TextBox txtToMaintenanceFees;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckBox cbMaintenanceFees;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtFromMaintenanceFees;
        private System.Windows.Forms.TabPage tabNumberTimesOfMaintenance;
        private System.Windows.Forms.CheckBox cbNumberMaintenance;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private Guna.UI2.WinForms.Guna2NumericUpDown nudToNumberMaintenance;
        private Guna.UI2.WinForms.Guna2NumericUpDown nudFromNumberMaintenance;
        private System.Windows.Forms.TabPage tabStatus;
        private Guna.UI2.WinForms.Guna2ComboBox cmbStatus;
        private System.Windows.Forms.Label lblTitleActive;
        private Guna.UI2.WinForms.Guna2ComboBox cbFilterBy;
        private System.Windows.Forms.TextBox txtFilterValue;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TabPage tabStartDate;
        private System.Windows.Forms.DateTimePicker dtpToStartDate;
        private System.Windows.Forms.DateTimePicker dtpFromStartDate;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.CheckBox cbStartDate;
        private Guna.UI2.WinForms.Guna2ContextMenuStrip guna2ContextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem updateRetuenToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem showEmployeeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem showReturnByEmployeeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem showCreatedByUserToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem showUpdatedByUserToolStripMenuItem;
    }
}
