// https://leetcode.com/problems/longest-ideal-subsequence/description/?envType=daily-question&envId=2024-04-25

public class Solution {
    public int LongestIdealString(string s, int k) {
        int[] dp = new int[26];
        int maxLen = 0;
        
        foreach (char c in s) {
            int current = c - 'a';
            int best = 0;
            
            for (int i = Math.Max(0, current - k); i <= Math.Min(25, current + k); i++) {
                best = Math.Max(best, dp[i]);
            }
            
            dp[current] = best + 1;
            maxLen = Math.Max(maxLen, dp[current]);
        }
        
        return maxLen;
    }
}