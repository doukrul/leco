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
        ListNode pre=res;
        while(head!=null&&head.next!=null){
            if(head.val==head.next.val){
                while(head.next!=null&&head.val==head.next.val){
                    head=head.next;
                }
                pre.next=head.next;
            }else{
                pre=pre.next;
            }
            head=head.next;
        }
        return res.next;
    }
}