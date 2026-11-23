public class Solution {
  public int FindClosest(int x, int y, int z) {
    if (Math.Abs(z - x) > Math.Abs(z - y)) {
      return 2;
    }
    if (Math.Abs(z - x) < Math.Abs(z - y)) {
      return 1;
    }
    return 0;
  }
}