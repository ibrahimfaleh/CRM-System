using System;
using System.Data;
using System.Data.SqlClient;

namespace CarRental_DataAccess
{
    public class clsCarRentalRuleData
    {

        public static bool GetCarRentalRuleInfo(ref int CarRentalRulesID, ref Byte DownPaymentPercentageOfTotalDailyRent, ref Byte DownPaymentPercentageOfTotalMonthlyRent, ref Byte DownPaymentPercentageOfTotalAnnualRent, ref string Rules,ref bool IsSolarMonths,ref byte? NumberOfDaysInMonthCustom)
        {

            bool isFound = false;
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            string query = "SELECT * FROM CarRentalRules";
            SqlCommand command = new SqlCommand(query, connection);
            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                if (reader.Read())
                {
                    isFound = true;
                    CarRentalRulesID = (int)reader["CarRentalRulesID"];
                    DownPaymentPercentageOfTotalDailyRent = (Byte)reader["DownPaymentPercentageOfTotalDailyRent"];
                    DownPaymentPercentageOfTotalMonthlyRent = (Byte)reader["DownPaymentPercentageOfTotalMonthlyRent"];
                    DownPaymentPercentageOfTotalAnnualRent = (Byte)reader["DownPaymentPercentageOfTotalAnnualRent"];
                    Rules = (string)reader["Rules"];
                    IsSolarMonths = (bool)reader["IsSolarMonths"];
                    if (reader["NumberOfDaysInMonthCustom"] != DBNull.Value)
                        NumberOfDaysInMonthCustom = (byte)reader["NumberOfDaysInMonthCustom"];
                }
                else
                {
                    isFound = false;
                }

                reader.Close();


            }
            catch (Exception ex)
            {
                //Console.WriteLine("Error: " + ex.Message);
                isFound = false;
            }
            finally
            {
                connection.Close();
            }

            return isFound;
        }
        public static bool UpdateCarRentalRule(Byte DownPaymentPercentageOfTotalDailyRent, Byte DownPaymentPercentageOfTotalMonthlyRent, Byte DownPaymentPercentageOfTotalAnnualRent, string Rules,bool IsSolarMonths,byte? NumberOfDaysInMonthCustom)
        {

            int rowsAffected = 0;
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = @"Update  CarRentalRules  
                            set
			DownPaymentPercentageOfTotalDailyRent = @DownPaymentPercentageOfTotalDailyRent,
			DownPaymentPercentageOfTotalMonthlyRent = @DownPaymentPercentageOfTotalMonthlyRent,
			DownPaymentPercentageOfTotalAnnualRent = @DownPaymentPercentageOfTotalAnnualRent,
			Rules = @Rules,
            IsSolarMonths=@IsSolarMonths,
             NumberOfDaysInMonthCustom=@NumberOfDaysInMonthCustom";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@DownPaymentPercentageOfTotalDailyRent", DownPaymentPercentageOfTotalDailyRent);
            command.Parameters.AddWithValue("@DownPaymentPercentageOfTotalMonthlyRent", DownPaymentPercentageOfTotalMonthlyRent);
            command.Parameters.AddWithValue("@DownPaymentPercentageOfTotalAnnualRent", DownPaymentPercentageOfTotalAnnualRent);
            command.Parameters.AddWithValue("@Rules", Rules);
            command.Parameters.AddWithValue("@IsSolarMonths", IsSolarMonths);
            command.Parameters.AddWithValue("@NumberOfDaysInMonthCustom", (object)NumberOfDaysInMonthCustom ?? DBNull.Value);
            try
            {
                connection.Open();
                rowsAffected = command.ExecuteNonQuery();

            }
            catch (Exception ex)
            {
                //Console.WriteLine("Error: " + ex.Message);
                return false;
            }

            finally
            {
                connection.Close();
            }

            return (rowsAffected > 0);
        }

    }
}
