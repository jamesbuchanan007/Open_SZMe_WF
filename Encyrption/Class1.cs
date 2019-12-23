using System;
using System.IO;
using System.Net.Mime;
using System.Security.Cryptography;
using System.Net.Sockets;
namespace Encyrption
{
    public class Class1
    {
        public static bool EncryptData(string site, string userId, string password, string misc)
        {
            try
            {
                //Create a new instance of the RijndaelManaged class and encrypt the stream.  
                RijndaelManaged rmCrypto = new RijndaelManaged();

                byte[] key = { 0x01, 0x02, 0x03, 0x04, 0x05, 0x06, 0x07, 0x08, 0x09, 0x10, 0x11, 0x12, 0x13, 0x14, 0x15, 0x16 };
                byte[] iv = { 0x01, 0x02, 0x03, 0x04, 0x05, 0x06, 0x07, 0x08, 0x09, 0x10, 0x11, 0x12, 0x13, 0x14, 0x15, 0x16 };

                string filePath = $@"{Environment.CurrentDirectory}\ed\+{site.Trim()}.txt";

                //Create a CryptoStream, pass it the FileStream, and encrypt it with the Rijndael class.  
                using (FileStream fileStream = new FileStream(filePath, FileMode.OpenOrCreate, FileAccess.Write))
                {
                    using (CryptoStream cryptStream = new CryptoStream(fileStream, rmCrypto.CreateEncryptor(key, iv), CryptoStreamMode.Write))
                    {
                        using (StreamWriter sWriter = new StreamWriter(cryptStream))
                        {
                            //ADD STRING TEXT
                            sWriter.WriteLine(site.Trim());
                            sWriter.WriteLine(userId.Trim());
                            sWriter.WriteLine(password.Trim());
                            sWriter.WriteLine(misc.Trim());

                            //Close all the connections.  
                            sWriter.Close();
                            cryptStream.Close();
                            fileStream.Close();
                        }
                    }
                }

                return true;
            }
            catch
            {
                return false;
            }
        }
    }
}
