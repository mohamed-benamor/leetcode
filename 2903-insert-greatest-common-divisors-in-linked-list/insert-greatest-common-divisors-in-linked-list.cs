/**
 * Definition for singly-linked list.
 * public class ListNode {
 *     public int val;
 *     public ListNode next;
 *     public ListNode(int val=0, ListNode next=null) {
 *         this.val = val;
 *         this.next = next;
 *     }
 * }
 */
public class Solution {
  public ListNode InsertGreatestCommonDivisors(ListNode head) {
    var current = head;

    while (current != null && current.next != null) {
      var node = new ListNode(GCD(current.val, current.next.val), current.next);

      current.next = node;
      current = node.next;
    }

    return head;
  }

  private int GCD(int a, int b) {
    return b == 0 ? a : GCD(b, a % b);
  }
}