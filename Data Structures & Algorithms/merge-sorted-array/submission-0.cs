public class Solution {
    public void Merge(int[] nums1, int m, int[] nums2, int n) {
        // Punteros para los últimos elementos válidos de cada arreglo
        int p1 = m - 1;
        int p2 = n - 1;
        // Puntero para la última posición disponible en nums1
        int p = m + n - 1;

        // Mientras haya elementos que comparar en ambos arreglos
        while (p1 >= 0 && p2 >= 0) {
            // Comparamos cuál es mayor y lo ponemos al final
            if (nums1[p1] > nums2[p2]) {
                nums1[p] = nums1[p1];
                p1--;
            } else {
                nums1[p] = nums2[p2];
                p2--;
            }
            p--;
        }

        // Si sobran elementos en nums2, los copiamos
        // (Si sobran en nums1, ya están en su lugar correcto)
        while (p2 >= 0) {
            nums1[p] = nums2[p2];
            p2--;
            p--;
        }
    }
}