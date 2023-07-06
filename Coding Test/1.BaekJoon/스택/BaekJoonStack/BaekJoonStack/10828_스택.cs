using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BaekJoonStack
{
    internal class _10828_스택
    {
        public static void Solution()
        {
            int inputNum = int.Parse(Console.ReadLine());
            Stack<string> testCase = new Stack<string>();
            StringBuilder sb = new StringBuilder();

            for (int i = 0; i < inputNum; i++)
            {
                string[] temp = Console.ReadLine().Split();

                switch (temp[0])
                {
                    case "push":
                        testCase.Push(temp[1]);
                        break;
                    case "pop":
                        sb.AppendLine(testCase.Count ==0 ? "-1" : testCase.Pop());
                        break;
                    case "size":
                        sb.AppendLine(testCase.Count().ToString());
                        break;
                    case "empty":
                        sb.AppendLine(testCase.Count == 0 ? "1" : "0");
                        break;
                    case "top":
                        sb.AppendLine(testCase.Count == 0 ? "-1" : testCase.Peek());
                        break;
                    default:
                        break;
                }
            }
            Console.WriteLine(sb);
        }
    }
}
