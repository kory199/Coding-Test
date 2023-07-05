using System;
using System.Collections.Generic;

namespace 집합과_맵
{
    internal class 대칭_차집합
    {
        public static void Solution()
        {
            int[] inputNum = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
            int groupATest = inputNum[0];
            int groupBTest = inputNum[1];
            int count = 0;
            int[] inputNumA = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
            int[] inputNumB = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
            Dictionary<int, bool> groupA = new Dictionary<int, bool>();
            Dictionary<int, bool> groupB = new Dictionary<int, bool>();

            for (int i = 0; i < groupATest; i++)
                groupA.Add(inputNumA[i], false);

            for (int i = 0; i < groupBTest; i++)
                groupB.Add(inputNumB[i], false);

            foreach (var item in groupB)
            {
                if (groupA.ContainsKey(item.Key))
                    groupA[item.Key] = true;
            }

            foreach (var item in groupA)
            {
                if (groupB.ContainsKey(item.Key))
                    groupB[item.Key] = true;
            }

            foreach (var item in groupA)
            {
                if (item.Value == false)
                    count++;
            }
            foreach (var item in groupB)
            {
                if (item.Value == false)
                    count++;
            }

            Console.WriteLine(count);
        }
    }
}
