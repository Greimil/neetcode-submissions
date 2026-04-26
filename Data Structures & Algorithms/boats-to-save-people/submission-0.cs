public class Solution {
    public int NumRescueBoats(int[] people, int limit) {
        int res = 0;
        int l = 0;
        int r = people.Length - 1;
        Array.Sort(people);

        while (l <= r) {
            int total = people[l] + people[r];

            if (total > limit) {
                r--;
            } else {
                r--;
                l++;
            }               
            
            res++;

        }
    
        return res;
    
    }
}