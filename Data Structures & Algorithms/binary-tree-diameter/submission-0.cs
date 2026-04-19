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
       public static int Dfs(TreeNode node, ref int res)
    {
        if (node == null) return 0;

        int alturaIz = Dfs(node.left, ref res);
        int alturaDe = Dfs(node.right, ref res);

        int resLocal = alturaIz + alturaDe;

        res = Math.Max(resLocal, res);

        return 1 + Math.Max(alturaIz, alturaDe);

    }


    public int DiameterOfBinaryTree(TreeNode root)
    {
        int res = 0;
        Dfs(root, ref res);
        return res;
    }
   
}
