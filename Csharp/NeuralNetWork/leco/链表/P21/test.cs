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
public class SolutionP21test1 {
    public ListNode MergeTwoLists(ListNode list1, ListNode list2) {
        ListNode res=new ListNode();
        ListNode cur=res;
        
        while(list1!=null&&list2!=null){
            if(list1.val<list2.val){
                cur.next=new ListNode(list1.val);
                list1=list1.next;
            }else{
                cur.next=new ListNode(list2.val);
                list2=list2.next;
            }
            cur=cur.next;
        }
        while(list1!=null){
            cur.next=new ListNode(list1.val);
            list1=list1.next;
            cur=cur.next;
        }
        while(list2!=null){
            cur.next=new ListNode(list2.val);
            list2=list2.next;
            cur=cur.next;
        }
        return res.next;
    }
}