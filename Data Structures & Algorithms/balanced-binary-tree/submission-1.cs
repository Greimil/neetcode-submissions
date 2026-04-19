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
     public int IsBalanceChecker(TreeNode root, ref bool IsBalance)
    {
        if (root == null) return 1;

        int leftheight = IsBalanceChecker(root.left, ref IsBalance);
        int rightheight = IsBalanceChecker(root.right, ref IsBalance);

        if (Math.Abs(leftheight - rightheight) > 1) IsBalance = false;

        return 1 + Math.Max(leftheight, rightheight);
    }

    public bool IsBalanced(TreeNode root)
    {
        bool balanced = true;

        IsBalanceChecker(root, ref balanced);

        return balanced;

    }
}
