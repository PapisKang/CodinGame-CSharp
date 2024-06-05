https://leetcode.com/problems/two-sum/description/?envType=study-plan-v2&envId=top-interview-150

public class Solution {
    public int[] TwoSum(int[] nums, int target) {
        Dictionary<int, int> numDict = new Dictionary<int, int>();
        for (int i = 0; i < nums.Length; i++) {
            int complement = target - nums[i];
            if (numDict.ContainsKey(complement)) {
                return new int[] { numDict[complement], i };
            }
            if (!numDict.ContainsKey(nums[i])) {
                numDict[nums[i]] = i;
            }
        }
        return null;
    }
}
