using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 기하_직사각형과_삼각형
{
    class _14215세막대
    {
        public static void Solution()
        {
            string[] inputStr = Console.ReadLine().Split(' ');
            List<int> triangle = new List<int>();

            triangle.Add(int.Parse(inputStr[0]));
            triangle.Add(int.Parse(inputStr[1]));
            triangle.Add(int.Parse(inputStr[2]));
            triangle.Sort();

            if (triangle[2] >= triangle[0] + triangle[1])
                triangle[2] = triangle[0] + triangle[1] - 1;

            Console.WriteLine(triangle.Sum());
        }
    }
}
