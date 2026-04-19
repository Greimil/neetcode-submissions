/*
// Definition for a Node.
public class Node {
    public int val;
    public Node next;
    public Node random;
    
    public Node(int _val) {
        val = _val;
        next = null;
        random = null;
    }
}
*/

public class Solution {
  public Node copyRandomList(Node head)
{
    if (head == null) return null;

    Dictionary<Node, Node> nodes = new Dictionary<Node, Node>();
    Node curr = head;

    while (curr != null)
    {
        nodes[curr] = new Node(curr.val);
        curr = curr.next;
    }

    curr = head;
    while (curr != null)
    {
        nodes[curr].next = curr.next != null ? nodes[curr.next] : null;
        nodes[curr].random = curr.random != null ? nodes[curr.random] : null;
        curr = curr.next;
    }

    return nodes[head];
}


}
