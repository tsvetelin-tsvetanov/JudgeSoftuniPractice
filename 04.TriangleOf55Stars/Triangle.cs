using System;

namespace _04.TriangleOf55Stars
{
    class Triangle
    {
        static void Main(string[] args)
        {
            //Write a C# console program that prints a triangle made of 55 stars 
            //on 10 lines:

            //cycle rows
            for(int i = 1; i <= 10; i++)
            {
                //print * based on row number
                for(int j = 0; j < i; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
            
        }
    }
}
