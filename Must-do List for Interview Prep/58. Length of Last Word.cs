// https://leetcode.com/problems/length-of-last-word/?envType=study-plan-v2&envId=top-interview-150

public class Solution {
    public int LengthOfLastWord(string s) {
        int total = s.Length  - 1;

        while (s[total] == ' ') {
            total--;
        }

        int i = total;
        int j = i;

        while (i > 0 && (s[i] == s[j] || s[i] != ' ')) {
            j = i--;
        }

        if(s[i] !=' ')
        {
            total++;
        }
        
        return total - i;
    }
}