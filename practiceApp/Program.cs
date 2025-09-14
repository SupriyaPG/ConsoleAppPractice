using practiceApp;
using System.Runtime.InteropServices;

internal class Program
{
    private static void Main(string[] args)
    {
        /* Console.WriteLine("Hello, World!");

         employee emp=new employee();
         emp.accept(001, "Sonu", 25);
         emp.display();

         Student[] obj=new Student[5];
         for (int i = 0; i < obj.Length; i++)
         {
             obj[i] = new Student();
             Console.WriteLine("Enter Roll No. :");
             int rno = Convert.ToInt32(Console.ReadLine());
             Console.WriteLine("Enter Fees:");
             int fees = Convert.ToInt32(Console.ReadLine());
             obj[i].Accept(rno, fees);
          }

         int Max = 0;
         int studentIndex = 0;
         for(int i = 0;i<obj.Length;i++)
         {
             if (Max < obj[i].fees)
             {
                 Max = obj[i].fees;
                 studentIndex = i;
             }
         }

         Console.WriteLine("Max Fees is:{0}", Max);
         obj[studentIndex].Display();  

         ConstructorExamle ce=new ConstructorExamle();
         ConstructorExamle objCon=new ConstructorExamle(30,20);  

         PropertyExample pe=new PropertyExample();
         pe._Width = 200;  //setter
         Console.WriteLine(pe._Width); //getter
        

        Carnivorus c = new Carnivorus();
        Herbivores h = new Herbivores();

        c.FoodHabits();
        h.FoodHabits();
        

        IFirst f=new InterfaceDemo();
        ISecond s=new InterfaceDemo();
        f.func1();
        f.func2();
        s.fun1();
        s.fun2();
        s.fun3();
        

        ExceptionHandling eh=new ExceptionHandling();
        eh.Exc_Handling();  

        //using throw keyword

        int num;
        try
        {
            Console.WriteLine("Enter a number:");
            num = Convert.ToInt32(Console.ReadLine());

            if (num < 0)
            {
                //throw new Exception();
                throw new NegativeNumberException();
            }
        }
        catch (NegativeNumberException ex)
        { 
        //    Console.WriteLine(ex.ToString());
                Console.WriteLine(ex.Message); //User define exception NegativeNumberException
        }

        */

        FileOperations fl=new FileOperations();
         fl.createFile();
         fl.AddContentInFile();
        fl.appendContentInFile();
        fl.readFileContent();
        fl.deleteFile();
    }
}