using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 프로그래머스
{
    class LV1둘만의암호
    {
        public static string solution(string s, string skip, int index)
        {
            string answer = "";
            char splitS;

            for (int i = 0; i < s.Length; i++)
            {
                splitS = s[i];

                for (int j = 0; j < index; )
                {
                    splitS = (char)((int)splitS + 1);

                    if (splitS > 'z') 
                        splitS = 'a';

                    if (skip.Contains(splitS))
                    {
                        continue;
                    }
                    j++;
                }
                answer += splitS;
            }
            return answer;
        }
    }
}
