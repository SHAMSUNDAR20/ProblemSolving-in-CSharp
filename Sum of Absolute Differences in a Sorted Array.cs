public class Solution {
    public int[] GetSumAbsoluteDifferences(int[] nums) {
        int n = nums.Length;
        int[] result = new int[n];
        int totalSum = 0, prefixSum = 0;
        
        for (int i = 0; i < n; i++) {
            totalSum += nums[i];
        }
        
        for (int i = 0; i < n; i++) {
            result[i] = nums[i] * i - prefixSum + totalSum - prefixSum - nums[i] * (n - i);
            prefixSum += nums[i];
        }
        
        return result;
    }
}