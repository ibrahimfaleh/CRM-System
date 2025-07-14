using CarRental.Properties;
using CarRental_Business;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using CarRental.People;

namespace CarRental
{
    public partial class ctrlPersonCard : UserControl
    {
        private clsPerson _Person;

        private int _PersonID = -1;

        public int PersonID
        {
            get { return _PersonID; }
        }

        public clsPerson SelectedPersonInfo
        {
            get { return _Person; }
        }
        private bool _EditedVisible = true;
        public bool EditedVisible
        {
            get
            {
                return _EditedVisible;
            }
            set
            {
                _EditedVisible = value;
                llEditPersonInfo.Visible = _EditedVisible;
            }
        }
        public ctrlPersonCard()
        {
            InitializeComponent();
        }

        private void _FillPersonInfo()
        {
            if (_Person != null) 
            {
                llEditPersonInfo.Enabled = true;
                _PersonID = _Person.PersonID();
                lblPersonID.Text=_Person.PersonID().ToString();
                lblName.Text = _Person.FullName;
                lblPhone.Text = _Person.Phone;
                lblEmail.Text = _Person.Email;
                lblCountry.Text=clsCountry.Find(_Person.NationalityCountryID).CountryName;
                lblDateOfBirth.Text=_Person.DateOfBirth.ToShortDateString();
                lblGendor.Text = _Person.Gendor == 0 ? "Male" : "Female";
                lblCity.Text = clsCity.Find(_Person.CityID).CityName;
                _LoadPersonImage();
            }
        }

        private void _LoadPersonImage()
        {
            if (_Person.Gendor == 0)
                pbPersonImage.Image = Resources.Male_512;
            else
                pbPersonImage.Image = Resources.Female_512;

            string ImagePath = _Person.ImagePath;
            if (ImagePath != "")
                if (File.Exists(ImagePath))
                    pbPersonImage.ImageLocation = ImagePath;
                else
                    MessageBox.Show("Could not find this image: = " + ImagePath, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

        }
        public void LoadPersonInfo(int PersonID)
        {
            _Person = clsPerson.Find(PersonID);
            if (_Person == null)
            {
                ResetPersonInfo();
                MessageBox.Show("No Person with PersonID = " + PersonID.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            _FillPersonInfo();
        }
        public void LoadPersonInfo(string Phone)
        {
            _Person = clsPerson.Find(Phone);
            if (_Person == null)
            {
                ResetPersonInfo();
                MessageBox.Show("No Person with Phone = " + Phone.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            _FillPersonInfo();
        }

        public void ResetPersonInfo ()
        {
            lblPersonID.Text = "???";
            lblName.Text = "???";
            lblPhone.Text = "???";
            lblEmail.Text = "???";
            lblGendor.Text = "???";
            lblDateOfBirth.Text = "???";
            lblCountry.Text = "???";
            pbPersonImage.ImageLocation = "";
            pbPersonImage.Image = Resources.Male_512;
            llEditPersonInfo.Visible = false;
        }

        private void ctrPersonCard_Load(object sender, EventArgs e)
        {

        }

        private void llEditPersonInfo_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmAddUpdatePerson frm = new frmAddUpdatePerson(_PersonID);
            frm.ShowDialog();
            LoadPersonInfo(_PersonID);
        }
    }
}
