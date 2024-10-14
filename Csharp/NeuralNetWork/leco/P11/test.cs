public class SolutionP11test1
{
    public int MaxArea(int[] height)
    {
        int prev = 0, last = height.Length - 1;

        int prevh_max = height[0];
        int lasth_max = height[height.Length - 1];
        int area = 0;
        while (last > prev)
        {
            int width = last - prev;
            int newarea = width * Math.Min(prevh_max, lasth_max);
            area = Math.Max(area, newarea);
            if (prevh_max > lasth_max)
            {
                last--;
                lasth_max = Math.Max(height[last], lasth_max);
            }
            else
            {
                prev++;
                prevh_max = Math.Max(height[prev], prevh_max);
            }

        }
        return area;
    }
}