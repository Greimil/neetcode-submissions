public class Solution {
      public bool SearchMatrix(int[][] matrix, int target)
    {

        int left = 0;
        int right = matrix.Length - 1;
        int idxArr = -1;

        while (left <= right)
        {
            int mid = (left + right) / 2;
            var starArr = matrix[mid][0];
            var endArr = matrix[mid][matrix[mid].Length - 1];

            if (starArr <= target && endArr >= target)
            {
                idxArr = mid;
                break;
            }
            else if (target <= starArr)
            {
                right = mid - 1;

            }
            else
            {
                left = mid + 1;

            }



        }
        ;


        if (idxArr == -1) return false;


        var arrToSearch = matrix[idxArr];
        int low = 0;
        int hight = arrToSearch.Length - 1;


        while (low <= hight)
        {
            int mid = (low + hight) / 2;

            if (arrToSearch[mid] == target) return true;

            if (arrToSearch[mid] < target)
            {
                low = mid + 1;

            }
            else
            {
                hight = mid - 1;
            }


        }



        return false;



    }

}
