/*
// Definition for a Node.
public class Node {
    public int val;
    public Node next;
    public Node random;
    
    public Node(int _val) {
        val = _val;
        next = null;
        random = null;
    }
}
*/
public class Node
{
    public int val;
    public Node next;
    public Node random;

    public Node(int _val)
    {
        val = _val;
        next = null;
        random = null;
    }
}
public class SolutionP138test1
{
    public Node CopyRandomList(Node head)
    {
        Node res = new Node(0);
        Node node = res;
        List<Node> list = new List<Node>();
        List<Node> nodelist = new List<Node>();
        //两个链表一遍循环
        while (head != null)
        {
            if (!list.Contains(head))
            {
                node.next = new Node(head.val);
                list.Add(head);
                nodelist.Add(node.next);
            }
            else
            {
                node.next = nodelist[list.IndexOf(head)];
            }
            if (head.random != null)
            {
                if (!list.Contains(head.random))
                {
                    node.next.random = new Node(head.random.val);
                    list.Add(head.random);
                    nodelist.Add(node.next.random);
                }
                else
                {
                    node.next.random = nodelist[list.IndexOf(head.random)];
                }
            }

            node = node.next;
            if (head.next != null)
            {
                head = head.next;
            }
            else
            {
                break;
            }
        }
        return res.next;
    }
}