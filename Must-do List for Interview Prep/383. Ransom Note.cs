// https://leetcode.com/problems/ransom-note/?envType=study-plan-v2&envId=top-interview-150

public class Solution {
    public bool CanConstruct(string ransomNote, string magazine) {
        Dictionary<char, int> magazineCount = new Dictionary<char, int>();
        
        foreach (char c in magazine) {
            if (magazineCount.ContainsKey(c)) {
                magazineCount[c]++;
            } else {
                magazineCount[c] = 1;
            }
        }
        
        foreach (char c in ransomNote) {
            if (!magazineCount.ContainsKey(c) || magazineCount[c] == 0) {
                return false;
            }
            magazineCount[c]--;
        }
        
        return true;
    }
}
