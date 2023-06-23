using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 재귀함수
{
    /* 유클리드 호제법을 이용한 최대공약수 구하기
     * 두 자연수 A, B에 대하여 (A>B) A를 B로 나눈 나머지를 R이라고 한다.
     * 이때 A와 B의 최대공약수는 B와 R의 최대공약수와 같다.
     */
    class 재귀함수_유클리드호제법_최대공약수
    {
        public static void Solution()
        {
            int answer = 0;
            
            answer = GCD(192, 162);
            Console.WriteLine(answer);
        }

        public static int GCD(int A, int B)
        {
            if (A % B == 0)
                return B;
            else
                return GCD(B, A % B);
        }
    }
}
