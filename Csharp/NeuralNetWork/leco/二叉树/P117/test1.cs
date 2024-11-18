

public class Node {
    public int val;
    public Node left;
    public Node right;
    public Node next;

    public Node() {}

    public Node(int _val) {
        val = _val;
    }

    public Node(int _val, Node _left, Node _right, Node _next) {
        val = _val;
        left = _left;
        right = _right;
        next = _next;
    }
}


public class SolutionP117test1 {
    public Node Connect(Node root) {
        if(root==null){
            return null;
        }
        root.next=null;
        Node levelstart=root;
        while(levelstart!=null){
            Node cur=levelstart;
            while(cur!=null){
                if(cur.left!=null){
                    if(cur.right!=null){
                        cur.left.next=cur.right;
                    }else{
                        cur.left.next=getnextnode(cur.next);
                    }
                }

                    if(cur.right!=null){
                        cur.right.next=getnextnode(cur.next);
                    }
                cur=cur.next;
            }
            levelstart=getnextnode(levelstart);
        }
        return root;
    }
    private Node getnextnode(Node node){
        while(node!=null){
            if(node.left!=null){
                return node.left;
            }
            if(node.right!=null){
                return node.right;
            }
            node=node.next;
        }
        return null;
    }
}