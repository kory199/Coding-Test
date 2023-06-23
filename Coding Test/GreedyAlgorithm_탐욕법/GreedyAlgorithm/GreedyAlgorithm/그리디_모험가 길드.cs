using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GreedyAlgorithm
{
    /* 모험가 길드
     * 한 마을에 모험가가 N명 았습니다. 모험가 길드에서는 N명의 모험가를
     * 대상으로 '공포도'를 측정했는데, '공포도'가 높은 모험가는 쉽게 공포를 
     * 느껴 위험상황에서 제대로 대처할 능력이 떨어집니다.
     * 모험가 길드장인 동빈이는 모험가 그룹을 안전하게 구성하고자 공포도가
     * X인 모험가는 반드시 X명 이상으로 구헌상 모험가 그룹이 참여해야 
     * 여행을 떠날 수 있도록 규정했습니다.
     * 동빈이는 최대 몇 개의 모험가 그룹을 만들 수 있는지 궁금합니다.
     * N명의 모험가에 대한 정보가 주어졌을 때, 여행을 떠날 수 있는
     * 그룹 수의 최댓값을 구하는 프로그램을 작성하세요.
     */
    class 그리디_모험가_길드
    {
        public static void Solution()
        {
            string inputTestScale = Console.ReadLine();
            string[] inputTestCase = Console.ReadLine().Split();
            int testScale = int.Parse(inputTestScale);
            List<int> player = new List<int>();
            int playerCount = 0;
            int teamCount = 0;

            for (int i = 0; i < testScale; i++)
                player.Add(int.Parse(inputTestCase[i]));

            player.Sort();

            for (int i = 0; i < testScale; i++)
            {
                playerCount++;
                if (player[i] <= playerCount)
                {
                    teamCount++;
                    playerCount = 0;
                }
            }

            Console.WriteLine(teamCount);
        }
    }
}
