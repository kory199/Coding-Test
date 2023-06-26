using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortAlgorithm
{
    /* 삽입 정렬
     * 처리되지 않은 데이터를 하나씩 골라 적절한 위치에 삽입
     * 선택 정렬에 비해 구현 난이도가 높지만, 일반적으로 효율적
     */
    class InsertionSort
    {
        public static void Solution()
        {
            int[] array = { 9, 8, 7, 6, 4, 5, 1, 2, 3, 0 };

            for (int i = 1; i < array.Length; i++)
            {
                int temp = 0;

                for (int j = i; j > 0; j--)
                {
                    if (array[j] < array[j - 1])
                    {
                        temp = array[j];
                        array[j] = array[j - 1];
                        array[j - 1] = temp;
                    }
                    else
                        break;
                }
            }


            Console.WriteLine("InsertionSort");
            for (int i = 0; i < array.Length; i++)
                Console.Write(array[i] + " ");
        }
    }
}
