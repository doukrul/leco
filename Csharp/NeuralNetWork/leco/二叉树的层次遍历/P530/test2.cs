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
public class SolutionP530test2 {
    public int GetMinimumDifference(TreeNode root) {
        //二叉搜索树中做中序遍历得到的是
        List<int> list=new List<int>();
        inorder(root,list);
        int min=100000;
        for(int i=1;i<list.Count;i++){
            int curmin=list[i]-list[i-1];
            if(min>curmin){
                min=curmin;
            }
        }
        return min;
    }
    private void inorder(TreeNode node,List<int> list) {
        if(node==null){
            return;
        }
        
        inorder(node.left,list);
        list.Add(node.val);
        inorder(node.right,list);
    }
}