using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Stack stores the values in LIFO style(Last In First Out). It provides a Push() to add a value and Pop() to retrieve values.
//C# includes both, generic and non generic Stack.

namespace practiceApp
{
    internal class StackDemo
    {
        internal void StackFun()
        {
            Stack<int> obj = new Stack<int>();
            obj.Push(1001);
            obj.Push(2003);
            obj.Push(3006);
            obj.Push(4008);
            obj.Push(5009);

            foreach(int i in obj)
            {
                Console.WriteLine("Pushed Element: "+i);
            }
            Console.WriteLine("Pop Out Element: "+obj.Pop());
        }

    }
}
