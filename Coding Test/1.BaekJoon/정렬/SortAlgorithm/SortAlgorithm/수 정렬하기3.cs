using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortAlgorithm
{
    internal class 수_정렬하기3
    {
        public static void Solution()
        {
            int n = int.Parse(Console.ReadLine());
            int[] inputNum = new int[10001];
            int max = int.MinValue;
            int temp = 0;

            StreamWriter sr = new StreamWriter(Console.OpenStandardOutput());
            StringBuilder sb = new StringBuilder();

            for (int i = 0; i < n; i++)
            {
                temp = int.Parse(Console.ReadLine());
                inputNum[temp]++;
                if (max < temp)
                {
                    max = temp;
                }
            }

            for (int i = 0; i < max; )
            {
                if (inputNum[i] == 0)
                {
                    i++;
                    continue;
                }

                sb.Append(i + "\n");
                inputNum[i]--;

                if (sb.Length > 500)
                {
                    sr.Write(sb);
                    sb.Clear();
                }
            }
            sr.Write(sb);
            sr.Close();
        }

        public static void Solution_Success()
        {
            int[] counting = new int[10001];

            var sw = new StreamWriter(Console.OpenStandardOutput());
            StringBuilder sb = new StringBuilder();
            int testCase = int.Parse(Console.ReadLine());
            int max = int.MinValue;
            int num = 0;

            for (int i = 0; i < testCase; i++)    // 카운팅
            {
                num = int.Parse(Console.ReadLine());
                counting[num]++;
                if (max < num)
                    max = num;
            }


            for (int i = 0; i <= max;)             // 정렬해서 출력
            {
                if (counting[i] == 0)
                {
                    i++;
                    continue;
                }

                sb.Append(i + "\n");
                counting[i]--;
                if (600 <= sb.Length)
                {
                    sw.Write(sb);
                    sb.Clear();
                }
            }
            sw.Write(sb);
            sw.Close();
        }
    }
}
