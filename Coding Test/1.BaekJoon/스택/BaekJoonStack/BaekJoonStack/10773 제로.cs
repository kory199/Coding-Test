using System;
using System.Collections.Generic;
using System.Linq;

namespace BaekJoonStack
{
    internal class _10773_제로
    {
        public static void Solution()
        {
            int inputNum = int.Parse(Console.ReadLine());
            Stack<int> testCase = new Stack<int>();

            for (int i = 0; i < inputNum; i++)
            {
                int temp = int.Parse(Console.ReadLine());

                if (temp == 0 && testCase.Count != 0)
                    testCase.Pop();
                else
                    testCase.Push(temp);
            }
            Console.WriteLine(testCase.Sum());
        }
    }
}
