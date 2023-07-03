using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace SortAlgorithm
{
    internal class 좌표_정렬하기
    {
        public static void Solution()
        {
            int testNum = int.Parse(Console.ReadLine());

            ValueTuple<int, int>[] position = new ValueTuple<int, int>[testNum];
            StreamWriter SW = new StreamWriter(Console.OpenStandardOutput());

            for (int i = 0; i < testNum; i++)
            {
                string[] inputTsetCase = Console.ReadLine().Split();

                position[i] = (int.Parse(inputTsetCase[0]), int.Parse(inputTsetCase[1]));
            }

            Array.Sort(position);

            for (int i = 0; i < testNum; i++)
                SW.WriteLine(position[i].Item1 + " " + position[i].Item2);
            SW.Close();
        }
    }
}
