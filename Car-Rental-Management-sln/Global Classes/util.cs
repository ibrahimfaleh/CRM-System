using System;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Security.Policy;
using System.Text;
using System.Windows.Forms;
using System.Windows.Forms.Design;

namespace CarRental.Classes
{
    public class clsUtil
    {
        public static string GenerateGUID()
        {

            // Generate a new GUID
            Guid newGuid = Guid.NewGuid();

            // convert the GUID to a string
            return newGuid.ToString();

        }

        public static bool CreateFolderIfDoesNotExist(ref string DestinationFolder)
        {
            string CurrentDirectory = Directory.GetCurrentDirectory();
            DirectoryInfo Folder = new DirectoryInfo(CurrentDirectory.Substring(0,CurrentDirectory.IndexOf("CRM-System")+10)+"/"+ DestinationFolder);
            DestinationFolder = Folder.FullName;   
            if (!Folder.Exists)
            {
                try
                {

                    Folder.Create();
                    return true;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error creating folder: " + ex.Message);
                    return false;
                }
            }

            return true;

        }

        public static string ReplaceFileNameWithGUID(string sourceFile)
        {
            // Full file name. Change your file name   
            string fileName = sourceFile;
            FileInfo fi = new FileInfo(fileName);
            string extn = fi.Extension;
            return GenerateGUID() + extn;

        }
        public static string ComputeHash(string input)
        {
            using (SHA256 sha256 = SHA256.Create()) 
            {
                byte[] hashBytes = sha256.ComputeHash(Encoding.UTF8.GetBytes(input));
                return BitConverter.ToString(hashBytes).Replace("-","").ToLower();
            }
        }
        public static bool CopyImagePeopleToProjectImagesFolder(ref string sourceFile)
        {
            // this funciton will copy the image to the
            // project images foldr after renaming it
            // with GUID with the same extention, then it will update the sourceFileName with the new name.

            string DestinationFolder = @"CarRental-People-Images\";
            if (!CreateFolderIfDoesNotExist(ref DestinationFolder))
            {
                return false;
            }

            string destinationFile = DestinationFolder + ReplaceFileNameWithGUID(sourceFile);
            try
            {
                File.Copy(sourceFile, destinationFile, true);

            }
            catch (IOException iox)
            {
                MessageBox.Show(iox.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            sourceFile = destinationFile;
            return true;
        }
        public static bool CopyImageVehiclesToProjectImagesFolder(ref string sourceFile)
        {

            string DestinationFolder = @"CarRental-Vehicles-Images\";
            if (!CreateFolderIfDoesNotExist(ref DestinationFolder))
            {
                return false;
            }

            string destinationFile = DestinationFolder + ReplaceFileNameWithGUID(sourceFile);
            try
            {
                File.Copy(sourceFile, destinationFile, true);

            }
            catch (IOException iox)
            {
                MessageBox.Show(iox.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            sourceFile = destinationFile;
            return true;
        }
        public static bool CopyLogoCompanyToProjectImagesFolder(ref string sourceFile)
        {
            string DestinationFolder = @"CarRental-LogoCompany-Images\";
            if (!CreateFolderIfDoesNotExist(ref DestinationFolder))
            {
                return false;
            }
            string destinationFile = DestinationFolder + ReplaceFileNameWithGUID(sourceFile);
            try
            {
                File.Copy(sourceFile, destinationFile, true);

            }
            catch (IOException iox)
            {
                MessageBox.Show(iox.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            sourceFile = destinationFile;
            return true;
        }
        public static bool CopyImageBillsToProjectImagesFolder(ref string sourceFile)
        {
            string DestinationFolder = @"CarRental-Bills-Images\";
            if (!CreateFolderIfDoesNotExist(ref DestinationFolder))
            {
                return false;
            }

            string destinationFile = DestinationFolder + ReplaceFileNameWithGUID(sourceFile);
            try
            {
                File.Copy(sourceFile, destinationFile, true);

            }
            catch (IOException iox)
            {
                MessageBox.Show(iox.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            sourceFile = destinationFile;
            return true;
        }

        public static bool CopyImageFinancialPenaltyToProjectImagesFolder(ref string sourceFile)
        {
            string DestinationFolder = @"CarRental-FinancialPenalty-Images\";
            if (!CreateFolderIfDoesNotExist(ref DestinationFolder))
            {
                return false;
            }

            string destinationFile = DestinationFolder + ReplaceFileNameWithGUID(sourceFile);
            try
            {
                File.Copy(sourceFile, destinationFile, true);

            }
            catch (IOException iox)
            {
                MessageBox.Show(iox.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            sourceFile = destinationFile;
            return true;
        }
        public static bool CopyImageChecksToProjectImagesFolder(ref string sourceFile)
        {
            string DestinationFolder = @"CarRental-Checks-Images\";
            if (!CreateFolderIfDoesNotExist(ref DestinationFolder))
            {
                return false;
            }

            string destinationFile = DestinationFolder + ReplaceFileNameWithGUID(sourceFile);
            try
            {
                File.Copy(sourceFile, destinationFile, true);

            }
            catch (IOException iox)
            {
                MessageBox.Show(iox.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            sourceFile = destinationFile;
            return true;
        }
    }
}
