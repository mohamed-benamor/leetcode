public class Solution {
  public int MySqrt(int x) {
    uint start = 0;
    uint end = 65636; // sqrt(2^32)

    while (start < end) {
      var mid = start + (end - start) / 2;

      if (mid * mid <= x && x < (mid + 1) * (mid + 1)) {
        return (int)mid;
      } else if (mid * mid > x) {
        end = mid - 1;
      } else {
        start = mid + 1;
      }
    }

    return (int)start;
  }
}