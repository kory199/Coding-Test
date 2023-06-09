using System;
using System.Collections.Generic;

namespace 프로그래머스
{
    class LV1개인정보수집유효기간
    {
        public static int[] solution(string today, string[] terms, string[] privacies)
        {
            int[] answer = new int[] { };
            Dictionary<string, int> userTerms = new Dictionary<string, int>();
            DateTime dateTime = DateTime.Parse(today);

            for (int i = 0; i < terms.Length; i++)
            {
                userTerms.Add(terms[i].Split[' ']);
            }



            // 파기정보 오름차순으로 answer

            return answer;
        }
    }
}
