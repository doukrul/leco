/**
 * Definition for a binary tree node.
 * public class TreeNode {
 *     public int val;
 *     public TreeNode left;
 *     public TreeNode right;
 *     public TreeNode(int val=0, TreeNode left=null, TreeNode right=null) {
 *         this.val = val;
 *         this.left = left;
 *         this.right = right;
 *     }
 * }
 */
public class BSTIterator {
    LinkedList<TreeNode> tree;
    LinkedListNode<TreeNode> point;
    public BSTIterator(TreeNode root) {
        this.tree = new LinkedList<TreeNode>();
        getinorder(root,tree);
        this.point = tree.First;
    }
    
    public int Next() {
        LinkedListNode<TreeNode> cur=point;
        point=point.Next;
        return cur.Value.val;
    }
    
    public bool HasNext() {
        if(point!=null){
            return true;
        }else{
            return false;
        }
    }
    public void getinorder(TreeNode node,LinkedList<TreeNode> tree) {
        if(node==null){
            return ;
        }
        getinorder(node.left,tree);
        tree.AddLast(node);
        getinorder(node.right,tree);
    }
}

/**
 * Your BSTIterator object will be instantiated and called as such:
 * BSTIterator obj = new BSTIterator(root);
 * int param_1 = obj.Next();
 * bool param_2 = obj.HasNext();
 */