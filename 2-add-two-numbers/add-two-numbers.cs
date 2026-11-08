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
  public ListNode AddTwoNumbers(ListNode l1, ListNode l2) {
    var list = new ListNode(0);
    var current = list;

    while (l1 != null || l2 != null) {
      var x = 0;
      var y = 0;
      
      if (l1 != null) {
        x = l1.val;
        l1 = l1.next;
      }
      if (l2 != null) {
        y = l2.val;
        l2 = l2.next;
      }

      current.val += x + y;

      if (l1 != null || l2 != null) {
        current.next = new ListNode(current.val / 10);
        current.val = current.val % 10;
        current = current.next;
      }
    }

    if (current.val / 10 == 1) {
      current.next = new ListNode(current.val / 10);
      current.val = current.val % 10;
    }

    return list;
  }
}