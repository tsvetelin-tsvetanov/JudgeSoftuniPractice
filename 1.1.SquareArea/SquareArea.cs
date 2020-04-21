using System;

namespace _1._1.SquareArea
{
    class SquareArea
    {
        static void Main(string[] args)
        {
            //write a console program that inputs an integer a and calculates 
            //the area of a square with side a. The task is trivial and easy: 
            //input a number from the console, multiply it by itself and print 
            //the obtained result on the console.

            int a = int.Parse(Console.ReadLine());

            Console.WriteLine(a * a);
        }

    }
}
