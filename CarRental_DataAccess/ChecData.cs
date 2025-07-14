using System;
using System.Data;
using System.Data.SqlClient;

namespace CarRental_DataAccess
{
    public class clsChecData
    {
         
        public static int AddNewCheck( DateTime DateCheck, Boolean FrontPart, string FrontPartImage, string FrontPartNote, double FrontPartFee, Boolean? RightPart, string RightPartImage, string RightNote, double RightPartFee,
            Boolean LeftPart, string LeftPartImage, 
            string LeftNote, double LeftPartFee, Boolean BackPart
            , string BackPartImage, string BackNote,double BackPartFee, Boolean UpperBody, string UpperBodyImage, string UpperBodyNote,double UpperBodyFee, Boolean Bag, string BagImage, string BagNote,double BagFee)
        {
            int CheckID = -1;
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            string query = @"INSERT INTO Checks ( DateCheck, FrontPart, FrontPartImage, FrontPartNote,FrontPartFee, RightPart, RightPartImage, RightNote,RightPartFee, LeftPart, LeftPartImage, LeftNote,LeftPartFee, BackPart, BackPartImage, BackNote,BackPartFee, UpperBody, UpperBodyImage, UpperBodyNote,UpperBodyFee, Bag, BagImage, BagNote,BagFee)
                             VALUES (  @DateCheck, @FrontPart, @FrontPartImage, @FrontPartNote,@FrontPartFee, @RightPart, @RightPartImage, @RightNote,@RightPartFee, @LeftPart, @LeftPartImage, @LeftNote,@LeftPartFee, @BackPart, @BackPartImage, @BackNote,@BackPartFee, @UpperBody, @UpperBodyImage, @UpperBodyNote,@UpperBodyFee, @Bag, @BagImage, @BagNote,@BagFee);
                             SELECT SCOPE_IDENTITY();";
            SqlCommand command = new SqlCommand(query, connection);


            command.Parameters.AddWithValue("@DateCheck", DateCheck);


            command.Parameters.AddWithValue("@FrontPart", FrontPart);
            command.Parameters.AddWithValue("@FrontPartImage", FrontPartImage);
            command.Parameters.AddWithValue("@FrontPartNote", FrontPartNote);
            command.Parameters.AddWithValue("@FrontPartFee", FrontPartFee);



            command.Parameters.AddWithValue("@RightPart", RightPart);
            command.Parameters.AddWithValue("@RightPartImage", RightPartImage);
            command.Parameters.AddWithValue("@RightNote", RightNote);
            command.Parameters.AddWithValue("@RightPartFee", RightPartFee);



            command.Parameters.AddWithValue("@LeftPart", LeftPart);
            command.Parameters.AddWithValue("@LeftPartImage", LeftPartImage);
            command.Parameters.AddWithValue("@LeftNote", LeftNote);
            command.Parameters.AddWithValue("@LeftPartFee", LeftPartFee);


            command.Parameters.AddWithValue("@BackPart", BackPart);
            command.Parameters.AddWithValue("@BackPartImage", BackPartImage);
            command.Parameters.AddWithValue("@BackNote", BackNote);
            command.Parameters.AddWithValue("@BackPartFee", BackPartFee);


            command.Parameters.AddWithValue("@UpperBody", UpperBody);
            command.Parameters.AddWithValue("@UpperBodyImage", UpperBodyImage);
            command.Parameters.AddWithValue("@UpperBodyNote", UpperBodyNote);
            command.Parameters.AddWithValue("@UpperBodyFee", UpperBodyFee);


            command.Parameters.AddWithValue("@Bag", Bag);
            command.Parameters.AddWithValue("@BagImage", BagImage);
            command.Parameters.AddWithValue("@BagNote", BagNote);
            command.Parameters.AddWithValue("@BagFee", BagFee);


            try
            {
                connection.Open();

                object result = command.ExecuteScalar();


                if (result != null && int.TryParse(result.ToString(), out int insertedID))
                {
                    CheckID = insertedID;
                }
            }

            catch (Exception ex)
            {
                //Console.WriteLine("Error: " + ex.Message);

            }

            finally
            {
                connection.Close();
            }


            return CheckID;
        }
         
        public static bool GetCheckInfoByID(int CheckID, ref DateTime DateCheck, ref Boolean FrontPart, ref string FrontPartImage, ref string FrontPartNote,ref double FrontPartFee, ref Boolean RightPart, ref string RightPartImage, ref string RightNote,
            ref double RightPartFee,
            ref Boolean LeftPart, ref string LeftPartImage, ref string LeftNote,ref double LeftPartFee, ref Boolean BackPart, ref string BackPartImage, ref string BackNote,ref double BackPartFee,
            ref Boolean UpperBody, ref string UpperBodyImage, ref string UpperBodyNote,ref double UpperBodyFee,
            ref Boolean Bag, ref string 
            BagImage, ref string BagNote,ref double BagFee)
        {

            bool isFound = false;
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            string query = "SELECT * FROM Checks WHERE CheckID = @CheckID";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@CheckID", CheckID);
            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                if (reader.Read())
                {
                    // The record was found
                    isFound = true;

                    DateCheck = (DateTime)reader["DateCheck"];


                    FrontPart = (Boolean)reader["FrontPart"];
                    FrontPartImage = (string)reader["FrontPartImage"];
                    FrontPartNote = (string)reader["FrontPartNote"];
                    FrontPartFee = double.Parse( reader["FrontPartFee"].ToString());


                    RightPart = (Boolean)reader["RightPart"];
                    RightPartImage = (string)reader["RightPartImage"];
                    RightNote = (string)reader["RightNote"];
                    RightPartFee = double.Parse(reader["RightPartFee"].ToString());


                    LeftPart = (Boolean)reader["LeftPart"];
                    LeftPartImage = (string)reader["LeftPartImage"];
                    LeftNote = (string)reader["LeftNote"];
                    LeftPartFee = double.Parse(reader["LeftPartFee"].ToString());


                    BackPart = (Boolean)reader["BackPart"];
                    BackPartImage = (string)reader["BackPartImage"];
                    BackNote = (string)reader["BackNote"];
                    BackPartFee = double.Parse(reader["BackPartFee"].ToString());

                    UpperBody = (Boolean)reader["UpperBody"];
                    UpperBodyImage = (string)reader["UpperBodyImage"];
                    UpperBodyNote = (string)reader["UpperBodyNote"];
                    UpperBodyFee = double.Parse(reader["UpperBodyFee"].ToString());


                    Bag = (Boolean)reader["Bag"];
                    BagImage = (string)reader["BagImage"];
                    BagNote = (string)reader["BagNote"];
                    BagFee = double.Parse(reader["BagFee"].ToString());

                }
                else
                {
                    // The record was not found
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
         

        public static bool IsCheckExist(int CheckID)
        {
            bool isFound = false;

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = "SELECT Found=1 FROM Checs WHERE CheckID = @CheckID";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@CheckID", CheckID);

            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                isFound = reader.HasRows;

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
         
        public static DataTable GetAllChecks()
        {

            DataTable dt = new DataTable();
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = "SELECT * FROM Checs";

            SqlCommand command = new SqlCommand(query, connection);

            try
            {
                connection.Open();

                SqlDataReader reader = command.ExecuteReader();

                if (reader.HasRows)

                {
                    dt.Load(reader);
                }

                reader.Close();


            }

            catch (Exception ex)
            {
                // Console.WriteLine("Error: " + ex.Message);
            }
            finally
            {
                connection.Close();
            }

            return dt;

        }
        // Implemention Delete

        public static bool DeleteCheck(int CheckID)
        {

            int rowsAffected = 0;

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = @"Delete Checs 
                                where CheckID = @CheckID";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@CheckID", CheckID);

            try
            {
                connection.Open();

                rowsAffected = command.ExecuteNonQuery();

            }
            catch (Exception ex)
            {
                // Console.WriteLine("Error: " + ex.Message);
            }
            finally
            {

                connection.Close();

            }

            return (rowsAffected > 0);

        }
        // Implemention Update

        public static bool UpdateCheck(int CheckID, DateTime DateCheck, Boolean FrontPart, string FrontPartImage, string FrontPartNote, double FrontPartFee, Boolean? RightPart, string RightPartImage, string RightNote, double RightPartFee,
            Boolean LeftPart, string LeftPartImage,
            string LeftNote, double LeftPartFee, Boolean BackPart
            , string BackPartImage, string BackNote, double BackPartFee, Boolean UpperBody, string UpperBodyImage, string UpperBodyNote, double UpperBodyFee, Boolean Bag, string BagImage, string BagNote, double BagFee)
        {

            int rowsAffected = 0;
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = @"Update  Checks  
                            set
			DateCheck = @DateCheck,
			FrontPart = @FrontPart,
			FrontPartImage = @FrontPartImage,
			FrontPartNote = @FrontPartNote,
            FrontPartFee = @FrontPartFee,
			RightPart = @RightPart,
			RightPartImage = @RightPartImage,
			RightNote = @RightNote,
            RightPartFee = @RightPartFee,
			LeftPart = @LeftPart,
			LeftPartImage = @LeftPartImage,
			LeftNote = @LeftNote,
            LeftPartFee = @LeftPartFee,
			BackPart = @BackPart,
			BackPartImage = @BackPartImage,
			BackNote = @BackNote,
            BackPartFee = @BackPartFee,
			UpperBody = @UpperBody,
			UpperBodyImage = @UpperBodyImage,
			UpperBodyNote = @UpperBodyNote,
            UpperBodyFee = @UpperBodyFee,
			Bag = @Bag,
			BagImage = @BagImage,
			BagNote = @BagNote,
            BagFee = @BagFee
             where CheckID = @CheckID";
            SqlCommand command = new SqlCommand(query, connection);


            command.Parameters.AddWithValue(@"CheckID", CheckID);
            command.Parameters.AddWithValue("@DateCheck", DateCheck);


            command.Parameters.AddWithValue("@FrontPart", FrontPart);
            command.Parameters.AddWithValue("@FrontPartImage", FrontPartImage);
            command.Parameters.AddWithValue("@FrontPartNote", FrontPartNote);
            command.Parameters.AddWithValue("@FrontPartFee", FrontPartFee);



            command.Parameters.AddWithValue("@RightPart", RightPart);
            command.Parameters.AddWithValue("@RightPartImage", RightPartImage);
            command.Parameters.AddWithValue("@RightNote", RightNote);
            command.Parameters.AddWithValue("@RightPartFee", RightPartFee);



            command.Parameters.AddWithValue("@LeftPart", LeftPart);
            command.Parameters.AddWithValue("@LeftPartImage", LeftPartImage);
            command.Parameters.AddWithValue("@LeftNote", LeftNote);
            command.Parameters.AddWithValue("@LeftPartFee", LeftPartFee);


            command.Parameters.AddWithValue("@BackPart", BackPart);
            command.Parameters.AddWithValue("@BackPartImage", BackPartImage);
            command.Parameters.AddWithValue("@BackNote", BackNote);
            command.Parameters.AddWithValue("@BackPartFee", BackPartFee);


            command.Parameters.AddWithValue("@UpperBody", UpperBody);
            command.Parameters.AddWithValue("@UpperBodyImage", UpperBodyImage);
            command.Parameters.AddWithValue("@UpperBodyNote", UpperBodyNote);
            command.Parameters.AddWithValue("@UpperBodyFee", UpperBodyFee);


            command.Parameters.AddWithValue("@Bag", Bag);
            command.Parameters.AddWithValue("@BagImage", BagImage);
            command.Parameters.AddWithValue("@BagNote", BagNote);
            command.Parameters.AddWithValue("@BagFee", BagFee);
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
