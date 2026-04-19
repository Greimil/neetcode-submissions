public class Solution {
    public int MaxProfit(int[] prices)
{

    int buyDayL = 0;
    int sellDayR = 1;
    int MaxProfit = 0;


    while (sellDayR < prices.Length)
    {
        if (prices[buyDayL] < prices[sellDayR])
        {
            MaxProfit = Math.Max(MaxProfit, prices[sellDayR] - prices[buyDayL]);
        }
        else
        {
            buyDayL= sellDayR;
            
        }

        sellDayR++;

    }


    return MaxProfit;

}
}
