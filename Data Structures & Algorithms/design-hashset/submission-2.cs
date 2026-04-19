public class MyHashSet {
    public int[] arr;
    
    public MyHashSet() {
        arr =  new int[1000001];
        Array.Fill(arr, -1);
    }
    
    public void Add(int key) {
        arr[key] = key;
    }
    
    public void Remove(int key) {
        arr[key]  = -1;
    }
    
    public bool Contains(int key) {
        return arr[key] != -1;
    }
}

/**
 * Your MyHashSet object will be instantiated and called as such:
 * MyHashSet obj = new MyHashSet();
 * obj.Add(key);
 * obj.Remove(key);
 * bool param_3 = obj.Contains(key);
 */