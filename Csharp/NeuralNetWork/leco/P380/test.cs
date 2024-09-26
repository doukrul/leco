using System;
using System.Collections.Generic;
/// <summary>
/// Dictionary:c#中的一种泛型集合,用来存储键值对(hash)
/// </summary>
public class RandomizedSet {
    private Random random;
    private List<int> list;
    private Dictionary<int,int> indexMap;
    //初始化
    public RandomizedSet() {
        this.random=new Random();
        list=new List<int>();
        //indexMap[key,value]键值对
        indexMap=new Dictionary<int, int>();
        
    }
    
    public bool Insert(int val) {
        if(indexMap.ContainsKey(val)){
            return false;
        }
        else{
            list.Add(val);
        }
        //看来是val,但indexMap[key]实际为值,记录元素val在list中的索引
        //list.Add添加元素到末尾,所以是-1即为索引
        indexMap[val]=list.Count-1;
        return true;
    }
    
    public bool Remove(int val) {
        if(!indexMap.ContainsKey(val)){
            // list.Remove(val);这样写时间复杂度为O(n)而不是O(1)
            return false;
        }
        
        return true;
    }
    
    public int GetRandom() {
        return 0;
    }
}

/**
 * Your RandomizedSet object will be instantiated and called as such:
 * RandomizedSet obj = new RandomizedSet();
 * bool param_1 = obj.Insert(val);
 * bool param_2 = obj.Remove(val);
 * int param_3 = obj.GetRandom();
 */