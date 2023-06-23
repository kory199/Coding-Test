using System;

namespace _1316_그룹_단어_체커
{
    class Program
    {
        static void Main(string[] args)
        {
            // 테스트 케이스를 입력받는 변수 선언 및 입력 받기
            int N = int.Parse(Console.ReadLine());

            // 테스트 케이스 크기에 맞는 문자열을 입력받기 위한 배열 선언
            string[] inStr = new string[N];

            // 그룹 단어를 카운트 할 Count 변수 초기화
            int Count = 0;

            // 테스트 케이스만큼 입력받을 문자열(소문자 알파벳) 입력 받기
            for (int i = 0; i < N; i++)
            {
                inStr[i] = Console.ReadLine();
            }

            // 입력된 문자열(소문자 알파벳)이 그룹 단어인지 카운트하는 반복문
            for (int i = 0; i < N; i++)
            {
                if (GroupAlphaCheck(inStr[i]))
                {
                    Count++;
                }
            }
            Console.WriteLine(Count);
        }
        // 입력된 문자열(소문자 알파벳)이 그룹 단어인지 판단하는 함수
        static bool GroupAlphaCheck(string inStr)
        {
            // 문자열을 비교해 그룹 단어 판별을 위해 2중 for문 선언
            for (int i = 0; i < inStr.Length; i++)
            {
                for (int j = i; j < inStr.Length; j++)
                {
                    // i배열이랑 2이상 떨어진 j배열에서 같은 알파벳이 나온다면 
                    // return = false
                    if (j - i > 1)
                    {
                        if (inStr[i] == inStr[j])
                        {
                            // return이 출력되면 함수는 break
                            return false;
                        }
                    }
                    if (inStr[i] == inStr[j])
                    {
                        // 같은 알파벳이 반복되는 배열까지 i스킵
                        i += j - i;
                    }
                }
            }
            return true;
        }
    }
}
