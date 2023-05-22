using System;

namespace _2439_별찍기__2
{
    class Program
    {
        static void Main(string[] args)
        {
            // 2중 for문

            int N = int.Parse(Console.ReadLine());

            for (int i = 1; i < N + 1; i++)
            {
                for (int j = 0; j < N - i; j++)
                {
                    Console.Write(" ");
                }
                for (int k = 0; k < i; k++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
        }
    }
}
