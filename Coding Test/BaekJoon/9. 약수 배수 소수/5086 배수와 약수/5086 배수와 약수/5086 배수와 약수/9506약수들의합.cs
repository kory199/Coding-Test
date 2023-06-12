using System;
using System.Collections.Generic;
using System.Text;

namespace _5086_배수와_약수
{
    internal class _9506약수들의합
    {
        public static void Solution()
        {
            int inputNum = 0;
            List<int> tempt = new List<int>();
            int sum = 0;

            while (true)
            {
                tempt.Clear();
                sum = 0;
                inputNum = int.Parse(Console.ReadLine());

                if (inputNum == -1)
                    break;

                for (int i = 1; i < inputNum; i++)
                {
                    if (inputNum % i == 0)
                    {
                        tempt.Add(i);
                        sum += i;
                    }
                }

                if (sum == inputNum)
                {
                    for (int i = 0; i < tempt.Count; i++)
                    {
                        if (i == 0)
                            Console.Write($"{inputNum} = {tempt[i]}");

                        else
                            Console.Write($" + {tempt[i]}");

                        if (i == tempt.Count-1)
                            Console.WriteLine();
                    }
                }

                else
                    Console.WriteLine($"{inputNum} is NOT perfect.");
            }
        }
    }
}
