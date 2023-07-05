using System;
using System.Collections.Generic;
using System.Text;

namespace 집합과_맵
{
    internal class 나는야_포켓몬_마스터_이다솜
    {
        #region 단일 Dictionary 및 KeyValuePair 사용 (시간 초과)
        public static void Solution()
        {
            Dictionary<string, int> poketBook = new Dictionary<string, int>();

            int[] inputStr = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
            int poketmonList = inputStr[0];
            int searchNum = inputStr[1];
            string[] searchList = new string[searchNum];

            StringBuilder sb = new StringBuilder();

            // 몬스터 정보 및 번호 입력
            for (int i = 1; i <= poketmonList; i++)
            {
                string poketmon = Console.ReadLine();
                poketBook.Add(poketmon, i);
            }

            for (int i = 0; i < searchNum; i++)
                searchList[i] = Console.ReadLine();

            for (int i = 0; i < searchNum; i++)
            {
                if (char.IsLetter(searchList[i][0]))
                    sb.AppendLine(poketBook[searchList[i]].ToString());
                else
                {
                    foreach (KeyValuePair<string, int> pair in poketBook)
                    {
                        if (pair.Value == int.Parse(searchList[i]))
                            sb.AppendLine(pair.Key);
                    }
                }
            }
            Console.WriteLine(sb);
        }
        #endregion

        #region Dictionary 2개 사용
        public static void SolutionDic()
        {
            int[] testCase = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
            int poketmonNumber = testCase[0];
            int searchNumberCount = testCase[1];

            Dictionary<string, int> poketmonList1 = new Dictionary<string, int>();
            Dictionary<int, string> poketmonList2 = new Dictionary<int, string>();

            StringBuilder sb = new StringBuilder();

            for (int i = 1; i <= poketmonNumber; i++)
            {
                string poketName = Console.ReadLine();

                poketmonList1.Add(poketName, i);
                poketmonList2.Add(i, poketName);
            }

            for (int i = 0; i < searchNumberCount; i++)
            {
                string searchName = Console.ReadLine();

                if (Char.IsLetter(searchName[0]))
                    sb.AppendLine(poketmonList1[searchName].ToString());
                else
                    sb.AppendLine(poketmonList2[int.Parse(searchName)]);
            }
            Console.WriteLine(sb);
        }
        #endregion
    }
}
