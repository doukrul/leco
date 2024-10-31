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
  public class ListNode2 {
      public int val;
      public ListNode next;
      public ListNode2(int x) {
          val = x;
          next = null;
      }
  }

public class SolutionP141test3
{
    public bool HasCycle(ListNode head)
    {
        if(head==null){
            return false;
        }
        ListNode slow=head;
        ListNode fast=head;
        while(fast.next!=null&&fast.next.next!=null){
            slow=slow.next;
            fast=fast.next.next;
            if(slow==fast){
                return true;
            }
        }
        return false;
    }
}