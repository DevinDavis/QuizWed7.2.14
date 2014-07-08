using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication3
{
    class Program
    {
        static void Main(string[] args)
        {
            int three = 3;
            int five = 5;

            for (int x = 1; x <= 100; x++)
            {

                if (0 == x % 3 && 0 != x % 5)
                {
                    Console.WriteLine(x + " Fizz");
                }
                else if (0 == x % 5 && 0 != x % 3)
                {
                    Console.WriteLine(x + " Buzz");
                }
                else if (0 == x % 3 && 0 == x % 5)
                {
                    Console.WriteLine(x + " FizzBuzz");
                }
                else
                {
                    Console.WriteLine(x);
                }
            }
                    Console.ReadLine();
        }
    }
}
