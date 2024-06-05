public class Solution {
    public void Rotate(int[] nums, int k) {
        int n = nums.Length;
        Reverse(nums, 0, n - 1);
        Reverse(nums, 0, k % n - 1);
        Reverse(nums, k, n - 1);
    }
    
    private void Reverse(int[] nums, int i, int j) {
        while (i < j) {
            int temp = nums[i];
            nums[i] = nums[j];
            nums[j] = temp;
            i++;
            j--;
        }
    }
}
