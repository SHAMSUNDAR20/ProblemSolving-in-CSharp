public class Solution {
    public string ReverseVowels(string s) {
        char[] chars = s.ToCharArray();
        int left = 0, right = s.Length - 1;
        while (left < right) {
            if ("aeiouAEIOU".IndexOf(chars[left]) != -1 && "aeiouAEIOU".IndexOf(chars[right]) != -1) {
                char temp = chars[left];
                chars[left] = chars[right];
                chars[right] = temp;
                left++;
                right--;
            } else if ("aeiouAEIOU".IndexOf(chars[left]) != -1) {
                right--;
            } else {
                left++;
            }
        }
        return new string(chars);
    }
}