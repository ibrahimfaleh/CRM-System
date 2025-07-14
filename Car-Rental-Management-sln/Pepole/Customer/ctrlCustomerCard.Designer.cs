namespace CarRental
{
    partial class ctrlCustomerCard
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
            this.label1 = new System.Windows.Forms.Label();
            this.lblDriverLicenseNumber = new System.Windows.Forms.Label();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblCustomerID = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.ctrlPersoneCard1 = new CarRental.ctrlPersonCard();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(33, 278);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(173, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Driver License Number :";
            // 
            // lblDriverLicenseNumber
            // 
            this.lblDriverLicenseNumber.AutoSize = true;
            this.lblDriverLicenseNumber.Location = new System.Drawing.Point(247, 278);
            this.lblDriverLicenseNumber.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDriverLicenseNumber.Name = "lblDriverLicenseNumber";
            this.lblDriverLicenseNumber.Size = new System.Drawing.Size(121, 13);
            this.lblDriverLicenseNumber.TabIndex = 2;
            this.lblDriverLicenseNumber.Text = "Driver License Number :";
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::CarRental.Properties.Resources.Lost_Driving_License_32;
            this.pictureBox3.Location = new System.Drawing.Point(210, 274);
            this.pictureBox3.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(23, 21);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 147;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::CarRental.Properties.Resources.Number_32;
            this.pictureBox1.Location = new System.Drawing.Point(471, 274);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(23, 21);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 150;
            this.pictureBox1.TabStop = false;
            // 
            // lblCustomerID
            // 
            this.lblCustomerID.AutoSize = true;
            this.lblCustomerID.Location = new System.Drawing.Point(498, 278);
            this.lblCustomerID.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCustomerID.Name = "lblCustomerID";
            this.lblCustomerID.Size = new System.Drawing.Size(121, 13);
            this.lblCustomerID.TabIndex = 149;
            this.lblCustomerID.Text = "Driver License Number :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(374, 278);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(91, 16);
            this.label3.TabIndex = 148;
            this.label3.Text = "Customer ID";
            // 
            // ctrlPersoneCard1
            // 
            this.ctrlPersoneCard1.BackColor = System.Drawing.Color.White;
            this.ctrlPersoneCard1.EditedVisible = true;
            this.ctrlPersoneCard1.Location = new System.Drawing.Point(2, 2);
            this.ctrlPersoneCard1.Margin = new System.Windows.Forms.Padding(2);
            this.ctrlPersoneCard1.Name = "ctrlPersoneCard1";
            this.ctrlPersoneCard1.Size = new System.Drawing.Size(621, 268);
            this.ctrlPersoneCard1.TabIndex = 0;
            this.ctrlPersoneCard1.Load += new System.EventHandler(this.ctrlPersoneCard1_Load);
            // 
            // ctrlCustomerCard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lblCustomerID);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.lblDriverLicenseNumber);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ctrlPersoneCard1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "ctrlCustomerCard";
            this.Size = new System.Drawing.Size(632, 320);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ctrlPersonCard ctrlPersoneCard1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblDriverLicenseNumber;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblCustomerID;
        private System.Windows.Forms.Label label3;
    }
}
