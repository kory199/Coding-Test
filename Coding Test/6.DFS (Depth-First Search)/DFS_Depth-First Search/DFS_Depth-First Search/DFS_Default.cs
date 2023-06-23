using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DFS_Depth_First_Search
{
    class DFS_Default
    {
        #region DFS_재귀함수
        public static bool[] visited = new bool[9];
        public static List<List<int>> graph = new List<List<int>>();
        
        // DFS 함수 정의
        public static void Dfs(int x)
        {
            // 현재 노드를 방문 처리
            visited[x] = true;
            Console.Write(x + " ");
            // 현재 노드와 연결된 다른 노드를 재귀적으로 방문
            for (int i = 0; i < graph[x].Count; i++)
            {
                int y = graph[x][i];
                if (!visited[y])
                    Dfs(y);
            }
        }

        public static void Solution()
        {
            // 그래프 초기화
            for (int i = 0; i < 9; i++)
            {
                graph.Add(new List<int>());
            }

            // 노드 1에 연결된 노드 정보 저장
            graph[1].Add(2);
            graph[1].Add(3);
            graph[1].Add(8);

            // 노드 2에 연결된 노드 정보 저장
            graph[2].Add(1);
            graph[2].Add(7);

            // 노드 3에 연결된 노드 정보 저장
            graph[3].Add(1);
            graph[3].Add(4);
            graph[3].Add(5);

            // 노드 4에 연결된 노드 정보 저장
            graph[4].Add(3);
            graph[4].Add(5);

            // 노드 5에 연결된 노드 정보 저장
            graph[5].Add(3);
            graph[5].Add(4);

            // 노드 6에 연결된 노드 정보 저장
            graph[6].Add(7);

            // 노드 7에 연결된 노드 정보 저장
            graph[7].Add(2);
            graph[7].Add(6);
            graph[7].Add(8);

            // 노드 8에 연결된 노드 정보 저장
            graph[8].Add(1);
            graph[8].Add(7);

            Dfs(1);
        }
        #endregion
    }
}
