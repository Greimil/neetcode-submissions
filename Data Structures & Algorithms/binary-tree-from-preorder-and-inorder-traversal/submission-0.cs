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
      public TreeNode BuildTree(int[] preorder, int[] inorder)
    {
        TreeNode root;

        if (preorder.Length == 1) return root = new TreeNode(preorder[0]);

        int preIndex = 0; // índice global para recorrer preorder

        var inorderIndexMap = new Dictionary<int, int>();
        for (int i = 0; i < inorder.Length; i++)
            inorderIndexMap[inorder[i]] = i;


        TreeNode DFS(int inStart, int inEnd)
        {
            if (inStart > inEnd)
                return null;

            // Aquí va tu lógica:

            // 1. Tomar preorder[preIndex] como valor de la raíz actual
            int value = preorder[preIndex];

            // 2. Crear el nodo
            TreeNode root = new TreeNode(value);

            // 3. Buscar ese valor en inorder[inStart..inEnd] para dividir en izquierda/derecha
            int idxInoder = inorderIndexMap[value];


            // 4. Incrementar preIndex
            preIndex++;

            // 5. Llamar recursivamente para left y right con nuevos rangos
            root.left = DFS(inStart, idxInoder - 1);

             root.right = DFS(idxInoder + 1 , inEnd );

            // 6. Retornar el nodo construido
            return root;
        }



        return DFS(0, inorder.Length - 1);
    }
}
