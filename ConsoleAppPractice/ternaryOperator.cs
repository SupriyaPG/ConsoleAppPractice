using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppPractice
{
    internal class ternaryOperator
    {
        internal void evenOdd()
        {
            int num = 5;
            string output = (num %2 == 0) ? "Even No." : "Odd No.";
            Console.WriteLine(output);
        }
    }
}
