https://leetcode.com/problems/valid-anagram/submissions/1251985894/?envType=study-plan-v2&envId=top-interview-150
public class Solution {
    public bool IsAnagram(string s, string t) {
                if (s.Length != t.Length) return false;

        Dictionary<char, int> counts = new Dictionary<char, int>();
        for (int i = 0; i < s.Length; i++) {
            char sC = s[i];
            char tC = t[i];

            if (counts.ContainsKey(sC))
                counts[sC]++;
            else
                counts[sC] = 1;

            if (counts.ContainsKey(tC))
                counts[tC]--;
            else
                counts[tC] = -1;
        }

        foreach (int count in counts.Values) {
            if (count != 0)
                return false;
        }

        return true;
    }
}
