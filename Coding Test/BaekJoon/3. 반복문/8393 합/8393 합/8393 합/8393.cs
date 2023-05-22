using System;

namespace _8393_합
{
    class Program
    {
        static void Main(string[] args)
        {
            int inNum = int.Parse(Console.ReadLine());

            int sum = 0;

            for (int i = 1; i <= inNum; i++)
            {
                sum += i;
            }
            Console.WriteLine(sum);
        }
    }
}
