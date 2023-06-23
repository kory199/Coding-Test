using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 구현
{
    /* 문자열 재정렬
     * 알파벳 대문자와 숫자(0~9)로만 구성도니 문자열이 입력으로 주어집니다.
     * 이때 모든 알파벳을 오름차순으로 정렬하여 이어서 출력한 뒤에, 그 뒤에
     * 모든 숫자를 더한 값을 이어서 출력합니다.
     * 
     * 예) K1KA5CB7 => ABCKK13 출력
     */
    class 구현_문자열재정렬
    {
        public static void Solution()
        {
            #region 내 풀이
            string inputStr = Console.ReadLine();
            List<char> inputChar = new List<char>();
            List<int> inputNum = new List<int>();

            for (int i = 0; i < inputStr.Length; i++)
            {
                if (inputStr[i] >= '0' && inputStr[i] <= '9')
                    inputNum.Add(((int)inputStr[i] - '0'));
                else
                    inputChar.Add(inputStr[i]);
            }

            inputChar.Sort();

            foreach (var i in inputChar)
                Console.Write(i);
            Console.WriteLine(inputNum.Sum());
            #endregion



            #region 이코테 풀이
            string str = Console.ReadLine();
            List<char> result = new List<char>();
            int value = 0;

            // 문자를 하나씩 확인하며
            for (int i = 0; i < str.Length; i++)
            {
                // 알파벳인 경우 결과 리스트에 삽입
                if (char.IsLetter(str[i]))
                {
                    result.Add(str[i]);
                }
                // 숫자는 따로 더하기
                else
                {
                    value += str[i] - '0';
                }
            }

            // 알파벳을 오름차순으로 정렬
            result.Sort();

            // 알파벳을 차례대로 출력
            for (int i = 0; i < result.Count; i++)
            {
                Console.Write(result[i]);
            }

            // 숫자가 하나라도 존재하는 경우 가장 뒤에 출력
            if (value != 0)
                Console.Write(value);
            Console.WriteLine();
            #endregion
        }
    }
}
