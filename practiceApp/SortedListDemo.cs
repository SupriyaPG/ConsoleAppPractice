using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//SortedList stores key and value pairs. It automatically arranges elements in ascending order of the key by default.
//C# includes both, generic and non-generic SortedList collection.

namespace practiceApp
{
    internal class SortedListDemo
    {
        internal void SortedListFun()
        {
            SortedList sl=new SortedList();
            sl.Add("RNo", 1001);
            sl.Add("Name", "Jay Kumar");
            sl.Add("Branch", "CS");
            sl.Add("fees", 20000);

            sl.Remove("fees"); // to remove elememt

            foreach (DictionaryEntry obj in sl)
            {
                Console.WriteLine("Kay is: {0} and vale is: {1}", obj.Key, obj.Value);
            }
        }
    }
}
