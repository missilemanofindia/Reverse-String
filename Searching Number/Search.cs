using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Searching_Number
{
    public class Search
    {
        static void Main(string[] args)
        {


            int[] Arr = { 12, 20, 30, 40, 50 };
            Boolean isFounf = false;

            Console.WriteLine("Enter number to find in array : ");
            int find = Convert.ToInt32(Console.ReadLine());
           // int find = 30;

            for(int i = 0; i < Arr.Length; i++)
            {
                if (Arr[i] == find)
                {
                    isFounf = true;          
                    break;
                }
               
            }

            if (isFounf == true)
            {
                Console.WriteLine($"We found {find} in given array.");
            }
            else
            {
                Console.WriteLine($"We dont found {find} in given array.");
            }
            
            Console.ReadLine();

        }
    }
}
