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
  public ListNode MergeTwoLists(ListNode list1, ListNode list2) {
    if (list1 is null) {
      return list2;
    }

    if (list2 is null) {
      return list1;
    }
    
    ListNode list;

    var current1 = list1;
    var current2 = list2;

    if (current1.val <= current2.val) {
      list = current1;
      current1 = current1.next;
    } else {
      list = current2;
      current2 = current2.next;
    }

    var current = list;

    while (current1 != null && current2 != null) {
      if (current1.val <= current2.val) {
        current.next = current1;
        current1 = current1.next;
      } else {
        current.next = current2;
        current2 = current2.next;
      }
      current = current.next;
      current.next = null;
    }

    while (current1 != null) {
      current.next = current1;
      current1 = current1.next;
      current = current.next;
      current.next = null;
    }
    
    while (current2 != null) {
      current.next = current2;
      current2 = current2.next;
      current = current.next;
      current.next = null;
    }

    return list;
  }
}