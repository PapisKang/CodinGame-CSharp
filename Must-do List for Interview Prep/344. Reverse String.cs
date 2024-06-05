// https://leetcode.com/problems/reverse-string/description/?envType=daily-question&envId=2024-06-02

public class Solution {
    public void ReverseString(char[] s) {
        int left = 0;
        int right = s.Length - 1;
        
        while (left < right) {
            char temp = s[left];
            s[left] = s[right];
            s[right] = temp;
            
            left++;
            right--;
        }
    }
}
