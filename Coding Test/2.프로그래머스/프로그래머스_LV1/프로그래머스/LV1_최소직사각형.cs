using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 프로그래머스
{
    internal class LV1_최소직사각형
    {
        public static int solution(int[,] sizes)
        {
            int maxNum = 0;
            int minNum = 0;

            for (int i = 0; i < sizes.GetLength(0); i++)
            {
                maxNum = Math.Max(maxNum, Math.Max(sizes[i, 0], sizes[i, 1]));
                minNum = Math.Max(minNum, Math.Min(sizes[i, 0], sizes[i, 1]));
            }

            return maxNum*minNum;
        }
    }
}
