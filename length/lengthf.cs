using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace length
{
    public static class extensionmthd
    {
        static int count = 0;
        public static int Lengthy(this string textlength)
        {
            foreach (char letter in textlength)
            {
                count = count + 1;
            }
            return count;
        }
    }

    // "this" keyword in C# : it tells the method you are currently working on it. if we dont use that keyword in lengthy method then we had to call 
    //the class name and need to access the method and inside which we would have to pass textlength;
    // with "this" :  int count = name.Lengthy();
    //without "this" : int count = extensionmthd.Lengthy(name);

    public class lengthf
    {
        static void Main(string[] args)
        {
          

                Console.WriteLine("Enter the string Name : ");
                string name = Console.ReadLine();

                // string name = "Abhishek";
                string reverse = "";
                int count = name.Lengthy();
                Console.WriteLine("Length is : " + count);
                Console.WriteLine("-------------------------Lets Reverse the Given string-----------------------------");

                for (int i = count - 1; i >= 0; i--)
                {
                    reverse = reverse + name[i];
                }

                Console.WriteLine("Your Reverse string is : " + reverse);

                Console.ReadLine();
            
        }
    }
}
