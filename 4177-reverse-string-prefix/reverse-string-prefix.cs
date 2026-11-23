public class Solution {
  public string ReversePrefix(string s, int k) {
    var left = 0;
    var right = k - 1;

    var chars = s.ToCharArray();

    while (left < right) {
      char tmp = chars[left];
      chars[left] = chars[right];
      chars[right] = tmp;

      left++;
      right--;
    }

    return new String(chars);
  }
}