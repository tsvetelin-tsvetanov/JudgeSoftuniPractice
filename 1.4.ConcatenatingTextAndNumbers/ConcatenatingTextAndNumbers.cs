using System;

namespace _1._4.ConcatenatingTextAndNumbers
{
    class ConcatenatingTextAndNumbers
    {
        static void Main(string[] args)
        {
            //Write a C# program, that reads a first name, last name, 
            //age and city from the console and prints a message of the 
            //following kind: You are <firstName> <lastName>, a <age>-years 
            //old person from <town>.

            string firstName = Console.ReadLine();
            string lastName = Console.ReadLine();
            int age = int.Parse(Console.ReadLine());
            string town = Console.ReadLine();

            Console.WriteLine("You are {0} {1}, a {2}-years old person from {3}.", 
                firstName, lastName, age, town);
        }
    }
}
