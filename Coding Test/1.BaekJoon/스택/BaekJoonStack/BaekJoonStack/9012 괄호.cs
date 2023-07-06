using System;
using System.Collections.Generic;
using System.Text;

namespace BaekJoonStack
{
    internal class _9012_괄호
    {
        public static void Solution()
        {
            int inputNum = int.Parse(Console.ReadLine());
            Stack<char> testCase = new Stack<char>();
            StringBuilder sb = new StringBuilder();

            for (int i = 0; i < inputNum; i++)
            {
                string temp = Console.ReadLine();
                bool check = true;
                testCase.Clear();

                for (int j = 0; j < temp.Length; j++)
                {
                    if (!check)
                        break;
                    if (temp[j] == '(')
                        testCase.Push('(');
                    else if (temp[j] == ')')
                    {
                        if (testCase.Count != 0)
                            testCase.Pop();
                        else
                            check = false;
                    }
                }
                if (!check)
                    sb.AppendLine("NO");
                else
                    sb.AppendLine(testCase.Count == 0 ? "YES" : "NO");
            }
            Console.WriteLine(sb);
        }
    }
}
