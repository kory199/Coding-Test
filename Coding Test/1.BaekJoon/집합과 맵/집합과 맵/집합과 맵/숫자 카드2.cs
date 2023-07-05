using System;
using System.Collections.Generic;
using System.Text;

namespace 집합과_맵
{
    internal class 숫자_카드2
    {
        public static void Solution()
        {
            int testCard = int.Parse(Console.ReadLine());
            int[] cardList = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
            int findCard = int.Parse(Console.ReadLine());
            int[] findCardList = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);

            Dictionary<int, int> cardInfo = new Dictionary<int, int>();
            StringBuilder sb = new StringBuilder();

            for (int i = 0; i < testCard; i++)
            {
                if (cardInfo.ContainsKey(cardList[i]))
                    cardInfo[cardList[i]]++;
                else
                    cardInfo.Add(cardList[i], 1);
            }

            for (int i = 0; i < findCard; i++)
            {
                if (cardInfo.ContainsKey(findCardList[i]))
                    sb.Append(cardInfo[findCardList[i]] + " ");
                else
                    sb.Append(0 + " ");
            }
            Console.WriteLine(sb);
        }
    }
}
