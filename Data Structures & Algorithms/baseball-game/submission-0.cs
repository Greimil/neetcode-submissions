public class Solution {
    public int CalPoints(string[] operations) {
        List<int> list = new List<int>();

        foreach (var op in operations) {
            if (op == "+") {
                list.Add(list[^1] + list[^2]);

            } else if (op == "D") {
                list.Add(list[^1] * 2);

            } else if (op == "C") {
                list.RemoveAt(list.Count - 1);

            } else {
                list.Add(int.Parse(op));
            }
        }


        return list.Sum();
    }
}