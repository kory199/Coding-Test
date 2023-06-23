using System;

namespace _11720_숫자의_합
{
    class Program
    {
        static void Main(string[] args)
        {
            // 입력 될 숫자 개수 입력 (string -> int)
            int Num = int.Parse(Console.ReadLine());

            // 입력받는 숫자들을 저장 할 배열 선언
            string inStr = Console.ReadLine();
            int[] inNum = new int[inStr.Length];

            // 입력받은 숫자의 합을 구하기 위한 변수 초기화
            int Sum = 0;

            // string을 int배열에 넣는 반복문
            for (int i = 0; i < inStr.Length; i++)
            {
                inNum[i] = int.Parse(inStr[i].ToString());
            }

            // 입력된 N개 만큼 자연수 입력 및 더하기
            for (int i = 0; i < inStr.Length; i++)
            {
                Sum += inNum[i];
            }

            Console.WriteLine(Sum);
        }
    }
}
