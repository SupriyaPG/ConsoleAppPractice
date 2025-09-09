using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppPractice
{
    internal class swapProgram
    {
        static int a = 10, b = 20;

        internal void swp()
        {
            int temp;
            temp = a;
            a = b;
            b = temp;
            Console.WriteLine("This is Swap function :");

            Console.WriteLine("Value of a={0} and value of b={1}", a, b);
        }
    }
}
