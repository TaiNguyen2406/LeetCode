using System;

namespace BestTimeToBuyAndSellStock2
{
    class Program
    {
        static void Main(string[] args)
        {
            var nums = new int[] { 7, 1, 5, 3, 6, 4 };
            var k = MaxProfit(nums);
            Console.WriteLine(k);
            nums = new int[] { 1, 2, 3, 4, 5 };
             k = MaxProfit(nums);
            Console.WriteLine(k);
        }
        public static int MaxProfit(int[] prices)
        {
            int maxprofit = 0;
            for (int i = 1; i < prices.Length; i++)
            {
                if (prices[i] > prices[i - 1])
                    maxprofit += prices[i] - prices[i - 1];
            }
            return maxprofit;
        }


        public static int MaxProfitBruteForce(int[] prices)
        {
            return Calculate(prices, 0);
        }
        
       
        public static int Calculate(int[] prices, int s)
        {
            if (s >= prices.Length)
                return 0;
            int max = 0;
            for (int start = s; start < prices.Length; start++)
            {
                int maxprofit = 0;
                for (int i = start + 1; i < prices.Length; i++)
                {
                    if (prices[start] < prices[i])
                    {
                        int profit = Calculate(prices, i + 1) + prices[i] - prices[start];
                        if (profit > maxprofit)
                            maxprofit = profit;
                    }
                }
                if (maxprofit > max)
                    max = maxprofit;
            }
            return max;
        }
    }
}
