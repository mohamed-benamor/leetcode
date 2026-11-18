public class Solution {
  public int LengthOfLongestSubstring(string s) {
    var set = new HashSet<char>();

    var max = 0;
    var i = 0;
    var j = 0;

    while (i < s.Length && j < s.Length) {
      if (!set.Add(s[j])) {
        max = Math.Max(max, set.Count);
        set = new();
        i++;
        j = i;
        set.Add(s[j]);
      }

      j++;
    }

    return Math.Max(max, set.Count);
  }
}