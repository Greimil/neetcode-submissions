public class Solution {
    
    public int[] DailyTemperatures(int[] temperatures)
    {
        int[] result = new int[temperatures.Length];

        Stack<int> daysleft = new Stack<int>();

        for (int i = 0; i < temperatures.Length; i++)
        {
            int temp = temperatures[i];

            while (daysleft.Count > 0 && temp > temperatures[daysleft.Peek()])
            {
                int prevIndex = daysleft.Pop();

                result[prevIndex] = i - prevIndex;

            }

            daysleft.Push(i);

        }
      

        return result;
    }

}
