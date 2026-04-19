public class Solution {
    public int RemoveDuplicates(int[] nums) {
        // Si el array está vacío, no hay nada que hacer
        if (nums.Length == 0) return 0;

        // insertIndex empieza en 1 porque el primer elemento siempre es "único"
        int insertIndex = 1;

        // Recorremos el array desde el segundo elemento
        for (int i = 1; i < nums.Length; i++) {
            // Si el elemento actual es DIFERENTE al anterior...
            if (nums[i] != nums[i - 1]) {
                // ...lo guardamos en la posición que indica insertIndex
                nums[insertIndex] = nums[i];
                // Avanzamos el marcador para la siguiente escritura
                insertIndex++;
            }
        }

        // El valor de insertIndex será exactamente la cantidad de elementos únicos
        return insertIndex;
    }
}