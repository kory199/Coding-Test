using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortAlgorithm
{
    internal class 수_정렬하기2
    {
        public static void Solution()
        {
            int n = int.Parse(Console.ReadLine());
            int[] inputArray = new int[n];
            StringBuilder sb = new StringBuilder();

            for (int i = 0; i < n; i++)
                inputArray[i] = int.Parse(Console.ReadLine());
            
            Array.Sort(inputArray);

            foreach (var studentScore in inputArray)
                sb.AppendLine(studentScore.ToString());

            Console.WriteLine(sb.ToString());
        }
    }
}
