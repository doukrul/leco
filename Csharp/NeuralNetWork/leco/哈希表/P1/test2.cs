public class SolutionP1test2 {
    public int[] TwoSum(int[] nums, int target) {
        HashSet<int> set = new HashSet<int>();
        for(int i=0;i<nums.Length;i++){
            if(set.Contains(target-nums[i])){
                return new int[]{nums[i],Array.IndexOf(nums,target-nums[i])};

            }
            if(!set.Contains(nums[i])){
                set.Add(nums[i]);
            }
        }
        return new int[]{};
    }
}