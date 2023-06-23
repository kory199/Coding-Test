using System;

namespace _10988_팰린드롬인지_확인하기
{
    class Program
    {
        static void Main(string[] args)
        {
            string inputStr;
            string conStr;

            inputStr = Console.ReadLine();

            char[] revStr = new char[inputStr.Length];

            int isAnswer = 0;

            for (int i = 0; i < inputStr.Length; i++)
            {
                revStr[i] = inputStr[inputStr.Length - 1 - i];
            }

            conStr = new string(revStr);

            if (conStr.CompareTo(inputStr) == 0)
            {
                isAnswer = 1;
            }

            else
            {
                isAnswer = 0;
            }

            Console.WriteLine(isAnswer);
        }
    }
}
