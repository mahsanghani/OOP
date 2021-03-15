using System;
using System.Collections.Generic;
using System.Text;

namespace OOP
{
    public class Father
    {
        public Father()
        {
            Console.WriteLine("father class constructor");
        }
        public void FatherMethod()
        {
            Console.WriteLine("this property belongs to the Father");
        }
    }

    public class Child : Father
    {
        public Child() : base()
        {
            Console.WriteLine("child class constructor");
        }
        public void ChildMethod()
        {
            Console.WriteLine("this property belongs to the Child");
        }
    }
    class Inheritance
    { 
        /*static void Main(string[] args)
        {
            Father father = new Father();
            father.FatherMethod();

            Child child = new Child();
            child.FatherMethod();
            child.ChildMethod();
            Console.ReadKey();
        }*/
    }
}
