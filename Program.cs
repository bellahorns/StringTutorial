using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringTutorial
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a string to encrypt:"); 

            try
            {
                string message = Console.ReadLine();
                string encryptedMessage = EncryptString(message);
            }
            catch (FormatException)
            {
                Console.WriteLine("Incorect Input");
            }
            finally
            {
                Console.WriteLine("Press any key to exit...");
                Console.ReadKey();
            }
        }

        static string EncryptString(string inputString)
        {
            // Guard clause to check if input is a valid string

            // Reverse the string
            char[] cArray = inputString.ToCharArray();
            string reverse = String.Empty;
            for (int i = cArray.Length - 1; i > -1; i--)
            {
                reverse += cArray[i];
            }

            // Convert every second charatcer to uppercase
            string multiCase = String.Empty;


            // Interpolateion and concatenation
            string secretCode = "secret-" + multiCase + "-code";


            // String conversion using ASCII values to shift each character by 1


            string finalEncryption = new string(finalEncryptionChars);
            return finalEncryption;
        }
    }
}
