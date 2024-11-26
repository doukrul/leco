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
public class Solution
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
        int mark = 1;
        while (queue.Count > 0)
        {
            List<int> level=new List<int>();
            int size = queue.Count;
            if (mark % 2 == 0)
            {
                for (int i = 0; i < size; i++)
                {
                    TreeNode node = queue.Dequeue();
                    level.Add(node.val);
                    if (node.left != null)
                    {
                        queue.Enqueue(node.left);
                    }
                    if (node.right != null)
                    {
                        queue.Enqueue(node.right);
                    }
                }
            }
            else
            {
                for (int i = 0; i < size; i++)
                {
                    TreeNode node = queue.Dequeue();
                    level.Add(node.val);
                    if (node.right != null)
                    {
                        queue.Enqueue(node.right);
                    }
                    if (node.left != null)
                    {
                        queue.Enqueue(node.left);
                    }
                }
            }
            mark++;
            res.Add(level);
        }
        return res;
    }
}