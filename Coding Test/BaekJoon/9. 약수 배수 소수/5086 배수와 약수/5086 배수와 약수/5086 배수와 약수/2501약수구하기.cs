using System;
using System.Collections.Generic;
using System.Text;

namespace _5086_배수와_약수
{
    internal class _2501약수구하기
    {
        public static void Solution()
        {
            string[] inputStr = Console.ReadLine().Split(' ');
            int N = int.Parse(inputStr[0]);
            int K = int.Parse(inputStr[1]);
            List<int> measure = new List<int>();

            for (int i = 1; i <= N; i++)
            {
                if (N % i == 0)
                {
                    measure.Add(i);
                }
            }
            if (K > measure.Count)
                Console.WriteLine(0);

            else
                Console.WriteLine(measure[K-1]);
        }
    }
}
