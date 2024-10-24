public class SolutionP128test1
{
    public int LongestConsecutive(int[] nums)
    {
        Array.Sort(nums);
        int maxl = 1;
        int result = 1;
        if (nums.Length == 0)
        {
            return 0;
        }
        //-1 0 0
        for (int i = 1; i < nums.Length; i++)
        {
            if (i <= nums.Length - 2 && nums[i] == nums[i - 1])
            {
                continue;
            }
            if (nums[i] == nums[i - 1] + 1)
            {
                maxl += 1;
            }
            else
            {
                result = Math.Max(result, maxl);
                maxl = 1;
            }
            if (i == nums.Length - 1)
            {
                result = Math.Max(result, maxl);
            }
        }
        return result;
    }
}