public class Solution42
{
    public int Trap(int[] height)
    {
        int rainwater = 0;
        int n = height.Length;
        int[] left = new int[n];
        int[] right = new int[n];
        left[0] = height[0];
        for (int i = 1; i <= n - 1; ++i)
        {
            left[i] = Math.Max(height[i], left[i - 1]);
        }
        right[n - 1] = height[n - 1];
        for (int i = n - 2; i >= 0; --i)
        {
            right[i] = Math.Max(height[i], right[i + 1]);
        }
        for(int i=0;i<n;++i){
            rainwater+=Math.Min(left[i],right[i])-height[i];
        }
        
        return rainwater;
    }
}