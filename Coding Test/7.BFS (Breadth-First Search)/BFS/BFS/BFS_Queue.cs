using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BFS
{
    class BFS_Queue
    {
        public static bool[] visitCheck = new bool[9];
        public static List<List<int>> node = new List<List<int>>();

        public static void BFS(int findNode)
        {
            Queue<int> visiteNode = new Queue<int>();
            // 현재 노드 방문
            visitCheck[findNode] = true;
            // 현재 노드를 큐에 추가
            visiteNode.Enqueue(findNode);

            while (visiteNode.Count > 0)
            {
                // 방문한 노드를 출력하고 Dequeue
                int curNode = visiteNode.Dequeue();
                Console.Write($"{curNode} ");

                // 해당 노드와 연결된 노드 중 방문하지 않은 노드를 큐에 삽입
                foreach (var i in node[curNode])
                {
                    if (!visitCheck[i])
                    {
                        visiteNode.Enqueue(i);
                        visitCheck[i] = true;
                    }
                }
            }
        }

        public static void Solution()
        {
            // list 초기화
            for (int i = 0; i < 9; i++)
            {
                node.Add(new List<int>());
            }

            // 1번 노드 인접 노드 추가 
            node[1].Add(2);
            node[1].Add(3);
            node[1].Add(8);

            // 2번 노드 인접 노드 추가
            node[2].Add(1);
            node[2].Add(7);

            // 3번 노드 인접 노드 추가
            node[3].Add(1);
            node[3].Add(4);
            node[3].Add(5);

            // 4번 노드 인접 노드 추가
            node[4].Add(3);
            node[4].Add(5);

            // 5번 노드 인접 노드 추가
            node[5].Add(3);
            node[5].Add(4);

            // 6번 노드 인접 노드 추가
            node[6].Add(7);

            // 7번 노드 인접 노드 추가
            node[7].Add(2);
            node[7].Add(6);
            node[7].Add(8);

            // 8번 노드 인접 노드 추가
            node[8].Add(1);
            node[8].Add(7);

            BFS(1);
        }
    }
}
