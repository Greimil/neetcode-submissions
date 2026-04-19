public class MyHashMap {
    int[] arr;
    public MyHashMap() {
        arr = new int[1000001];
        Array.Fill(arr,-1);
    }
    
    public void Put(int key, int value) {
        arr[key] = value;
    }
    
    public int Get(int key) {
        return arr[key];
    }
    
    public void Remove(int key) {
        arr[key] = -1;
    }
}

/**
 * Your MyHashMap object will be instantiated and called as such:
 * MyHashMap obj = new MyHashMap();
 * obj.Put(key,value);
 * int param_2 = obj.Get(key);
 * obj.Remove(key);
 */