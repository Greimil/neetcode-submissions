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

public class Solution {
     public int GoodNodes(TreeNode root)
    {
        int count = 0;

        void DFS(TreeNode node, ref int count, int max)
        {
            if (node == null)
            {
                return;
            }

            if (node.val >= max)
            {
                count++;
            }

            max = Math.Max(max, node.val);


            DFS(node.right, ref count,  max);
            DFS(node.left, ref count,  max);


        }

        DFS(root, ref count, int.MinValue);

        return count;

    }

}
