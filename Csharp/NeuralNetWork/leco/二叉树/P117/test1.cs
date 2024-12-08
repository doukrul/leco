

public class Node2 {
    public int val;
    public Node2 left;
    public Node2 right;
    public Node2 next;

    public Node2() {}

    public Node2(int _val) {
        val = _val;
    }

    public Node2(int _val, Node2 _left, Node2 _right, Node2 _next) {
        val = _val;
        left = _left;
        right = _right;
        next = _next;
    }
}


public class SolutionP117test1 {
    public Node2 Connect(Node2 root) {
        if(root==null){
            return null;
        }
        root.next=null;
        Node2 levelstart=root;
        while(levelstart!=null){
            Node2 cur=levelstart;
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
    private Node2 getnextnode(Node2 node){
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