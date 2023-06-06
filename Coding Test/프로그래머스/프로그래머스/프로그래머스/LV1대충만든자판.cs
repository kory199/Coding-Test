using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 프로그래머스
{
    class LV1대충만든자판
    {
        public static int[] solution(string[] keymap, string[] targets)
        {
            int[] answer = new int[targets.Length];
            int countText = 0;
            int countSum = 0;

            for (int i = 0; i < targets.Length; i++)
            {
                for (int j = 0; j < targets[i].Length; j++)
                {
                    countText = compareKeymap(targets[i][j], keymap);

                    if (countText == -1)
                    {
                        countSum = countText;
                        break;
                    }
                    else
                    {
                        countSum += countText;
                    }
                }
                answer[i] = countSum;
                countSum = 0;
            }
            return answer;
        }

        public static int compareKeymap(char targetChar, string[] keymap)
        {
            int count = -1;

            for (int i = 0; i < keymap.Length; i++)
            {
                for (int j = 0; j < keymap[i].Length; j++)
                {
                    if (keymap[i][j] == targetChar)
                    {
                        if (count == -1)
                        {
                            count = j + 1;
                            break;
                        }

                        else if (count > j)
                        {
                            count = j + 1;
                            break;
                        }
                    }
                }
            }
            return count;
        }
    }
}
