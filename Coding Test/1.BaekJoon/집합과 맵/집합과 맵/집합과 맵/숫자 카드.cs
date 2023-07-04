using System;
using System.Collections.Generic;
using System.Text;

namespace 집합과_맵
{
    internal class 숫자_카드
    {
        #region 정상 동작, 백준 기준 오답 왜 ?
        public static void Solution()
        {
            List<int> inputN = new List<int>();
            List<int> inputM = new List<int>();
            StringBuilder sb = new StringBuilder();

            int n = int.Parse(Console.ReadLine());
            string[] inputStrN = Console.ReadLine().Split();
            for (int i = 0; i < n; i++)
                inputN.Add(int.Parse(inputStrN[i]));

            int m = int.Parse(Console.ReadLine());
            string[] inputStrM = Console.ReadLine().Split();
            for (int i = 0; i < m; i++)
                inputM.Add(int.Parse(inputStrM[i]));

            inputN.Sort();

            for (int i = 0; i < m; i++)
                sb.Append(BinarySearch(inputN, 0, n - 1, inputM[i]).ToString() + " ");

            Console.WriteLine(sb);
        }

        public static int BinarySearch(List<int> arr, int first, int last, int target)
        {
            int mid = (first + last) / 2;
            // 역전 발생 시 return
            if (first > last)
                return 0;

            if (arr[mid] == target)
                return 1;
            else if (target < arr[mid])
                return BinarySearch(arr, first, mid - 1, target);
            else
                return BinarySearch(arr, mid + 1, last, target);
        }
        #endregion

        #region 백준 정답
        // 이분 탐색
        static bool BinarySearch(int[] arr, int n)
        {
            int leftIndex = 0;
            int rightIndex = arr.Length - 1;

            while (leftIndex <= rightIndex)
            {
                int midIndex = (leftIndex + rightIndex) / 2;
                int mid = arr[midIndex];

                if (n < mid)
                    rightIndex = midIndex - 1;
                else if (n > mid)
                    leftIndex = midIndex + 1;
                else
                    return true;
            }
            return false;
        }

        static void SolutionBJ()
        {
            StringBuilder sb = new StringBuilder();

            int n = Convert.ToInt32(Console.ReadLine());
            int[] arr = new int[n];
            string[] input = Console.ReadLine().Split(' ');
            for (int i = 0; i < n; i++)
            {
                arr[i] = Convert.ToInt32(input[i]);
            }

            Array.Sort(arr);

            int m = Convert.ToInt32(Console.ReadLine());
            input = Console.ReadLine().Split(' ');

            for (int i = 0; i < m; i++)
            {
                int num = Convert.ToInt32(input[i]);
                if (BinarySearch(arr, num))
                    sb.Append("1 ");
                else
                    sb.Append("0 ");
            }

            Console.WriteLine(sb);
        }
        #endregion
    }
}
