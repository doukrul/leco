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
public class SolutionP82test1 {
    public ListNode DeleteDuplicates(ListNode head) {
        ListNode res=new ListNode(0);
        res.next=head;
        ListNode cur=head;
        ListNode com=head;
        while(cur.next!=null){
            if(cur.next!=cur){
                break;
            }
            cur=cur.next;
        }
        cur=cur.next;
        res.next=cur;
        while(cur!=null){
            if(cur!=com){
                com=cur;
            }
            cur=cur.next;
        }
        return res.next;
    }
}