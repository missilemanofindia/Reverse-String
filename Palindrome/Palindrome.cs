using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Palindrome
{
    public class Palindrome
    {
        static void Main(string[] args)
        {
   
          
                Console.Write("Enter a Number To Check Palindrome: ");
                int number = int.Parse(Console.ReadLine());
                int remainder, sum = 0;
                int temp = number;
                while (number > 0)
                {
                    remainder = number % 10;
                    sum = (sum * 10) + remainder;
                    number /= 10;
                }
                if (temp == sum)
                    Console.WriteLine($"Number {temp} is Palindrome.");
                else
                    Console.WriteLine($"Number {temp} is not Palindrome.");

            Console.ReadLine();
        }

    }
}


