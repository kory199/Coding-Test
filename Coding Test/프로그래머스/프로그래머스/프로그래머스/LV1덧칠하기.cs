using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 프로그래머스
{
    class LV1덧칠하기
    {
        public static int solution(int n, int m, int[] section)
        {
            int answer = 0;
            int num = 0;

            for (int i = 0; i < section.Length; i++)
            {
                if (section[i] > num)
                {
                    num = (section[i] + m) - 1;
                    answer++;
                }
            }

            return answer;
        }
    }
}
