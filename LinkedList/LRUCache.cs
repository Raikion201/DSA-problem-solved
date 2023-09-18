public class LRUCache {
    private Dictionary <int , LinkedListNode<(int key, int value)>> _dict = new();
    private LinkedList<(int key, int value)> values = new();
    private int _capacity ;
    public LRUCache(int capacity) {
        _capacity = capacity;
    }

    public int Get(int key) {

        if (!_dict.ContainsKey(key)) {
            return -1;
        }
        var node = _dict[key];
        values.Remove(node);
        values.AddFirst(node);
        return node.Value.value;
    }

    public void Put(int key, int value) {
        if(!_dict.ContainsKey(key) && _dict.Count >= _capacity ){
            var node = values.Last;
            _dict.Remove(node.Value.key);
            values.RemoveLast();
        }
        var existingNode = _dict.GetValueOrDefault(key);
        if(existingNode != null){
            values.Remove(existingNode);
        }
        values.AddFirst((key, value));
        _dict[key] = values.First;
        }
    }


/**
 * Your LRUCache object will be instantiated and called as such:
 * LRUCache obj = new LRUCache(capacity);
 * int param_1 = obj.Get(key);
 * obj.Put(key,value);
 */