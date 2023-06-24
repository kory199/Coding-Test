using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DFS_Depth_First_Search
{
    /* 음료수 얼려 먹기
     * N x M 크기의 얼음 틀이 있습니다. 구멍이 뚫려 있는 부분은 0, 칸막이가 존재하는
     * 부분은 1로 표시됩니다. 구멍이 뚫려ㅓ 있는 부분끼리 상,하,좌,우로 붙어 있는 경우
     * 서로 연결되어 있는 것으로 간주합니다. 이때, 얼음 틀의 모양이 주어졌을 떄 생성되는
     * 총 아이크스림의 개수를 구하는 프로그램을 작성하세요.
     */
    class DFS_음료수얼려먹기_이코테
    {
        static int n, m;
        static int[,] graph = new int[1000, 1000];

        #region 이코테 풀이
        public static bool DFS(int x, int y)
        {
            // 주어진 범위를 벗어나는 경우에는 즉시 종료
            if (x <= -1 || x >= n || y <= -1 || y >= m)
            {
                return false;
            }
            // 현재 노드를 아직 방문하지 않았다면
            if (graph[x, y] == 0)
            {
                // 해당 노드 방문 처리
                graph[x, y] = 1;
                // 상, 하, 좌, 우의 위치들도 모두 재귀적으로 호출
                DFS(x - 1, y);
                DFS(x, y - 1);
                DFS(x + 1, y);
                DFS(x, y + 1);
                return true;
            }
            return false;
        }

        public static void Solution()
        {
            // N, M을 공백을 기준으로 구분하여 입력 받기
            string[] input = Console.ReadLine().Split();
            n = int.Parse(input[0]);
            m = int.Parse(input[1]);

            // 2차원 배열의 맵 정보 입력 받기
            for (int i = 0; i < n; i++)
            {
                string str = Console.ReadLine();
                for (int j = 0; j < m; j++)
                {
                    graph[i, j] = str[j] - '0';
                }
            }

            // 모든 노드(위치)에 대하여 음료수 채우기
            int result = 0;
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    // 현재 위치에서 DFS 수행
                    if (DFS(i, j))
                    {
                        result += 1;
                    }
                }
            }
            Console.WriteLine(result); // 정답 출력
        }
        #endregion
    }
}
