using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SortAlgorithm
{
    internal class 나이순_정렬
    {
        public static void Solution()
        {
            int n = int.Parse(Console.ReadLine());
            List<(int, string)> playerInfo = new List<(int, string)>();

            for (int i = 0; i < n; i++)
            {
                string[] inputStr = Console.ReadLine().Split();
                int age = int.Parse(inputStr[0]);
                string name = inputStr[1];

                playerInfo.Add((age, name));
            }

            var answer = playerInfo.OrderBy(x => x.Item1).ToList();

            foreach (var item in answer)
                Console.WriteLine(item.Item1 + " " + item.Item2);
        }

        public static void SolutionSB()
        {
            StringBuilder sb = new StringBuilder();
            int n = int.Parse(Console.ReadLine());
            List<(int, string)> playerInfo = new List<(int, string)>();

            for (int i = 0; i < n; i++)
            {
                string[] inputStr = Console.ReadLine().Split();
                int age = int.Parse(inputStr[0]);
                string name = inputStr[1];

                playerInfo.Add((age, name));
            }

            var answer = playerInfo.OrderBy(x => x.Item1).ToList();

            foreach (var item in answer)
                sb.AppendLine(item.Item1 + " " + item.Item2);

            Console.WriteLine(sb);
        }
    }
}
