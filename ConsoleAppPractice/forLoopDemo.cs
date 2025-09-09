using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//WAP for L Pattern

namespace ConsoleAppPractice
{
    internal class forLoopDemo
    {
        internal void LpatternDemo()
        {
            int i, j;
            int n = 5;

            for(i=0;i<=5;i++)
            {
                if (i < n)
                { Console.WriteLine("*");  }
                else
                {
                    for (j = 0; j <= n; j++)
                    {
                        Console.Write("* ");
                    }
                    Console.WriteLine();
                }
                
            }

        }

        internal void triPatternDemo()
        {
            int i, j;
            
            for (i = 0; i <= 5; i++)
            {
              
                for(j = 0; j <= i;j++)
                {
                    Console.Write("* ");
                  
                }
                Console.WriteLine();
            }
        }

        internal void invTriPatternDemo()
        {
            int i, j;
            int n = 5;

            for (i = 0; i <= 5; i++)
            {
                for (j = 5; j >= i; j--)
                {
                    Console.Write(" ");
                    if (n <= j)
                    {
                        Console.Write("*");
                        n--;
                    }
                    
                }
                 Console.WriteLine();
            }

        }

        internal void invTriPatternDemo2()
        {
            int i, j;
            

            for (i = 5; i >= 0; i--)
            {
                for (j = 0; j <= i; j++)
                {
                   
                    if (j >= i)
                    {
                        int n = 5;
                        do
                        { 
                            Console.Write("*"); 
                            n--; 
                        } 
                        while (j<=n);
                    }
                    else
                        Console.Write(" ");

                }
                Console.WriteLine();
            }
        }

        internal void trianglePattern()
        {
            int i, j;

            for (i = 5; i >= 0; i--)
            {


                for (j = 0; j <= i; j++)
                {

                    if (j >= i)
                    {
                        int n = 5;
                        do
                        {
                            Console.Write("* ");
                            n--;
                        }
                        while (j <= n);
                    }
                    else
                        Console.Write(" ");

                }
                Console.WriteLine();
            }
        }

        internal void numPattern()
        { 
          for(int i = 1; i <= 5; i++)
          { 
                for (int j = 1; j <= 6 - i; j++)
                {
                    if (i % 2 != 0)
                        Console.Write(j + " ");
                    else
                        Console.Write(6 - j + " ");

                }
                Console.WriteLine();
          }
        }

        internal void letterPattern()
        {
            for(int i = 1;i <= 5;i++)
            {
                char ch= 'A';
                for(int j = 1;j <= 6 - i;j++)
                {
                    if(j%2!=0)
                        Console.Write(ch+" ");
                    else
                    {
                        Console.Write((char)(ch + 32)+ " ");
                        ch++;
                    }
                        
                }
                Console.WriteLine();
            }
        }
    }
}
