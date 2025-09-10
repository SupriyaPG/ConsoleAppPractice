using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Constructor is a dafault component of the class that will be called automatically when we create object.
// By default class contain system define defualt constructor that create constructor block after program compilation.

namespace practiceApp
{
    internal class ConstructorExamle
    {
        static int x,y;
        int a, b;
        static ConstructorExamle()
        {
            x = 100;
            y = 200;
            Console.WriteLine("This is a static default constructor"+(x+y));
        }

        internal ConstructorExamle()
        {
            a= 100;
            b= 200;
            Console.WriteLine("This is default constructor."+(a+b));
        }

        internal ConstructorExamle(int a, int b)
        { 
            this.a = a; this.b = b;
            Console.WriteLine("This is a parameterised constructor"+(a + b));
        }
    }
}
