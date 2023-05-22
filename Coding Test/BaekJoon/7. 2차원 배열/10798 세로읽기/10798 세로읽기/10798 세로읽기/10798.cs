using System;
using System.Text;

namespace _10798_세로읽기
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] inputStr = new string[5];
            StringBuilder answerSB = new StringBuilder();
            string answerStr;

            int maxNum = 0;

            for (int i = 0; i < 5; i++)
            {
                inputStr[i] = Console.ReadLine();

                if (maxNum <= inputStr[i].Length)
                {
                    maxNum = inputStr[i].Length;
                }
            }

            for (int i = 0; i < maxNum; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    if (inputStr[j].Length > i)
                    {
                        answerSB.Append(inputStr[j][i]);
                    }
                }
            }

            answerStr = answerSB.ToString();

            Console.WriteLine(answerStr);
        }
    }
}
