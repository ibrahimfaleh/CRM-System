namespace CarRental.Users
{
    partial class frmUserDetails
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
            this.lable = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            this.lblCountCreatedRentalBooking = new System.Windows.Forms.Label();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.lblTotalRentPayments = new System.Windows.Forms.Label();
            this.pictureBox11 = new System.Windows.Forms.PictureBox();
            this.ctrlUserCard1 = new CarRental.ctrlUserCard();
            this.ctrldgListUsersTransActions1 = new CarRental.Users.ctrldgListUsersTransActions();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox11)).BeginInit();
            this.SuspendLayout();
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
            this.lable.Size = new System.Drawing.Size(1441, 46);
            this.lable.TabIndex = 149;
            this.lable.Text = "User Details";
            this.lable.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lable.Click += new System.EventHandler(this.lable_Click);
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.Black;
            this.btnClose.FlatAppearance.BorderSize = 2;
            this.btnClose.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.btnClose.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.ForeColor = System.Drawing.Color.White;
            this.btnClose.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnClose.Location = new System.Drawing.Point(1289, 329);
            this.btnClose.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(140, 34);
            this.btnClose.TabIndex = 152;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // lblCountCreatedRentalBooking
            // 
            this.lblCountCreatedRentalBooking.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblCountCreatedRentalBooking.Location = new System.Drawing.Point(831, 244);
            this.lblCountCreatedRentalBooking.Name = "lblCountCreatedRentalBooking";
            this.lblCountCreatedRentalBooking.Size = new System.Drawing.Size(122, 23);
            this.lblCountCreatedRentalBooking.TabIndex = 175;
            this.lblCountCreatedRentalBooking.Text = "label4";
            this.lblCountCreatedRentalBooking.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox3.Image = global::CarRental.Properties.Resources.NumberOf;
            this.pictureBox3.InitialImage = null;
            this.pictureBox3.Location = new System.Drawing.Point(831, 145);
            this.pictureBox3.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(122, 95);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 174;
            this.pictureBox3.TabStop = false;
            // 
            // lblTotalRentPayments
            // 
            this.lblTotalRentPayments.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblTotalRentPayments.Location = new System.Drawing.Point(1087, 244);
            this.lblTotalRentPayments.Name = "lblTotalRentPayments";
            this.lblTotalRentPayments.Size = new System.Drawing.Size(122, 23);
            this.lblTotalRentPayments.TabIndex = 169;
            this.lblTotalRentPayments.Text = "label3";
            this.lblTotalRentPayments.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBox11
            // 
            this.pictureBox11.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox11.Image = global::CarRental.Properties.Resources.ActualProfits;
            this.pictureBox11.InitialImage = null;
            this.pictureBox11.Location = new System.Drawing.Point(1087, 145);
            this.pictureBox11.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pictureBox11.Name = "pictureBox11";
            this.pictureBox11.Size = new System.Drawing.Size(122, 95);
            this.pictureBox11.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox11.TabIndex = 165;
            this.pictureBox11.TabStop = false;
            // 
            // ctrlUserCard1
            // 
            this.ctrlUserCard1.BackColor = System.Drawing.Color.White;
            this.ctrlUserCard1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ctrlUserCard1.EditedVisible = true;
            this.ctrlUserCard1.Location = new System.Drawing.Point(7, 58);
            this.ctrlUserCard1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.ctrlUserCard1.Name = "ctrlUserCard1";
            this.ctrlUserCard1.Size = new System.Drawing.Size(659, 305);
            this.ctrlUserCard1.TabIndex = 154;
            // 
            // ctrldgListUsersTransActions1
            // 
            this.ctrldgListUsersTransActions1.AutoSize = true;
            this.ctrldgListUsersTransActions1.Location = new System.Drawing.Point(24, 375);
            this.ctrldgListUsersTransActions1.Name = "ctrldgListUsersTransActions1";
            this.ctrldgListUsersTransActions1.ShowUserDetailsVisible = true;
            this.ctrldgListUsersTransActions1.Size = new System.Drawing.Size(1405, 285);
            this.ctrldgListUsersTransActions1.TabIndex = 153;
            // 
            // frmUserDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1441, 672);
            this.Controls.Add(this.lblCountCreatedRentalBooking);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.lblTotalRentPayments);
            this.Controls.Add(this.pictureBox11);
            this.Controls.Add(this.ctrlUserCard1);
            this.Controls.Add(this.ctrldgListUsersTransActions1);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.lable);
            this.Name = "frmUserDetails";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "User Details";
            this.Load += new System.EventHandler(this.frmUserDetails_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox11)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lable;
        private System.Windows.Forms.Button btnClose;
        private ctrldgListUsersTransActions ctrldgListUsersTransActions1;
        private ctrlUserCard ctrlUserCard1;
        private System.Windows.Forms.Label lblCountCreatedRentalBooking;
        public System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Label lblTotalRentPayments;
        public System.Windows.Forms.PictureBox pictureBox11;
    }
}