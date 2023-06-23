using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 기하_직사각형과_삼각형
{
    class _9063대지
    {
        public static void Solution()
        {
            int testCase = int.Parse(Console.ReadLine());
            int Answer = 0;
            List<int> dotX = new List<int>();
            List<int> dotY = new List<int>();

            for (int i = 0; i < testCase; i++)
            {
                string[] temp = Console.ReadLine().Split(' ');
                dotX.Add(int.Parse(temp[0]));
                dotY.Add(int.Parse(temp[1]));
            }

            Answer = (dotX.Max() - dotX.Min()) * (dotY.Max() - dotY.Min());
            Console.WriteLine(Answer);
        }
    }
}
