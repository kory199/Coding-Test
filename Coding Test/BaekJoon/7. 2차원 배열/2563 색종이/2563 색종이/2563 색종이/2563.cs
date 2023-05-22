using System;

namespace _2563_색종이
{
    class Program
    {
        static void Main(string[] args)
        {
            string inputStr;
            string[] colorPaper;
            int[,] areaMatrix = new int[100, 100];

            inputStr = Console.ReadLine();

            int inputNum = int.Parse(inputStr);
            int[] paperPositionX = new int[inputNum];
            int[] paperPositionY = new int[inputNum];
            int answerArea = 0;

            for (int y = 0; y < 100; y++)
            {
                for (int x = 0; x < 100; x++)
                {
                    areaMatrix[y, x] = 0;
                }
            }

            for (int i = 0; i < inputNum; i++)
            {
                colorPaper = Console.ReadLine().Split(' ');
                paperPositionX[i] = int.Parse(colorPaper[0]);
                paperPositionY[i] = int.Parse(colorPaper[1]);

                for (int y = paperPositionY[i]; y < paperPositionY[i] + 10; y++)
                {
                    for (int x = paperPositionX[i]; x < paperPositionX[i] + 10; x++)
                    {
                        areaMatrix[y, x] = 1;
                    }
                }
            }

            for (int i = 0; i < 100; i++)
            {
                for (int j = 0; j < 100; j++)
                {
                    if (areaMatrix[i, j] == 1)
                    {
                        answerArea++;
                    }
                }
            }

            Console.WriteLine(answerArea);
        }
    }
}
