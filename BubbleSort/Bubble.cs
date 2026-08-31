using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BubbleSort
{
    public class Bubble
    {
        static void Main(string[] args)
        {
            int[] Arr = { 5, 6, 2, 7, 1, 8, 3 };
            int n = Arr.Length;
            //  Array.ForEach(Arr, Console.WriteLine);
            Console.WriteLine(string.Join(", ", Arr));
            for (int i =0;i<n-1;i++)
            {
                for (int j =0;j<n-1;j++)
                {
                    if (Arr[j] > Arr[j + 1])
                    {
                        int temp = Arr[j];
                        Arr[j] = Arr[j + 1];
                        Arr[j + 1] = temp;
                    }
                }

            }
            Console.WriteLine(string.Join(", ", Arr));
            Console.ReadLine();
        }
    }
}
