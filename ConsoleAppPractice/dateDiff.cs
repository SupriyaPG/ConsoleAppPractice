using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// WAP to calculate the difference of two dates shold be assigning on DDMMYYYY. suppose date are 12052016 13062019

namespace ConsoleAppPractice
{
    internal class dateDiff
    {
       internal void yrDiff()
        {
            String date1 = "12052016";
            String date2 = "13062019";
            int d1=Convert.ToInt32(date1);
            int d2=Convert.ToInt32(date2);
            int y1 = d1 % 10000;
            int y2 = d2 % 10000;
            Console.WriteLine("Difference of date in year {0} ",y2-y1);

        }
    }
}
