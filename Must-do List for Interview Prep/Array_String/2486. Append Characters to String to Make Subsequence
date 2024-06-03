// https://leetcode.com/problems/append-characters-to-string-to-make-subsequence/?envType=daily-question&envId=2024-06-03

public class Solution {
    public int AppendCharacters(string s, string t) {
         int i = 0, j = 0;

        while (i < s.Length && j < t.Length) {
            if (s[i] == t[j]) {
                j++;
            }
            i++;
        }
        
        return t.Length - j;
    }
}
