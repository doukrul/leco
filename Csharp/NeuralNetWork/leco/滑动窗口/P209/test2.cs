public class SolutionP209test2 {
    public int MinSubArrayLen(int target, int[] nums) {
        int result=int.MaxValue;
        int sum=0;
        //子串头下标
        int subi=0;
        int sublength=0;
        for(int i=0;i<nums.Length;i++){
            sum+=nums[i];
            while(sum>=target){
                sublength=i-subi+1;
                result=Math.Min(result,sublength);
                sum-=nums[subi++];
            }
        }
        return result;
    }
}