namespace CarRental.Users
{
    partial class ctrlUserAllInfo
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
            this.ctrlUserCard1 = new CarRental.ctrlUserCard();
            this.label12 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lblTotalRentalTransActions = new System.Windows.Forms.Label();
            this.llCreatedRental = new System.Windows.Forms.LinkLabel();
            this.llCreatedUsers = new System.Windows.Forms.LinkLabel();
            this.llCreatedByUserID = new System.Windows.Forms.LinkLabel();
            this.llCountTransActions = new System.Windows.Forms.LinkLabel();
            this.llVehicleReturn = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // ctrlUserCard1
            // 
            this.ctrlUserCard1.BackColor = System.Drawing.Color.White;
            this.ctrlUserCard1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ctrlUserCard1.EditedVisible = true;
            this.ctrlUserCard1.Location = new System.Drawing.Point(2, 2);
            this.ctrlUserCard1.Margin = new System.Windows.Forms.Padding(2);
            this.ctrlUserCard1.Name = "ctrlUserCard1";
            this.ctrlUserCard1.Size = new System.Drawing.Size(623, 302);
            this.ctrlUserCard1.TabIndex = 0;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Tai Le", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.SlateBlue;
            this.label12.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.label12.Location = new System.Drawing.Point(787, 35);
            this.label12.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(144, 18);
            this.label12.TabIndex = 176;
            this.label12.Text = "Count TransActions :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Tai Le", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.SlateBlue;
            this.label1.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.label1.Location = new System.Drawing.Point(655, 278);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(138, 18);
            this.label1.TabIndex = 177;
            this.label1.Text = "Created By UserID :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Tai Le", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.SlateBlue;
            this.label2.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.label2.Location = new System.Drawing.Point(655, 237);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(149, 18);
            this.label2.TabIndex = 178;
            this.label2.Text = "Total Rental Income :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Tai Le", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.SlateBlue;
            this.label3.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.label3.Location = new System.Drawing.Point(920, 75);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(112, 18);
            this.label3.TabIndex = 179;
            this.label3.Text = "Vehicle Return :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Tai Le", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.SlateBlue;
            this.label4.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.label4.Location = new System.Drawing.Point(920, 116);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(115, 18);
            this.label4.TabIndex = 180;
            this.label4.Text = "Created Rental :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Tai Le", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.SlateBlue;
            this.label5.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.label5.Location = new System.Drawing.Point(920, 155);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(109, 18);
            this.label5.TabIndex = 181;
            this.label5.Text = "Created Users :";
            // 
            // lblTotalRentalTransActions
            // 
            this.lblTotalRentalTransActions.AutoSize = true;
            this.lblTotalRentalTransActions.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblTotalRentalTransActions.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.lblTotalRentalTransActions.Location = new System.Drawing.Point(813, 238);
            this.lblTotalRentalTransActions.Name = "lblTotalRentalTransActions";
            this.lblTotalRentalTransActions.Size = new System.Drawing.Size(41, 15);
            this.lblTotalRentalTransActions.TabIndex = 182;
            this.lblTotalRentalTransActions.Text = "label6";
            // 
            // llCreatedRental
            // 
            this.llCreatedRental.AutoSize = true;
            this.llCreatedRental.Location = new System.Drawing.Point(1039, 116);
            this.llCreatedRental.Name = "llCreatedRental";
            this.llCreatedRental.Size = new System.Drawing.Size(55, 13);
            this.llCreatedRental.TabIndex = 183;
            this.llCreatedRental.TabStop = true;
            this.llCreatedRental.Text = "linkLabel1";
            // 
            // llCreatedUsers
            // 
            this.llCreatedUsers.AutoSize = true;
            this.llCreatedUsers.Location = new System.Drawing.Point(1039, 157);
            this.llCreatedUsers.Name = "llCreatedUsers";
            this.llCreatedUsers.Size = new System.Drawing.Size(55, 13);
            this.llCreatedUsers.TabIndex = 184;
            this.llCreatedUsers.TabStop = true;
            this.llCreatedUsers.Text = "linkLabel2";
            // 
            // llCreatedByUserID
            // 
            this.llCreatedByUserID.AutoSize = true;
            this.llCreatedByUserID.Location = new System.Drawing.Point(811, 279);
            this.llCreatedByUserID.Name = "llCreatedByUserID";
            this.llCreatedByUserID.Size = new System.Drawing.Size(55, 13);
            this.llCreatedByUserID.TabIndex = 185;
            this.llCreatedByUserID.TabStop = true;
            this.llCreatedByUserID.Text = "linkLabel3";
            // 
            // llCountTransActions
            // 
            this.llCountTransActions.AutoSize = true;
            this.llCountTransActions.Location = new System.Drawing.Point(947, 37);
            this.llCountTransActions.Name = "llCountTransActions";
            this.llCountTransActions.Size = new System.Drawing.Size(55, 13);
            this.llCountTransActions.TabIndex = 186;
            this.llCountTransActions.TabStop = true;
            this.llCountTransActions.Text = "linkLabel4";
            // 
            // llVehicleReturn
            // 
            this.llVehicleReturn.AutoSize = true;
            this.llVehicleReturn.Location = new System.Drawing.Point(1039, 77);
            this.llVehicleReturn.Name = "llVehicleReturn";
            this.llVehicleReturn.Size = new System.Drawing.Size(55, 13);
            this.llVehicleReturn.TabIndex = 187;
            this.llVehicleReturn.TabStop = true;
            this.llVehicleReturn.Text = "linkLabel5";
            // 
            // ctrlUserAllInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.llVehicleReturn);
            this.Controls.Add(this.llCountTransActions);
            this.Controls.Add(this.llCreatedByUserID);
            this.Controls.Add(this.llCreatedUsers);
            this.Controls.Add(this.llCreatedRental);
            this.Controls.Add(this.lblTotalRentalTransActions);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.ctrlUserCard1);
            this.Name = "ctrlUserAllInfo";
            this.Size = new System.Drawing.Size(1113, 306);
            this.Load += new System.EventHandler(this.ctrlUserAllInfo_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ctrlUserCard ctrlUserCard1;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblTotalRentalTransActions;
        private System.Windows.Forms.LinkLabel llCreatedRental;
        private System.Windows.Forms.LinkLabel llCreatedUsers;
        private System.Windows.Forms.LinkLabel llCreatedByUserID;
        private System.Windows.Forms.LinkLabel llCountTransActions;
        private System.Windows.Forms.LinkLabel llVehicleReturn;
    }
}
