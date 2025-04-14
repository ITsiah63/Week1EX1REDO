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
            Console.WriteLine("INFORMATION INPUT");
            string fname = string.Empty;
            string lname = string.Empty;
            string age = string.Empty;
            string color = string.Empty;

            Console.WriteLine("What is your first name?");
            fname = Console.ReadLine();

            Console.WriteLine("What is your last name?");
            lname = Console.ReadLine();

            Console.WriteLine("What is your age?");
            age = Console.ReadLine(); 

            Console.WriteLine("What is your favorite color?");
            color = Console.ReadLine();

            Console.WriteLine("Hello " + fname + " " + lname + " your favorite color is " + color + " and you are " + age + " years old");

        }
    }
}
