using System;
using System.Collections.Generic;
using System.Text;

namespace BaekJoonStack
{
    internal class _4949_균형잡힌_세상
    {
        public static void Solution()
        {
            Stack<char> testCase = new Stack<char>();
            StringBuilder sb = new StringBuilder();
            bool isBalance = true;

            while (true)
            {
                string temp = Console.ReadLine();
                testCase.Clear();
                isBalance = true;

                // 입력받은 문자열에 . 만 있으면 종료
                if (temp == ".")
                    break;

                foreach (var tempChar in temp)
                {
                    // 입력값이 '(' or '[' 일 때
                    if (tempChar == '(' || tempChar == '[')
                        testCase.Push(tempChar);
                    // 입력값이 ')' or ']' 일 때 균형을 이루는지 판단
                    else if (tempChar == ')' || tempChar == ']')
                    {
                        if (testCase.Count != 0)
                        {
                            if (testCase.Peek() == '(' && tempChar == ')')
                                testCase.Pop();
                            else if (testCase.Peek() == '[' && tempChar == ']')
                                testCase.Pop();
                            else
                                isBalance = false;
                        }
                        // stack.count가 0이면 균형 X
                        else
                            isBalance = false;
                    }
                }
                // stack.count가 0이 아니거나 (push, pop이 균형을 이루지 않음)
                // isBalance가 false일 경우 (균형이 깨짐)
                if (testCase.Count != 0 || isBalance == false)
                    sb.AppendLine("no");
                else
                    sb.AppendLine("yes");
            }
            Console.WriteLine(sb);
        }
    }
}
