namespace CarRental.Bill.Controls
{
    partial class ctrlBillCard
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
            this.pbBillImage = new System.Windows.Forms.PictureBox();
            this.txtDetails = new Guna.UI2.WinForms.Guna2TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.llBillID = new System.Windows.Forms.LinkLabel();
            this.label2 = new System.Windows.Forms.Label();
            this.llUpdate = new System.Windows.Forms.LinkLabel();
            this.lblCost = new System.Windows.Forms.Label();
            this.lblType = new System.Windows.Forms.Label();
            this.lblCreatedDate = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lblUpdatedDate = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.lblStatus = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pbBillImage)).BeginInit();
            this.SuspendLayout();
            // 
            // pbBillImage
            // 
            this.pbBillImage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pbBillImage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbBillImage.Image = global::CarRental.Properties.Resources.bill;
            this.pbBillImage.InitialImage = null;
            this.pbBillImage.Location = new System.Drawing.Point(498, 53);
            this.pbBillImage.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pbBillImage.Name = "pbBillImage";
            this.pbBillImage.Size = new System.Drawing.Size(127, 122);
            this.pbBillImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbBillImage.TabIndex = 125;
            this.pbBillImage.TabStop = false;
            this.pbBillImage.Click += new System.EventHandler(this.pbBillImage_Click);
            // 
            // txtDetails
            // 
            this.txtDetails.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtDetails.DefaultText = "";
            this.txtDetails.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtDetails.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtDetails.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtDetails.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtDetails.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtDetails.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtDetails.ForeColor = System.Drawing.Color.Black;
            this.txtDetails.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtDetails.Location = new System.Drawing.Point(83, 99);
            this.txtDetails.MaxLength = 250;
            this.txtDetails.Multiline = true;
            this.txtDetails.Name = "txtDetails";
            this.txtDetails.PasswordChar = '\0';
            this.txtDetails.PlaceholderText = "";
            this.txtDetails.ReadOnly = true;
            this.txtDetails.SelectedText = "";
            this.txtDetails.Size = new System.Drawing.Size(340, 76);
            this.txtDetails.TabIndex = 122;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(183, 48);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 18);
            this.label4.TabIndex = 120;
            this.label4.Text = "Type :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(3, 119);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 18);
            this.label3.TabIndex = 119;
            this.label3.Text = "Details :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(19, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 18);
            this.label1.TabIndex = 118;
            this.label1.Text = "Cost :";
            // 
            // llBillID
            // 
            this.llBillID.AutoSize = true;
            this.llBillID.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.llBillID.Location = new System.Drawing.Point(81, 3);
            this.llBillID.Name = "llBillID";
            this.llBillID.Size = new System.Drawing.Size(68, 16);
            this.llBillID.TabIndex = 117;
            this.llBillID.TabStop = true;
            this.llBillID.Text = "linkLabel1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(11, 2);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 18);
            this.label2.TabIndex = 116;
            this.label2.Text = "Bill ID :";
            // 
            // llUpdate
            // 
            this.llUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.llUpdate.Location = new System.Drawing.Point(498, 33);
            this.llUpdate.Name = "llUpdate";
            this.llUpdate.Size = new System.Drawing.Size(127, 16);
            this.llUpdate.TabIndex = 126;
            this.llUpdate.TabStop = true;
            this.llUpdate.Text = "Update";
            this.llUpdate.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.llUpdate.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.llUpdate_LinkClicked);
            // 
            // lblCost
            // 
            this.lblCost.AutoSize = true;
            this.lblCost.Location = new System.Drawing.Point(79, 52);
            this.lblCost.Name = "lblCost";
            this.lblCost.Size = new System.Drawing.Size(35, 13);
            this.lblCost.TabIndex = 127;
            this.lblCost.Text = "label5";
            // 
            // lblType
            // 
            this.lblType.AutoSize = true;
            this.lblType.Location = new System.Drawing.Point(243, 53);
            this.lblType.Name = "lblType";
            this.lblType.Size = new System.Drawing.Size(35, 13);
            this.lblType.TabIndex = 128;
            this.lblType.Text = "label6";
            // 
            // lblCreatedDate
            // 
            this.lblCreatedDate.AutoSize = true;
            this.lblCreatedDate.Location = new System.Drawing.Point(306, 7);
            this.lblCreatedDate.Name = "lblCreatedDate";
            this.lblCreatedDate.Size = new System.Drawing.Size(35, 13);
            this.lblCreatedDate.TabIndex = 130;
            this.lblCreatedDate.Text = "label6";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(183, 3);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(117, 18);
            this.label6.TabIndex = 129;
            this.label6.Text = "Created Date :";
            // 
            // lblUpdatedDate
            // 
            this.lblUpdatedDate.AutoSize = true;
            this.lblUpdatedDate.Location = new System.Drawing.Point(538, 7);
            this.lblUpdatedDate.Name = "lblUpdatedDate";
            this.lblUpdatedDate.Size = new System.Drawing.Size(35, 13);
            this.lblUpdatedDate.TabIndex = 132;
            this.lblUpdatedDate.Text = "label6";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label8.Location = new System.Drawing.Point(409, 3);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(120, 18);
            this.label8.TabIndex = 131;
            this.label8.Text = "Updated Date :";
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Location = new System.Drawing.Point(371, 83);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(35, 13);
            this.lblStatus.TabIndex = 134;
            this.lblStatus.Text = "label6";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.Location = new System.Drawing.Point(302, 78);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(66, 18);
            this.label7.TabIndex = 133;
            this.label7.Text = "Status :";
            // 
            // ctrlBillCard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.lblUpdatedDate);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.lblCreatedDate);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.lblType);
            this.Controls.Add(this.lblCost);
            this.Controls.Add(this.llUpdate);
            this.Controls.Add(this.pbBillImage);
            this.Controls.Add(this.txtDetails);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.llBillID);
            this.Controls.Add(this.label2);
            this.Name = "ctrlBillCard";
            this.Size = new System.Drawing.Size(629, 179);
            ((System.ComponentModel.ISupportInitialize)(this.pbBillImage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox pbBillImage;
        private Guna.UI2.WinForms.Guna2TextBox txtDetails;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.LinkLabel llBillID;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.LinkLabel llUpdate;
        private System.Windows.Forms.Label lblCost;
        private System.Windows.Forms.Label lblType;
        private System.Windows.Forms.Label lblCreatedDate;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblUpdatedDate;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.Label label7;
    }
}
