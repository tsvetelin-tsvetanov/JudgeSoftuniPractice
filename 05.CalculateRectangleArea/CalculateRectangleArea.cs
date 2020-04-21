using System;

namespace _05.CalculateRectangleArea
{
    class CalculateRectangleArea
    {
        static void Main(string[] args)
        {
            //Write a C# program that reads from the console two numbers, 
            //a and b, calculates and prints the area of a rectangle with 
            //sides a and b.


            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());

            Console.WriteLine(a * b);
        }
    }
}
