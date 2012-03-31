using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ConsoleProgram;
using ConsoleProject;
using ConsoleProject.MyFirstDataTypes;

namespace ConsoleProgram
{
    class Program
    {
        static void Main(string[] args)
        {
            //console.write("this is my first method \n");
            //int foo = 10;
            //int bar = 12;
            //float foofloat = 3.14f;
            //decimal decimaltype = 3.00m;
            //char single = 'a';
            //bool maybe = true;
            //int foocalc = 5 + 6; // 11
            ///* what is this? */

            //string mystring = "this is a string";
            //string mystring2 = "this is a better way to do this.";

            //console.writeline(mystring2);
            //string verbatim = @"""isn't this a string?""";
            //console.writeline(verbatim);

            //console.writeline(single);
            //console.writeline(mystring2);
            //string fName = "Michael";
            //string lName = "Lolza";
            //int length = fName.Length;
            //int length2 = lName.Length;
            //Console.WriteLine(length);
            //Console.WriteLine(length2);

            //int index = fName.IndexOf('a', 
            //            fName.IndexOf("a") + 1);
            //int index2 = fName.LastIndexOf('l');
            //string index3 = fName.Substring(3);
            //Console.WriteLine(index);
            //Console.WriteLine(index2);
            //Console.WriteLine(index3);
            //string remove = lName.Remove(0, 3);
            //Console.WriteLine(remove);
            //string replace = lName.Replace("Lol", "Superlol");
            //Console.WriteLine(replace);/

            StringBuilder sb = new StringBuilder(),
                y = sb;
            DateTime dt = new DateTime();

            sb.Append("Hello, ");
            y.Append("World!");
            Console.WriteLine(y.ToString());

            // sb = null;
            int? foo = null; // Using the question mark makes it into a nullable field.
            // Console.WriteLine(sb.ToString()); /*This is invalid if you write out a null object to*/
            Person person = new Person("John", "Doe");
            Person john = new Person("John", "Smith");
            Person jane = new Person("Jane", "Doe");

            Console.WriteLine(jane.FirstName + " " + jane.LastName + " is going to marry " + john.FirstName + " " + john.LastName);

        //    Console.WriteLine(person.SayHello("Ryan"));
            Console.WriteLine(person.FirstName + " " + person.LastName);
            string greeting = john.SayHello(jane);
            Console.WriteLine(greeting);

        }
    }
}

