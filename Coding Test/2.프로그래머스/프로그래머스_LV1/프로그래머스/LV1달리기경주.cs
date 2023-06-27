using System.Collections.Generic;

namespace 프로그래머스
{
    class LV1달리기경주
    {
        public static string[] solution(string[] players, string[] callings)
        {
            string[] answer = new string[players.Length];

            Dictionary<string, int> playerInfoMap = new Dictionary<string, int>();

            int[] playerIndices = new int[players.Length];
            int curPlayerRank = 0;
            int prevPlayerRank = 0;

            // player info mapping 
            // dictionary 시간 복잡도 O(1)
            for (int i = 0; i < players.Length; i++)
            {
                playerInfoMap[players[i]] = i;
                playerIndices[i] = i;
                answer[i] = players[i];
            }

            // 순위 변경
            for (int i = 0; i < callings.Length; i++)
            {
                curPlayerRank = playerInfoMap[callings[i]];
                string transPlayer = players[curPlayerRank-1];

                if (curPlayerRank > 0)
                {
                    prevPlayerRank = curPlayerRank - 1;
                    playerInfoMap[callings[i]] = prevPlayerRank;
                    playerInfoMap[transPlayer] = curPlayerRank;
                    players[prevPlayerRank] = callings[i];
                    players[curPlayerRank] = transPlayer;
                }
            }

            // 변경된 순위에 따른 선수 answer배열에 추가
            for (int i = 0; i < players.Length; i++)
            {
                answer[i] = players[i];
            }
            return answer;
        }
    }
}
