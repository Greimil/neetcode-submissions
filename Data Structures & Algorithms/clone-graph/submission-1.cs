public class Solution {
public Node CloneGraph(Node node)
{
    if (node == null) return null;

    Dictionary<Node, Node> hashMap = new Dictionary<Node, Node>();

    Node dfs(Node curr)
    {
       
        if (hashMap.ContainsKey(curr))
            return hashMap[curr];

        
        Node clone = new Node(curr.val);
        hashMap[curr] = clone;

        
        foreach (Node neighbor in curr.neighbors)
        {
            clone.neighbors.Add(dfs(neighbor));
        }

        return clone;
    }

    return dfs(node);
}

}