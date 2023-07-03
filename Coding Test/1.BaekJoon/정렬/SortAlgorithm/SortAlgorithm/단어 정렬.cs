using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortAlgorithm
{
    internal class 단어_정렬
    {
        public static void Solution()
        {
            int n = int.Parse(Console.ReadLine());
            List<string> inputStr = new List<string>();

            for (int i = 0; i < n; i++)
            {
                string inputData = Console.ReadLine();

                if (!inputStr.Contains(inputData))
                    inputStr.Add(inputData);
            }

            inputStr.Sort((x, y) => 
            {
                int lengthComparison = x.Length.CompareTo(y.Length);
                if (lengthComparison == 0)
                    return string.Compare(x, y, StringComparison.Ordinal); // 문자열 자체를 오름차순으로 정렬
                else
                    return lengthComparison;
            });

            foreach (var item in inputStr)
                Console.WriteLine(item);
        }
    }
}
