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
public class TreeNode2
{
    public int val;
    public TreeNode left;
    public TreeNode right;
    public TreeNode2(int val = 0, TreeNode left = null, TreeNode right = null)
    {
        this.val = val;
        this.left = left;
        this.right = right;
    }
}
public class SolutionP129test2
{
    public int SumNumbers(TreeNode root)
    {
        return GetNum(root,0);
    }
    public int GetNum(TreeNode root,int num)
    {
        
        if(root==null){
            return 0;
        }
        num=num*10+root.val;
        if(root.left==null&&root.right==null){
            return num;
        }
        return GetNum(root.left,num)+GetNum(root.right,num);
    }
}