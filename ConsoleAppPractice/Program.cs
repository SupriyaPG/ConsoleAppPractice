using ConsoleAppPractice;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");
            
        /*
         demoFunction obj = new demoFunction();
        obj.fun();
        obj.fun1();

        swapProgram swObj = new swapProgram();
        swObj.swp();

        constValue objConst=new constValue();
        objConst.fixValue();

        BoxingExample example = new BoxingExample();
        example.boxingFun();
        example.unboxingFun();

        DataTypes dataTypes = new DataTypes();
        dataTypes.PDatatype();
        dataTypes.DDatatype();

        sumOfDate sd=new sumOfDate();
        sd.date();

        ternaryOperator tO=new ternaryOperator();
        tO.evenOdd();

        switchCase sc=new switchCase();
        sc.vowelCon();
        */

        forLoopDemo fd=new forLoopDemo();
        fd.LpatternDemo();
        fd.triPatternDemo();
        fd.invTriPatternDemo();
        fd.invTriPatternDemo2();
        fd.trianglePattern();
        fd.numPattern();
        fd.letterPattern();
    }
}