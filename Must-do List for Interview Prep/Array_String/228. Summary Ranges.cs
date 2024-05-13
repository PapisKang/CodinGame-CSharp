// https://leetcode.com/problems/summary-ranges/?envType=study-plan-v2&envId=top-interview-150
public class Solution {
    public IList<string> SummaryRanges(int[] nums) {
        List<string> result = new List<string>();
        if (nums.Length == 0) 
        {
            return result;
        }

        int x = nums[0];

        for (int i = 1; i < nums.Length; i++) {
            if (nums[i] != nums[i - 1] + 1) {
                if (x == nums[i - 1]) {
                    result.Add(x.ToString());
                } else {
                    result.Add($"{x}->{nums[i - 1]}");
                }
                x = nums[i];
            }
        }

        if (x == nums[nums.Length - 1]) {
            result.Add(x.ToString());
        } else {
            result.Add($"{x}->{nums[nums.Length - 1]}");
        }

        return result;
    }
}