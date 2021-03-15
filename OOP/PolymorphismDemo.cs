using System;
using System.Collections.Generic;
using System.Text;

namespace OOP
{
    public abstract class Employee
    {
        public virtual void LeaderName()
        {

        }
    }

    public class hrDept : Employee
    {
        public override void LeaderName()
        {
            base.LeaderName();
            Console.WriteLine("Bob");
        }
    }

    public class itDept : Employee
    {
        public override void LeaderName()
        {
            base.LeaderName();
            Console.WriteLine("Joe");
        }
    }

    public class finDept : Employee
    {
        public override void LeaderName()
        {
            base.LeaderName();
            Console.WriteLine("Tom");
        }
    }

    class PolymorphismDemo
    {
        static void Main(string[] args)
        {
            hrDept hr = new hrDept();
            itDept it = new itDept();
            finDept fin = new finDept();

            hr.LeaderName();
            it.LeaderName();
            fin.LeaderName();

            Console.ReadKey();
        }
    }
}
