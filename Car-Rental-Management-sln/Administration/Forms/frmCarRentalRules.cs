using CarRental.Classes;
using System;
using System.ComponentModel;
using System.Windows.Forms;

namespace CarRental.Administration.Forms
{
    public partial class frmCarRentalRules : Form
    {
        public frmCarRentalRules()
        {
            InitializeComponent();
        }
        private void _LoadData()
        {
            nudDailyRent.Value = clsGlobal.CurrentCarRentalRule.DownPaymentPercentageOfTotalDailyRent;
            nudMonthlyRent.Value = clsGlobal.CurrentCarRentalRule.DownPaymentPercentageOfTotalMonthlyRent;
            nudAnnualRent.Value = clsGlobal.CurrentCarRentalRule.DownPaymentPercentageOfTotalAnnualRent;
            txtRentalRules.Text = clsGlobal.CurrentCarRentalRule.Rules;
            if(!clsGlobal.CurrentCarRentalRule.IsSolarMonths)
                txtNumberOfDaysMonth.Text=clsGlobal.CurrentCarRentalRule.NumberOfDaysInMonthCustom.ToString();
            tsTypeOfMonth.Checked = clsGlobal.CurrentCarRentalRule.IsSolarMonths;
        }
        private void frmCarRentalRules_Load(object sender, EventArgs e)
        {
            _LoadData();
        }
        private void txtRentalRules_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txtRentalRules.Text))
            {
                e.Cancel = true;
                errorProvider1.SetError(txtRentalRules, "");

            }
            else
                errorProvider1.SetError(txtRentalRules, null);
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            if (!this.ValidateChildren())
            {
                MessageBox.Show("Some fileds are not valide!, put the mouse over the red icon(s) to see the erro", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            clsGlobal.CurrentCarRentalRule.DownPaymentPercentageOfTotalDailyRent = (byte)nudDailyRent.Value;
            clsGlobal.CurrentCarRentalRule.DownPaymentPercentageOfTotalMonthlyRent = (byte)nudMonthlyRent.Value;
            clsGlobal.CurrentCarRentalRule.DownPaymentPercentageOfTotalAnnualRent = (byte)nudAnnualRent.Value;
            clsGlobal.CurrentCarRentalRule.Rules = txtRentalRules.Text;
            clsGlobal.CurrentCarRentalRule.IsSolarMonths = tsTypeOfMonth.Checked;
            if (!clsGlobal.CurrentCarRentalRule.IsSolarMonths)
                clsGlobal.CurrentCarRentalRule.NumberOfDaysInMonthCustom = byte.Parse(txtNumberOfDaysMonth.Text);
            else
                clsGlobal.CurrentCarRentalRule.NumberOfDaysInMonthCustom = null;
            if (clsGlobal.CurrentCarRentalRule.Save())
            {
                MessageBox.Show("Saved successfully", "Saved", MessageBoxButtons.OK, MessageBoxIcon.Information);
                _LoadData();
            }
            else
                MessageBox.Show("Not saved", "Saved", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();   
        }

        private void tsTypeOfMonth_CheckedChanged(object sender, EventArgs e)
        {
            if (tsTypeOfMonth.Checked)
            {
                lblTitleNumberOfDaysMonth.Visible = false;
                txtNumberOfDaysMonth.Visible = false;
            }
            else
            {
                lblTitleNumberOfDaysMonth.Visible = true;
                txtNumberOfDaysMonth.Visible = true;
            }
        }
    }
}
