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
public class SolutionP103test2
{
    public IList<IList<int>> ZigzagLevelOrder(TreeNode root)
    {
        List<IList<int>> res = new List<IList<int>>();
        if (root == null)
        {
            return res;
        }
        Queue<TreeNode> queue = new Queue<TreeNode>();
        queue.Enqueue(root);
        bool mark=false;
        while (queue.Count > 0)
        {
            int size = queue.Count;
            int []level=new int[size];
            for (int i = 0; i < size; i++)
            {
                TreeNode node = queue.Dequeue();
                level[mark?size-i-1:i]=node.val;
                if (node.left != null)
                {
                    queue.Enqueue(node.left);
                }
                if (node.right != null)
                {
                    queue.Enqueue(node.right);
                }
            }
            mark=!mark;
            res.Add(level);
        }
        return res;
    }
}