using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppPractice
{
    internal class DataTypes
    {
        public void PDatatype()
        {
            int a = 10; //4 byte
            byte bt = 2; //1 byte
            float f = 23.45F; //4 byte
            double d = 22354.5; //8 byte
            bool b = false; //1 byte
            char c = 'a'; //2 byte
            string str = "hello";

            Console.WriteLine("Primitive datatype : a={0},bt ={1},f={2},d={3},b={4},c={5},str={6}",a,bt,f,d,b,c,str);

        }

        public void DDatatype()
        {
            Int16 a = 10;
            Byte b = 2;
            Double d = 78.8747;
            Boolean b1= true;
            Char ch= 'a';
            String str1= "hello";
            Object o = 66;

            Console.WriteLine("Derived Datatype : a ={0},b ={1},d={2},b1={3},ch={4},str1={5},o={6}",a,b,b1,d,ch,str1,o);
        }
    }
}
