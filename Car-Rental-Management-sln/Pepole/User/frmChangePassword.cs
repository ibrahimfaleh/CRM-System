using CarRental.Classes;
using CarRental_Business;
using Guna.UI2.WinForms;
using System;
using System.ComponentModel;
using System.Windows.Forms;

namespace CarRental.People.User
{
    public partial class frmChangePassword : Form
    {
        private int _UserID;
        private clsUser _User;
        public frmChangePassword(int UserID)
        {
            InitializeComponent();
            _UserID = UserID;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtConfirmPassword_Validating(object sender, CancelEventArgs e)
        {
            Guna2TextBox Temp = (Guna2TextBox)sender;
            if (txtConfirmPassword.Text != txtNewPassword.Text)
            {
                e.Cancel = true;
                errorProvider1.SetError(Temp, "Password mismatch");
            }
            else
                errorProvider1.SetError(Temp, null);
        }

        private void btnHideShowtxtCurrentPassword_Click(object sender, EventArgs e)
        {
            txtCurrentPassword.UseSystemPasswordChar = !(txtCurrentPassword.UseSystemPasswordChar);
        }

        private void btnHideShowtxtNewPassword_Click(object sender, EventArgs e)
        {
            txtNewPassword.UseSystemPasswordChar = !txtNewPassword.UseSystemPasswordChar;
        }

        private void btnHideShowtxtConfirmPassword_Click(object sender, EventArgs e)
        {
            txtConfirmPassword.UseSystemPasswordChar = !txtConfirmPassword.UseSystemPasswordChar;
        }

        private void txtEmpty_Validating(Object sender, CancelEventArgs e)
        {
            Guna2TextBox Temp=(Guna2TextBox)sender;
            if (string.IsNullOrEmpty(Temp.Text.Trim()))
            {
                e.Cancel = true;
                errorProvider1.SetError(Temp, "This cannot be blank");
                return;
            }
            else
            {
                errorProvider1.SetError(Temp, null);
            };
        }
        private void txtCurrentPassword_Validating(object sender, CancelEventArgs e)
        {
            txtEmpty_Validating(sender, e);
            Guna2TextBox Temp = (Guna2TextBox)sender;
            if (clsUtil.ComputeHash( txtCurrentPassword.Text) != clsGlobal.CurrentUser.Password)
            {
                e.Cancel = true;
                errorProvider1.SetError(Temp, "The password is incorrect");
            }
            else
                errorProvider1.SetError(Temp, null);
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (!this.ValidateChildren())
            {
                MessageBox.Show("Some fileds are not valide!, put the mouse over the red icon(s) to see the erro", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;

            }
            clsGlobal.CurrentUser.Password =clsUtil.ComputeHash( txtNewPassword.Text);
            if (clsGlobal.CurrentUser.Save(clsGlobal.CurrentUser.UserID))
            {
                MessageBox.Show("Data Saved Successfully.", "Saved", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
                MessageBox.Show("Error: Data Is not Saved Successfully.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

        }

        private void frmChangePassword_Load(object sender, EventArgs e)
        {
            _ResetDfaUltValues();
            _User = clsUser.FindByUserID(_UserID);
            if(_User!=null)
            {
                ctrlUserCard1.LoadUserInfo(_UserID);
            }else
            {
                MessageBox.Show("Could not Find User with id = " + _UserID,
    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();

                return;
            }
        }

        private void _ResetDfaUltValues()
        {
            txtNewPassword.Text = "";
            txtCurrentPassword.Text = "";
            txtConfirmPassword.Text = "";
        }
        private void txtNewPassword_Validating(object sender, CancelEventArgs e)
        {
            txtEmpty_Validating(sender, e);
            if (txtNewPassword.Text.Length < 4)
            {
                e.Cancel = true;
                errorProvider1.SetError(txtNewPassword, "Password length must be more than 3 characters");
            }
            else
                errorProvider1.SetError(txtNewPassword, null);

        }

    }
}
