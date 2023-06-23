using System;

namespace _14681_사분면_고르기
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arrayNum =
            {
                int.Parse(Console.ReadLine()),
                int.Parse(Console.ReadLine())
            };

            if (0 < arrayNum[0])
            {
                if (0 < arrayNum[1])
                {
                    Console.WriteLine("1");
                }

                else
                {
                    Console.WriteLine("4");
                }
            }

            else if (arrayNum[0] < 0)
            {
                if (0 < arrayNum[1])
                {
                    Console.WriteLine("2");
                }

                else
                {
                    Console.WriteLine("3");
                }
            }
        }
    }
}
