using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleProject.MyFirstDataTypes
{
    internal class Person
        // All classes are internal, available inside the assembly.
        // public can make it usable anywhere.

    {
        private string fName; // = string.Empty;
        private string lName; //  = string.Empty;

        public Person(string fName, string lName) // This is automatically considered private unless otherwise declared.
        {
            this.fName = fName;
            this.lName = lName;
        }
        public void DoesNothing()
        {
            Console.WriteLine("void is used to mean we want nothing returned back");
        }

        public string SayHello(string name)
        {
            return "Hello, " + name;
        }
       // private Person personOfInterest = new Person();

    }
}