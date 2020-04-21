using System;

namespace _1._3.GreetingByName
{
    class GreetingByName
    {
        static void Main(string[] args)
        {
            //Write a program that reads a person's name and prints Hello, <name>!, 
            //where <name> is the name entered earlier.

            String name = Console.ReadLine();
            Console.WriteLine("Hello, " + name + "!");
            
        }
    }
}
