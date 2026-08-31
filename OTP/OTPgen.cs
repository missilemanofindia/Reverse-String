using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OTP
{
    class OTPgen
    {
        static void Main(string[] args)
        {
            
                // Generate a random 6-character alphanumeric OTP 
                string otp = GenerateRandomOTP(6);

                Console.WriteLine("Generated OTP: " + otp);

            Console.ReadLine();
        }

            static string GenerateRandomOTP(int length)
            {
                const string characters = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";

                // Use a StringBuilder for efficient string concatenation 
                System.Text.StringBuilder otpBuilder = new System.Text.StringBuilder();

                // Use a random number generator 
                Random random = new Random();

                for (int i = 0; i < length; i++)
                {
                    // Append a random character from the 'characters' string 
                    otpBuilder.Append(characters[random.Next(characters.Length)]);
                }

                return otpBuilder.ToString();
           
            }

    }



}
    