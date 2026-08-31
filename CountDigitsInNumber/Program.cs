using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CountDigitsInNumber
{
    public class Program
    {
        static void Main(string[] args)
        {
            //string num = "17423423428";
            //int result = num.Length;
            //Console.WriteLine("Given Number has digits: "+ result);
            int number = 8424528;
            int counter = 0;
            int result;
            while (number > 0)
            {
                number = number / 10;
                result = number;
                counter++;
               // Console.WriteLine($"Given number has {result}");
            }
            for (int i = counter;i >= 0; i--)
            {
                Console.WriteLine($"Given number has {i}");
            }
            Console.WriteLine($"Given number has {counter} Digits.");
            Console.ReadLine();
        }
    }
}
