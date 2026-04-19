public class Solution {
   public int CarFleet(int target, int[] position, int[] speed)
    {
        var cars = position.Select((pos, i) => new { pos, spd = speed[i] }).
        OrderByDescending(car => car.pos)
        .ToArray();

        double[] timeToTarget = new double[position.Length];

        int idx = 0;
        foreach (var car in cars)
        {
            timeToTarget[idx] = (double)(target - car.pos) / car.spd;
            idx++;
        }

        // Stack<int> fleets 
        Stack<double> fleets = new Stack<double>();

        foreach (var time in timeToTarget)
        {
            if (fleets.Count == 0 || time > fleets.Peek())
            {
                fleets.Push(time); // Nueva fleet
            }
            // Si time <= fleets.Peek(), se une a esa fleet, no hacemos nada
        }
        return fleets.Count;


    }

}
