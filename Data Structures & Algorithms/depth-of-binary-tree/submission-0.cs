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
    public int MaxDepth(TreeNode root) {
        if(root == null) return 0;
        
        Queue<TreeNode> cola = new Queue<TreeNode>();
        int depth = 0;
        cola.Enqueue(root);

        while(cola.Count != 0) {
            int levelSize = cola.Count;

            for (int i = 0; i < levelSize; i++) {
                TreeNode current = cola.Dequeue();

                if(current.left != null) {
                    cola.Enqueue(current.left);
                }

                
                if(current.right != null) {
                    cola.Enqueue(current.right);
                }
            
            }
            
                depth++;
        }


        return depth;
    }
}
