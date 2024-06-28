https://leetcode.com/problems/first-unique-character-in-a-string/?envType=daily-question&envId=2024-06-28
public class Solution {
    public int FirstUniqChar(string s) {
        if(s.Length == 1)
        {
            return 0;
        }

        Dictionary<char, int> stringCh = new Dictionary<char, int>();

        foreach (char c in s) {
            if (stringCh.ContainsKey(c)) {
                stringCh[c]++;
            } else {
                stringCh[c] = 1;
            }
        }

        for (int i = 0; i < s.Length; i++) {
            if (stringCh[s[i]] == 1) {
                return i;
            }
        }

        return -1;
    }
}
