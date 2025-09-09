using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practiceApp
{
    internal class employee
    {
        private int empid;
        private int age;
        private String empname;

        internal void accept(int empid,String empname, int age)
        {
            this.empid = empid;
            this.age = age;
            this.empname = empname;

        }

        internal void display()
        {
            Console.WriteLine("Id:{0},Name:{1},Age:{2}",empid,empname,age);
        
        }
    }
}
