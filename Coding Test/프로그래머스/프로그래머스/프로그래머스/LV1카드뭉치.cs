using System.Collections.Generic;

namespace 프로그래머스
{
    class LV1카드뭉치
    {
        public static string solution(string[] cards1, string[] cards2, string[] goal)
        {
            string answer = "";
            Dictionary<string, int> cardMap1 = new Dictionary<string, int>();
            Dictionary<string, int> cardMap2 = new Dictionary<string, int>();
            int cardCount1 = 0;
            int cardCount2 = 0;

            for (int i = 0; i < cards1.Length; i++)
            {
                cardMap1.Add(cards1[i], i);
            }

            for (int i = 0; i < cards2.Length; i++)
            {
                cardMap2.Add(cards2[i], i);
            }

            for (int i = 0; i < goal.Length; i++)
            {
                if (cardMap1.ContainsKey(goal[i]))
                {
                    if (cardMap1[goal[i]] == cardCount1)
                    {
                        cardCount1++;
                        continue;
                    }
                    else
                    {
                        return answer = "No";
                    }
                }

                if (cardMap2.ContainsKey(goal[i]))
                {
                    if (cardMap2[goal[i]] == cardCount2)
                    {
                        cardCount2++;
                        continue;
                    }
                    else
                    {
                        return answer = "No";
                    }
                }
            }
            answer = "Yes";

            return answer;
        }
    }
}
