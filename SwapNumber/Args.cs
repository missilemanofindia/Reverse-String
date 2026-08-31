using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SwapNumber
{
    public class Args
    {
        static void Main(string[] args)
        {
            Console.WriteLine($"Total arguments passed: {args.Length}");

            for (int i = 0; i < args.Length; i++)
            {
                Console.WriteLine($"Argument [{i}]: {args[i]}");
            }

            // args[0] = "add"
            // args[1] = "5"
            // args[2] = "10"

            if (args[0] == "add")
            {
                int num1 = int.Parse(args[1]);
                int num2 = int.Parse(args[2]);
                Console.WriteLine($"Result: {num1 + num2}");

                Console.ReadLine();
            }
        }
    }
}
