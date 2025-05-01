namespace SolveLeetCodeTestProject.NeetCode;

[TestClass]
public class BestTimeToBuyAndSellStockTest
{
    [TestMethod]
    public void BestTimeToBuyAndSellStock()
    {
        Assert.AreEqual(MaxProfit([10, 1, 5, 6, 7, 1]), 6);
    }

    // Time complexity: O(n)
    // Space complexity: O(1)
    public int MaxProfit(int[] prices)
    {
        int priceMax = -1;
        int priceMin = 100;
        int profit = 0;
        for (int i = prices.Length - 1; i >= 0; i--)
        {
            if (prices[i] > priceMax)
            {
                priceMax = prices[i];
                priceMin = 100;
            }
            if (prices[i] < priceMin)
            {
                priceMin = prices[i];
                profit = Math.Max(profit, priceMax - priceMin);
            }
        }
        return profit;
    }
}
