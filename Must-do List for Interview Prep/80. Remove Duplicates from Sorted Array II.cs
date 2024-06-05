//https://leetcode.com/problems/remove-duplicates-from-sorted-array-ii/?envType=study-plan-v2&envId=top-interview-150
public class Solution {
    public int RemoveDuplicates(int[] nums) {
          if (nums.Length <= 2) return nums.Length;
        
        int i = 2; 
        for (int j = 2; j < nums.Length; j++) {
            if (nums[j] != nums[i - 2]) {
                nums[i] = nums[j];
                i++;
            }
        }
        
        return i;
    }
}
