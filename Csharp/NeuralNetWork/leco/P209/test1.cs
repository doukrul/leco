public class SolutionP209test1
{
    //双层循环时间复杂度O(n),数据量过大时超出时间限制,直接不能运行

    public int MinSubArrayLen(int target, int[] nums)
    {
        int result = int.MaxValue;
        int sublength = 0;

        for (int i = 0; i < nums.Length; i++)
        {
            int sum = 0;
            for (int j = i; j < nums.Length; j++)
            {
                sum += nums[j];
                if (sum >= target)
                {
                    sublength = j - i + 1;
                    result = Math.Min(result, sublength);
                    break;
                }
            }
        }
        return result==int.MaxValue?0:result;
    }
}