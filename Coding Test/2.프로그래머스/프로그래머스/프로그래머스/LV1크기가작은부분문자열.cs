using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 프로그래머스
{
    class LV1크기가작은부분문자열
    {
        public static int solution(string t, string p)
        {
            int answer = 0;
            long transP = long.Parse(p);
            string tempT = "";

            for (int i = 0; i < t.Length - p.Length + 1; i++)
            {
                for (int j = 0; j < p.Length; j++)
                {
                    if (j + i < t.Length)
                    {
                        tempT += t[j + i];
                    }
                }

                if (long.Parse(tempT) <= transP)
                {
                    answer++;
                }
                tempT = "";
            }
            return answer;
        }
    }
}
