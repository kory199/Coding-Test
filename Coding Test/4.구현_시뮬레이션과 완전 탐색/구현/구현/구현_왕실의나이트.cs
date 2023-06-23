using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 구현
{
    /* 왕실의 나이트
     * 행복 왕국의 왕실 정원은 체스판과 같은 8x8 좌표 평면입니다. 왕실 정원의
     * 특정한 한 칸에 나이트가 서 있습니다. 나이트는 매우 충성스러운 신하로서 매일
     * 무술을 연마합니다. 나이트는 말을 타고 있기 때문에 이동을 할 때는 L자 형태로만
     * 이동할 수 있으며, 정원 밖으로는 나갈 수 없습니다.
     * 나이트는 특정 위치에서 다음과 같은 2가지 경우로 이동할 수 있습니다.
     *  1. 수평으로 두 칸 이동한 뒤에 수직으로 한 칸 이동하기
     *  2. 수직으로 두 칸 이동한 뒤에 수평으로 한칸 이동하기
     *  
     *  이 처럼 8x8 좌표 평면상에서 나이트의 위치가 주어졌을 때 나이트가 이동할 수 있는
     *  경우의 수를 출력하는 프로그램을 작성하세요. 왕실의 정원에서 행 위치를 표현할 떄는
     *  1부터 8로 표현하며, 열 위치를 표현할떄는 a부터 h로 표현합니다.
     */
    class 구현_왕실의나이트
    {
        public static void Solution()
        {
            #region 내 풀이
            string inputStr = Console.ReadLine();
            char[] inputHorizontalPosition = { 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h' };
            int x = ((int)inputStr[1] - '0') - 1;
            int y = 0;
            int[] dx = { 1, -1, 1, -1, 2, 2, -2, -2 };
            int[] dy = { 2, 2, -2, -2, 1, -1, 1, -1 };
            int count = 0;

            for (int i = 0; i < inputHorizontalPosition.Length; i++)
            {
                if (inputHorizontalPosition[i] == inputStr[0])
                {
                    y = i;
                    break;
                }
            }

            for (int i = 0; i < 8; i++)
            {
                int nx = x + dx[i];
                int ny = y + dy[i];

                if (nx >= 0 && ny >= 0 && nx < 8 && ny < 8)
                    count++;
            }
            Console.WriteLine(count);
            #endregion

            #region 이코테 풀이
            // 현재 나이트의 위치 입력받기
            string inputData = Console.ReadLine();
            int row = inputData[1] - '0';
            int column = inputData[0] - 'a' + 1;

            // 나이트가 이동할 수 있는 8가지 방향 정의
            int[] _dx = { -2, -1, 1, 2, 2, 1, -1, -2 };
            int[] _dy = { -1, -2, -2, -1, 1, 2, 2, 1 };

            // 8가지 방향에 대하여 각 위치로 이동이 가능한지 확인
            int result = 0;
            for (int i = 0; i < 8; i++)
            {
                // 이동하고자 하는 위치 확인
                int nextRow = row + _dx[i];
                int nextColumn = column + _dy[i];
                // 해당 위치로 이동이 가능하다면 카운트 증가
                if (nextRow >= 1 && nextRow <= 8 && nextColumn >= 1 && nextColumn <= 8)
                {
                    result += 1;
                }
            }

            Console.WriteLine(result);
            #endregion
        }
    }
}
