public class MyQueue {
  private readonly Stack<int> current = new();
  private readonly Stack<int> queue = new();

  public void Push(int x) {
    current.Push(x);
  }
  
  public int Pop() {
    if (queue.Count == 0) {
      while (current.Count > 0) {
        queue.Push(current.Pop());
      }
    }

    return queue.Pop();
  }
  
  public int Peek() {
    if (queue.Count == 0) {
      while (current.Count > 0) {
        queue.Push(current.Pop());
      }
    }

    return queue.Peek();
  }
  
  public bool Empty() {
    return queue.Count == 0 && current.Count == 0;
  }
}

/**
 * Your MyQueue object will be instantiated and called as such:
 * MyQueue obj = new MyQueue();
 * obj.Push(x);
 * int param_2 = obj.Pop();
 * int param_3 = obj.Peek();
 * bool param_4 = obj.Empty();
 */