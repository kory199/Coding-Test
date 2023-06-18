using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 기하_직사각형과_삼각형
{
    class _1085직사각형에서탈출
    {
        public static void Solution()
        {
            string[] inputStr = Console.ReadLine().Split(' ');
            List<int> distance = new List<int>();

            int x = int.Parse(inputStr[0]);
            int y = int.Parse(inputStr[1]);
            int w = int.Parse(inputStr[2]);
            int h = int.Parse(inputStr[3]);

            distance.Add(Math.Abs(x-0));
            distance.Add(Math.Abs(y-0));
            distance.Add(Math.Abs(x-w));
            distance.Add(Math.Abs(y-h));

            Console.WriteLine(distance.Min()); 
        }
    }
}
