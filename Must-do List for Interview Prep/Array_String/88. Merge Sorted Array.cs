// https://leetcode.com/problems/merge-sorted-array/?envType=study-plan-v2&envId=top-interview-150 

public class Solution {
    public void Merge(int[] nums1, int m, int[] nums2, int n) {
        int ptr1 = m - 1;
        int ptr2 = n - 1;
        int mergedPtr = m + n - 1;
        
        while (ptr1 >= 0 && ptr2 >= 0) {
            if (nums1[ptr1] > nums2[ptr2]) {
                nums1[mergedPtr] = nums1[ptr1];
                ptr1--;
            } else {
                nums1[mergedPtr] = nums2[ptr2];
                ptr2--;
            }
            mergedPtr--;
        }
        
        while (ptr2 >= 0) {
            nums1[mergedPtr] = nums2[ptr2];
            ptr2--;
            mergedPtr--;
        }
    }
}