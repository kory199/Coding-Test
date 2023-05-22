using System;

namespace _5597_과제_안_내신_분
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] checkNum = new int[31];

            for (int i = 0; i < checkNum.Length; i++)
            {
                checkNum[i] = 0;
            }

            for (int j = 1; j < 29; j++)
            {
                string inStr = Console.ReadLine();
                int transNum = int.Parse(inStr);

                checkNum[transNum] = 1;
            }

            for (int k = 0; k < checkNum.Length; k++)
            {
                if (checkNum[k] == 1)
                {
                    continue;
                }

                else if (k != 0 && checkNum[k] == 0)
                {
                    Console.WriteLine(k);
                }
            }
        }
    }
}
