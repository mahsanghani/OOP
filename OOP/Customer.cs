using System;
using System.Collections.Generic;
using System.Text;

namespace OOP
{
    class Customer
    {
        public int Id;
        public string Name;
        public string Address;

        static private int x,y;
        static Customer() 
        { 
            x = 10; 
        }
        static public void getData()
        {
            y = x * x;
            Console.WriteLine(y);
        }

        Customer()
        {
            Id = 101;
            Name = "Bob";
            Address = "Canada";
        }

       public Customer(string first_name, string last_name)
        {
            Name = first_name + " " + last_name;
        }

        public void AppendData()
        {
            Console.WriteLine(Name);
        }

        public void Dispose()
        {
            Console.WriteLine("Fields cleaned");
            x = 0; y = 0;
        }

        ~Customer()
        {
            Dispose();
        }

        public void display()
        {
            Console.WriteLine("Customer=" + Id);
            Console.WriteLine("Name=" + Name);
            Console.WriteLine("Address=" + Address);
        }

        /*static void Main(string[] args)
        {
            Customer customer = new Customer();
            Customer me = new Customer("me", "me");
            me.AppendData();

            Customer.getData();

            customer.display();

            Console.WriteLine(customer.Id);
            Console.WriteLine(customer.Name);
            Console.WriteLine(customer.Address);
        }*/
    }
}
