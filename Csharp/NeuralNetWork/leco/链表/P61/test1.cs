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
public class SolutionP61test1 {
    public ListNode RotateRight(ListNode head, int k) {
        if(head==null||head.next==null){
            return head;
        }
        ListNode res=new ListNode(0);
        res.next=head;
        ListNode cur=head;
        int len=0;
        while(cur!=null){
            len++;
            cur=cur.next;
        }
        cur=res;
        k=k%len;
        if(k==0){
            return head;
        }
        for(int i=0;i<len-k;i++){
            cur=cur.next;
        }
        ListNode end=cur;
        cur=cur.next;
        res.next=cur;
        while(cur.next!=null){
            cur=cur.next;
        }
        cur.next=head;
        end.next=null;
        return res.next;
    }
}