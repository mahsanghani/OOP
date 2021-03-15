using System;
using System.Collections.Generic;
using System.Text;

namespace OOP
{
    class myBase
    {
        public virtual void VirtualMethod()
        {
            Console.WriteLine("virtual method defined in the base class");
        }
    }
    class myDerived : myBase
    {
        public override void VirtualMethod()
        {
            base.VirtualMethod();
            Console.WriteLine("virtual method defined in the derived class");
        }
    }
    class virtualClass
    {
        /*static void Main(string[] args)
        {
            new myDerived().VirtualMethod();
            Console.ReadKey();
        }*/
    }
}
