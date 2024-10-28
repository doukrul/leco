using System;
using System.Collections.Generic;

public class MinStack2
{
    private int count;
    private int min;
    private List<int> minl;
    private List<int> list;

    public MinStack2()
    {
        this.count = 0;
        this.min = int.MaxValue;
        this.minl = new List<int>();
        this.list = new List<int>();
    }

    public void Push(int val)
    {
        if(count==0){
            min=val;
        }
        if (val <= min)
        {
            min = val;
            minl.Add(min);
        }else{
            minl.Add(min);
        }
        list.Add(val);
        this.count++;
    }

    public void Pop()
    {
        minl.RemoveAt(count - 1);
        if(count>1)
        min=minl[count-2];
        list.RemoveAt(count - 1);
        count--;
    }

    public int Top()
    {
        return this.list[count - 1];
    }

    public int GetMin()
    {
        return this.min;
    }
}

/**
 * Your MinStack object will be instantiated and called as such:
 * MinStack obj = new MinStack();
 * obj.Push(val);
 * obj.Pop();
 * int param_3 = obj.Top();
 * int param_4 = obj.GetMin();
 */