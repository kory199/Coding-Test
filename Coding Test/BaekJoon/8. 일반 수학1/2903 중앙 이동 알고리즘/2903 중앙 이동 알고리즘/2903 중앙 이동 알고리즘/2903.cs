using System;

namespace _2903_중앙_이동_알고리즘
{
    class Program
    {
        static void Main(string[] args)
        {
            string testCase = Console.ReadLine();
            int testNum = int.Parse(testCase);
            int answer = 2;

            for (int i = 1; i <= testNum; i++)
            {
                answer = answer + (int)Math.Pow(2, (double)(i - 1));
            }

            Console.WriteLine(answer * answer);
        }
    }
}
