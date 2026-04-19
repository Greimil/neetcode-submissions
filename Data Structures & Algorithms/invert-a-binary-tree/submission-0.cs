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
    public TreeNode InvertTree(TreeNode root) {
        if(root == null) return root;

        Stack<TreeNode> stack = new Stack<TreeNode>();
        stack.Push(root);

        while(stack.Count != 0) {
           TreeNode Node = stack.Pop();
           TreeNode Temp = Node;

        
          TreeNode temp = Node.left;
          Node.left = Node.right;
          Node.right = temp;
         


           if(Node.right != null) {
             stack.Push(Node.right);
           }

            
           if(Node.left != null) {
             stack.Push(Node.left);
           }
        }

        return root;

    }
}
