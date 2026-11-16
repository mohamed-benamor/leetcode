public class Solution {
  public int[] RecoverOrder(int[] order, int[] friends) {
    var isFriend = new bool[order.Length + 1];
    var solution = new int[friends.Length];

    foreach (var friend in friends) {
      isFriend[friend] = true;
    }

    var index = 0;

    for (var i = 0; i < order.Length; i++) {
      if (isFriend[order[i]]) {
        solution[index] = order[i];
        index++;
      }
    }

    return solution;
  }
}