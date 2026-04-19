public class MyHashSet {
    int?[] arr;

    public MyHashSet() {
        
        this.arr = new int?[1000000]; 
    }
    
    public void Add(int key) {
        this.arr[key] = key;
    }
    
    public void Remove(int key) {
        this.arr[key] = null;
    }
    
    public bool Contains(int key) {
        return this.arr[key] != null;
    }
}

/**
 * Your MyHashSet object will be instantiated and called as such:
 * MyHashSet obj = new MyHashSet();
 * obj.Add(key);
 * obj.Remove(key);
 * bool param_3 = obj.Contains(key);
 */