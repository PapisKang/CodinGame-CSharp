https://leetcode.com/problems/contains-duplicate-ii/submissions/1254363524/?envType=study-plan-v2&envId=top-interview-150
public class Solution {
    public bool ContainsNearbyDuplicate(int[] nums, int k) {
        Dictionary<int, int> dicIndex = new Dictionary<int, int>();
        
        for (int i = 0; i < nums.Length; i++) {
            if (dicIndex.ContainsKey(nums[i]) && i - dicIndex[nums[i]] <= k) {
                return true;
            }
            dicIndex[nums[i]] = i;
        }
        
        return false; 
    }
}
