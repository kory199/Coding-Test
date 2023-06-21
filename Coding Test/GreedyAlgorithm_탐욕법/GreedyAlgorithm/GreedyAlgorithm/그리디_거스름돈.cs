using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GreedyAlgorithm
{
    /* 거스름 돈 
     * 당신은 음식점의 계산을 도와주는 점원입니다. 카운터에는 거스름돈으로
     * 사용할 500, 100, 50, 10원짜리 동전이 무한히 존재한다고 가정합니다.
     * 손님에게 거슬러 주어야 할 돈이 N원일 때 거슬러 주어야 할 동전의 
     * 최소 개수를 구하시오. 단, 거슬러 줘야 할 돈 N은 항상 10의 배수입니다.
     */
    class 그리디_거스름돈
    {
        public static void Solution()
        {
            int N = 1130;
            int[] change = { 500, 100, 50, 10 };
            int count = 0;

            for (int i = 0; i < change.Length; i++)
            {
                count += N / change[i];
                N %= change[i];
            }
            Console.WriteLine(count);
        }
    }
}
