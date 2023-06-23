using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DFS_Depth_First_Search
{
    class testDfs
    {
        // 0번 노드 생략
        public static bool[] visiteCheck = new bool[9];
        // 노드 정보를 입력할 list생성
        public static List<List<int>> node = new List<List<int>>();

        public static void DFS(int nodeNum)
        {
            visiteCheck[nodeNum] = true;
            Console.Write($"{nodeNum} ");

            for (int i = 0; i < node[nodeNum].Count; i++)
            {
                int childrenNode = node[nodeNum][i];

                if (!visiteCheck[childrenNode])
                    DFS(childrenNode);
            }
        }

        public static void Solution()
        {
            // 노드 초기화
            for (int i = 0; i < 9; i++)
            {
                node.Add(new List<int>());
            }

            // 1번 인접 노드 추가
            node[1].Add(2);
            node[1].Add(3);

            // 2번 인접 노드 추가
            node[2].Add(1);
            node[2].Add(7);
            node[2].Add(8);

            // 3번 인접 노드 추가
            node[3].Add(1);
            node[3].Add(4);
            node[3].Add(5);

            // 4번 인접 노드 추가
            node[4].Add(3);
            node[4].Add(5);

            // 5번 인접 노드 추가
            node[5].Add(3);
            node[5].Add(4);

            // 6번 인접 노드 추가
            node[6].Add(7);

            // 7번 인접 노드 추가
            node[7].Add(2);
            node[7].Add(6);
            node[7].Add(8);

            // 8번 인접 노드 추가
            node[8].Add(1);
            node[8].Add(7);

            // 탐색 할 노드
            DFS(1);
        }
    }
}
