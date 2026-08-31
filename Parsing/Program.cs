using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parsing
{
    class Program
    {
        static void Main(string[] args)
        {
            string Input = "abc";

            // --- Using Parse() ---
            // ❌ This line immediately crashes the app with a FormatException
          //  int Result1 = int.Parse(Input);
          //  Console.WriteLine($"Success: {Result1}");
            // --- Using TryParse() ---
            //  This safely checks the data and assigns 0 to the result variable
            if (int.TryParse(Input, out int Result2))
            {
                Console.WriteLine($"Success: {Result2}");
            }
            else
            {
                Console.WriteLine("Conversion failed. No exception thrown!");
            }
            Console.ReadLine();
        }
    }
}
