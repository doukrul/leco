// /*
// // Definition for a Node.
// public class Node {
//     public int val;
//     public Node next;
//     public Node random;
    
//     public Node(int _val) {
//         val = _val;
//         next = null;
//         random = null;
//     }
// }
// */
// public class SolutionP138test2
// {
//     public Node CopyRandomList(Node head)
//     {
//         Node res = new Node(0);
//         Node node = res;
//         Node cur = head;
//         Dictionary<Node,int> list = new Dictionary<Node, int>();
//         List<Node> nodelist= new List<Node>();
//         int i=0;
//         //两遍循环,先顺序存后随机指针
//         while(cur!=null){
//             node.next =new Node(cur.val);
//             list.Add(cur,i++);
//             nodelist.Add(node.next);
//             node=node.next;
//             cur=cur.next;
//         }
//         Node n=res;
//         while(head!=null){
//             if(head.random!=null){
//                 n.next.random=nodelist[list[head.random]];
//             n=n.next;
//             head=head.next;
//             }
            
//         }

//         return res.next;
//     }
// }