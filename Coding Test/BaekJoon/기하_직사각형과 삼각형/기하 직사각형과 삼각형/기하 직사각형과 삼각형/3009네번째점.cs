using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 기하_직사각형과_삼각형
{
    class _3009네번째점
    {
        public static void Solution()
        {
            int[,] dotX = new int[3, 1];
            int[,] dotY = new int[3, 1];
            string[] inputStr;
            int minValueX = int.MaxValue;
            int minValueY = int.MaxValue;
            int newDotX = 0;
            int newDotY = 0;

            Dictionary<int, int> frequencyNumX = new Dictionary<int, int>();
            Dictionary<int, int> frequencyNumY = new Dictionary<int, int>();

            // 데이터 초기화
            for (int i = 0; i < 3; i++)
            {
                inputStr = Console.ReadLine().Split(' ');
                dotX[i, 0] = int.Parse(inputStr[0]);
                dotY[i, 0] = int.Parse(inputStr[1]);
            }

            // 배열 요소 빈도 계산
            for (int i = 0; i < 3; i++)
            {
                if (frequencyNumX.ContainsKey(dotX[i, 0]))
                    frequencyNumX[dotX[i, 0]]++;
                else
                    frequencyNumX[dotX[i, 0]] = 1;
                if (frequencyNumY.ContainsKey(dotY[i, 0]))
                    frequencyNumY[dotY[i, 0]]++;
                else
                    frequencyNumY[dotY[i, 0]] = 1;
            }

            // X좌표의 동일한 수 중 빈도가 적은 것 찾기
            foreach (var dot in frequencyNumX)
            {
                if (dot.Value < minValueX)
                {
                    minValueX = dot.Value;
                    newDotX = dot.Key;
                }
            }

            // Y좌표의 동일한 수 중 빈도가 적은 것 찾기
            foreach (var dot in frequencyNumY)
            {
                if (dot.Value < minValueY)
                {
                    minValueY = dot.Value;
                    newDotY = dot.Key;
                }
            }
            Console.WriteLine(newDotX + " " + newDotY);
        }
    }
}
