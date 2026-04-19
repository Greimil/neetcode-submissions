public class LRUCache
{
    public class NodeD
    {
        public int key;
        public int value;
        public NodeD prev;
        public NodeD next;

        public NodeD(int key, int value)
        {
            this.key = key;
            this.value = value;
        }
    }

    private int capacity;
    private Dictionary<int, NodeD> cache;
    private NodeD head, tail;

    public LRUCache(int capacity)
    {
        this.capacity = capacity;
        this.cache = new Dictionary<int, NodeD>();

        // Nodos dummy para simplificar inserciones y eliminaciones
        head = new NodeD(0, 0);
        tail = new NodeD(0, 0);
        head.next = tail;
        tail.prev = head;
    }

    public int Get(int key)
    {
        if (!cache.ContainsKey(key)) return -1;

        NodeD node = cache[key];
        moveToHead(node);
        return node.value;
    }

    public void Put(int key, int value)
    {
        if (cache.ContainsKey(key))
        {
            NodeD node = cache[key];
            node.value = value;
            moveToHead(node);
        }
        else
        {
            NodeD newNode = new NodeD(key, value);
            cache[key] = newNode;
            addNode(newNode);

            if (cache.Count > capacity)
            {
                NodeD tailNode = popTail();
                cache.Remove(tailNode.key);
            }
        }
    }

   
    private void addNode(NodeD node)
    {
        node.prev = head;
        node.next = head.next;

        head.next.prev = node;
        head.next = node;
    }


    private void removeNode(NodeD node)
    {
        node.prev.next = node.next;
        node.next.prev = node.prev;
    }

    
    private void moveToHead(NodeD node)
    {
        removeNode(node);
        addNode(node);
    }

    
    private NodeD popTail()
    {
        NodeD node = tail.prev;
        removeNode(node);
        return node;
    }
}
