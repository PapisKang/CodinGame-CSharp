// https://leetcode.com/problems/jump-game/?envType=study-plan-v2&envId=top-interview-150
public class Solution {
    public bool CanJump(int[] nums) {
        int n = nums.Length;
        int f = 0;
        
        for (int i = 0; i < n; i++) {
            if (i > f) {
                return false;
            }
            f = Math.Max(f, i + nums[i]);
            if (f >= n - 1) {
                return true;
            }
        }
        
        return false;
    }
}
