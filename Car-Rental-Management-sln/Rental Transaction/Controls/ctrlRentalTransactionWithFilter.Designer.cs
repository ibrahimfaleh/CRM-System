namespace CarRental.Rental_Transaction.Controls
{
    partial class ctrlRentalTransactionWithFilter
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
            this.ctrlRentalTransactionDetails1 = new CarRental.Rental_Transaction.ctrlRentalTransactionDetails();
            this.gbFind = new System.Windows.Forms.GroupBox();
            this.btnFind = new System.Windows.Forms.Button();
            this.cmbFindBy = new Guna.UI2.WinForms.Guna2ComboBox();
            this.txtValue = new Guna.UI2.WinForms.Guna2TextBox();
            this.gbFind.SuspendLayout();
            this.SuspendLayout();
            // 
            // ctrlRentalTransactionDetails1
            // 
            this.ctrlRentalTransactionDetails1.AutoSize = true;
            this.ctrlRentalTransactionDetails1.Location = new System.Drawing.Point(3, 70);
            this.ctrlRentalTransactionDetails1.Name = "ctrlRentalTransactionDetails1";
            this.ctrlRentalTransactionDetails1.Size = new System.Drawing.Size(746, 385);
            this.ctrlRentalTransactionDetails1.TabIndex = 0;
            this.ctrlRentalTransactionDetails1.VehicleEditeVisable = false;
            // 
            // gbFind
            // 
            this.gbFind.Controls.Add(this.btnFind);
            this.gbFind.Controls.Add(this.cmbFindBy);
            this.gbFind.Controls.Add(this.txtValue);
            this.gbFind.Dock = System.Windows.Forms.DockStyle.Top;
            this.gbFind.Location = new System.Drawing.Point(0, 0);
            this.gbFind.Name = "gbFind";
            this.gbFind.Size = new System.Drawing.Size(752, 64);
            this.gbFind.TabIndex = 24;
            this.gbFind.TabStop = false;
            // 
            // btnFind
            // 
            this.btnFind.BackgroundImage = global::CarRental.Properties.Resources.Serch;
            this.btnFind.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnFind.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFind.Location = new System.Drawing.Point(585, 13);
            this.btnFind.Margin = new System.Windows.Forms.Padding(2);
            this.btnFind.Name = "btnFind";
            this.btnFind.Size = new System.Drawing.Size(47, 38);
            this.btnFind.TabIndex = 26;
            this.btnFind.UseVisualStyleBackColor = true;
            this.btnFind.Click += new System.EventHandler(this.btnFind_Click);
            // 
            // cmbFindBy
            // 
            this.cmbFindBy.AutoRoundedCorners = true;
            this.cmbFindBy.BackColor = System.Drawing.Color.Transparent;
            this.cmbFindBy.BorderColor = System.Drawing.Color.Black;
            this.cmbFindBy.BorderRadius = 17;
            this.cmbFindBy.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbFindBy.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbFindBy.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cmbFindBy.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cmbFindBy.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cmbFindBy.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cmbFindBy.ItemHeight = 30;
            this.cmbFindBy.Items.AddRange(new object[] {
            "Transaction ID",
            "Plate Number"});
            this.cmbFindBy.Location = new System.Drawing.Point(358, 14);
            this.cmbFindBy.Name = "cmbFindBy";
            this.cmbFindBy.Size = new System.Drawing.Size(188, 36);
            this.cmbFindBy.StartIndex = 0;
            this.cmbFindBy.TabIndex = 25;
            // 
            // txtValue
            // 
            this.txtValue.AutoRoundedCorners = true;
            this.txtValue.BorderColor = System.Drawing.Color.Black;
            this.txtValue.BorderRadius = 17;
            this.txtValue.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtValue.DefaultText = "";
            this.txtValue.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtValue.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtValue.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtValue.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtValue.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtValue.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtValue.ForeColor = System.Drawing.Color.Black;
            this.txtValue.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtValue.Location = new System.Drawing.Point(120, 14);
            this.txtValue.Name = "txtValue";
            this.txtValue.PasswordChar = '\0';
            this.txtValue.PlaceholderText = "";
            this.txtValue.SelectedText = "";
            this.txtValue.Size = new System.Drawing.Size(200, 36);
            this.txtValue.TabIndex = 24;
            this.txtValue.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtValue_KeyPress);
            // 
            // ctrlRentalTransactionWithFilter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.Controls.Add(this.gbFind);
            this.Controls.Add(this.ctrlRentalTransactionDetails1);
            this.Name = "ctrlRentalTransactionWithFilter";
            this.Size = new System.Drawing.Size(752, 458);
            this.gbFind.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ctrlRentalTransactionDetails ctrlRentalTransactionDetails1;
        private System.Windows.Forms.GroupBox gbFind;
        private System.Windows.Forms.Button btnFind;
        private Guna.UI2.WinForms.Guna2ComboBox cmbFindBy;
        private Guna.UI2.WinForms.Guna2TextBox txtValue;
    }
}
