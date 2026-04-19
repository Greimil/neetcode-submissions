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
    public void RightSideViewDFS(TreeNode root, ref List<int> nodesValue, int Depth)
    {
        if (root == null) return;

        if (nodesValue.Count == Depth) nodesValue.Add(root.val);

        RightSideViewDFS(root.right, ref nodesValue, Depth + 1);

        RightSideViewDFS(root.left, ref nodesValue, Depth + 1);



    }


    public List<int> RightSideView(TreeNode root)
    {
        List<int> nodesValues = new List<int>();

        RightSideViewDFS(root, ref nodesValues, 0);

        return nodesValues;
    }
}
