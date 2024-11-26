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
public class SolutionP114test1 {
    public void Flatten(TreeNode root) {
        List<TreeNode> treeNodes= new List<TreeNode>();
        help(root,treeNodes);
        TreeNode cur=root;
        foreach(var node in treeNodes) {
            cur.right=node;
            cur.left=null;
            cur=cur.right;
        }
        cur.right=null;
        return;
    }
    private void help(TreeNode node,List<TreeNode> treeNodes){
        if(node==null){
            return;
        }
        treeNodes.Add(node);
        help(node.left,treeNodes);
        help(node.right,treeNodes);
    }
}