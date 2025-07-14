namespace CarRental.Bill.Controls
{
    partial class ctrlBillCardWithFilter
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
            this.ctrlBillCard1 = new CarRental.Bill.Controls.ctrlBillCard();
            this.gbSerch = new System.Windows.Forms.GroupBox();
            this.pbAddNew = new System.Windows.Forms.PictureBox();
            this.pbFind = new System.Windows.Forms.PictureBox();
            this.txtSerch = new Guna.UI2.WinForms.Guna2TextBox();
            this.btnReset = new Guna.UI2.WinForms.Guna2Button();
            this.gbSerch.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbAddNew)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbFind)).BeginInit();
            this.SuspendLayout();
            // 
            // ctrlBillCard1
            // 
            this.ctrlBillCard1.AutoSize = true;
            this.ctrlBillCard1.Location = new System.Drawing.Point(3, 81);
            this.ctrlBillCard1.Name = "ctrlBillCard1";
            this.ctrlBillCard1.Size = new System.Drawing.Size(580, 179);
            this.ctrlBillCard1.TabIndex = 0;
            this.ctrlBillCard1.UpdateVisible = false;
            // 
            // gbSerch
            // 
            this.gbSerch.Controls.Add(this.btnReset);
            this.gbSerch.Controls.Add(this.pbAddNew);
            this.gbSerch.Controls.Add(this.pbFind);
            this.gbSerch.Controls.Add(this.txtSerch);
            this.gbSerch.Dock = System.Windows.Forms.DockStyle.Top;
            this.gbSerch.Location = new System.Drawing.Point(0, 0);
            this.gbSerch.Name = "gbSerch";
            this.gbSerch.Size = new System.Drawing.Size(586, 75);
            this.gbSerch.TabIndex = 1;
            this.gbSerch.TabStop = false;
            // 
            // pbAddNew
            // 
            this.pbAddNew.Image = global::CarRental.Properties.Resources.plus;
            this.pbAddNew.Location = new System.Drawing.Point(281, 29);
            this.pbAddNew.Name = "pbAddNew";
            this.pbAddNew.Size = new System.Drawing.Size(34, 26);
            this.pbAddNew.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbAddNew.TabIndex = 6;
            this.pbAddNew.TabStop = false;
            this.pbAddNew.Click += new System.EventHandler(this.pbAddNew_Click);
            // 
            // pbFind
            // 
            this.pbFind.Image = global::CarRental.Properties.Resources.search;
            this.pbFind.Location = new System.Drawing.Point(229, 29);
            this.pbFind.Name = "pbFind";
            this.pbFind.Size = new System.Drawing.Size(34, 26);
            this.pbFind.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbFind.TabIndex = 5;
            this.pbFind.TabStop = false;
            this.pbFind.Click += new System.EventHandler(this.pbFind_Click);
            // 
            // txtSerch
            // 
            this.txtSerch.AutoRoundedCorners = true;
            this.txtSerch.BorderRadius = 13;
            this.txtSerch.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtSerch.DefaultText = "";
            this.txtSerch.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtSerch.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtSerch.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtSerch.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtSerch.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtSerch.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtSerch.ForeColor = System.Drawing.Color.Black;
            this.txtSerch.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtSerch.Location = new System.Drawing.Point(21, 27);
            this.txtSerch.Name = "txtSerch";
            this.txtSerch.PasswordChar = '\0';
            this.txtSerch.PlaceholderText = "";
            this.txtSerch.SelectedText = "";
            this.txtSerch.Size = new System.Drawing.Size(200, 28);
            this.txtSerch.TabIndex = 4;
            this.txtSerch.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSearch_KeyPress);
            // 
            // btnReset
            // 
            this.btnReset.AutoRoundedCorners = true;
            this.btnReset.BorderRadius = 15;
            this.btnReset.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnReset.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnReset.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnReset.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnReset.FillColor = System.Drawing.Color.Black;
            this.btnReset.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnReset.ForeColor = System.Drawing.Color.White;
            this.btnReset.Location = new System.Drawing.Point(454, 27);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(114, 32);
            this.btnReset.TabIndex = 7;
            this.btnReset.Text = "Reset";
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // ctrlBillCardWithFilter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.Controls.Add(this.gbSerch);
            this.Controls.Add(this.ctrlBillCard1);
            this.Name = "ctrlBillCardWithFilter";
            this.Size = new System.Drawing.Size(586, 263);
            this.gbSerch.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbAddNew)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbFind)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ctrlBillCard ctrlBillCard1;
        private System.Windows.Forms.GroupBox gbSerch;
        private System.Windows.Forms.PictureBox pbAddNew;
        private System.Windows.Forms.PictureBox pbFind;
        private Guna.UI2.WinForms.Guna2TextBox txtSerch;
        private Guna.UI2.WinForms.Guna2Button btnReset;
    }
}
