/** 
 * Forward declaration of guess API.
 * @param  num   your guess
 * @return 	     -1 if num is higher than the picked number
 *			      1 if num is lower than the picked number
 *               otherwise return 0
 * int guess(int num);
 */

public class Solution : GuessGame {
  public int GuessNumber(int n) {
    if (guess(n) == 0) {
      return n;
    }

    var start = 0;
    var end = n;

    while (start <= end) {
      var mid = start + (end - start) / 2;

      var guessing = guess(mid);

      if (guessing == 0) {
        return mid;
      } else if (guessing == 1) {
        start = mid + 1;
      } else {
        end = mid - 1;
      }
    }

    return start;
  }
}