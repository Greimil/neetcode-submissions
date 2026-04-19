public class MyHashMap {
    int?[] arr;
    public MyHashMap() {
        this.arr = new int?[1000001];
    }
    
    public void Put(int key, int value) {
        this.arr[key] = value;
    }
    
    public int Get(int key) {
        return this.arr[key] ?? -1;
    }
    
    public void Remove(int key) {
        this.arr[key] = null;
    }
}

/**
 * Your MyHashMap object will be instantiated and called as such:
 * MyHashMap obj = new MyHashMap();
 * obj.Put(key,value);
 * int param_2 = obj.Get(key);
 * obj.Remove(key);
 */