using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortAlgorithm
{
    /* 선택 정렬 ------
     * 처리되지 않은 데이터 중에서 가장 작은 데이터를 선택해
     * 맨 앞에 있는 데이터와 바꾸는 것을 반복
     * 
     * 시간 복잡도 ------
     * N + (N -1) + (N - 2) + ... + 2
     * 
     * BIG O ------
     * O(N2)
     */
    class SelectionSort
    {
        public static void Solution()
        {
            int[] array = { 1, 0, 3, 2, 5, 4, 6, 8, 7, 9 };

            for (int i = 0; i < array.Length; i++)
            {
                int min = 0;

                for (int j = i + 1; j < array.Length; j++)
                {
                    if (array[j] < array[i])
                    {
                        min = array[j];
                        array[j] = array[i];
                        array[i] = min;
                    }
                }
            }
            for (int i = 0; i < array.Length; i++)
                Console.Write(array[i] + " ");
        }
    }
}
