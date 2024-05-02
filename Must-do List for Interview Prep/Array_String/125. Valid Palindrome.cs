// https://leetcode.com/problems/valid-palindrome/description/?envType=study-plan-v2&envId=top-interview-150

public class Solution {
    public bool IsPalindrome(string s) {
        StringBuilder sb = new StringBuilder();
        foreach (char c in s) {
            if (char.IsLetterOrDigit(c)) {
                sb.Append(char.ToLower(c));
            }
        }
        string normalizedString = sb.ToString();
        
        int left = 0;
        int right = normalizedString.Length - 1;
        while (left < right) {
            if (normalizedString[left] != normalizedString[right]) {
                return false;
            }
            left++;
            right--;
        }
        return true;
    }
}