using System;

namespace _2675_문자열_반복
{
    class Program
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());

            for (int i = 0; i < N; i++)
            {
                // 문자 반복횟수 및 문자 저장을 위한 배열 생성
                string inStr = Console.ReadLine();

                // inOut[0]는 문자 반복을 위한 변수로 사용
                string[] inOut = inStr.Split(' ');

                // 문자열 반복 횟수
                for (int j = 0; j < inOut[1].Length; j++)
                {
                    for (int k = 0; k < int.Parse(inOut[0]); k++)
                    {
                        Console.Write(inOut[1][j]);
                    }
                }
                Console.WriteLine();
            }
        }
    }
}
