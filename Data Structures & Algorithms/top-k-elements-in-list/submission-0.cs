public class Solution {
  public int[] TopKFrequent(int[] nums, int k)
{
    var dict = new Dictionary<int, int>();
    int[] res = new int[k];


    for (int i = 0; i < nums.Length; i++)
    {
        int num = nums[i];


        if (dict.ContainsKey(num))
        {

            dict[num]++;

        }
        else
        {

            dict[num] = 1;

        }

    }

    


    res = dict.OrderByDescending((pair) => pair.Value)
    .Select(pair => pair.Key)
    .ToArray();

   

   
    return res.Take(k).ToArray();

}
}
