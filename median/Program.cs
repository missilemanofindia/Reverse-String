using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace median
{
    public class Program
    {
        public static void Main(string[] args)
        {
            int[] num1 = { 1, 3, 4 };
            int[] num2 = {2};

            int[] merged = num1.Concat(num2).ToArray();

            Console.WriteLine($"merged aaray is [{string.Join(",",merged)}]");
            Console.ReadLine();
        }
    }
}
