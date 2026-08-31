using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reverse_Array
{
    public class Array
    {
        static void Main(string[] args)
        {
            int [] arr = { 1,2,3,4 };
            int[] output = { };
            for(int i = arr.Length - 1; i >= 0; i--)
            {
                Console.WriteLine("your array number: " + arr[i]);
            }
            Console.ReadLine();
        }
    }
}
