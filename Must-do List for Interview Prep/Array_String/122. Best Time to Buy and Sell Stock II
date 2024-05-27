// https://leetcode.com/problems/best-time-to-buy-and-sell-stock-ii/submissions/1269790616/?envType=study-plan-v2&envId=top-interview-150
public class Solution {
    public int MaxProfit(int[] prices) {
        int maxProfit = 0;
        for (int i = 1; i < prices.Length; i++) {
            if (prices[i] > prices[i - 1]) {
                maxProfit += prices[i] - prices[i - 1];
            }
        }
        return maxProfit;
    }
}
