using System;

namespace _02.Expression
{
    class Expression
    {
        static void Main(string[] args)
        {
            //Write a console-based C# console program that calculates and prints the 
            //value of the following numerical expression:
            //(3522 + 52353) * 23 - (2336 * 501 + 23432 - 6743) * 3
            //55,875 * 23 = 1,285,125 
            //1,187,025 * 3 = 3,561,075
            //Note: it is not allowed to previously calculate the value 
            //(for example with Windows Calculator).

            Console.WriteLine((3522 + 52353) * 23 - (2336 * 501 + 23432 - 6743) * 3);
        }
    }
}
