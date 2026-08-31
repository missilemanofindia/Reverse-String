using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinarySearch
{
    public class Binary
    {
        static void Main(string[] args)
        {
            int[] Arr = {1,2,3,4,5,6,7,8,9,10};

            //************ In Built Method ********************//

                 int a = Array.BinarySearch(Arr, 4);  // BinarySearch(Array, ValueToCheck)
                 Console.WriteLine(a);

            //************************************************//

            //Boolean flag = false;
            //int key = 11;
            //int l = 0;
            //int h = Arr.Length - 1;
            
            //while (l<=h)
            //{
            //    int m = (l + h) / 2;

            //    //1)
            //    if (Arr[m] == key)
            //    {
            //        Console.WriteLine("Element found...!");
            //        flag = true;
            //        break;
            //    }

            //    //2)
            //    if (Arr[m] < key)
            //    {
            //        l = m + 1;  
            //    }

            //    //3)
            //    if (Arr[m] > key)
            //    {
            //        h = m - 1;
            //    }

               
            //}
            //if (flag == false)
            //{
            //    Console.WriteLine("Element not found!!!");
            //}
            Console.ReadLine();
        }
    }
}
