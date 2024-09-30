//双指针不用左右数组版本
public class Solution42sp1
{
    public int Trap(int[] height)
    {
        int ans=0;
        int n=height.Length;
        int left=0,right=n-1;
        int pre_max=height[0];
        int suf_max=height[n-1];
        while(left<right){
            pre_max=Math.Max(height[left],pre_max);
            suf_max=Math.Max(height[right],suf_max);
            if(pre_max<=suf_max){
                ans+=Math.Min(pre_max,suf_max)-height[left];
                ++left;
            }
            else{
                ans+=Math.Min(pre_max,suf_max)-height[right];
                --right;
            }
        }

        return ans;
    }
}