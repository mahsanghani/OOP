using System;
using System.Collections.Generic;
using System.Text;

namespace OOP
{
    public abstract class Employees
    {
        public abstract void displayData();
    }
    public class test : Employees
    {
        public override void displayData()
        {
            Console.WriteLine("abstract class method");
        }
    }
    class abstractClass
    {
        /*static void Main(string[] args)
        {
            new test().displayData();
        }*/
    }
}
