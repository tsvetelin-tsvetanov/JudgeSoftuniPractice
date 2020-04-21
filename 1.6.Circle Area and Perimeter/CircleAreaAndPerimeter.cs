using System;

namespace _1._6.Circle_Area_and_Perimeter
{
    class CircleAreaAndPerimeter
    {
        static void Main(string[] args)
        {
            //Write a program that reads from the console a number r 
            //and calculates and prints the area and perimeter of a 
            //circle with radius r.

            double r = double.Parse(Console.ReadLine());

            Console.WriteLine("Area = {0}", (Math.PI * r * r));
            Console.WriteLine("Perimeter = {0}", (2 * Math.PI * r));

        }
    }
}
