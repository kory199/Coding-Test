using System;

namespace _1546_평균
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            int N = int.Parse(input);
            // intNum 배열의 크기를 입력된 N값으로 선언
            int[] intNum = new int[N];
            // 최대값 저장
            double MaxNum = 0;
            // 중간 계산
            double Sum = 0;
            // 최종 계산
            double Answer = 0;

            // string을 int 배열에 대입
            // string for문 밖에 선언 **
            string inStr = Console.ReadLine();
            string[] strings = inStr.Split(' ');

            for (int i = 0; i < intNum.Length; i++)
            {
                intNum[i] = int.Parse(strings[i]);
            }

            // 최대값 초기화
            MaxNum = intNum[0];

            for (int k = 1; k < N; k++)
            {
                if (MaxNum < intNum[k])
                {
                    MaxNum = intNum[k];
                }
            }

            for (int x = 0; x < N; x++)
            {
                Sum += intNum[x];
            }

            // 최종 계산
            Answer = (Sum * 100) / MaxNum / N;
            Console.WriteLine(Answer);
        }

    }
}
}
