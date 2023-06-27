using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortAlgorithm
{
    /* 계수 정렬
     * 특정한 조건이 부합할 떄만 사용할 수 있지만 매우 빠르게
     * 동작하는 정렬 알고리즘
     * - 계수 정렬은 데이터의 크기 범위가 제한되어 정수
     *    형태로 표현할 수 있을 때 사용가능
     *  
     * 데이터의 개수가 N, 데이터(양수) 중 최댓값이 K일 떄
     * 최악의 경우에도 수행 시간 O(N+K)를 보장
     */
    class 2_CountingSort
    {
        public static void Solution()
        {
            int[] array = { 7, 5, 9, 0, 3, 1, 6, 2, 9, 1, 4, 8, 0, 5, 2 };
            int[] count = new int[10];

            for (int i = 0; i < array.Length; i++)
                count[array[i]]++;


            for (int i = 0; i < count.Length; i++)
            {
                for (int j = 0; j < count[i]; j++)
                {
                    Console.Write(i + " ");
                }
            }

        }
    }
}
