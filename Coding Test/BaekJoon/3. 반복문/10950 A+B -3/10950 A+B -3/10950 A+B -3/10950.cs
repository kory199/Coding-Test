using System;

namespace _10950_A_B__3
{
    class Program
    {
        static void Main(string[] args)
        {
            int Num = int.Parse(Console.ReadLine());
            int[] answerNum = new int[Num];

            for (int i = 0; i < Num; i++)
            {
                string[] strings = Console.ReadLine().Split(' ');
                int A = int.Parse(strings[0]);
                int B = int.Parse(strings[1]);

                answerNum[i] = A + B;
            }

            for (int i = 0; i < Num; i++)
            {
                Console.WriteLine(answerNum[i]);
            }
        }
    }
}
