using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


// Interface is pure abstract class that contains set of abstract methods to perform data abstraction
// Interface is also used to implement multiple inheritance that is not possible by class.
// Interface method is public and abstract by default.
// Advantages of interface - 1.Data Abstraction, 2.Multiple inheritance
namespace practiceApp
{
    internal class InterfaceDemo : IFirst, ISecond
    {
        public void fun1()
        {
            Console.WriteLine("Second interface : fun1");
        }

        public void fun2()
        {
            Console.WriteLine("Second interface : fun2");
        }

        public void fun3()
        {
            Console.WriteLine("Second interface : fun3");
        }

        public void func1()
        {
            Console.WriteLine("first interface : func1");
        }
        public void func2()
        {
            Console.WriteLine("first interface : func2");
        }
    }
}
