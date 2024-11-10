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
public class SolutionP25test1 {
    public ListNode ReverseKGroup(ListNode head, int k) {
        if(k==1){
            return head;
        }
        ListNode res=new ListNode(0);
        ListNode cur=head;
        int count=0;
        while(cur!=null){
            count++;
            cur=cur.next;
        }
        if(count<2){
            return head;
        }
        int n=count/k;
        if(n<1){
            return head;
        }

        ListNode pre=new ListNode(0);
        pre.next=head;
        ListNode start=pre.next;
        ListNode then=start.next;
        for(int i=0;i<n;i++){
            for(int j=0;j<k-1;j++){
                start.next=then.next;
                then.next=pre.next;
                pre.next=then;
                then=start.next;
            }
            if(i==0){
                res.next=pre.next;
            }
            pre=start;
            start=pre.next;
            if(start!=null){
                then=start.next;
            }
            
        }
        return res.next;
    }
}