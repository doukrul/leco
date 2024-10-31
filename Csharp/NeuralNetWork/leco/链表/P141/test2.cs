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
  public class ListNode1 {
      public int val;
      public ListNode next;
      public ListNode1(int x) {
          val = x;
          next = null;
      }
  }

public class SolutionP141test2
{
    public bool HasCycle(ListNode head)
    {

        var list = new HashSet<ListNode>();
        
        while (head.next != null)
        {
            if (list.Contains(head))
            {
                return true;
            }else{
                list.Add(head);
                head = head.next;
            }
        }
        return false;
    }
}