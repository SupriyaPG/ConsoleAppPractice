using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppPractice
{
    internal class BoxingExample
    {
        internal void boxingFun()
        {
            int a = 10;
            Object obj = a; 
            Console.WriteLine("Value of object:"+obj);
        }

        internal void unboxingFun()
        {
            Object a = 20;
            int b = (int)a;
            Console.WriteLine("Value of integer after parsing from object:" + b);
        }
    }
}
