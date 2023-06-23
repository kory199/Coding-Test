using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 브루트포스
{
    // 연립방정식
    class 수학은비대면강의입니다2
    {
        public static void Solution()
        {
            string[] inputStr = Console.ReadLine().Split(' ');
            int a = int.Parse(inputStr[0]);
            int b = int.Parse(inputStr[1]);
            int c = int.Parse(inputStr[2]);
            int d = int.Parse(inputStr[3]);
            int e = int.Parse(inputStr[4]);
            int f = int.Parse(inputStr[5]);

            int x = (b * f - e * c) / (b * d - a * e);
            int y = (a * f - c * d) / (a * e - b * d);
            Console.WriteLine(x + " " + y);
        }
    }
}
