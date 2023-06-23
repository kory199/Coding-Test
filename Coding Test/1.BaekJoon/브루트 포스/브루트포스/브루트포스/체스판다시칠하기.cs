using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 브루트포스
{
    class 체스판다시칠하기
    {
        public static void Solution()
        {
            int[] arraySize = Console.ReadLine().Split().Select(n => int.Parse(n)).ToArray();

            string[] chessArray = new string[arraySize[0]];
            int resultCount = 0;
            int countB = 0;
            int countW = 0;
            int minCount = int.MaxValue;
            for (int i = 0; i < arraySize[0]; i++)
                chessArray[i] = Console.ReadLine();

            //탐색 시작 위치 x
            for (int i = 0; i <= arraySize[1] - 8; i++)
            {
                //탐색 시작 위치 y
                for (int j = 0; j <= arraySize[0] - 8; j++)
                {
                    for (int n = j; n < j + 8; n++)
                    {
                        for (int m = i; m < i + 8; m++)
                        {
                            char temp = chessArray[n][m];
                            //좌상단이 B일경우와 W일 경우 모두 구해서 작은 수 를 사용
                            if ((n + m) % 2 == 0)
                            {
                                if (temp != 'B') countB++;
                                if (temp != 'W') countW++;
                            }
                            else
                            {
                                if (temp != 'W') countB++;
                                if (temp != 'B') countW++;
                            }
                        }
                    }
                    resultCount = countB > countW ? countW : countB;
                    if (minCount > resultCount) minCount = resultCount;
                    resultCount = countB = countW = 0;
                }
            }
            Console.WriteLine(minCount);
        }
    }
}
