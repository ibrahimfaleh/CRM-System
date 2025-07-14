using CarRental.Amounts_Spent.Money_Withdrawal_Transactions;
using CarRental.Amounts_Spent.Salary_Payments;
using CarRental.Checks;
using CarRental.Classes;
using CarRental.Customers;
using CarRental.Login;
using CarRental.People;
using CarRental.People.Employee;
using CarRental.Rental_Fund;
using CarRental.Rental_Fund.General_Revenue_Fund;
using CarRental.Rental_Transaction;
using CarRental.Rental_Transaction.Rental_Settings;
using CarRental.Users;
using CarRental.Vehicles;
using CarRental_Business;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CarRental
{

    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new frmLogin());
        }
    }
}
