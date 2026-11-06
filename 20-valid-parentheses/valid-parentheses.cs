public class Solution {
  public bool IsValid(string s) {
    if (s.Length % 2 == 1) {
      return false;
    }

    if (s[0] == ')' || s[0] == ']' || s[0] == '}') {
      return false;
    }

    var stack = new Stack<int>();

    foreach (var c in s) {
      if (c == '(' || c == '[' || c == '{') {
        stack.Push(c);
      } else {
        if (stack.Count == 0) {
          return false;
        }

        if (c == ')' && stack.Peek() != '(') {
          return false;
        } else if (c == ']' && stack.Peek() != '[') {
          return false;
        } else if (c == '}' && stack.Peek() != '{') {
          return false;
        }
        stack.Pop();
      }
    }

    return stack.Count == 0;
  }
}