public class SolutionP56test1
{
    public int[][] Merge(int[][] intervals)
    {
        if (intervals.Length <= 1)
        {
            return intervals;
        }

        // 按区间的起始位置排序
        Array.Sort(intervals, (a, b) => a[0].CompareTo(b[0]));

        List<int[]> result = new List<int[]>();

        int start = intervals[0][0];
        int end = intervals[0][1];

        for (int i = 1; i < intervals.Length; i++)
        {
            if (intervals[i][0] <= end) // 有重叠
            {
                end = Math.Max(end, intervals[i][1]); // 更新结束位置
            }
            else // 没有重叠
            {
                result.Add(new int[] { start, end }); // 添加当前合并的区间
                start = intervals[i][0]; // 更新新的起始位置
                end = intervals[i][1];   // 更新新的结束位置
            }
        }

        // 添加最后一个区间
        result.Add(new int[] { start, end });

        return result.ToArray();
    }
}
