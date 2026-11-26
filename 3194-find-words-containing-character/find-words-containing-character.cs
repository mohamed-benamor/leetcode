public class Solution {
  public IList<int> FindWordsContaining(string[] words, char x) {
    var solution = new List<int>();

    for (int i = 0; i < words.Length; i++) {
      if (words[i].Contains(x)) {
        solution.Add(i);
      }
    }

    return solution;
  }
}