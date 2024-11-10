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
public class SolutionP92test1 {
    public ListNode ReverseBetween(ListNode head, int left, int right) {

        if(left==right) return head;

        ListNode res=new ListNode(0);
        ListNode node;
        ListNode cur=head;
        Dictionary<int,ListNode> map=new Dictionary<int,ListNode>();
        int count=1;
        while(cur!=null){
            map.Add(count++,cur);
            cur=cur.next;
        }
        cur=res;
        
        while(left<right){
            ListNode temp=map[left];
            map[left]=map[right];
            map[right]=temp;
            left++;
            right--;
        }

        for(int i=1;i<count;i++){
            cur.next=map[i];
            cur=cur.next;
        }
        cur.next=null;
        return res.next;
    }
}