using System;

namespace _2444_별_찍기__7
{
    class Program
    {
        static void Main(string[] args)
        {
            int inputNum = 0;
            int repeatNum = 0;
            int blankNum = 0;
            int starNum = 1;

            inputNum = int.Parse(Console.ReadLine());
            repeatNum = inputNum * 2 - 1;
            blankNum = inputNum - 1;

            for (int i = 0; i < repeatNum; i++)
            {
                // 별 출력
                if (i < inputNum)
                {
                    // 공백 출력
                    for (int blank = 0; blank < blankNum; blank++)
                    {
                        Console.Write(" ");
                    }

                    blankNum--;

                    for (int star = 0; star < starNum; star++)
                    {
                        Console.Write("*");
                    }
                    starNum += 2;
                }

                else if (i >= inputNum)
                {
                    if (i == inputNum)
                    {
                        blankNum = 1;
                        starNum -= 2;
                    }

                    // 공백 출력
                    for (int blank = 0; blank < blankNum; blank++)
                    {
                        Console.Write(" ");
                    }

                    blankNum++;
                    starNum -= 2;

                    // 별 출력
                    for (int star = 0; star < starNum; star++)
                    {
                        Console.Write("*");
                    }
                }
                Console.WriteLine();
            }
        }
    }
}
