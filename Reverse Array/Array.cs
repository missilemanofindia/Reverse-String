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
            int[] arr = { 1, 2, 3, 4 };

            // Fix 1: Initialize the output array with the same size as the input array
            int[] output = new int[arr.Length];

            int j = 0;
            // Fix 2: Loop backwards through 'arr' and copy elements into 'output'
            for (int i = arr.Length - 1; i >= 0; i--)
            {
                output[j] = arr[i];
                j++;
            }

            Console.WriteLine($"This is output array {string.Join(",",output)}");

            Console.ReadLine();
        }
    }
}
