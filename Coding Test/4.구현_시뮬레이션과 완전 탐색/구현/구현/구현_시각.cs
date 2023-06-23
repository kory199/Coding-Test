using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 구현
{
    /* 시각
     * 정수 N이 입력되면 00시 00분 00초부터 N시 59분 59초까지의 모든 시각 중에서
     * 3이 하나라도 포함되는 모든 경우의 수를 구하는 프로그램을 작성하시오.
     * 
     * 예를 들어 1을 입력했을 때 다음은 3이 하나라도 포함되어 있으므로 세어야되는 시각입니다.
     * 00시 00분 03초 / 00시 13분 30초
     * 
     * 반면에 다음은 3이 하나도 포함되어 있지 않으므로 세면 안되는 시각입니다.
     * 00시 02분 55초 / 01시 27분 45초
     */
    class 구현_시각
    {
        public static void Solution()
        {
            // 완전 탐색
            int clock = int.Parse(Console.ReadLine());
            int count = 0;

            for (int h = 0; h < clock + 1; h++)
            {
                for (int m = 0; m < 60; m++)
                {
                    for (int s = 0; s < 60; s++)
                    {
                        if (Check(h, m, s))
                            count++;
                    }
                }
            }
            Console.WriteLine(count);
        }

        public static bool Check(int h, int m, int s)
        {
            if (h % 10 == 3 || m / 10 == 3 || m % 10 == 3 ||
                s / 10 == 3 || s % 10 == 3)
            {
                return true;
            }

            return false;
        }
    }
}
