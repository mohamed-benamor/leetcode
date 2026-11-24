public class Solution {
  public IList<IList<string>> GroupAnagrams(string[] strs) {
    var anagrams = new Dictionary<string, IList<string>>();

    foreach (var str in strs) {
      var chars = new char[26];

      foreach (var c in str) {
        chars[c - 'a']++;
      }

      var key = new string(chars);

      if (!anagrams.ContainsKey(key)) {
        anagrams[key] = new List<string>();
      }

      anagrams[key].Add(str);
    }

    return anagrams.Values.ToList();
  }
}