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

    
    public bool IsValidBST(TreeNode root)
    {

        return valid(root, long.MinValue, long.MaxValue);

    }

    bool valid(TreeNode currentNode, long left, long right)
    {
        if (currentNode == null) return true;

      if (currentNode.val <= left || currentNode.val >= right) return false;



        return valid(currentNode.left, left, currentNode.val) && valid(currentNode.right, currentNode.val, right);


    }

}
   
