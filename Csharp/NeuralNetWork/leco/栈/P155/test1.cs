using System;
using System.Collections.Generic;

public class MinStack
{
    private int count;
    private int min;
    private List<int> minl;
    private List<int> list;

    public MinStack()
    {
        this.count = 0;
        this.min = int.MaxValue;
        this.minl = new List<int>();
        this.list = new List<int>();
    }

    public void Push(int val)
    {
        if (val <= min)
        {
            minl.Add(val);
            min = val;
        }
        list.Add(val);
        this.count++;
    }

    public void Pop()
    {
        if (list[count - 1] == min)
        {
            minl.RemoveAt(minl.Count - 1);
            if (minl.Count > 0)
            {
                min = minl[minl.Count - 1];
            }
            else
            {
                min = int.MaxValue;
            }
        }
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