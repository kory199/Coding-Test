using System;

namespace _2745_진법_변환
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] inputStr;

            string inputDecimal;

            int decimalNum = 0;
            double answerNum = 0;

            inputStr = Console.ReadLine().Split(' ');

            inputDecimal = inputStr[0];
            decimalNum = int.Parse(inputStr[1]);

            int[] transDecimal = new int[inputDecimal.Length];

            for (int i = 0; i < inputDecimal.Length; i++)
            {
                if ((int)inputDecimal[i] >= 65 && (int)inputDecimal[i] <= 90)
                {
                    transDecimal[i] = (int)inputDecimal[i] - 55;
                }

                else
                {
                    transDecimal[i] = (int)inputDecimal[i] - 48;
                }

                answerNum += transDecimal[i] * Math.Pow(decimalNum, inputDecimal.Length - 1 - i);
            }
            Console.WriteLine(answerNum);
        }
    }
}
