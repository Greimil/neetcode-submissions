public class Solution {
    
    public int FindKthLargest(int[] nums, int k)
    {
        PriorityQueue<int, int> minHeap = new();

        foreach (var num in nums)
        {
            minHeap.Enqueue(num, num);
            if (minHeap.Count > k)
            {
                minHeap.Dequeue();
            }


       }

        return minHeap.Peek();
    }
}
