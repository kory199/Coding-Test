using System;

namespace _5622_다이얼
{
    class Program
    {
        static void Main(string[] args)
        {
            // 대문자 알파벳 입력
            string inStr = Console.ReadLine();

            // 입력받은 알파벳을 정수형으로 변환 받기위한 배열 선언
            int[] inNum = new int[inStr.Length];

            // 알파벳 배열 선언
            int[] alpa = new int[26];

            /*// 2~9 번호 저장을 위한 변수 설정
            int Num = 2;*/

            // 입력된 알파벳을 숫자로 변환하기 위한 배열 선언
            int[] intArray = new int[inStr.Length];

            // 최소 시간 출력을 위한 변수 초기화
            int Answer = 0;

            // 입력받은 알파벳을 정수형으로 변환 (아스키 코드표의 10진수로 저장됨)
            for (int i = 0; i < inStr.Length; i++)
            {
                inNum[i] = (int)inStr[i];
            }

            // 알파벳 대입
            for (int i = 0; i < 26; i++)
            {
                alpa[i] = 65 + i;
            }

            // 입력된 알파벳 별 숫자 반환
            for (int i = 0; i < inStr.Length; i++)
            {
                for (int j = 65; j < 91; j += 3)
                {
                    if (inNum[i] < 68)
                    {
                        intArray[i] = 3;
                        break;
                    }

                    else if (68 <= inNum[i] && inNum[i] < 71)
                    {
                        intArray[i] = 4;
                        break;
                    }

                    else if (71 <= inNum[i] && inNum[i] < 74)
                    {
                        intArray[i] = 5;
                        break;
                    }

                    else if (74 <= inNum[i] && inNum[i] < 77)
                    {
                        intArray[i] = 6;
                        break;
                    }

                    else if (77 <= inNum[i] && inNum[i] < 80)
                    {
                        intArray[i] = 7;
                        break;
                    }

                    else if (80 <= inNum[i] && inNum[i] < 84)
                    {
                        intArray[i] = 8;
                        break;
                    }

                    else if (84 <= inNum[i] && inNum[i] < 87)
                    {
                        intArray[i] = 9;
                        break;
                    }

                    else
                    {
                        intArray[i] = 10;
                        break;
                    }
                }
                /*// 알파벳 마다 숫자를 입력하고 초기화
                Num = 2;*/
            }
            // 최소 시간
            for (int i = 0; i < inStr.Length; i++)
            {
                Answer += intArray[i];
            }
            Console.WriteLine(Answer);
        }
    }
}
