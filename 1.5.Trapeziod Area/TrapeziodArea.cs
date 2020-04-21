using System;

namespace _1._5.Trapeziod_Area
{
    class TrapeziodArea
    {
        static void Main(string[] args)
        {
            //Write a program that reads three numbers from the console b1, b2 and h 
            //and calculates the area of a trapezoid with bases b1 and b2 and height h. 
            //The formula for trapezoid area is (b1 + b2) * h / 2.


            double b1 = double.Parse(Console.ReadLine());
            double b2 = double.Parse(Console.ReadLine());
            double h = double.Parse(Console.ReadLine());

            Console.WriteLine((b1 + b2) * h / 2);


        }
    }
}
