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
public class SolutionP19test1 {
    public ListNode RemoveNthFromEnd(ListNode head, int n) {
        ListNode res=new ListNode(0);
        res.next=head;
        ListNode cur=res;
        
        int count=0;
        while(cur!=null){
            count++;
            cur=cur.next;
        }
        int length=count-n+1;
        cur=res;
        for(int i=0;i<length-2;i++){
            cur=cur.next;
        }
        if(cur.next!=null){
            if(cur.next.next!=null){
                cur.next=cur.next.next;
            }else{
                cur.next=null;
            }
        }
        
        return res.next;
    }
}