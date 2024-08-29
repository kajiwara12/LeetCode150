using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedList
{
    public class LRUCache
    {
        private LinkedList<int?> _cache;
        private Dictionary<int, LinkedListNode<int?>> _index;
        private int _capacity;
        public LRUCache(int capacity)
        {
            _cache = new LinkedList<int?>();
            _index = new Dictionary<int, LinkedListNode<int?>>();
            _capacity = capacity;
        }

        public int Get(int key)
        {
            if (!_index.TryGetValue(key, out LinkedListNode<int?> node)) { return -1; }
            if (!node.Value.HasValue) { return -1; }
            _cache.Remove(node);
            _cache.AddFirst(node);
            return node.Value!.Value;

        }

        public void Put(int key, int value)
        {
            if (_index.ContainsKey(key) && !_index[key].Value.HasValue) { _index.Remove(key); }
            LinkedListNode<int?> node = new LinkedListNode<int?>(value);

            if (_index.TryAdd(key, node)) // this key is new to the dictionary
            {
                if (_cache.Count + 1 > _capacity)
                //check if the _cache is full, if _cache.Count+1 is > than _capacity,we need to evict the oldest node
                {
                    _cache.Last!.Value = null;
                    _cache.RemoveLast();
                }
                _cache.AddFirst(node);
            }
            else // this key exists so update the node value and bring it the front of the cache.
            {
                node = _index[key];
                node.Value = value;
                _cache.Remove(node);
                _cache.AddFirst(node);
            }
        }
    }


}
