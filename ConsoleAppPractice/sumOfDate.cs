using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppPractice
{
    internal class sumOfDate
    {
        internal void date()
        {
            String dt = "07092025";

            int d1 = Convert.ToInt32(dt);
            int sum = 0;

            while (d1!=0)
            {
                int first = d1 % 10;
                d1 = (int)(d1 / 10);
                sum += first;
            }

            Console.WriteLine(sum);
        }
    }
}
