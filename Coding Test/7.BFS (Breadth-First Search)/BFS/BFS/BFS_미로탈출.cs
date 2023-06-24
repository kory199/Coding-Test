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
    class BFS_미로탈출
    {
        public static void Solution()
        {

        }
    }
    class Node
    {
        private int X = 0;
        private int Y = 0;

        // 생성자
        public Node(int x, int y)
        {
            this.X = x;
            this.Y = y;
        }

        public int getX()
        {
            return this.X;
        }

        public int getY()
        {
            return this.Y;
        }
    }

    class Main
    {

    }
}
