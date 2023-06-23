using System;

namespace _2588_곱셈
{
    class Program
    {
        static void Main(string[] args)
        {
            string inputStr1 = Console.ReadLine();
            string inputStr2 = Console.ReadLine();

            int inputNum1 = int.Parse(inputStr1);
            int inputNum2 = int.Parse(inputStr2);

            int[] TransNum2 =
            {
                inputNum2 / 100,
                inputNum2 / 10 % 10,
                inputNum2 % 10
            };

            int[] answerNum =
            {
                inputNum1 * TransNum2[2],
                inputNum1 * TransNum2[1],
                inputNum1 * TransNum2[0],
            };

            Console.WriteLine(answerNum[0]);
            Console.WriteLine(answerNum[1]);
            Console.WriteLine(answerNum[2]);
            Console.WriteLine(answerNum[0] + answerNum[1] * 10 + answerNum[2] * 100);
        }
    }
}
