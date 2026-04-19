public class Solution {
   public int MaxProduct(int[] nums)
{
    // Inicializamos el producto máximo, mínimo y el resultado con el primer elemento
    int maxProd = nums[0];
    int minProd = nums[0];
    int result = nums[0];

    // Recorremos el arreglo desde el segundo elemento
    for (int i = 1; i < nums.Length; i++)
    {
        int num = nums[i];

        // Si el número es negativo, intercambiamos maxProd y minProd
        // porque un negativo puede volver máximo a lo que antes era mínimo
        if (num < 0)
        {
            int temp = maxProd;
            maxProd = minProd;
            minProd = temp;
        }

        // Actualizamos el máximo: o tomamos el número solo,
        // o lo multiplicamos con el máximo anterior
        maxProd = Math.Max(num, num * maxProd);

        // Lo mismo para el mínimo, pero tomando el menor valor
        minProd = Math.Min(num, num * minProd);

        // Actualizamos el resultado global con el máximo encontrado hasta ahora
        result = Math.Max(result, maxProd);
    }

    // Al final, result contiene el producto máximo de subarreglo
    return result;
}
}
