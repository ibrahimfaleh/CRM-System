namespace CarRental.Customers
{
    partial class frmShowCustomerInfo
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
            this.btnClose = new Guna.UI2.WinForms.Guna2Button();
            this.lable = new System.Windows.Forms.Label();
            this.ctrlDgvListTransactions1 = new CarRental.Rental_Transaction.ctrlDgvListTransactions();
            this.ctrlCustomerCard1 = new CarRental.ctrlCustomerCard();
            this.lblTotalVehiclesBreakdownPayments = new System.Windows.Forms.Label();
            this.lblTotalPayments = new System.Windows.Forms.Label();
            this.lblTotalRentPayments = new System.Windows.Forms.Label();
            this.lblKl = new System.Windows.Forms.Label();
            this.lblDays = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox12 = new System.Windows.Forms.PictureBox();
            this.pictureBox11 = new System.Windows.Forms.PictureBox();
            this.pictureBox9 = new System.Windows.Forms.PictureBox();
            this.lblNumberOfRented = new System.Windows.Forms.Label();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox12)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox11)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox9)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.Black;
            this.btnClose.BorderColor = System.Drawing.Color.White;
            this.btnClose.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnClose.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnClose.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnClose.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnClose.FillColor = System.Drawing.Color.Black;
            this.btnClose.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnClose.ForeColor = System.Drawing.Color.White;
            this.btnClose.Location = new System.Drawing.Point(1291, 361);
            this.btnClose.Margin = new System.Windows.Forms.Padding(2);
            this.btnClose.Name = "btnClose";
            this.btnClose.PressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnClose.Size = new System.Drawing.Size(107, 33);
            this.btnClose.TabIndex = 144;
            this.btnClose.Text = "Close";
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // lable
            // 
            this.lable.Dock = System.Windows.Forms.DockStyle.Top;
            this.lable.Font = new System.Drawing.Font("Microsoft Tai Le", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lable.ForeColor = System.Drawing.Color.Black;
            this.lable.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.lable.Location = new System.Drawing.Point(0, 0);
            this.lable.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lable.Name = "lable";
            this.lable.Size = new System.Drawing.Size(1409, 54);
            this.lable.TabIndex = 148;
            this.lable.Text = "Customer Info";
            this.lable.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ctrlDgvListTransactions1
            // 
            this.ctrlDgvListTransactions1.AutoSize = true;
            this.ctrlDgvListTransactions1.BackColor = System.Drawing.Color.White;
            this.ctrlDgvListTransactions1.Location = new System.Drawing.Point(11, 398);
            this.ctrlDgvListTransactions1.Margin = new System.Windows.Forms.Padding(2);
            this.ctrlDgvListTransactions1.Name = "ctrlDgvListTransactions1";
            this.ctrlDgvListTransactions1.ShowCreatedByUserIDVisible = true;
            this.ctrlDgvListTransactions1.ShowCustomerVisible = true;
            this.ctrlDgvListTransactions1.ShowUpdatedByUserIDVisible = true;
            this.ctrlDgvListTransactions1.Size = new System.Drawing.Size(1393, 318);
            this.ctrlDgvListTransactions1.TabIndex = 150;
            // 
            // ctrlCustomerCard1
            // 
            this.ctrlCustomerCard1.BackColor = System.Drawing.Color.White;
            this.ctrlCustomerCard1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ctrlCustomerCard1.EditedVisible = true;
            this.ctrlCustomerCard1.Location = new System.Drawing.Point(9, 85);
            this.ctrlCustomerCard1.Margin = new System.Windows.Forms.Padding(2);
            this.ctrlCustomerCard1.Name = "ctrlCustomerCard1";
            this.ctrlCustomerCard1.Size = new System.Drawing.Size(632, 309);
            this.ctrlCustomerCard1.TabIndex = 151;
            // 
            // lblTotalVehiclesBreakdownPayments
            // 
            this.lblTotalVehiclesBreakdownPayments.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblTotalVehiclesBreakdownPayments.Location = new System.Drawing.Point(740, 354);
            this.lblTotalVehiclesBreakdownPayments.Name = "lblTotalVehiclesBreakdownPayments";
            this.lblTotalVehiclesBreakdownPayments.Size = new System.Drawing.Size(122, 23);
            this.lblTotalVehiclesBreakdownPayments.TabIndex = 155;
            this.lblTotalVehiclesBreakdownPayments.Text = "label1";
            this.lblTotalVehiclesBreakdownPayments.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblTotalPayments
            // 
            this.lblTotalPayments.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblTotalPayments.Location = new System.Drawing.Point(1143, 354);
            this.lblTotalPayments.Name = "lblTotalPayments";
            this.lblTotalPayments.Size = new System.Drawing.Size(122, 23);
            this.lblTotalPayments.TabIndex = 156;
            this.lblTotalPayments.Text = "label2";
            this.lblTotalPayments.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblTotalRentPayments
            // 
            this.lblTotalRentPayments.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblTotalRentPayments.Location = new System.Drawing.Point(946, 354);
            this.lblTotalRentPayments.Name = "lblTotalRentPayments";
            this.lblTotalRentPayments.Size = new System.Drawing.Size(122, 23);
            this.lblTotalRentPayments.TabIndex = 157;
            this.lblTotalRentPayments.Text = "label3";
            this.lblTotalRentPayments.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblKl
            // 
            this.lblKl.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblKl.Location = new System.Drawing.Point(946, 196);
            this.lblKl.Name = "lblKl";
            this.lblKl.Size = new System.Drawing.Size(122, 23);
            this.lblKl.TabIndex = 161;
            this.lblKl.Text = "label4";
            this.lblKl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblDays
            // 
            this.lblDays.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblDays.Location = new System.Drawing.Point(1143, 196);
            this.lblDays.Name = "lblDays";
            this.lblDays.Size = new System.Drawing.Size(122, 23);
            this.lblDays.TabIndex = 160;
            this.lblDays.Text = "label5";
            this.lblDays.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Image = global::CarRental.Properties.Resources.Days;
            this.pictureBox1.InitialImage = null;
            this.pictureBox1.Location = new System.Drawing.Point(1143, 97);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(122, 95);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 159;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox2.Image = global::CarRental.Properties.Resources.km;
            this.pictureBox2.InitialImage = null;
            this.pictureBox2.Location = new System.Drawing.Point(946, 97);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(122, 95);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 158;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox12
            // 
            this.pictureBox12.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox12.Image = global::CarRental.Properties.Resources.VehicleDamage;
            this.pictureBox12.InitialImage = null;
            this.pictureBox12.Location = new System.Drawing.Point(740, 255);
            this.pictureBox12.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pictureBox12.Name = "pictureBox12";
            this.pictureBox12.Size = new System.Drawing.Size(122, 95);
            this.pictureBox12.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox12.TabIndex = 154;
            this.pictureBox12.TabStop = false;
            // 
            // pictureBox11
            // 
            this.pictureBox11.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox11.Image = global::CarRental.Properties.Resources.ActualProfits;
            this.pictureBox11.InitialImage = null;
            this.pictureBox11.Location = new System.Drawing.Point(946, 255);
            this.pictureBox11.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pictureBox11.Name = "pictureBox11";
            this.pictureBox11.Size = new System.Drawing.Size(122, 95);
            this.pictureBox11.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox11.TabIndex = 153;
            this.pictureBox11.TabStop = false;
            // 
            // pictureBox9
            // 
            this.pictureBox9.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox9.Image = global::CarRental.Properties.Resources.gross;
            this.pictureBox9.InitialImage = null;
            this.pictureBox9.Location = new System.Drawing.Point(1143, 255);
            this.pictureBox9.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pictureBox9.Name = "pictureBox9";
            this.pictureBox9.Size = new System.Drawing.Size(122, 95);
            this.pictureBox9.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox9.TabIndex = 152;
            this.pictureBox9.TabStop = false;
            // 
            // lblNumberOfRented
            // 
            this.lblNumberOfRented.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblNumberOfRented.Location = new System.Drawing.Point(740, 196);
            this.lblNumberOfRented.Name = "lblNumberOfRented";
            this.lblNumberOfRented.Size = new System.Drawing.Size(122, 23);
            this.lblNumberOfRented.TabIndex = 163;
            this.lblNumberOfRented.Text = "label4";
            this.lblNumberOfRented.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox3.Image = global::CarRental.Properties.Resources.NumberOf;
            this.pictureBox3.InitialImage = null;
            this.pictureBox3.Location = new System.Drawing.Point(740, 97);
            this.pictureBox3.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(122, 95);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 162;
            this.pictureBox3.TabStop = false;
            // 
            // frmShowCustomerInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1409, 727);
            this.Controls.Add(this.lblNumberOfRented);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.lblKl);
            this.Controls.Add(this.lblDays);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.lblTotalRentPayments);
            this.Controls.Add(this.lblTotalPayments);
            this.Controls.Add(this.lblTotalVehiclesBreakdownPayments);
            this.Controls.Add(this.pictureBox12);
            this.Controls.Add(this.pictureBox11);
            this.Controls.Add(this.pictureBox9);
            this.Controls.Add(this.ctrlCustomerCard1);
            this.Controls.Add(this.ctrlDgvListTransactions1);
            this.Controls.Add(this.lable);
            this.Controls.Add(this.btnClose);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frmShowCustomerInfo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Show CustomerInfo";
            this.Load += new System.EventHandler(this.frmShowCustomerInfo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox12)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox11)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox9)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Guna.UI2.WinForms.Guna2Button btnClose;
        private System.Windows.Forms.Label lable;
        private Rental_Transaction.ctrlDgvListTransactions ctrlDgvListTransactions1;
        private ctrlCustomerCard ctrlCustomerCard1;
        public System.Windows.Forms.PictureBox pictureBox12;
        public System.Windows.Forms.PictureBox pictureBox11;
        public System.Windows.Forms.PictureBox pictureBox9;
        private System.Windows.Forms.Label lblTotalVehiclesBreakdownPayments;
        private System.Windows.Forms.Label lblTotalPayments;
        private System.Windows.Forms.Label lblTotalRentPayments;
        private System.Windows.Forms.Label lblKl;
        private System.Windows.Forms.Label lblDays;
        public System.Windows.Forms.PictureBox pictureBox1;
        public System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label lblNumberOfRented;
        public System.Windows.Forms.PictureBox pictureBox3;
    }
}