// Approach 1: Greedy + Prefix Suffix Array LeetCode

public class Solution
{
    public long MaximumTripletValue(int[] nums)
    {
        int n = nums.Length;
        int[] leftMax = new int[n];
        int[] rightMax = new int[n];
        for (int i = 1; i < n; i++)
        {
            leftMax[i] = Math.Max(leftMax[i - 1], nums[i - 1]);
            rightMax[n - 1 - i] = Math.Max(rightMax[n - i], nums[n - i]);
        }
        long res = 0;
        for (int j = 1; j < n - 1; j++)
        {
            res = Math.Max(res, (long)(leftMax[j] - nums[j]) * rightMax[j]);
        }
        return res;
    }
}
