using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortAlgorithm
{
    internal class 좌표_압축
    {
        public static void Solution()
        {
            int n = int.Parse(Console.ReadLine());
            string[] inputStr = Console.ReadLine().Split();
            List<(int, int)> inputNum = new List<(int, int)>();
            StringBuilder sb = new StringBuilder();

            for (int i = 0; i < n; i++)
                // 최초의 값 및 인덱스 저장
                inputNum.Add((int.Parse(inputStr[i]), i));

            // item1을 기준으로 오름 차순 정렬
            var sortList = inputNum.OrderBy(x => x.Item1).ToList();

            // 변경된 인덱스를 받을 새로운 배열 선언
            int[] newOrder = new int[n];
            int transIdx = 0;

            // 정렬한 리스트로 새로운 배열 재정의
            for (int i = 1; i < n; i++)
            {
                if (sortList[i - 1].Item1 != sortList[i].Item1)
                    transIdx++;
                newOrder[sortList[i].Item2] = transIdx;
            }

            foreach (var item in newOrder)
                sb.Append(item + " ");
            Console.WriteLine(sb);
        }
    }
}
