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
        // This is the new syntax.
        public string FirstName { get; private set; }
        public string LastName  { get; private set; }
        

        // This is .NET old syntax.
        //private string fName; // = string.Empty;
        //private string lName; //  = string.Empty;
        //public string FName
        //{
        //    get { return fName; }
        //    set
        //    {
        //        fName = value;
        //    }
        //}
        //public string LName
        //{
        //    get { return lName; }
        //    set { lName = value; }
        //}


        public Person(string fName, string lName) // This is automatically considered private unless otherwise declared.
        {
            FirstName = fName;
            LastName = lName;
        }
        public void DoesNothing()
        {
            Console.WriteLine("void is used to mean we want nothing returned back");
        }

      /*  public string SayHello(string name)
        {
            return "Hello, " + name;
        }
       */
       // private Person personOfInterest = new Person();

        public string SayHello(Person person)
        {
            return "Hello, " + person.FirstName + " " + person.LastName;
        }

    }
}