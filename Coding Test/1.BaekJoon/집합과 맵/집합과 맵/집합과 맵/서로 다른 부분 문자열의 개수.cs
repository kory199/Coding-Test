using System;
using System.Collections.Generic;

namespace 집합과_맵
{
    internal class 서로_다른_부분_문자열의_개수
    {
        public static void Solution()
        {
            string input = Console.ReadLine();
            HashSet<string> substrings = new HashSet<string>();

            // 부분 문자열 생성
            for (int i = 0; i < input.Length; i++)
            {
                for (int j = i + 1; j <= input.Length; j++)
                {
                    substrings.Add(input.Substring(i, j - i));
                }
            }
            int count = substrings.Count;
            Console.WriteLine(count);
        }
    }
}
