using System;

namespace _1157_단어공부
{
    class Program
    {
        static void Main(string[] args)
        {
            // 알파벳 대소문자로 이루어진 문자열 입력
            string inStr = Console.ReadLine();

            // String을 int 형으로 변환 후 저장하기 위한 배열 선언
            int[] inNum = new int[inStr.Length];

            // 입력된 문자 중 A~Z 카운트를 위한 배열 선언
            int[] alpaArray = new int[26];

            // 카운트 변수 선언
            int Count = 0;

            // 최빈도 값이 저장된 배열 번호를 받기 위한 변수 초기화
            int fNum = 0;

            // 최빈도 알파벳 값이 여러개일 경우를 위한 변수 초기화
            int MaxS = 0;

            // 입력된 문자열을 char로 변환하고 이를 int형으로 변환 (ASC ii표를 참고)
            for (int i = 0; i < inStr.Length; i++)
            {
                inNum[i] = Convert.ToInt32(inStr[i]);

                // 입력된 문자 중 소문자를 대문자로 변환
                if (inNum[i] >= 97)
                {
                    inNum[i] -= 32;
                }
            }

            for (int i = 0; i < 26; i++)
            {
                // alpaArray[] 초기화
                alpaArray[i] = 0;
            }

            // 입력된 문자열 중 가장 많이 사용된 알파벳 카운트
            for (int i = 0; i < inStr.Length; i++)
            {
                for (int j = 0; j < 26; j++)
                {
                    if (inNum[i] == j + 65)
                    {
                        alpaArray[j] += ++Count;
                    }
                }
                // 카운트 변수 사용 후 초기화
                Count = 0;
            }

            // 가장 많이 사용된 알파벳을 저장한 배열을 찾기 위한 변수 선언
            int Max = alpaArray[0];

            // ---------------------------------------------------------------

            for (int i = 0; i < 26; i++)
            {
                // 최빈도 알파벳 뽑기
                if (Max < alpaArray[i])
                {
                    Max = alpaArray[i];
                    fNum = i;
                }
            }

            // 최대값이 같은 경우 '?' 출력은 위한 반복문
            for (int i = 0; i < 26; i++)
            {
                if (alpaArray[fNum] == alpaArray[i])
                {
                    // 최댓값으로 존재하는 알파벳이 여러개인 경우 
                    if ((fNum) != i)
                    {
                        MaxS = 63;
                        Console.WriteLine((char)MaxS);
                        break;
                    }
                }
            }
            if (MaxS != 63)
            {
                Console.WriteLine((char)(fNum + 65));
            }
        }
    }
}
