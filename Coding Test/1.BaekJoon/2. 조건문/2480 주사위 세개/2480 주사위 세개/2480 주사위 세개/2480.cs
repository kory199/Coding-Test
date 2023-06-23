using System;

namespace _2480_주사위_세개
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            string[] output = input.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            int A = int.Parse(output[0]);
            int B = int.Parse(output[1]);
            int C = int.Parse(output[2]);


            if (A == B && A == C && B == C)
            {
                Console.WriteLine(10000 + A * 1000);
            }
            else if (A == B || A == C || B == C)
            {
                if (A == B)
                {
                    Console.WriteLine(1000 + A * 100);
                }

                else if (A == C)
                {
                    Console.WriteLine(1000 + A * 100);
                }

                else
                {
                    Console.WriteLine(1000 + B * 100);
                }
            }

            else if (A != B && A != C && B != C)
            {
                if (A > B)
                {
                    if (A > C)
                    {
                        Console.WriteLine(100 * A);
                    }
                    else
                    {
                        Console.WriteLine(100 * C);
                    }
                }

                else if (B > C)
                {
                    Console.WriteLine(100 * B);
                }

                else
                {
                    Console.WriteLine(100 * C);
                }
            }
        }
    }
}
