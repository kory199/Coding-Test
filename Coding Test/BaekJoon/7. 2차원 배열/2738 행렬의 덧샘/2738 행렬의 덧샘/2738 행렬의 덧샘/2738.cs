using System;

namespace _2738_행렬의_덧샘
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] inputNM;
            string[] matrixIndex;
            int N = 0;
            int M = 0;

            inputNM = Console.ReadLine().Split(' ');

            N = int.Parse(inputNM[0]);
            M = int.Parse(inputNM[1]);

            int[,] inputN = new int[N, M];
            int[,] inputM = new int[N, M];
            int[,] answerMatrix = new int[N, M];

            for (int i = 0; i < N; i++)
            {
                matrixIndex = Console.ReadLine().Split(' ');

                for (int j = 0; j < M; j++)
                {
                    inputN[i, j] = int.Parse(matrixIndex[j]);
                }
            }

            for (int i = 0; i < N; i++)
            {
                matrixIndex = Console.ReadLine().Split(' ');

                for (int j = 0; j < M; j++)
                {
                    inputM[i, j] = int.Parse(matrixIndex[j]);
                }
            }

            for (int i = 0; i < N; i++)
            {
                for (int j = 0; j < M; j++)
                {
                    answerMatrix[i, j] = inputN[i, j] + inputM[i, j];
                    Console.Write(answerMatrix[i, j] + " ");
                }
                Console.WriteLine();
            }
        }
    }
}
