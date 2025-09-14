using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practiceApp
{
    internal class ExceptionHandling
    {
        internal void Exc_Handling()
        {
            /*  int a, b, c;
              a = 10;
              b = 0;
              c = a / b;
              Console.WriteLine(c);*/ //this code gives run time error - exception handling
            String s = "Success";
            try {
            int a, b, c;
                Console.WriteLine("Enter first number:");
            a = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter second number:");
                b =Convert.ToInt32(Console.ReadLine());
            c = a / b;
            Console.WriteLine("{0}/{1}",a,b+ "="+c);
            }
            catch(FormatException ex)
            { Console.WriteLine("Enter only numeric value");
                s = "Fail";
            }
            catch (DivideByZeroException ex)
            { Console.WriteLine("Denominator can not be zero");
                s = "Fail";
            }
            finally { Console.WriteLine(s); }
        }
    }
}
