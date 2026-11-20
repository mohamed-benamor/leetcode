public class Solution {
  public int MirrorDistance(int n) {
    return Math.Abs(n - Reverse(n));
  }

  static int Reverse(int n) {
    var reverse = 0;

    while (n != 0) {
      reverse = (reverse * 10) + (n % 10);
      n /= 10;
    }

    return reverse;
  }
}