// https://leetcode.com/problems/single-number-iii/description/?envType=daily-question&envId=2024-05-31

public class Solution {
    public int[] SingleNumber(int[] nums) {
        int xor = 0;
        foreach (int num in nums) {
            xor ^= num;
        }
        
        int bi = xor & (-xor);
        
        int num1 = 0, num2 = 0;
        foreach (int num in nums) {
            if ((num & bi) == 0) {
                num1 ^= num;
            } else {
                num2 ^= num;
            }
        }
        
        return new int[] { num1, num2 };
    }
}
