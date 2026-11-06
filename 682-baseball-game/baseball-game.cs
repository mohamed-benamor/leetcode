public class Solution {
    public int CalPoints(string[] operations) {
        var stack = new Stack<int>();
        
        foreach (var operation in operations) {
          switch (operation) {
          case "C":
            stack.Pop();
            break;

          case "D":
            stack.Push(stack.Peek() * 2);
            break;

          case "+":
            var a = stack.Pop();
            var b = stack.Pop();

            stack.Push(b);
            stack.Push(a);
            stack.Push(a + b);
            break;
          
          default:
            stack.Push(int.Parse(operation));
            break;
          }
        }

        return stack.Sum();
    }
}