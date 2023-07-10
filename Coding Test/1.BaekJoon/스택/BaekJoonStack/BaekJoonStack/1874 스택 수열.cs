using System;
using System.Collections.Generic;
using System.Text;

namespace BaekJoonStack
{
    internal class _1874_스택_수열
    {
        public static void Solution()
        {
            int inputNum = int.Parse(Console.ReadLine());
            Stack<int> testNum = new Stack<int>();
            StringBuilder sb = new StringBuilder();
            int maxNum = 1;
            bool isCheck = true;

            for (int i = 1; i <= inputNum; i++)
            {
                int temp = int.Parse(Console.ReadLine());

                if (!isCheck)
                    break;

                while (temp >= maxNum)
                {
                    testNum.Push(maxNum);
                    sb.AppendLine("+");
                    maxNum++;
                }

                if (testNum.Peek() != temp)
                {
                    isCheck = false;
                    break;
                }

                testNum.Pop();
                sb.AppendLine("-");
            }

            if (isCheck)
                Console.WriteLine(sb);
            else
                Console.WriteLine("NO");
        }
    }
}
