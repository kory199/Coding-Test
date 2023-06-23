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
        }
    }
}
