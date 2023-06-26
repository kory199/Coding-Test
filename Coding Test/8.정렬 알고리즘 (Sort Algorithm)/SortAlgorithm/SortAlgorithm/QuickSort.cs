using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortAlgorithm
{
    class QuickSort
    {
        /* Quick Sort
         * 기준 데이터를 설정하고 그 기준보다 큰 데이터와 작은 데이터 위치를 바꾸는 방법
         * 일반적인 상황에서 가장 많이 사용되는 정렬 알고리즘 중 하나
         * 병합 정렬과 더불어 대부분의 프로그래밍 언어의 정렬 라이브러리의 근간이 됨
         * 가장 기본적인 퀵 정렬은 첫 번째 데이터를 기준 데이터(pivot)로 설정
         * 
         * 시간 복잡도
         * 평균의 경우 : O(NlogN)
         * 최악의 경우 : O(N2)
         */
        public static void QuickSortFunc(int[] arr, int start, int end)
        {
            int pivot = start;
            int left = start + 1;
            int right = end;

            if (start >= end) //배열의 원소가 1개일 경우 함수 종료
                return;

            // 역전이 일어날 때까지
            while (left <= right)
            {
                // 피벗보다 큰 데이터를 찾을 떄까지
                while (left <= end && arr[left] <= arr[pivot])
                    left++;
                // 피버벳보다 작은 데이터를 찾을 때까지
                while (right > start && arr[right] >= arr[pivot])
                    right--;
                // 역전됐다면 작은 데이터와 피벗 데이터를 교체
                if (left > right)
                {
                    int temp = arr[pivot];
                    arr[pivot] = arr[right];
                    arr[right] = temp;
                }
                // 역전되지 않았다면 작은 데이터와 큰 데이터를 교체
                else
                {
                    int temp = arr[left];
                    arr[left] = arr[right];
                    arr[right] = temp;
                }
            }
            // 분할 이우 왼쪽 / 오른쪽 각각 정렬 수행
            QuickSortFunc(arr, start, right - 1);
            QuickSortFunc(arr, right + 1, end);
        }

        public static void Solution()
        {
            int[] array = { 2, 3, 0, 1, 4, 6, 5, 9, 7, 8 };

            QuickSortFunc(array, 0, array.Length - 1);

            Console.WriteLine("Quick Sort");
            for (int i = 0; i < array.Length; i++)
                Console.Write(i + " ");
        }
    }
}
