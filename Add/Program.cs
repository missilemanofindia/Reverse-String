using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using addition;

namespace Add
{
    public class Program
    {
        public static void Main(string[] args)
        {
            //Arrange
            Class1 c1 = new Class1();
            int a = 10;
            int b = 20;
            int c = 6;
            int d = 30;
            int ouput = c1.Add();
            Console.WriteLine($"{ouput}");
            Console.ReadLine();
            

        }
    }
}
