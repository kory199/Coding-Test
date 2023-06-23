using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 재귀함수
{
    class 재귀함수_팩토리얼
    {
       public static void Solution()
        {
            int num = 5;

            Console.WriteLine(Factorial(num));
        }

        public static int Factorial(int n)
        {
            if (n == 1)
                return 1;
            return n*Factorial(n - 1);
        }
    }
}
