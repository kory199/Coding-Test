﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortAlgorithm
{
    /* 동비닝는 두 개의 배열 A와 B를 가지고 있습니다. 두 배열은 N개의 원소로
     * 구성되어 있으며, 배열의 원소는 모두 자연수입니다.
     * 동빈이는 최대 K번의 바꿔치기 연산을 수행할 수 있는데, 바꿔치기 연산이란
     * 배열 A에 있는 원소 하나와 배열 B에 이쓴ㄴ 원소 하나를 골라서 두 원소를
     * 서로 바꾸는 것을 말합니다.
     * 동빈이의 최종 목표는 배열 A의 모든 원소의 합이 최대가 되도록 하는 것이며,
     * 여러분은 동빈이를 도와야 합니다.
     * N, K 그리고 배열 A와 B의 정보가 주어졌을 때, 최대 K번의 바꿔치기 연산을
     * 수행하여 만들 수 있는 배열 A의 모든 원소의 합의 최댓값을 출력하는 프로그램을
     * 작성하시오.
     */
    class 이코테_두배열의원소교체
    {
        public static void Solution()
        {
            string[] inputStr = Console.ReadLine().Split();
            int n = int.Parse(inputStr[0]);
            int k = int.Parse(inputStr[1]);
            int[] A = new int[n];
            int[] B = new int[n];
            int answer = 0;

            for (int i = 0; i < 2; i++)
            {
                string[] inputTestCase = Console.ReadLine().Split();

                for (int j = 0; j < inputTestCase.Length; j++)
                {
                    if (i == 0)
                        A[j] = int.Parse(inputTestCase[j]);
                    else
                        B[j] = int.Parse(inputTestCase[j]);
                }
            }

            Array.Sort(A);
            Array.Sort(B);
            Array.Reverse(B);

            for (int i = 0; i < k; i++)
            {
                if (A[i] < B[i])
                    A[i] = B[i];
            }

            for (int i = 0; i < A.Length; i++)
                answer += A[i];

            Console.WriteLine(answer);
        }
    }
}
