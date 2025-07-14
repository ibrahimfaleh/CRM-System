namespace CarRental.Checks
{
    partial class frmAddUpdateFinalCheck
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAddUpdateFinalCheck));
            this.txtFrontPartCost = new System.Windows.Forms.TextBox();
            this.txtRightPartCost = new System.Windows.Forms.TextBox();
            this.txtUpperBodyCost = new System.Windows.Forms.TextBox();
            this.txtBackPartCost = new System.Windows.Forms.TextBox();
            this.txtLeftPartCost = new System.Windows.Forms.TextBox();
            this.txtBagCost = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.txtTotalCost = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pbBackPart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbBag)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbUpperBody)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbLeftPart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbRightPart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbFrontPart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // pbBackPart
            // 
            this.pbBackPart.Image = ((System.Drawing.Image)(resources.GetObject("pbBackPart.Image")));
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(879, 102);
            // 
            // pbBag
            // 
            this.pbBag.Image = ((System.Drawing.Image)(resources.GetObject("pbBag.Image")));
            // 
            // pbUpperBody
            // 
            this.pbUpperBody.Image = ((System.Drawing.Image)(resources.GetObject("pbUpperBody.Image")));
            this.pbUpperBody.Location = new System.Drawing.Point(733, 363);
            // 
            // pbLeftPart
            // 
            this.pbLeftPart.Image = ((System.Drawing.Image)(resources.GetObject("pbLeftPart.Image")));
            // 
            // pbRightPart
            // 
            this.pbRightPart.Image = ((System.Drawing.Image)(resources.GetObject("pbRightPart.Image")));
            this.pbRightPart.Location = new System.Drawing.Point(733, 209);
            // 
            // pbFrontPart
            // 
            this.pbFrontPart.Image = ((System.Drawing.Image)(resources.GetObject("pbFrontPart.Image")));
            this.pbFrontPart.Location = new System.Drawing.Point(733, 55);
            // 
            // lblTitle
            // 
            this.lblTitle.Size = new System.Drawing.Size(1073, 43);
            this.lblTitle.Text = "Add New Final Check";
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(547, 314);
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(532, 160);
            // 
            // label6
            // 
            this.label6.Location = new System.Drawing.Point(532, 471);
            // 
            // lblCheckDate
            // 
            this.lblCheckDate.Size = new System.Drawing.Size(0, 16);
            this.lblCheckDate.Text = "";
            // 
            // linkLabel5
            // 
            this.linkLabel5.Location = new System.Drawing.Point(741, 415);
            // 
            // linkLabel2
            // 
            this.linkLabel2.Location = new System.Drawing.Point(741, 261);
            // 
            // llSetImage
            // 
            this.llSetImage.Location = new System.Drawing.Point(741, 107);
            // 
            // txtFrontPart
            // 
            this.txtFrontPart.Location = new System.Drawing.Point(628, 125);
            // 
            // txtRightPart
            // 
            this.txtRightPart.Location = new System.Drawing.Point(628, 279);
            // 
            // txtUpperBody
            // 
            this.txtUpperBody.Location = new System.Drawing.Point(628, 434);
            // 
            // cbFrontPart
            // 
            this.cbFrontPart.Location = new System.Drawing.Point(902, 157);
            // 
            // cbRightPart
            // 
            this.cbRightPart.Location = new System.Drawing.Point(902, 314);
            // 
            // cbUpperBody
            // 
            this.cbUpperBody.Location = new System.Drawing.Point(902, 468);
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(645, 548);
            // 
            // txtFrontPartCost
            // 
            this.txtFrontPartCost.Location = new System.Drawing.Point(942, 154);
            this.txtFrontPartCost.Name = "txtFrontPartCost";
            this.txtFrontPartCost.Size = new System.Drawing.Size(100, 20);
            this.txtFrontPartCost.TabIndex = 265;
            this.txtFrontPartCost.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtAmount_KeyPress);
            this.txtFrontPartCost.Validating += new System.ComponentModel.CancelEventHandler(this.ValidateEmptyTextBox);
            // 
            // txtRightPartCost
            // 
            this.txtRightPartCost.Location = new System.Drawing.Point(942, 314);
            this.txtRightPartCost.Name = "txtRightPartCost";
            this.txtRightPartCost.Size = new System.Drawing.Size(100, 20);
            this.txtRightPartCost.TabIndex = 266;
            this.txtRightPartCost.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtAmount_KeyPress);
            this.txtRightPartCost.Validating += new System.ComponentModel.CancelEventHandler(this.ValidateEmptyTextBox);
            // 
            // txtUpperBodyCost
            // 
            this.txtUpperBodyCost.Location = new System.Drawing.Point(942, 465);
            this.txtUpperBodyCost.Name = "txtUpperBodyCost";
            this.txtUpperBodyCost.Size = new System.Drawing.Size(100, 20);
            this.txtUpperBodyCost.TabIndex = 267;
            this.txtUpperBodyCost.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtAmount_KeyPress);
            this.txtUpperBodyCost.Validating += new System.ComponentModel.CancelEventHandler(this.ValidateEmptyTextBox);
            // 
            // txtBackPartCost
            // 
            this.txtBackPartCost.Location = new System.Drawing.Point(406, 156);
            this.txtBackPartCost.Name = "txtBackPartCost";
            this.txtBackPartCost.Size = new System.Drawing.Size(100, 20);
            this.txtBackPartCost.TabIndex = 268;
            this.txtBackPartCost.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtAmount_KeyPress);
            this.txtBackPartCost.Validating += new System.ComponentModel.CancelEventHandler(this.ValidateEmptyTextBox);
            // 
            // txtLeftPartCost
            // 
            this.txtLeftPartCost.Location = new System.Drawing.Point(406, 314);
            this.txtLeftPartCost.Name = "txtLeftPartCost";
            this.txtLeftPartCost.Size = new System.Drawing.Size(100, 20);
            this.txtLeftPartCost.TabIndex = 269;
            this.txtLeftPartCost.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtAmount_KeyPress);
            this.txtLeftPartCost.Validating += new System.ComponentModel.CancelEventHandler(this.ValidateEmptyTextBox);
            // 
            // txtBagCost
            // 
            this.txtBagCost.Location = new System.Drawing.Point(406, 471);
            this.txtBagCost.Name = "txtBagCost";
            this.txtBagCost.Size = new System.Drawing.Size(100, 20);
            this.txtBagCost.TabIndex = 270;
            this.txtBagCost.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtAmount_KeyPress);
            this.txtBagCost.Validating += new System.ComponentModel.CancelEventHandler(this.ValidateEmptyTextBox);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label10.Location = new System.Drawing.Point(957, 107);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(38, 16);
            this.label10.TabIndex = 271;
            this.label10.Text = "Cost";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label11.Location = new System.Drawing.Point(430, 105);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(38, 16);
            this.label11.TabIndex = 272;
            this.label11.Text = "Cost";
            // 
            // txtTotalCost
            // 
            this.txtTotalCost.Location = new System.Drawing.Point(362, 541);
            this.txtTotalCost.Multiline = true;
            this.txtTotalCost.Name = "txtTotalCost";
            this.txtTotalCost.ReadOnly = true;
            this.txtTotalCost.Size = new System.Drawing.Size(260, 54);
            this.txtTotalCost.TabIndex = 273;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label12.Location = new System.Drawing.Point(271, 562);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(86, 16);
            this.label12.TabIndex = 274;
            this.label12.Text = "Total Cost :";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // frmAddUpdateFinalCheck
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1073, 607);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.txtTotalCost);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.txtBagCost);
            this.Controls.Add(this.txtLeftPartCost);
            this.Controls.Add(this.txtBackPartCost);
            this.Controls.Add(this.txtUpperBodyCost);
            this.Controls.Add(this.txtRightPartCost);
            this.Controls.Add(this.txtFrontPartCost);
            this.Name = "frmAddUpdateFinalCheck";
            this.Text = "frmAddUpdateFinalCheck";
            this.Load += new System.EventHandler(this.frmAddUpdateFinalCheck_Load);
            this.Controls.SetChildIndex(this.txtFrontPart, 0);
            this.Controls.SetChildIndex(this.txtRightPart, 0);
            this.Controls.SetChildIndex(this.txtUpperBody, 0);
            this.Controls.SetChildIndex(this.txtLeftPart, 0);
            this.Controls.SetChildIndex(this.txtBag, 0);
            this.Controls.SetChildIndex(this.txtBackPart, 0);
            this.Controls.SetChildIndex(this.cbFrontPart, 0);
            this.Controls.SetChildIndex(this.cbRightPart, 0);
            this.Controls.SetChildIndex(this.cbUpperBody, 0);
            this.Controls.SetChildIndex(this.cbBackPart, 0);
            this.Controls.SetChildIndex(this.cbLeftPart, 0);
            this.Controls.SetChildIndex(this.cbBag, 0);
            this.Controls.SetChildIndex(this.btnClose, 0);
            this.Controls.SetChildIndex(this.pbFrontPart, 0);
            this.Controls.SetChildIndex(this.pbRightPart, 0);
            this.Controls.SetChildIndex(this.pbLeftPart, 0);
            this.Controls.SetChildIndex(this.pbUpperBody, 0);
            this.Controls.SetChildIndex(this.pbBag, 0);
            this.Controls.SetChildIndex(this.label2, 0);
            this.Controls.SetChildIndex(this.lblTitle, 0);
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.label3, 0);
            this.Controls.SetChildIndex(this.label4, 0);
            this.Controls.SetChildIndex(this.label6, 0);
            this.Controls.SetChildIndex(this.label7, 0);
            this.Controls.SetChildIndex(this.label8, 0);
            this.Controls.SetChildIndex(this.lblCheckDate, 0);
            this.Controls.SetChildIndex(this.llSetImage, 0);
            this.Controls.SetChildIndex(this.linkLabel1, 0);
            this.Controls.SetChildIndex(this.linkLabel2, 0);
            this.Controls.SetChildIndex(this.linkLabel4, 0);
            this.Controls.SetChildIndex(this.linkLabel5, 0);
            this.Controls.SetChildIndex(this.pbBackPart, 0);
            this.Controls.SetChildIndex(this.label5, 0);
            this.Controls.SetChildIndex(this.linkLabel3, 0);
            this.Controls.SetChildIndex(this.label9, 0);
            this.Controls.SetChildIndex(this.txtFrontPartCost, 0);
            this.Controls.SetChildIndex(this.txtRightPartCost, 0);
            this.Controls.SetChildIndex(this.txtUpperBodyCost, 0);
            this.Controls.SetChildIndex(this.txtBackPartCost, 0);
            this.Controls.SetChildIndex(this.txtLeftPartCost, 0);
            this.Controls.SetChildIndex(this.txtBagCost, 0);
            this.Controls.SetChildIndex(this.label10, 0);
            this.Controls.SetChildIndex(this.label11, 0);
            this.Controls.SetChildIndex(this.txtTotalCost, 0);
            this.Controls.SetChildIndex(this.label12, 0);
            ((System.ComponentModel.ISupportInitialize)(this.pbBackPart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbBag)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbUpperBody)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbLeftPart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbRightPart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbFrontPart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtFrontPartCost;
        private System.Windows.Forms.TextBox txtRightPartCost;
        private System.Windows.Forms.TextBox txtUpperBodyCost;
        private System.Windows.Forms.TextBox txtBackPartCost;
        private System.Windows.Forms.TextBox txtLeftPartCost;
        private System.Windows.Forms.TextBox txtBagCost;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtTotalCost;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}