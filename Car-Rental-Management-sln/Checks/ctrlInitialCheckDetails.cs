using CarRental.Classes;

using CarRental.Properties;
using CarRental_Business;
using System;
using System.IO;
using System.Windows.Forms;

namespace CarRental.Checks
{
    public partial class ctrlInitialCheckDetails : UserControl
    {


        public clsCheck _Check;
        public ctrlInitialCheckDetails()
        {
            InitializeComponent();
        }


        protected void _ResetDefaultValue()
        {
            txtFrontPart.Text = "";
            txtRightPart.Text = "";
            txtLeftPart.Text = "";
            txtBackPart.Text = "";
            txtUpperBody.Text = "";
            txtBag.Text = "";
            pbFrontPart.Image = Resources.Car;
            pbRightPart.Image = Resources.Car;
            pbLeftPart.Image = Resources.Car;
            pbBackPart.Image = Resources.Car;
            pbUpperBody.Image = Resources.Car;
            pbBag.Image = Resources.Car;
        }
        public void LoadCheckInfo(int CheckID)
        {
            if ((_Check = clsCheck.Find(CheckID)) != null)
            {
                cbFrontPart.Checked = _Check.FrontPart;
                txtFrontPart.Text = _Check.FrontPartNote;
                pbFrontPart.Image = Resources.Car;
                string ImagePath = _Check.FrontPartImage;
                if (ImagePath != "")
                    if (File.Exists(ImagePath))
                        pbFrontPart.Load(ImagePath);

                cbRightPart.Checked = _Check.RightPart;
                txtRightPart.Text = _Check.RightNote;
                pbRightPart.Image = Resources.Car;
                ImagePath = _Check.RightPartImage;
                if (ImagePath != "")
                    if (File.Exists(ImagePath))
                        pbRightPart.Load(ImagePath);

                cbLeftPart.Checked = _Check.LeftPart;
                txtLeftPart.Text = _Check.LeftNote;
                pbLeftPart.Image = Resources.Car;
                ImagePath = _Check.LeftPartImage;
                if (ImagePath != "")
                    if (File.Exists(ImagePath))
                        pbLeftPart.Load(ImagePath);

                cbBackPart.Checked = _Check.BackPart;
                txtBackPart.Text = _Check.BackNote;
                pbBackPart.Image = Resources.Car;
                ImagePath = _Check.BackPartImage;
                if (ImagePath != "")
                if (File.Exists(ImagePath))
                        pbBackPart.Load(ImagePath);

                cbUpperBody.Checked = _Check.UpperBody;
                txtUpperBody.Text = _Check.UpperBodyNote;
                pbUpperBody.Image = Resources.Car;
                ImagePath = _Check.UpperBodyImage;
                if (ImagePath != "")
                    if (File.Exists(ImagePath))
                        pbUpperBody.Load(ImagePath);

                cbBag.Checked = _Check.Bag;
                txtBag.Text = _Check.BagNote;
                pbBag.Image = Resources.Car;
                ImagePath = _Check.BagImage;

                if (ImagePath != "")

                    if (File.Exists(ImagePath))
                        pbBag.Load(ImagePath);

                lblCheckDate.Text = _Check.DateCheck.ToString("d");
            }
            else
            {
                _ResetDefaultValue();
            }
        }
        private void ctrlCheckDetails_Load(object sender, EventArgs e)
        {

        }
        private void pbFrontPart_Click(object sender, EventArgs e)
        {
            PictureBox pictureBox = (PictureBox)sender;
            frmShowImage frm = new frmShowImage(pictureBox.ImageLocation);
            frm.Show();
        }

        private void cbFrontPart_Click(object sender, EventArgs e)
        {
              cbFrontPart.Checked = _Check.FrontPart;
        }

        private void cbUpperBody_Click(object sender, EventArgs e)
        {

                cbUpperBody.Checked = _Check.UpperBody;
        }

        private void cbBackPart_Click(object sender, EventArgs e)
        {

                cbBackPart.Checked = _Check.BackPart;
        }

        private void cbLeftPart_Click(object sender, EventArgs e)
        {

                cbLeftPart.Checked = _Check.LeftPart;
        }

        private void cbBag_Click(object sender, EventArgs e)
        {

                cbBag.Checked = _Check.Bag;
        }

        private void cbRightPart_Click(object sender, EventArgs e)
        {

                cbRightPart.Checked = _Check.RightPart;
        }

        private void lblFrontPartFee_VisibleChanged(object sender, EventArgs e)
        {

        }
        private void pb_Click(object sender, EventArgs e)
        {
            PictureBox pictureBox = (PictureBox)sender;
            frmShowImage frm = new frmShowImage(pictureBox.ImageLocation);
            frm.Show();
        }
    }
}
