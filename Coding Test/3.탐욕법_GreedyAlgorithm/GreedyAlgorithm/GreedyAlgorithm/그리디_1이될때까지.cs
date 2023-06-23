using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GreedyAlgorithm
{
    // 첫쨰 줄에 N(1<=N<=100,000)과 K(2<=ㅏ<=100,000)가
    // 공백을 기준으로 하여 각각 자연수로 주어짐
    // 
    // 출력 조건
    // 첫째 줄에 N이 1이 될 때까지 1번 혹은 2번의 과정을
    // 수행해야하는 횟수의 최솟값을 출력

    class 그리디_1이될때까지
    {
        public static void Solution()
        {
            string[] inputStr = Console.ReadLine().Split();
            int N = int.Parse(inputStr[0]);
            int K = int.Parse(inputStr[1]);
            int N1 = N;
            int N2 = N;
            int K1 = K;
            int K2 = K;
            int count1 = 0;
            int count2 = 0;

            #region 풀이 1번 (O(log n))

            while (true)
            {
                // 입력된 숫자 N에서 가장 가까운 K 배수 구하기
                int temp = (N1 / K1) * K1;
                // 일력된 숫자 N에서 가장 가까운 K의 배수와의 차이로 배수가 아닐 때 -1과정 생략
                count1 += N1 % K1;
                N1 = temp;

                // N을 더 이상 K로 나눌 수 없을 때 반복문 탈출
                if (N1 < K1)
                    break;
                // 새로 할당된 N을 K로 나누기 (이때 N은 항상 K의 배수)
                N1 /= K;
                count1++;
            }

            // K로 나누어지지 않는 수 N에서 -1
            count1 += N1 - 1;

            Console.WriteLine($"풀이 1번 : {count1}");
            #endregion

            #region 풀이 2번 (O(N))

            while (true)
            {
                if (N2 == 1)
                    break;

                count2++;

                if (N2 % K2 == 0)
                    N2 /= K2;
                else
                    N2 -= 1;
            }

            Console.WriteLine($"풀이 2번 : {count2}");
            #endregion
        }
    }
}
