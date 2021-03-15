using System;
using System.Collections.Generic;
using System.Text;

namespace OOP
{
    class functionOverload
    {
        public string Name;

        public void setName(string last_name)
        {
            Name = last_name;
            Console.WriteLine(Name);
        }

        public void setName(string first_name, string last_name)
        {
            Name = first_name + " " + last_name;
            Console.WriteLine(Name);
        }

        public void setName(string first_name, string middle_name, string last_name)
        {
            Name = first_name + " " + middle_name + " " + last_name;
            Console.WriteLine(Name);
        }

        /*static void Main(string[] args)
        {
            functionOverload obj = new functionOverload();

            obj.setName("me");
            obj.setName("me", "me");
            obj.setName("me", "me", "me");

        }*/
    }
}
