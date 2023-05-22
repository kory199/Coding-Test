using System;

namespace _9086_문자열
{
    class Program
    {
        static void Main(string[] args)
        {
            int testCase = 0;
            string testStr;
            testCase = int.Parse(Console.ReadLine());

            for (int i = 0; i < testCase; i++)
            {
                testStr = Console.ReadLine();

                Console.WriteLine("{0}{1}", testStr[0], testStr[testStr.Length - 1]);
            }
        }
    }
}
