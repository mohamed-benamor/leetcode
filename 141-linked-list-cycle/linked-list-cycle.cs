/**
 * Definition for singly-linked list.
 * public class ListNode {
 *     public int val;
 *     public ListNode next;
 *     public ListNode(int x) {
 *         val = x;
 *         next = null;
 *     }
 * }
 */
public class Solution {
  public bool HasCycle(ListNode head) {
    var nodes = new HashSet<ListNode>();
    var current = head;

    while (current != null) {
      if (!nodes.Add(current)) {
        return true;
      }

      current = current.next;
    }

    return false;
  }
}