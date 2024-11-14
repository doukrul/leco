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
public class SolutionP86test1 {
    public ListNode Partition(ListNode head, int x) {
        ListNode res=new ListNode(-201);
        res.next=head;
        ListNode cur=res;
        while(cur.next!=null){
            if(cur.next.val>=x){
                break;
            }
            cur=cur.next;
        }
        //start是把节点移到com前面
        ListNode start=cur;
        if(cur.next==null){
            return head;
        }
        cur=cur.next;//cur到了第一个大于等于x的节点
        ListNode com=cur;
        ListNode pre=cur;
        while(cur!=null){
            if(cur.val<x){
                start.next=cur;
                cur=cur.next;
                pre.next=cur;
                start.next.next=com;
                start=start.next;
            }else{
                pre=cur;
                cur=cur.next;
                
            }
        }

        return res.next;
    }
}