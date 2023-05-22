using System;

namespace _1152_단어의_개수
{
    class Program
    {
        static void Main(string[] args)
        {
            // 문자열을 입력받고 공백을 기준으로 분리함
            string[] inStr = Console.ReadLine().Split(' ');

            // 단어 개수 카운트를 위한 변수 초기화
            int Count = inStr.Length;

            // 공백 확인을 위한 변수 설정 (아스키 코드표 상 스페이스바)
            string Space = "";

            for (int i = 0; i < inStr.Length; i++)
            {
                if (inStr[i] == Space)
                {
                    Count--;
                }
            }
            Console.WriteLine(Count);
        }
    }
}
