public class Solution {
   public int LastStoneWeight(int[] stones)
    {
        PriorityQueue<int, int> maxheap = new PriorityQueue<int, int>();

        foreach (var stone in stones)
        {
            int weight = stone;

            maxheap.Enqueue(stone, -weight);


        }


        while (maxheap.Count > 1)
        {
            int stone1 = maxheap.Dequeue();
            int stone2 = maxheap.Dequeue();

            if (stone1 < stone2)
            {
                stone2 = stone2 - stone1;
                maxheap.Enqueue(stone2, -stone2);

            }
            
            if(stone1 > stone2)
            {
                stone1 = stone1 - stone2;
                maxheap.Enqueue(stone1, -stone1);

            }


        }


        return maxheap.Count == 1 ? maxheap.Dequeue() : 0;


    }
}
