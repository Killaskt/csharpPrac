using System;

namespace HelloWorld // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args) // entry point
        {
            Console.WriteLine("Hello World!");
            Console.WriteLine("What is your name?");

            string str = Console.ReadLine() ?? "NULL"; // asks for name

            Console.WriteLine("Hello, " + str);
        }
    }
}

// alternatively we can remove all paratheses and just have the main code at the top level without any boilerplate if its a simple program (so no main, namespace or class)