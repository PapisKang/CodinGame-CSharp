// https://leetcode.com/problems/is-subsequence/?envType=study-plan-v2&envId=top-interview-150
public class Solution {
    public bool IsSubsequence(string s, string t) {
        int i = 0, j = 0;
        while (j < t.Length) {
            if (i < s.Length && s[i] == t[j]) {
                i++;
            }
            j++;
        }
        return i == s.Length;
    }
}