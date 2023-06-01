using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 프로그래머스
{
    class LV1삼총사
    {
        public static int solution(int[] number)
        {
            int answer = 0;

            for (int i = 0; i < number.Length - 2; i++)
            {
                for (int j = i + 1; j < number.Length; j++)
                {
                    for (int k = j + 1; k < number.Length; k++)
                    {
                        if (number[i] + number[j] + number[k] == 0)
                        {
                            answer++;
                        }
                    }
                }
            }
            return answer;
        }
    }
}
