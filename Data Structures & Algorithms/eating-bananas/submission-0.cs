public class Solution {
    public int MinEatingSpeed(int[] piles, int h)
    {
        int maxPile = 0;

        foreach (var pile in piles)
        {
            maxPile = Math.Max(maxPile, pile);

        }


        int left = 1;
        int right = maxPile;
        int mink = int.MaxValue;

        while (left <= right)
        {
            int mid = (left + right) / 2;


            int hoursToPile = 0;

            foreach (var pile in piles)
            {
                hoursToPile += (pile + mid - 1) / mid;
            }

            if (hoursToPile <= h && mid < mink)
            {
                mink = Math.Min(mink, mid);
                right = mid - 1;
            }
            else
            {
                left = mid + 1;
            }


        }

        return mink;
    }

}
