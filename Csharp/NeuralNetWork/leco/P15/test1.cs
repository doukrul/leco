public class SolutionP15test1
{
    public IList<IList<int>> ThreeSum(int[] nums)
    {
        Array.Sort(nums);
        List<IList<int>> list = new List<IList<int>>();
        int pre = 0;
        while (pre < nums.Length - 2)
        {
            if (pre > 0 && nums[pre] == nums[pre - 1])
            {
                pre++;
                continue;
            }
            int mid = pre + 1, suf = nums.Length - 1;
            while (mid < suf)
            {
                int sum = nums[pre] + nums[mid] + nums[suf];
                if (sum == 0)
                {
                    list.Add(new List<int>(){
                        nums[pre],nums[mid],nums[suf]
                    });
                    while (mid < suf && nums[mid + 1] == nums[mid]) mid++;
                    while (suf > mid && nums[suf] == nums[suf - 1]) suf--;
                    mid++;
                    suf--;
                }
                else if (sum > 0)
                {
                    suf--;
                }
                else
                {
                    mid++;
                }

            }

            pre++;
        }
        return list;
    }
}