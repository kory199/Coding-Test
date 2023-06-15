using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 브루트포스
{
    class 수학은비대면강의입니다
    {
        // 브루트 포스 방식

        // 브루트 포스 
        // 컴퓨터 과학에서 생성 및 테스트라고도 하는 무차별 대입 검색 또는 철저한 검색은
        // 매우 일반적인 문제 해결 기술이자 각 후보가 문제 진술을 만족하는지 여부에 대해
        // 가능한 모든 후보를 체계적으로 확인하는 알고리즘
        public static void Solution()
        {
            string[] inputStr = Console.ReadLine().Split(' ');
            int a = int.Parse(inputStr[0]);
            int b = int.Parse(inputStr[1]);
            int c = int.Parse(inputStr[2]);
            int d = int.Parse(inputStr[3]);
            int e = int.Parse(inputStr[4]);
            int f = int.Parse(inputStr[5]);

            for (int x = -999; x <= 999; x++)
            {
                for (int y = -999; y <= 999; y++)
                {
                    if (a*x + b*y == c && d*x+e*y == f)
                    {
                        Console.WriteLine(x + " " + y);
                    }
                }
            }
        }
    }
}
