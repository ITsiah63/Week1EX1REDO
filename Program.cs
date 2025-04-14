using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week1EX2REDO
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //printing out the title 
            Console.WriteLine("INFORMATION INPUT");

            //declaring varables used
            string fname = string.Empty;
            string lname = string.Empty;
            string age = string.Empty;
            string color = string.Empty;

            //asking user for first name
            Console.WriteLine("What is your first name?");
            fname = Console.ReadLine();

            //asking user for last name
            Console.WriteLine("What is your last name?");
            lname = Console.ReadLine();

            //asking user for age
            Console.WriteLine("What is your age?");
            age = Console.ReadLine(); 

            //asking user for favorite color
            Console.WriteLine("What is your favorite color?");
            color = Console.ReadLine();

            //using all variables to construct sentence
            Console.WriteLine("Hello " + fname + " " + lname + " your favorite color is " + color + " and you are " + age + " years old");

        }
    }
}
