using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CarRental.Login;
using CarRental_Business;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TreeView;


namespace CarRental.Classes
{
    internal static  class clsGlobal
    {
        public  enum enPermissions 
        {
            All=-1
                ,frmAddUpdatePerson=1
                ,frmAddUpdateCustomer=2
                ,frmListVehicles=4
                ,frmBookingCheck=8
                ,frmVehicleReturn=16
                ,frmListRentalTransactions=32
                ,frmShowCustomerDetails=64
                ,frmShowRentalDetails=128
                ,frmAddNewRentalBooking=256
                ,frmDailyIncomeFund=512
                ,frmListDailyIncomeFunds=1024
                ,frmSalaryPayments=2048
                ,frmListSalaryPayments=4096
                ,frmMoneyWithdrawal=8192
                ,frmVat=16384
                ,frmAddNewBranch=32768
                ,frmUpdateBranch=65536
                ,frmAddUpdateUsers=131072
                ,frmListUsers=262144
                ,frmUserDetails=524288
                ,frmListUsersTransaction=1048576
                ,frmUpdateAmountSpent=2097152
                ,frmGeneralFundSupport=4194304
                ,frmListGeneralFundSupporters=8388608
                ,frmAddUpdateMaintenance=16777216
                ,frmListMaintenanceTransactions=33554432
                ,frmManagingGeneralFund=67108864
                ,frmAddUpdateEmployee=134217728
                ,frmListEmployees=268435456
        }
        public static clsCarRentalRule CurrentCarRentalRule;
        public static clsBranch Branch = new clsBranch();
        public static clsUser CurrentUser;
        public static clsTax Tax;
        public static frmLogin frmLogin;
        public static clsCompany CurrentCompany;
        public static bool IsVehicleRentalSystemSound=false;
        public static bool IsDailyFundAvailable=false;
        public static int GeneralRevenueFundID ;
        public static bool IsBranchInformationAvailable=false;
        public static bool IsGeneralFundAvailable=false;
        public static bool RememberUsernameAndPassword(string Username, string Password)
        {

            try
            {
                string currentDirectory = System.IO.Directory.GetCurrentDirectory();
                string filePath = currentDirectory + "\\data.txt";

                if (Username=="" && File.Exists(filePath)) 
                { 
                     File.Delete(filePath);
                    return true;

                }
                string dataToSave = Username + "#//#"+Password ;
                using (StreamWriter writer = new StreamWriter(filePath))
                {
                    writer.WriteLine(dataToSave);
                  return true;
                }
            }
            catch (Exception ex)
            {
               MessageBox.Show ($"An error occurred: {ex.Message}");
                return false;
            }
        }
        public static void GetGeneralRevenueFund()
        {
            clsGeneralRevenueFund generalRevenueFund=clsGeneralRevenueFund.GetGeneralRevenueFund();
            GeneralRevenueFundID = generalRevenueFund.GeneralRevenueFundID;
            IsGeneralFundAvailable= generalRevenueFund != null;
        }
        public static bool GetStoredCredential(ref string Username, ref string Password)
        {
            try
            {
                string currentDirectory = System.IO.Directory.GetCurrentDirectory();

                string filePath  = currentDirectory + "\\data.txt";

                if (File.Exists(filePath))
                {
                    using (StreamReader reader = new StreamReader(filePath))
                    {
                        string line;
                        while ((line = reader.ReadLine()) != null)
                        {
                            string[] result = line.Split(new string[] { "#//#" }, StringSplitOptions.None);

                            Username = result[0];
                            Password = result[1];
                        }
                        return true;
                    }
                }
                else
                {
                    return false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show ($"An error occurred: {ex.Message}");
                return false;   
            }

        }
        public static bool CheckAccessPermissions(enPermissions Permissions)
        {
            if (clsGlobal.CurrentUser.Permissions == (int)enPermissions.All)
                return true;
            if ((((int)Permissions)&clsGlobal.CurrentUser.Permissions)==(int)Permissions)
                return true;
            return false;
        }
    }
}
