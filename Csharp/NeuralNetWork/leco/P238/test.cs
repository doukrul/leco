public class Solution
{
    public int[] ProductExceptSelf(int[] nums)
    {
        int[] answer = new int[nums.Length];
        int n = nums.Length;
        int pre = 1;
        int last = 1;
        for (int i = 0; i < n; ++i)
        {
            answer[i] = pre;
            pre *= nums[i];
        }
        for (int i = n - 1; i >= 0; --i)
        {
            answer[i] *= last;
            last *= nums[i];
        }
        return answer;
    }
}