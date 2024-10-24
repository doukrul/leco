public class SolutionP1test1s {
    public int[] TwoSum(int[] nums, int target) {

        for(int i=0;i< nums.Length;i++){
            for(int j=i;j<nums.Length;j++) {
                if(nums[i]+nums[j]==target){
                    return new int[]{i, j};
                }
            }
        }
        return new int[]{0,nums.Length-1 };
    }
}