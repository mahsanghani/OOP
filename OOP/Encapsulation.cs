using static OOP.Customer;
using System;
using System.Collections.Generic;
using System.Text;

namespace OOP
{
    class Encapsulation
    {
        int x;
        public Encapsulation(int iX)
        {
            this.x = iX;
        }
        public void MySquare()
        {
            int calc = x * x;
            Console.WriteLine(calc);
        }

        /*static void Main(string[] args)
        {
            Encapsulation encapsulation= new Encapsulation(20);
            encapsulation.MySquare();
        }*/
    }
}
