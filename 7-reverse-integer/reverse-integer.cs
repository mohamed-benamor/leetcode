public class Solution {
  public int Reverse(int x) {
    var reverse = 0;

    while (x != 0) {
      if (reverse > int.MaxValue / 10 || reverse < int.MinValue / 10) {
        return 0;
      }

      reverse = reverse * 10 + x % 10;
      x /= 10;
    }

    return reverse;
  }
}