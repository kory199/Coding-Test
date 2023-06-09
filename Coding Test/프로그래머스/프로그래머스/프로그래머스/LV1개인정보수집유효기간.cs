using System;
using System.Collections.Generic;

namespace 프로그래머스
{
    class LV1개인정보수집유효기간
    {
        public int[] solution(string today, string[] terms, string[] privacies)
        {
            /*List<int> list = new List<int>();
            int todayYear = int.Parse(today.Split('.')[0]);
            int todayMonth = int.Parse(today.Split('.')[1]);
            int todayDay = int.Parse(today.Split('.')[2]);
            int todaySum = (todayYear * 12 * 28) + (todayMonth * 28) + todayDay;

            string[] termsCode = new string[terms.Length];
            int[] termsMonth = new int[terms.Length];

            for (int i = 0; i < terms.Length; i++)
            {
                termsCode[i] = terms[i].Split(' ')[0];
                termsMonth[i] = int.Parse(terms[i].Split(' ')[1]);
            }

            for (int i = 0; i < privacies.Length; i++)
            {
                string[] temp = privacies[i].Split('.', ' ');
                int year = int.Parse(temp[0]);
                int month = int.Parse(temp[1]);
                int day = int.Parse(temp[2]);
                int num = Array.IndexOf(termsCode, temp[3]);
                month += Convert.ToInt32(termsMonth[num]);
                int sum = (year * 12 * 28) + (month * 28) + day - 1;

                if (todaySum > sum)
                {
                    list.Add(i + 1);
                }
            }

            int[] answer = list.ToArray();
            return answer;*/

            DateTime dtToday = DateTime.Parse(today.Replace(".", "/") + " 00:00");
            List<int> answer = new List<int>();
            Dictionary<string, int> termsDic = new Dictionary<string, int>();
            for (int i = 0; i < terms.Length; i++)
            {
                string[] tempArr = terms[i].Split(' ');
                termsDic.Add(tempArr[0], Int32.Parse(tempArr[1]));
            }
            for (int i = 0; i < privacies.Length; i++)
            {
                string[] tempArr = privacies[i].Split(' ');
                DateTime dtPriv = DateTime.Parse(tempArr[0].Replace(".", "/") + " 00:00").AddMonths(termsDic[tempArr[1]]);

                if (dtPriv <= dtToday) answer.Add(i + 1);
            }
            return answer.ToArray();
        }
    }
}
