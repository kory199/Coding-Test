using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BFS
{
    /* 미로 탈출
     * 동빈이는 N x M 크기의 직사각형 혀애의 미로에 갇혔습니다. 미로에는
     * 여러 미러의 괴물이 있어 이를 피해 탈출해야 합니다.
     * 동빈이의 위치는 (1,1)이며 미로의 출구는 (N,M)의 위치에 존재하며
     * 한 번에 한 칸씩 이동할 수 있습니다. 이떄 괴물이 있는 부분은 0으로,
     * 괴물이 없는 부분은 1로 표시되어 있습니다. 미로는 반드시 탈출할 수
     * 있는 형태로 제시됩니다.
     * 이떄 동빈이가 탈출하기 위해 움직여야하는 최소 칸의 개수를 구하세요.
     * 칸을 셀 떄는 시작 칸과 마지막 칸을 모두 포함해서 계산합니다.
     * 
     * BFS 선정 이유 
     * 간선의 비용이 모두 같을 때 최단거리를 탐색하기 위해
     */
    public static class BFS_미로탈출
    {
        public static int n, m;
        public static int[,] graph = new int[201, 201];

        // 이동할 네 가지 방향 정의 (상, 하, 좌, 우)
        public static int[] dx = { -1, 1, 0, 0 };
        public static int[] dy = { 0, 0, -1, 1 };

        public static int BFSFunc(int x, int y)
        {
            // 큐(Queue) 구현을 위해 Queue 라이브러리 사용
            Queue<Node> q = new Queue<Node>();
            q.Enqueue(new Node(x, y));

            // 큐가 빌 때까지 반복하기
            while (q.Count > 0)
            {
                Node node = q.Dequeue();
                x = node.X;
                y = node.Y;

                // 현재 위치에서 4가지 방향으로의 위치 확인
                for (int i = 0; i < 4; i++)
                {
                    int nx = x + dx[i];
                    int ny = y + dy[i];

                    // 미로 찾기 공간을 벗어난 경우 무시
                    if (nx < 0 || nx >= n || ny < 0 || ny >= m)
                        continue;

                    // 벽인 경우 무시
                    if (graph[nx, ny] == 0)
                        continue;

                    // 해당 노드를 처음 방문하는 경우에만 최단 거리 기록
                    if (graph[nx, ny] == 1)
                    {
                        graph[nx, ny] = graph[x, y] + 1;
                        q.Enqueue(new Node(nx, ny));
                    }
                }
            }

            // 가장 오른쪽 아래까지의 최단 거리 반환
            return graph[n - 1, m - 1];
        }

        public static void Solution()
        {
            // N, M 입력 받기
            string[] input = Console.ReadLine().Split();
            n = int.Parse(input[0]);
            m = int.Parse(input[1]);

            // 2차원 배열 입력 받기
            for (int i = 0; i < n; i++)
            {
                string str = Console.ReadLine();
                for (int j = 0; j < m; j++)
                {
                    graph[i, j] = str[j] - '0';
                }
            }

            // BFS를 수행한 결과 출력
            Console.WriteLine(BFSFunc(0, 0));
        }
    }

    class Node
    {
        public int X { get; private set; }
        public int Y { get; private set; }

        // 생성자
        public Node(int x, int y)
        {
            this.X = x;
            this.Y = y;
        }
    }
}
