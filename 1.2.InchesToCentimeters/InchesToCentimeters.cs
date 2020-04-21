using System;

namespace _1._2.InchesToCentimeters
{
    class InchesToCentimeters
    {
        static void Main(string[] args)
        {
            //Write a program that reads a number from the console 
            //(not necessarily an integer) and converts the number from 
            //inches to centimeters. For the purpose it multiplies the 
            //inches by 2.54 (because one inch = 2.54 centimeters).


            decimal centimeter = decimal.Parse(Console.ReadLine());

            Console.WriteLine(centimeter * (decimal)2.54);
        }
    }
}
