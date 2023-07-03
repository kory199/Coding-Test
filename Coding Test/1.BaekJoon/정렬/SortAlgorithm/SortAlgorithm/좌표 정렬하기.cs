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
        public static void SolutionList()
        {
            StreamWriter writer = new StreamWriter(Console.OpenStandardOutput());
            StreamReader reader = new StreamReader(Console.OpenStandardInput());

            int n = int.Parse(reader.ReadLine());
            List<(int, int)> list = new List<(int, int)>();
            for (int i = 0; i < n; i++)
            {
                string[] str = reader.ReadLine().Split();
                int x = int.Parse(str[0].ToString());
                int y = int.Parse(str[1].ToString());
                list.Add((x, y));
            }

            // x 좌표로 정렬하고, y좌표로 정렬
            var sortList = list.OrderBy(x => x.Item1).ThenBy(x => x.Item2).ToList();

            //var sortList = (from data in list
            //                orderby data.Item1, data.Item2
            //                select data).ToList();

            for (int i = 0; i < n; i++)
                writer.WriteLine($"{sortList[i].Item1} {sortList[i].Item2}");

            writer.Close();
            reader.Close();
        }

        public static void SolutionTuple()
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
