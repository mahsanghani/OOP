using System;
using System.Collections.Generic;
using System.Text;

namespace OOP
{
    public interface abc
    {
        void methodA();
        void methodB();
    }
    public interface xyz : abc 
    { 
        void methodC(); 
    }
    class test3 : abc
    {
        public void methodA()
        {
            Console.WriteLine("methodA");
        }
        public void methodB()
        {
            Console.WriteLine("methodB");
        }
    }
    class InterfaceDemo
    {
        /*static void Main(string[] args)
        {
            test3 test3 = new test3();
            test3.methodA();
            test3.methodB();
        }*/
    }
}
