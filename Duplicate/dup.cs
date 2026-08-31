using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Duplicate
{
    public  class dup
    {
        static void Main(string[] args)
        {
            int[] Arr = { 1, 2, 7, 9, 5 };

            for(int i = 0; i < Arr.Length; i++)
            {
                int k = Arr[i];
                for (int j = 0; j < Arr.Length; j++)
                {
                    if (k == j)
                    {
                        Console.WriteLine("asda");
                        break;
                    }
                }

            }
            Console.ReadLine();
        }
    }
}
