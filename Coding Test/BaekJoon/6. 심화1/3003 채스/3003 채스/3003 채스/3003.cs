using System;

namespace _3003_채스
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] Chess = { 1, 1, 2, 2, 2, 8 };
            string[] inputNum = Console.ReadLine().Split(' ');

            int[] answerNum = new int[6];


            for (int i = 0; i < Chess.Length; ++i)
            {
                answerNum[i] = Chess[i] - int.Parse(inputNum[i]);
            }

            for (int i = 0; i < Chess.Length; i++)
            {
                Console.Write(answerNum[i] + " ");
            }
        }
    }
}
