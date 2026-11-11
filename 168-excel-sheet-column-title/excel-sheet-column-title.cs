public class Solution {
  public string ConvertToTitle(int columnNumber) {
    var stack = new Stack<char>();

    while (columnNumber > 0) {
      var offset = (columnNumber - 1) % 26;
      columnNumber = (columnNumber - 1) / 26;

      stack.Push((char)(offset + 65));
    }

    return String.Join("", stack);
  }
}