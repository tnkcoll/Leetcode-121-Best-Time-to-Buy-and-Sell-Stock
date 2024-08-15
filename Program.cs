namespace Leetcode__121_Best_Time_to_Buy_and_Sell_Stock
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] prices = { 2, 4, 1 , 7, 1, 8 };
            Console.WriteLine(MaxProfit(prices));
        }

        public static int MaxProfit(int[] prices)
        {
            int i;
            int j;
            int buyPrice = 10001;
            int profit = 0;
            int maxProfit = 0;

            for (i = 0; i < prices.Length; i++)
            {
                if (prices[i] < buyPrice)
                {
                    buyPrice = prices[i];
                    for (j = i + 1; j < prices.Length; j++)
                    {
                        if (prices[j] > buyPrice)
                        {
                            profit = prices[j] - prices[i];
                            
                            if (profit > maxProfit)
                                maxProfit = profit;
                        }
                    }
                }
            }

            return maxProfit;

        }
    }
}
