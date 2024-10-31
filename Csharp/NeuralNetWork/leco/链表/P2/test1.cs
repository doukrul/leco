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
  public class ListNode {
     public int val;
     public ListNode next;
    public ListNode(int val=0, ListNode next=null) {
        this.val = val;
         this.next = next;
     }
 }
public class SolutionP2test1 {
    public ListNode AddTwoNumbers(ListNode l1, ListNode l2) {
        ListNode res=new ListNode(0);
        ListNode node=res;
        int carry=0;
        while(l1!=null||l2!=null||carry!=0){
            int n1=(l1!=null)?l1.val:0;
            int n2=(l2!=null)?l2.val:0;
            int sum=n1+n2+carry;
            carry=sum/10;

            node.next=new ListNode(sum%10);
            node=node.next;

            if(l1!=null){
                l1=l1.next;
            }
            if(l2!=null){
                l2=l2.next;
            }

            
        }

        return res.next;
    }

}