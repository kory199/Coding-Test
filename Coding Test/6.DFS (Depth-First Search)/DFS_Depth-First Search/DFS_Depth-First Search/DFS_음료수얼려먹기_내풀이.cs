using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DFS_Depth_First_Search
{
    class DFS_음료수얼려먹기_내풀이
    {
        static int n = 0;
        static int m = 0;
        static int[,] map = new int[1000, 1000];
        static int answer = 0;

        public static bool DFS(int x, int y)
        {
            if (x < 0 || x >= n || y < 0 || y >= m)
                return false;
            // 방묻되지 않는 노드라면
            if (map[x, y] == 0)
            {
                // 방문한 노드 체크
                map[x, y] = 1;

                DFS(x, y - 1);
                DFS(x, y + 1);
                DFS(x - 1, y);
                DFS(x + 1, y);

                return true;
            }
            return false;
        }

        public static void Solution()
        {
            string[] inputMapSize = Console.ReadLine().Split();
            n = int.Parse(inputMapSize[0]);
            m = int.Parse(inputMapSize[1]);

            // 얼음틀에 음료수 채워넣기
            for (int x = 0; x < n; x++)
            {
                string molt = Console.ReadLine();
                for (int y = 0; y < m; y++)
                    map[x, y] = molt[y] - '0';
            }

            // 아이스크림 개수 탐색
            for (int x = 0; x < n; x++)
            {
                for (int y = 0; y < m; y++)
                {
                    if (DFS(x, y))
                        answer++;
                }
            }
            Console.WriteLine(answer);
        }
    }
}
