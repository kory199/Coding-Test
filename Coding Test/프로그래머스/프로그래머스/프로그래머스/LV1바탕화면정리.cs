using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 프로그래머스
{
    class LV1바탕화면정리
    {
        public static int[] solution(string[] wallpaper)
        {
            int lux = 50;
            int luy = 50;
            int rdx = 0;
            int rdy = 0;

            for (int i = 0; i < wallpaper.Length; i++)
            {
                for (int j = 0; j < wallpaper[0].Length; j++)
                {
                    if (wallpaper[i][j] == '#')
                    {
                        lux = lux > i ? i : lux;
                        luy = luy > j ? j : luy;
                        rdx = rdx < i ? i : rdx;
                        rdy = rdy < j ? j : rdy;
                    }
                }
            }

            int[] answer = new int[] { lux, luy, rdx + 1, rdy + 1 };
            return answer;
        }
    }
}
