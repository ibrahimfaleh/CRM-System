namespace CarRental.Rental_Transaction
{
    partial class frmListRentalTransAction
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
            this.btnClose = new Guna.UI2.WinForms.Guna2Button();
            this.btnAddNewBooking = new System.Windows.Forms.Button();
            this.ctrlDgvListTransactions1 = new CarRental.Rental_Transaction.ctrlDgvListTransactions();
            this.SuspendLayout();
            // 
            // lable
            // 
            this.lable.Dock = System.Windows.Forms.DockStyle.Top;
            this.lable.Font = new System.Drawing.Font("Microsoft Tai Le", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lable.ForeColor = System.Drawing.Color.SlateBlue;
            this.lable.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.lable.Location = new System.Drawing.Point(0, 0);
            this.lable.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lable.Name = "lable";
            this.lable.Size = new System.Drawing.Size(1415, 46);
            this.lable.TabIndex = 150;
            this.lable.Text = "List Rental bookings";
            this.lable.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.BackColor = System.Drawing.Color.Black;
            this.btnClose.BorderColor = System.Drawing.Color.White;
            this.btnClose.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnClose.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnClose.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnClose.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnClose.FillColor = System.Drawing.Color.Black;
            this.btnClose.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnClose.ForeColor = System.Drawing.Color.White;
            this.btnClose.Location = new System.Drawing.Point(1244, 517);
            this.btnClose.Margin = new System.Windows.Forms.Padding(2);
            this.btnClose.Name = "btnClose";
            this.btnClose.PressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnClose.Size = new System.Drawing.Size(153, 29);
            this.btnClose.TabIndex = 151;
            this.btnClose.Text = "Close";
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnAddNewBooking
            // 
            this.btnAddNewBooking.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAddNewBooking.BackColor = System.Drawing.Color.Black;
            this.btnAddNewBooking.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddNewBooking.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnAddNewBooking.ForeColor = System.Drawing.Color.White;
            this.btnAddNewBooking.Location = new System.Drawing.Point(1268, 66);
            this.btnAddNewBooking.Margin = new System.Windows.Forms.Padding(2);
            this.btnAddNewBooking.Name = "btnAddNewBooking";
            this.btnAddNewBooking.Size = new System.Drawing.Size(129, 34);
            this.btnAddNewBooking.TabIndex = 152;
            this.btnAddNewBooking.Text = "Add New";
            this.btnAddNewBooking.UseVisualStyleBackColor = false;
            this.btnAddNewBooking.Click += new System.EventHandler(this.btnAddNewBooking_Click);
            // 
            // ctrlDgvListTransactions1
            // 
            this.ctrlDgvListTransactions1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ctrlDgvListTransactions1.BackColor = System.Drawing.Color.White;
            this.ctrlDgvListTransactions1.Location = new System.Drawing.Point(7, 117);
            this.ctrlDgvListTransactions1.Margin = new System.Windows.Forms.Padding(2);
            this.ctrlDgvListTransactions1.Name = "ctrlDgvListTransactions1";
            this.ctrlDgvListTransactions1.ShowCreatedByUserIDVisible = true;
            this.ctrlDgvListTransactions1.ShowCustomerVisible = true;
            this.ctrlDgvListTransactions1.ShowUpdatedByUserIDVisible = true;
            this.ctrlDgvListTransactions1.Size = new System.Drawing.Size(1397, 392);
            this.ctrlDgvListTransactions1.TabIndex = 153;
            // 
            // frmListTransAction
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1415, 557);
            this.Controls.Add(this.ctrlDgvListTransactions1);
            this.Controls.Add(this.btnAddNewBooking);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.lable);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frmListTransAction";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "List TransAction";
            this.Load += new System.EventHandler(this.frmListTransAction_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lable;
        private Guna.UI2.WinForms.Guna2Button btnClose;
        private System.Windows.Forms.Button btnAddNewBooking;
        private ctrlDgvListTransactions ctrlDgvListTransactions1;
    }
}