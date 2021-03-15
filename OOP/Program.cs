using System;

namespace OOP
{
    class Program
    {
        public void MainFunction()
        {
            Console.WriteLine("Main class");
        }
        /*static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            Program program = new Program();
            program.MainFunction();

            demo demoObject = new demo();
            demoObject.addition();

            partialclassDemo obj = new partialclassDemo();
            obj.method1();obj.method2();
        }*/
    }

    class demo
    {
        int x = 10;int y = 20;int z;
        public void addition()
        {
            z = x + y;
            Console.WriteLine("other class in Namespae");
            Console.WriteLine(z);
        }
    }

    static class staticDemo
    {
        static int x = 10, y;

        static void calculate()
        {
            y = x * x;
            Console.WriteLine(y);
        }
        /*static void Main(string[] args)
        {
            staticDemo.calculate();
        }*/
    }
}
