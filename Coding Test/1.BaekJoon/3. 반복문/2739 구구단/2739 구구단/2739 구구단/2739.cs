using System;

namespace _2739_구구단
{
    class Program
    {
        static void Main(string[] args)
        {
            int Num = int.Parse(Console.ReadLine());

            for (int i = Num; i < Num + 1; i++)
            {
                for (int j = 1; j < 10; j++)
                {
                    Console.WriteLine($"{i} * {j} = {i * j}");
                }
            }
        }
    }
}
