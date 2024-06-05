https://leetcode.com/problems/happy-number/submissions/1253343539/?envType=study-plan-v2&envId=top-interview-150
public class Solution {
    public bool IsHappy(int n) {
        HashSet<int> dic = new HashSet<int>();
        
        while (n != 1 && !dic.Contains(n)) {
            dic.Add(n);
            n = NextNumber(n);
        }
        
        return n == 1;
    }

    private int NextNumber(int n) {
        int sum = 0;
        while (n > 0) {
            int d = n % 10;
            sum += d * d;
            n /= 10;
        }
        return sum;
    }
}
