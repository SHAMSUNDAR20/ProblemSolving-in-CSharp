public class Solution {
    public int[] Intersect(int[] nums1, int[] nums2) {
        Dictionary<int, int> count1 = new Dictionary<int, int>();
        Dictionary<int, int> count2 = new Dictionary<int, int>();
        foreach (int num in nums1) {
            if (count1.ContainsKey(num)) {
                count1[num]++;
            } else {
                count1[num] = 1;
            }
        }
        foreach (int num in nums2) {
            if (count2.ContainsKey(num)) {
                count2[num]++;
            } else {
                count2[num] = 1;
            }
        }
        List<int> intersection = new List<int>();
        foreach (KeyValuePair<int, int> entry in count1) {
            if (count2.ContainsKey(entry.Key)) {
                for (int i = 0; i < Math.Min(entry.Value, count2[entry.Key]); i++) {
                    intersection.Add(entry.Key);
                }
            }
        }
        return intersection.ToArray();
    }
}