public class Solution {
    public IList<string> ReadBinaryWatch(int turnedOn) {
        IList<string> times = new List<string>();
        for (int h = 0; h < 12; h++)
            for (int m = 0; m < 60; m++)
                if (BitCount(h) + BitCount(m) == turnedOn)
                    times.Add(string.Format("{0}:{1:D2}", h, m));
        return times;
    }

    private int BitCount(int x) {
        int count;
        for (count = 0; x > 0; count++)
            x &= x - 1; // clear the least significant bit set
        return count;
    }
}