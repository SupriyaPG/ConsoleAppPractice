using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

//Hashtable stores key and value pairs. It retrieves the values by compairing the hash value of the keys. BitArray manages a compact
//array of bit values which represented as Booleans,where true indicates that the bit is on (1) and false indicates the bit is off(0).

namespace practiceApp
{
    internal class HashTable
    {
        internal void HashtableFun()
        {
            Hashtable o = new Hashtable();
            o.Add("RNo", 1001);
            o.Add("Name", "Jay Kumar");
            o.Add("Branch", "CS");
            o.Add("fees", 20000);

            o.Remove("fees"); // to remove elememt

            foreach (DictionaryEntry obj in o)
            {
                Console.WriteLine("Kay is: {0} and vale is: {1}", obj.Key, obj.Value);
            }
        }
    }
}
