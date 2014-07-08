using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2
{
    class Program
    {
        static void Main(string[] args)
        {
            double book1 = 10.19;
            double book2 = 13.57;
            
            int x;
            
            Console.WriteLine("10 Day Green Smoothie Cleanse: $" + book1);
            Console.WriteLine("Discover Secrets to a Healthier You: $" + book2);
            
            
            if (book1 < book2)
            {
                x = -1;
                Console.WriteLine(x);
            }
            else if (book1 > book2)
            {
                x = 1;
                Console.WriteLine(x);
            }
            else

                x = 0;
                Console.ReadLine();         

            
        }

    }
}
