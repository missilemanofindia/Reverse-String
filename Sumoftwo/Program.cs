using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sumoftwo
{
    public class Program
    {
        public static void Main(string[] args)
        {
            int[] lst = { 1, 2, 3, 4, 5, 6, 7 };
            int target = 5;

            for(int i = 0; i <= lst.Length - 1; i++)
            {
                for (int j = 0; j <= lst.Length - 1; j++)
                {
                    if (lst[i] + lst[j] == target)
                    {
                        Console.WriteLine($"We found element {i} and {j}");
                        
                    }
                    break;
                }

            }
            Console.ReadLine();
        }

        
    }
}
