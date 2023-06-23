using System;

namespace _2566_최댓값
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] inputMatrix;
            int[,] matrix = new int[9, 9];
            int[] matrixNum = new int[2];
            int maxNum = 0;

            for (int i = 0; i < 9; i++)
            {
                inputMatrix = Console.ReadLine().Split(' ');

                for (int j = 0; j < 9; j++)
                {
                    matrix[i, j] = int.Parse(inputMatrix[j]);

                    if (matrix[i, j] >= maxNum)
                    {
                        maxNum = matrix[i, j];
                        matrixNum[0] = i + 1;
                        matrixNum[1] = j + 1;
                    }
                }
            }
            Console.WriteLine(maxNum);
            Console.Write(matrixNum[0] + " " + matrixNum[1]);
        }
    }
}
