// https://leetcode.com/problems/majority-element/?envType=study-plan-v2&envId=top-interview-150
// Boyer–Moore majority vote algorithm 

public class Solution {
    public int MajorityElement(int[] nums) {
        int number = 0;
        int count = 0;
        
        foreach (int num in nums) {
            if (count == 0) {
                number = num;
            }
            if (num == number) {
                count++;
            } else {
                count--;
            }
        }
        
        return number;
    }
}