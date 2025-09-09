using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppPractice
{
    internal class switchCase
    {
        internal void vowelCon()
        {
            Console.WriteLine("Enter char :");
            string input= Console.ReadLine();

            char ch = input[0]; 
            //char ch = char.Parse(Console.ReadLine());

            switch(ch)
            {
                case 'a':
                case 'e':
                case 'i':
                case 'o':
                case 'u':
                    Console.WriteLine("Vowel");
                    break;
                default:
                    Console.WriteLine("Consonant");
                    break;
            }

        }
    }
}
