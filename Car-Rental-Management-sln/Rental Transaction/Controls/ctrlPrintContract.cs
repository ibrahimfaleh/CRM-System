using CarRental.Classes;
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

namespace CarRental.Rental_Transaction.Controls
{
    public partial class ctrlPrintContract : UserControl
    {
        private bool _PageRules;
        private clsRentalTransaction _rentalTransaction;
        private int? _transactionId;
        public ctrlPrintContract()
        {
            InitializeComponent();
        }
        public void LoadRentalBookingDetal(int RentalTransactionID)
        {
            _transactionId = RentalTransactionID;
        }
        private void Title(ref float Margin, System.Drawing.Printing.PrintPageEventArgs e)
        {
            e.Graphics.DrawImage(System.Drawing.Image.FromFile(clsGlobal.CurrentCompany.LogoPath), (e.PageBounds.Width - 100) / 2, 20, 100, 100);
            Font fontNumber = new Font("Arial", 10, FontStyle.Regular);
            Font fontType = new Font("Arial", 11, FontStyle.Bold);
            Font fontName = new Font("Arial", 18, FontStyle.Bold);
            SizeF fontSizeName = e.Graphics.MeasureString(clsGlobal.CurrentCompany.Name, fontName);
            e.Graphics.DrawString(clsGlobal.CurrentCompany.Name, fontName, System.Drawing.Brushes.Red, (e.PageBounds.Width - fontSizeName.Width) / 2, 130);
            Margin = 50;
            e.Graphics.DrawString(DateTime.Now.ToString("G"), fontType, System.Drawing.Brushes.Black, e.PageBounds.Width - 200, Margin);
            foreach (DataRow row in clsCompanyContactNumber.GetAllCompanyContactNumbers().Rows)
            {
                SizeF fontSizeType = e.Graphics.MeasureString(row[2].ToString() + ":", fontType);
                e.Graphics.DrawString(row[2].ToString() + ":", fontType, System.Drawing.Brushes.Black, 40, Margin);
                e.Graphics.DrawString(row[1].ToString(), fontNumber, System.Drawing.Brushes.Black, fontSizeType.Width + 40, Margin + 2);
                Margin += 40;
            }
            SizeF fontSizeEmail = e.Graphics.MeasureString("Email :", fontType);
            e.Graphics.DrawString("Email :", fontType, System.Drawing.Brushes.Black, 40, Margin);
            e.Graphics.DrawString(clsGlobal.CurrentCompany.Email, fontNumber, System.Drawing.Brushes.Black, fontSizeEmail.Width + 40, Margin + 2);
            
        }
        private void _WriteString(ref float x, ref float y, string text, Font font, System.Drawing.Printing.PrintPageEventArgs e, float AddMorex = 0)
        {
            SizeF fontSize = e.Graphics.MeasureString(text, font);
            e.Graphics.DrawString(text, font, System.Drawing.Brushes.Black, y, x + AddMorex);
            y += fontSize.Width;
        }
        private string _GenereateDash(string text, System.Drawing.Printing.PrintPageEventArgs e, bool IsFull)
        {
            string st = "";
            if (IsFull)
                for (int i = 0; i < e.PageBounds.Width; i++)
                {
                    st += "_";
                }
            else
                for (int i = 0; i < text.Length; i++)
                {
                    st += "_";
                }
            return st;
        }
        private void _FieldDrawing(float x, float y, string Text, System.Drawing.Printing.PrintPageEventArgs e, bool IsFull = true)
        {
            float tempy = y;
            x -= 25;
            _WriteString(ref x, ref y, _GenereateDash(Text, e, IsFull), new Font("Arial", 11, FontStyle.Bold), e);
            x += 30;
            _WriteString(ref x, ref tempy, _GenereateDash(Text, e, IsFull), new Font("Arial", 11, FontStyle.Bold), e);

        }
        private void BoodyBookingInfo(ref float Margin, System.Drawing.Printing.PrintPageEventArgs e)
        {
            float y = 20;
            Margin += 90;
            Font fontTitle = new Font("Arial", 11, FontStyle.Bold);
            SizeF fontSizeTitle;
            y = 0;
            y += (e.PageBounds.Width - (fontSizeTitle = e.Graphics.MeasureString("Rental Booking No :" + _rentalTransaction.TransactionID.ToString(), new Font("Arial", 11, FontStyle.Bold))).Width) / 2;

            _FieldDrawing(Margin, y, "Rental Booking No :" + _rentalTransaction.TransactionID.ToString(), e, false);
            _WriteString(ref Margin, ref y, "Rental Booking No :" + _rentalTransaction.TransactionID.ToString(), new Font("Arial", 11, FontStyle.Bold), e);
            Margin += 50;
            y = 20;


            _FieldDrawing(Margin, y, "Start Date :", e);
            _WriteString(ref Margin, ref y, "Start Date :", new Font("Arial", 11, FontStyle.Bold), e);
            y += 5;
            _FieldDrawing(Margin, y - 5, _rentalTransaction.RentalStartDate.ToString(), e);
            _WriteString(ref Margin, ref y, _rentalTransaction.RentalStartDate.ToString(), new Font("Arial", 10, FontStyle.Regular), e, 3.5f);


            y += 5;
            _FieldDrawing(Margin, y - 5, "End Date :", e);
            _WriteString(ref Margin, ref y, "End Date :", new Font("Arial", 11, FontStyle.Bold), e);
            y += 10;
            _FieldDrawing(Margin, y - 15, _rentalTransaction.RentalEndDate.ToString(), e);
            _WriteString(ref Margin, ref y, _rentalTransaction.RentalEndDate.ToString(), new Font("Arial", 10, FontStyle.Regular), e, 3.5f);




            Margin += 50;
            y = 20;


            _FieldDrawing(Margin, y, "Type Rental :", e);
            _WriteString(ref Margin, ref y, "Type Rental :", new Font("Arial", 11, FontStyle.Bold), e);
            y += 10;
            if (_rentalTransaction.IsMonthly)
            {
                _FieldDrawing(Margin, y - 10, "Monthly", e);
                _WriteString(ref Margin, ref y, "Monthly", new Font("Arial", 10, FontStyle.Regular), e, 1.50f);
            }
            else
            {
                _FieldDrawing(Margin, y - 10, "Daily", e);
                _WriteString(ref Margin, ref y, "Daily", new Font("Arial", 10, FontStyle.Regular), e, 1.50f);
            }
            y += 10;
            _FieldDrawing(Margin, y - 20, "Initial Months :", e);
            _WriteString(ref Margin, ref y, "Initial Months :", new Font("Arial", 11, FontStyle.Bold), e);
            y += 10;
            _FieldDrawing(Margin, y - 15, _rentalTransaction.InitialRentalMonths.ToString() + "  ", e);
            _WriteString(ref Margin, ref y, _rentalTransaction.InitialRentalMonths.ToString(), new Font("Arial", 10, FontStyle.Regular), e, 2.5f);
            y += 10;
            _FieldDrawing(Margin, y - 20, "Initial Days :", e);
            _WriteString(ref Margin, ref y, "Initial Days :", new Font("Arial", 11, FontStyle.Bold), e);
            y += 10;
            _FieldDrawing(Margin, y - 15, _rentalTransaction.InitialRentalDays.ToString() + "  ", e);
            _WriteString(ref Margin, ref y, _rentalTransaction.InitialRentalDays.ToString(), new Font("Arial", 10, FontStyle.Regular), e, 2.5f);

            y += 10;
            _FieldDrawing(Margin, y - 30, "Free Kilometers Credit :", e);
            _WriteString(ref Margin, ref y, "Free Kilometers Credit :", new Font("Arial", 11, FontStyle.Bold), e);
            y += 10;
            _FieldDrawing(Margin, y - 25, _rentalTransaction.FreeKilometersCredit.ToString() + "    ", e);
            _WriteString(ref Margin, ref y, _rentalTransaction.FreeKilometersCredit.ToString(), new Font("Arial", 10, FontStyle.Regular), e, 2.5f);
            Margin += 50;
            y = 20;


            _FieldDrawing(Margin, y, "Pickup Branch :", e);
            _WriteString(ref Margin, ref y, "Pickup Branch :", new Font("Arial", 11, FontStyle.Bold), e);
            y += 10;
            _FieldDrawing(Margin, y - 10, clsBranch.Find(_rentalTransaction.PickupBranchID).StreetName, e);
            _WriteString(ref Margin, ref y, clsBranch.Find(_rentalTransaction.PickupBranchID).StreetName, new Font("Arial", 10, FontStyle.Regular), e, 2.5f);

            y += 10;
            _FieldDrawing(Margin, y - 10, "Drop Off BranchID :", e);
            _WriteString(ref Margin, ref y, "Drop Off BranchID :", new Font("Arial", 11, FontStyle.Bold), e);
            if (_rentalTransaction.DropOffBranchID.HasValue)
            {
                _FieldDrawing(Margin, y - 10, clsBranch.Find(_rentalTransaction.DropOffBranchID.Value).StreetName, e);
                _WriteString(ref Margin, ref y, clsBranch.Find(_rentalTransaction.DropOffBranchID.Value).StreetName, new Font("Arial", 10, FontStyle.Regular), e, 2.5f);
            }
            else
            {
                _FieldDrawing(Margin, y - 10, "  ", e);
                _WriteString(ref Margin, ref y, "  ", new Font("Arial", 10, FontStyle.Regular), e, 2.5f);
            }
            Margin += 50;
            y = 20;
            _FieldDrawing(Margin, y, "Price Per Month :", e);
            _WriteString(ref Margin, ref y, "Price Per Month :", new Font("Arial", 11, FontStyle.Bold), e);
            y += 10;
            _FieldDrawing(Margin, y - 15, _rentalTransaction.RentalPricePerMonth.ToString() + "  ", e);
            _WriteString(ref Margin, ref y, _rentalTransaction.RentalPricePerMonth.ToString() + "  ", new Font("Arial", 10, FontStyle.Regular), e, 2.5f);
            y += 10;
            _FieldDrawing(Margin, y - 13, "Price Per Day :", e);
            _WriteString(ref Margin, ref y, "Price Per Day :", new Font("Arial", 11, FontStyle.Bold), e);
            y += 10;
            _FieldDrawing(Margin, y - 30, _rentalTransaction.RentalPricePerDay.ToString() + "    ", e);
            _WriteString(ref Margin, ref y, _rentalTransaction.RentalPricePerDay.ToString() + "    ", new Font("Arial", 10, FontStyle.Regular), e, 2.5f);

            y += 10;
            _FieldDrawing(Margin, y - 23, "Price Per Hour :", e);
            _WriteString(ref Margin, ref y, "Price Per Hour :", new Font("Arial", 11, FontStyle.Bold), e);
            y += 10;
            _FieldDrawing(Margin, y - 30, _rentalTransaction.RentalPricePerHours.ToString() + "    ", e);
            _WriteString(ref Margin, ref y, _rentalTransaction.RentalPricePerHours.ToString() + "    ", new Font("Arial", 10, FontStyle.Regular), e, 2.5f);
            y += 10;
            _FieldDrawing(Margin, y - 33, "Price Per Mileage :", e);
            _WriteString(ref Margin, ref y, "Price Per Mileage :", new Font("Arial", 11, FontStyle.Bold), e);
            y += 10;
            _FieldDrawing(Margin, y - 30, _rentalTransaction.RentalPricePerMileage.ToString() + "    ", e);
            _WriteString(ref Margin, ref y, _rentalTransaction.RentalPricePerMileage.ToString() + "    ", new Font("Arial", 10, FontStyle.Regular), e, 2.5f);


            Margin += 50;
            y = 0;
            y += (e.PageBounds.Width - (fontSizeTitle = e.Graphics.MeasureString("Payment Details  :", new Font("Arial", 11, FontStyle.Bold))).Width) / 2;
            _FieldDrawing(Margin, y, "Vehicle Details", e, false);
            _WriteString(ref Margin, ref y, "Vehicle Details", new Font("Arial", 11, FontStyle.Bold), e);
            Margin += 50;
            y = 20;
            _FieldDrawing(Margin, y, "Name :  ", e);
            _WriteString(ref Margin, ref y, "Name :", new Font("Arial", 11, FontStyle.Bold), e);
            y += 10;
            _FieldDrawing(Margin, y - 15, _rentalTransaction.VehicleInfo.Name, e);
            _WriteString(ref Margin, ref y, _rentalTransaction.VehicleInfo.Name, new Font("Arial", 10, FontStyle.Regular), e, 2.5f);
            y += 10;
            _FieldDrawing(Margin, y - 33, "Plate Number :   ", e);
            _WriteString(ref Margin, ref y, "Plate Number:", new Font("Arial", 11, FontStyle.Bold), e);
            y += 10;
            _FieldDrawing(Margin, y - 20, _rentalTransaction.VehicleInfo.PlateNumber, e);
            _WriteString(ref Margin, ref y, _rentalTransaction.VehicleInfo.PlateNumber, new Font("Arial", 10, FontStyle.Regular), e, 1.5f);
            y += 10;
            _FieldDrawing(Margin, y - 33, "Mileage :   ", e);
            _WriteString(ref Margin, ref y, "Mileage :", new Font("Arial", 11, FontStyle.Bold), e);
            y += 10;
            _FieldDrawing(Margin, y - 20, _rentalTransaction.VehicleInfo.Mileage.ToString() + "    ", e);
            _WriteString(ref Margin, ref y, _rentalTransaction.VehicleInfo.Mileage.ToString() + "    ", new Font("Arial", 10, FontStyle.Regular), e, 2.5f);


            Margin += 50;
            y = 0;
            y += (e.PageBounds.Width - (fontSizeTitle = e.Graphics.MeasureString("Payment Details  :", new Font("Arial", 11, FontStyle.Bold))).Width) / 2;
            _FieldDrawing(Margin, y, "Initial Payment Details", e, false);
            _WriteString(ref Margin, ref y, "Initial Payment Details", new Font("Arial", 11, FontStyle.Bold), e);

            Margin += 50;
            y = 20;

            _FieldDrawing(Margin, y, "Initial Total Due Amount", e);
            _WriteString(ref Margin, ref y, "Initial Total Due Amount", new Font("Arial", 11, FontStyle.Bold), e);
            y += 10;
            _FieldDrawing(Margin, y - 15, _rentalTransaction.InitialTotalDueAmount.ToString() + "  ", e);
            _WriteString(ref Margin, ref y, _rentalTransaction.InitialTotalDueAmount.ToString() + "  ", new Font("Arial", 10, FontStyle.Regular), e, 2.5f);
            y += 10;
            _FieldDrawing(Margin, y - 13, "Vat :", e);
            _WriteString(ref Margin, ref y, "Vat :", new Font("Arial", 11, FontStyle.Bold), e);
            y += 10;
            _FieldDrawing(Margin, y - 30, "%" + (_rentalTransaction.Vat * 100 - (100)).ToString() + "    ", e);
            _WriteString(ref Margin, ref y, "%" + (_rentalTransaction.Vat * 100 - (100)).ToString() + "    ", new Font("Arial", 10, FontStyle.Regular), e, 2.5f);
            y += 10;
            _FieldDrawing(Margin, y - 13, "Initial  after Vat :", e);
            _WriteString(ref Margin, ref y, "Initial  after Vat :", new Font("Arial", 11, FontStyle.Bold), e);
            y += 10;
            _FieldDrawing(Margin, y - 30, _rentalTransaction.InitialTotalDueAmountAfterTax.ToString() + "    ", e);
            _WriteString(ref Margin, ref y, _rentalTransaction.InitialTotalDueAmountAfterTax.ToString() + "    ", new Font("Arial", 10, FontStyle.Regular), e, 2.5f);
            y += 10;
            _FieldDrawing(Margin, y - 13, "Initial Amount Paid :", e);
            _WriteString(ref Margin, ref y, "Initial Amount Paid :", new Font("Arial", 11, FontStyle.Bold), e);
            y += 10;
            _FieldDrawing(Margin, y - 30, _rentalTransaction.PaidInitialTotalDueAmount.ToString() + "    ", e);
            _WriteString(ref Margin, ref y, _rentalTransaction.PaidInitialTotalDueAmount.ToString() + "    ", new Font("Arial", 10, FontStyle.Regular), e, 2.5f);


            if (_rentalTransaction.BookingStatus == (byte)clsRentalBooking.enRentalBookingStatus.Completed)
            {
                Margin += 50;
                y = 0;
                y += (e.PageBounds.Width - (fontSizeTitle = e.Graphics.MeasureString("Payment Details  :", new Font("Arial", 11, FontStyle.Bold))).Width) / 2;
                _FieldDrawing(Margin, y, "Vehicle Return  Details", e, false);
                _WriteString(ref Margin, ref y, "Vehicle Return  Details", new Font("Arial", 11, FontStyle.Bold), e);
                Margin += 50;
                y = 20;
                _FieldDrawing(Margin, y, "Actual Return Date :", e);
                _WriteString(ref Margin, ref y, "Actual Return Date :", new Font("Arial", 11, FontStyle.Bold), e);
                y += 10;
                _FieldDrawing(Margin, y - 10, _rentalTransaction.VehicleReturnInfo.ActualReturnDate.ToString() + "    ", e);
                _WriteString(ref Margin, ref y, _rentalTransaction.VehicleReturnInfo.ActualReturnDate.ToString() + "    ", new Font("Arial", 10, FontStyle.Regular), e, 2.5f);
                y += 10;
                _FieldDrawing(Margin, y - 10, "Actual Rental Days :", e);
                _WriteString(ref Margin, ref y, "Actual Rental Days :", new Font("Arial", 11, FontStyle.Bold), e);
                y += 10;
                _FieldDrawing(Margin, y - 15, _rentalTransaction.VehicleReturnInfo.ActualRentalDays.ToString() + "    ", e);
                _WriteString(ref Margin, ref y, _rentalTransaction.VehicleReturnInfo.ActualRentalDays.ToString() + "    ", new Font("Arial", 10, FontStyle.Regular), e, 1.5f);
                y += 10;
                _FieldDrawing(Margin, y - 10, "Actual Rental Months :", e);
                _WriteString(ref Margin, ref y, "Actual Rental Months :", new Font("Arial", 11, FontStyle.Bold), e);
                y += 10;
                _FieldDrawing(Margin, y - 15, _rentalTransaction.VehicleReturnInfo.ActualRentalMonths.ToString() + "    ", e);
                _WriteString(ref Margin, ref y, _rentalTransaction.VehicleReturnInfo.ActualRentalMonths.ToString() + "    ", new Font("Arial", 10, FontStyle.Regular), e, 2.5f);
                Margin += 50;
                y = 20;
                _FieldDrawing(Margin, y, "Additional Charges :", e);
                _WriteString(ref Margin, ref y, "Additional Charges :", new Font("Arial", 11, FontStyle.Bold), e);
                y += 10;
                _FieldDrawing(Margin, y - 15, _rentalTransaction.VehicleReturnInfo.AdditionalCharges.ToString() + "    ", e);
                _WriteString(ref Margin, ref y, _rentalTransaction.VehicleReturnInfo.AdditionalCharges.ToString() + "    ", new Font("Arial", 10, FontStyle.Regular), e, 2.5f);
                y += 10;
                _FieldDrawing(Margin, y - 10, "Additional Hours :", e);
                _WriteString(ref Margin, ref y, "Additional Hours :", new Font("Arial", 11, FontStyle.Bold), e);
                y += 10;
                _FieldDrawing(Margin, y - 15, _rentalTransaction.VehicleReturnInfo.AdditionalHours.ToString() + "    ", e);
                _WriteString(ref Margin, ref y, _rentalTransaction.VehicleReturnInfo.AdditionalHours.ToString() + "    ", new Font("Arial", 10, FontStyle.Regular), e, 2.5f);

                y += 10;
                _FieldDrawing(Margin, y - 10, "Consumed Mileage :", e);
                _WriteString(ref Margin, ref y, "Consumed Mileage :", new Font("Arial", 11, FontStyle.Bold), e);
                y += 10;
                _FieldDrawing(Margin, y - 25, _rentalTransaction.VehicleReturnInfo.ConsumedMileage.ToString() + "    ", e);
                _WriteString(ref Margin, ref y, _rentalTransaction.VehicleReturnInfo.ConsumedMileage.ToString() + "    ", new Font("Arial", 10, FontStyle.Regular), e, 2.5f);

                y += 10;
                _FieldDrawing(Margin, y - 20, "Additional Kilometer :", e);
                _WriteString(ref Margin, ref y, "Additional Kilometer :", new Font("Arial", 11, FontStyle.Bold), e);
                y += 10;
                _FieldDrawing(Margin, y - 15, _rentalTransaction.VehicleReturnInfo.AdditionalKilometer.ToString() + "    ", e);
                _WriteString(ref Margin, ref y, _rentalTransaction.VehicleReturnInfo.AdditionalKilometer.ToString() + "    ", new Font("Arial", 10, FontStyle.Regular), e, 2.5f);


                Margin += 50;
                y = 0;
                y += (e.PageBounds.Width - (fontSizeTitle = e.Graphics.MeasureString("Payment Details  :", new Font("Arial", 11, FontStyle.Bold))).Width) / 2;
                _FieldDrawing(Margin, y, "Final Payment Details", e, false);
                _WriteString(ref Margin, ref y, "Final Payment Details", new Font("Arial", 11, FontStyle.Bold), e);
                Margin += 50;
                y = 20;
                _FieldDrawing(Margin, y, "Actual Total Due Amount :", e);
                _WriteString(ref Margin, ref y, "Actual Total Due Amount :", new Font("Arial", 11, FontStyle.Bold), e);
                y += 10;
                _FieldDrawing(Margin, y - 10, _rentalTransaction.ActualTotalDueAmount.ToString() + "    ", e);
                _WriteString(ref Margin, ref y, _rentalTransaction.ActualTotalDueAmount.ToString() + "    ", new Font("Arial", 10, FontStyle.Regular), e, 2.5f);
                y += 10;
                _FieldDrawing(Margin, y - 10, "Total Remaining :", e);
                _WriteString(ref Margin, ref y, "Total Remaining :", new Font("Arial", 11, FontStyle.Bold), e);
                y += 10;
                _FieldDrawing(Margin, y - 15, _rentalTransaction.TotalRemaining.ToString() + "    ", e);
                _WriteString(ref Margin, ref y, _rentalTransaction.TotalRemaining.ToString() + "    ", new Font("Arial", 10, FontStyle.Regular), e, 1.5f);
                y += 10;
                _FieldDrawing(Margin, y - 10, "Total Refunded Amount :", e);
                _WriteString(ref Margin, ref y, "Total Refunded Amount :", new Font("Arial", 11, FontStyle.Bold), e);
                y += 10;
                _FieldDrawing(Margin, y - 15, _rentalTransaction.TotalRefundedAmount.ToString() + "    ", e);
                _WriteString(ref Margin, ref y, _rentalTransaction.TotalRefundedAmount.ToString() + "    ", new Font("Arial", 10, FontStyle.Regular), e, 2.5f);

            }

        }
        private void Button(ref float Margin, System.Drawing.Printing.PrintPageEventArgs e)
        {
            clsCustomer customer = clsCustomer.Find(_rentalTransaction.CustomerID);
            float y = 20;
            Margin += 50;

            _WriteString(ref Margin, ref y, "Customer Name :", new Font("Arial", 11, FontStyle.Bold), e);
            y += 10;
            _WriteString(ref Margin, ref y, customer.PersonInfo.FullName, new Font("Arial", 10, FontStyle.Regular), e, 3.5f);

            Margin += 30;
            y = 20;
            _WriteString(ref Margin, ref y, "Driver License Number :", new Font("Arial", 11, FontStyle.Bold), e);
            y += 10;
            _WriteString(ref Margin, ref y, customer.DriverLicenseNumber, new Font("Arial", 10, FontStyle.Regular), e, 3.5f);

            Margin += 30;
            y = 20;
            _WriteString(ref Margin, ref y, "Phone Number :", new Font("Arial", 11, FontStyle.Bold), e);
            y += 10;
            _WriteString(ref Margin, ref y, customer.PersonInfo.Phone, new Font("Arial", 10, FontStyle.Regular), e, 3.5f);

        }
        private void _WritePageRules(ref float Margin, System.Drawing.Printing.PrintPageEventArgs e)
        {
            if (!_PageRules)
            {
                e.HasMorePages = true;
                _PageRules = true;

                return;
            }
            else
            {
                e.HasMorePages = false;
            }
            float y = 20;
            Margin += 90;
            SizeF fontSizeTitle;
            y = 0;
            y += (e.PageBounds.Width - (fontSizeTitle = e.Graphics.MeasureString("Rules", new Font("Arial", 11, FontStyle.Bold))).Width) / 2;
            Margin += 50;
            _FieldDrawing(Margin, y, " Rules ", e, false);
            _WriteString(ref Margin, ref y, " Rules", new Font("Arial", 11, FontStyle.Bold), e);
            Margin += 50;
            y = 20;
            _WriteString(ref Margin, ref y, clsGlobal.CurrentCarRentalRule.Rules, new Font("Arial", 13, FontStyle.Regular), e, 3.5f);
        }
        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            float Margin = 0;
            Title(ref Margin, e);
            if (!_PageRules)
                BoodyBookingInfo(ref Margin, e);
            if (!_PageRules)
                Button(ref Margin, e);
            _WritePageRules(ref Margin, e);

        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            if(_transactionId.HasValue)
            _rentalTransaction = clsRentalTransaction.Find(_transactionId.Value);

            if(_rentalTransaction!=null)
            {
                printDialog1.Document = printDocument1;
                if (printDialog1.ShowDialog() == DialogResult.OK)
                {
                    printDocument1.Print();
                }
            }
        }
    }
}
