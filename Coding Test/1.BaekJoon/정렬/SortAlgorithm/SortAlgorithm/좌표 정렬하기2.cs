using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace SortAlgorithm
{
    internal class 좌표_정렬하기2
    {
        public static void Solution()
        {
            StringBuilder sb = new StringBuilder();

            int n = int.Parse(Console.ReadLine());
            List<ValueTuple<int, int>> position = new List<ValueTuple<int, int>>();

            for (int i = 0; i < n; i++)
            {
                string[] inputStr = Console.ReadLine().Split();
                int positionX = int.Parse(inputStr[0]);
                int positionY = int.Parse(inputStr[1]);
                position.Add((positionX,positionY));
            }

            // y 좌표 기준정렬 이후 x좌표 기준정렬
            var aa =  position.OrderBy(x => x.Item2).ThenBy(x => x.Item1).ToList();

            foreach (var item in aa)
                sb.AppendLine(item.Item1.ToString() + " " + item.Item2.ToString());

            Console.WriteLine(sb);
        }
    }
}
