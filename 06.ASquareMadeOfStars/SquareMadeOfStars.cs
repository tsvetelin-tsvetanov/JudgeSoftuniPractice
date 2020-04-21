using System;

namespace _06.ASquareMadeOfStars
{
    class SquareMadeOfStars
    {
        static void Main(string[] args)
        {
            //Write a C# console program that reads from the console 
            //an integer N and prints on the console a square made out of N stars, 
            //like in the examples below.

            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                if (i == 0 || i == n - 1)
                {
                    for (int j = 0; j < n; j++)
                    {
                        Console.Write("*");
                    }
                    Console.WriteLine();
                }
                else
                {
                    Console.Write("*");
                    for (int j = 0; j < n - 2; j++)
                    {
                        Console.Write(" ");
                    }
                    Console.WriteLine("*");
                }
            }

        }
    }
}
