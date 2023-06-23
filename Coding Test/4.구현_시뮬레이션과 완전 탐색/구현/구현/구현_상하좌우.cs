using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 구현
{
    /* 여행가 A는 NxN 크기의 정사각형 공간 위에 서 있습니다.
     * 이 공간은 1x1 크기의 정사각형으로 나누어져 있습니다.
     * 가장 왼쪽 위 좌표는 (1,1)이며, 가장 오른쪽 아래 좌표는
     * (N,N)에 해당합니다. 여행가 A는 상,하,좌,우 방향으로
     * 이동할 수 있으며, 시작 좌표는 항상 (1,1)입니다.
     * 우리 앞에는 여행가 A가 이동할 계획이 적신 기획서가 놓여 있습니다.
     * 계획서에는 하나의 줄에 띄어쓰기를 기준으로 하여 L,R,U,D 중
     * 하나의 문자가 반복적으로 적혀 있습니다.
     */
    class 구현_상하좌우
    {
        public static void Solution()
        {
            #region 내 풀이
            int mapSize = int.Parse(Console.ReadLine());
            string[] movePosition = Console.ReadLine().Split();
            int playerPositionX = 1;
            int playerPositionY = 1;

            for (int i = 0; i < movePosition.Length; i++)
            {
                char[] temp = movePosition[i].ToCharArray();
                int prevPlayerPositionX = playerPositionX;
                int prevPlayerPositionY = playerPositionY;

                switch (temp[0])
                {
                    case 'R':
                        playerPositionY++;
                        break;
                    case 'L':
                        playerPositionY--;
                        break;
                    case 'U':
                        playerPositionX--;
                        break;
                    case 'D':
                        playerPositionX++;
                        break;
                    default:
                        break;
                }

                if (playerPositionX < 1 || playerPositionX > mapSize ||
                    playerPositionY < 1 || playerPositionY > mapSize)
                {
                    playerPositionX = prevPlayerPositionX;
                    playerPositionY = prevPlayerPositionY;
                }
            }
            Console.WriteLine($"{playerPositionX} {playerPositionY}");
            #endregion

            #region 이코테 풀이
            // N을 입력받기
            int n = int.Parse(Console.ReadLine());
            string[] plans = Console.ReadLine().Split(' ');
            int x = 1, y = 1;

            // L, R, U, D에 따른 이동 방향 
            int[] dx = { 0, 0, -1, 1 };
            int[] dy = { -1, 1, 0, 0 };
            char[] moveTypes = { 'L', 'R', 'U', 'D' };

            // 이동 계획을 하나씩 확인
            for (int i = 0; i < plans.Length; i++)
            {
                char plan = plans[i][0];
                // 이동 후 좌표 구하기 
                int nx = -1, ny = -1;
                for (int j = 0; j < 4; j++)
                {
                    if (plan == moveTypes[j])
                    {
                        nx = x + dx[j];
                        ny = y + dy[j];
                    }
                }
                // 공간을 벗어나는 경우 무시 
                if (nx < 1 || ny < 1 || nx > n || ny > n)
                    continue;
                // 이동 수행 
                x = nx;
                y = ny;
            }

            Console.WriteLine(x + " " + y);
            #endregion
        }
    }
}
