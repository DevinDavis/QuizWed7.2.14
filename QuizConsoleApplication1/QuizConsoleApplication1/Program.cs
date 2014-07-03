using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuizConsoleApplication1
{
    public class FindSmallest
    {
        static void Main(string[] args)
        {
            int a = 50;
            int b = 100;
            int ret;
            FindSmallest n = new FindSmallest();

            ret = n.FindMin(a, b);
            Console.WriteLine("Smallest Interger is {0}", ret);
            Console.ReadLine();
        }
        public int FindMin(int a, int b)
        {
            int result;

            if (a < b)
                result = a;

            else
                result = b;

            return result;
        }
    }
}

