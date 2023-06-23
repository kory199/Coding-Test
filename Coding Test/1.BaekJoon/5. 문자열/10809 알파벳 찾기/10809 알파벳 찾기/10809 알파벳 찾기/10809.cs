using System;

namespace _10809_알파벳_찾기
{
    class Program
    {
        static void Main(string[] args)
        {
            // 단어 입력 (알파벳 소문자)
            string inStr = Console.ReadLine();

            // 입력된 단어를 int 형으로 받을 배열 선언
            int[] inNum = new int[inStr.Length];

            // 알파벳 배열 크기 선언
            int[] alphabet = new int[26];

            // 최종으로 출력될 배열 선언
            int[] Answer = new int[26];

            // 입력된 단어를 ASC ii를 참고하여 int 로 변경
            for (int i = 0; i < inStr.Length; i++)
            {
                inNum[i] = Convert.ToInt32(inStr[i]);
            }

            // 알파벳 배열에 ASC ii int 입력
            for (int i = 0; i < 26; i++)
            {
                alphabet[i] = i + 97; // ASC ii : 97 == 'a'
            }

            // 단어가 포함되어있지 않을 경우를 기본으로 생각
            for (int i = 0; i < 26; i++)
            {
                Answer[i] = -1;
            }

            // 같은 알파벳이 있는경우 첫 번째 글자만 인식되도록 뒷 문자정보를 없앰
            for (int i = 0; i < inStr.Length; i++)
            {
                for (int j = i + 1; j < inStr.Length; j++)
                {
                    if (inNum[i] == inNum[j])
                    {
                        // 같은 알파벳이 있는경우 뒤 알파벳이 검색되지않도록 임의의 수로 초기화
                        inNum[j] = 0;
                    }
                }
            }

            // 입력된 단어에 사용되지 않은 알파벳 찾기
            // 단어에 사용된 알파벳이 단어의 몇번째 배열에서 사용됐는지 검색
            for (int i = 0; i < inStr.Length; i++)
            {
                for (int j = 0; j < 26; j++)
                {
                    if (inNum[i] == alphabet[j])
                    {
                        Answer[j] = i;
                    }
                }
            }
            for (int i = 0; i < 26; i++)
            {
                Console.Write($"{Answer[i]} ");
            }
        }
    }
}
