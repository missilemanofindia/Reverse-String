using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Diagnostics;

namespace practise
{
   
    public class Program
    {
        public static void Main(string[] args)
        {
            int totalElements = 100000;
            List<int> myList = new List<int>();
            HashSet<int> mySet = new HashSet<int>();

            // Fill both with numbers from 0 to 99,999
            for (int i = 0; i < totalElements; i++)
            {
                myList.Add(i);
                mySet.Add(i);
            }

            // Target is the last item (worst-case scenario for List)
            int target = 99999;

            // 1. Benchmark the List
            Stopwatch watch = Stopwatch.StartNew();
            bool foundInList = myList.Contains(target);
            watch.Stop();
            Console.WriteLine($"[List] Found: {foundInList} | Time: {watch.Elapsed.TotalMilliseconds} ms");

            // 2. Benchmark the HashSet
            watch.Restart();
            bool foundInSet = mySet.Contains(target);
            watch.Stop();
            Console.WriteLine($"[HashSet] Found: {foundInSet} | Time: {watch.Elapsed.TotalMilliseconds} ms");

            Console.ReadLine();
        }
    }
    
}
