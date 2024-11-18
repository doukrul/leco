/*
// Definition for a Node.
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
*/

public class SolutionP117test2 {
    public Node Connect(Node root) {
        if(root==null){
            return null;
        }
        


        if(root.left!=null){
            if(root.right!=null){
                root.left.next=root.right;
            }else{
                root.left.next=getnextnode(root.next);
            }
        }

        if(root.right!=null){
            root.right.next=getnextnode(root.next);
        }

        
        Connect(root.right);
        Connect(root.left);
        return root;
    }
    private Node getnextnode(Node node){
        if(node==null){
            return null;
        }

            if(node.left!=null){
                return node.left;
            }
            if(node.right!=null){
                return node.right;
            }
        
        return getnextnode(node.next);
    }
}