public class SolutionP209test1
{
    public int MinSubArrayLen(int target, int[] nums)
    {
        int result = nums.Length - 1;
        int sum = 0;
        foreach (int n in nums)
        {
            sum += n;
        }
        if (sum < target)
        {
            return 0;
        }
        Array.Sort(nums);
        for (int i = 0; i < nums.Length; i++)
        {
            if(sum>target){
                sum-=nums[i];
                result--;
            }

        }
        return result;
    }
}