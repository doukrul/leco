using System.Collections.Generic;
using System.Linq;

public class LRUCache {
    private Dictionary<int, int> cache;
    private LinkedList<int> lruList;
    private int capacity;

    public LRUCache(int capacity) {
        cache = new Dictionary<int, int>();
        lruList = new LinkedList<int>();
        this.capacity = capacity;
    }

    public int Get(int key) {
        if (cache.ContainsKey(key)) {
            // 移动到链表尾部
            lruList.Remove(key);
            lruList.AddLast(key);
            return cache[key];
        }
        return -1;
    }

    public void Put(int key, int value) {
        if (cache.ContainsKey(key)) {
            // 更新值并移动到链表尾部
            cache[key]=value;
            lruList.Remove(key);
            lruList.AddLast(key);
        } else {
            if (cache.Count >= capacity) {
                // 删除最久未使用的元素
                cache.Remove(lruList.First.Value);
                lruList.RemoveFirst();
            }
            // 插入新元素
            lruList.AddLast(key);
            cache.Add(key, value);
        }
    }
}