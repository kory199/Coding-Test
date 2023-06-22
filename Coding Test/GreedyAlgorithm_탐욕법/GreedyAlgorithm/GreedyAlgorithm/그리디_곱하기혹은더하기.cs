using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GreedyAlgorithm
{
    /* 곱하기 혹은 더하기
     * 각 자리가 숫자(0~9)로만 이루어진 문자열 S가 주어졌을 때, 왼쪽부터 오른쪽으로 하나씩
     * 숫자를 확인하며 숫자 사이에 X혹은 +연산자를 넣어 결과적으로 만들어질 수 있는 가장 
     * 큰 수를 구하는 프로그램을 작성하세요. 단, +보다 X를 먼저 계산하는 일반적인 방식과는 달리,
     * 모든 연산은 왼쪽에서부터 순서대로 이루어진다고 가정합니다.
     * 예를 드렁 02984라는 문자열을 만들 수 있는 가장 큰수는 576입니다.
     * 또한 만들어질 수 있는 가장 큰 수는 항상 20억 이하의 정수가 되도록 입력이 주어집니다.
    */
    class 그리디_곱하기혹은더하기
    {
        public static void Solution()
        {
            string inputStr = Console.ReadLine();
            int temp = int.Parse(inputStr[0].ToString()); ;
            int answer = 0;

            for (int i = 0; i < inputStr.Length - 1; i++)
            {
                int transNum = int.Parse(inputStr[i + 1].ToString());

                if (temp == 0 || temp == 1 || transNum == 0 || transNum == 1)
                    temp += transNum;
                else
                    temp *= transNum;
            }
            Console.WriteLine(temp);
        }
    }
}
