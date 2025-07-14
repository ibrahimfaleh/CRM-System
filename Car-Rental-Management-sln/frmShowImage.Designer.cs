namespace CarRental
{
    partial class frmShowImage
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
            this.pbFrontPart = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbFrontPart)).BeginInit();
            this.SuspendLayout();
            // 
            // pbFrontPart
            // 
            this.pbFrontPart.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pbFrontPart.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbFrontPart.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pbFrontPart.ErrorImage = global::CarRental.Properties.Resources.Written_Test_512;
            this.pbFrontPart.Image = global::CarRental.Properties.Resources.Car;
            this.pbFrontPart.InitialImage = null;
            this.pbFrontPart.Location = new System.Drawing.Point(0, 0);
            this.pbFrontPart.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pbFrontPart.Name = "pbFrontPart";
            this.pbFrontPart.Size = new System.Drawing.Size(1071, 659);
            this.pbFrontPart.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbFrontPart.TabIndex = 115;
            this.pbFrontPart.TabStop = false;
            // 
            // frmShowImage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1071, 659);
            this.Controls.Add(this.pbFrontPart);
            this.Name = "frmShowImage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Show Image";
            this.Load += new System.EventHandler(this.frmShowImage_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbFrontPart)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pbFrontPart;
    }
}