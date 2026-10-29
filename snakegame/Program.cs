using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace snakegame
{
    public class Country
    {
        public static int SnakeFill(int side)
        {
            int sizeofBox = side * side;
            int currentlength = 1;

            int count = 0;
            for (int i = 1; i <= sizeofBox; i++)
            {
                if (currentlength <= sizeofBox)
                {
                    currentlength = currentlength * 2;
                    if (currentlength > sizeofBox)
                    {
                        break;
                    }
                    count++;
                }

            }
            Console.WriteLine($"{count} times the snake can eat before it runs out of space.");
            return count;
        }
    }


    public class Program
    {
        static void Main(string[] args)
        {
            Country.SnakeFill(8);
            Console.ReadLine();
        }
    }
}
