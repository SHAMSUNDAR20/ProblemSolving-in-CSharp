public class Solution {
    public bool IsSubsequence(string s, string t) {
        int indexS = 0, indexT = 0;
        while (indexS < s.Length && indexT < t.Length) {
            if (s[indexS] == t[indexT]) {
                indexS++;
            }
            indexT++;
        }
        return indexS == s.Length;
    }
}