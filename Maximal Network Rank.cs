public class Solution {
    public int MaximalNetworkRank(int n, int[][] roads) {
        bool[,] connected = new bool[n, n];
        int[] count = new int[n];
        foreach (var road in roads) {
            count[road[0]]++;
            count[road[1]]++;
            connected[road[0], road[1]] = connected[road[1], road[0]] = true;
        }
        int maxRank = 0;
        for (int i = 0; i < n; i++) {
            for (int j = i + 1; j < n; j++) {
                int rank = count[i] + count[j] - (connected[i, j] ? 1 : 0);
                maxRank = Math.Max(maxRank, rank);
            }
        }
        return maxRank;
    }
}