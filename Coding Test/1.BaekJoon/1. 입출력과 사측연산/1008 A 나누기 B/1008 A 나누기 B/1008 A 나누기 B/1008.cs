using System;

namespace _1008_A_나누기_B
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] inputStr = null;
            decimal A = 0;
            decimal B = 0;

            inputStr = Console.ReadLine().Split(' ');

            A = decimal.Parse(inputStr[0]);
            B = decimal.Parse(inputStr[1]);

            Console.WriteLine(A / B);
        }
    }
}
