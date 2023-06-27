using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 프로그래머스
{
    class LV1_K번쨰수
    {
        public static int[] solution(int[] array, int[,] commands)
        {
            int[] answer = new int[commands.GetLength(0)];

            for (int i = 0; i < commands.GetLength(0); i++)
            {
                int[] tempArray = new int[commands[i, 1] - commands[i, 0] + 1];

                for (int j = 0; j < tempArray.Length; j++)
                    tempArray[j] = array[commands[i, 0] + j - 1];
                Array.Sort(tempArray);
                answer[i] = tempArray[commands[i, 2] - 1];
            }
            return answer;
        }
    }
}
