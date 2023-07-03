using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortAlgorithm
{
    internal class 커트라인
    {
        public static void Solution()
        {
            string[] inputInfo = Console.ReadLine().Split();
            string[] score = Console.ReadLine().Split();

            int student = int.Parse(inputInfo[0]);
            int order = int.Parse(inputInfo[1]);
            int[] inputNum = new int[student];

            for (int i = 0; i < score.Length; i++)
                inputNum[i] = int.Parse(score[i]);

            Array.Sort(inputNum);
            Array.Reverse(inputNum);
            Console.WriteLine(inputNum[order-1]);
        }
    }
}
