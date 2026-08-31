using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimeNumber
{
    public class Prime
    {
        static void Main(string[] args)
        {
            int looping = 0;
            for(int i = 1; i <=args.Length; i++)
            {
                int counter = 0;
                for(int j = 1; j <= i; j++)
                {
                    if (i % j == 0)
                    {
                        counter++;
                      
                    }
                   // looping++;
                }
                if (counter == 2)
                {
                    Console.WriteLine("Its prime:"+i);
                    looping++;
                }
               // Console.WriteLine("This many prime in between 1 to 100:" + looping);
               
            }
            Console.WriteLine("This many prime in between 1 to 100:" + looping);
            Console.ReadLine();
              

        }
    }
}
