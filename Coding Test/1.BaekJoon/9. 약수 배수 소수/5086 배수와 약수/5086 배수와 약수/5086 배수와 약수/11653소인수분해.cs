using System;
using System.Collections.Generic;
using System.Text;

namespace _5086_배수와_약수
{
    internal class _11653소인수분해
    {
        public static void Solution()
        {
            int Num = int.Parse(Console.ReadLine());

            if (Num != 1)
            {
                for (int i = 2; i <= Num; i++)
                {
                    while (Num % i == 0)
                    {
                        Console.WriteLine(i);
                        Num /= i;
                        i = 2;
                    }
                }
            }
        }
    }
}
