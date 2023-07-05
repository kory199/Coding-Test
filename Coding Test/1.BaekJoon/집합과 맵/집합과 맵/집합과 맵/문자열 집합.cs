using System;
using System.Collections.Generic;

namespace 집합과_맵
{
    internal class 문자열_집합
    {
        #region List
        public static void Solution()
        {
            string[] inputTest = Console.ReadLine().Split();
            int n = int.Parse(inputTest[0]);
            int m = int.Parse(inputTest[1]);

            List<string> inputN = new List<string>();
            List<string> inputM = new List<string>();

            int count = 0;

            for (int i = 0; i < n; i++)
                inputN.Add(Console.ReadLine());
            for (int i = 0; i < m; i++)
                inputM.Add(Console.ReadLine());
            for (int i = 0; i < m; i++)
                if (inputN.Contains(inputM[i]))
                    count++;

            Console.WriteLine(count);
        }
        #endregion

        #region HashSet
        public static void SolutionHashSet()
        {
            int[] inputTest = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
            int n = inputTest[0];
            int m = inputTest[1];
            int count = 0;

            string[] inputN = new string[n];
            HashSet<string> transStr = new HashSet<string>();

            for (int i = 0; i < n; i++)
                inputN[i] = Console.ReadLine();

            foreach (var item in inputN)
                transStr.Add(item);

            for (int i = 0; i < m; i++)
            {
                string temp = Console.ReadLine();
                if (transStr.Contains(temp))
                    count++;
            }
            Console.WriteLine(count);
        }
        #endregion
    }
}
