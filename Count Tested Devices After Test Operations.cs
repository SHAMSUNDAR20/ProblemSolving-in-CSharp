public class Solution {
    public int CountTestedDevices(int[] batteryPercentages) {
        int testedDevices = 0;
        for (int i = 0; i < batteryPercentages.Length; i++) {
            if (batteryPercentages[i] > 0) {
                testedDevices++;
                for (int j = i + 1; j < batteryPercentages.Length; j++) {
                    batteryPercentages[j] = Math.Max(0, batteryPercentages[j] - 1);
                }
            }
        }
        return testedDevices;
    }
}