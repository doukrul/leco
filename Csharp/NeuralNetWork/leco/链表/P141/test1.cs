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


public class SolutionP141test1
{
    public bool HasCycle(ListNode head)
    {
        if(head==null){
            return false;
        }
        var nownode = head;
        var list = new List<ListNode>();
        
        while (nownode.next != null)
        {
            if (list.Contains(nownode))
            {
                return true;
            }else{
                list.Add(nownode);
                nownode = nownode.next;
            }
        }
        return false;
    }
}