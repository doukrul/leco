public class SolutionP219test4 {
    public bool ContainsNearbyDuplicate(int[] nums, int k) {
        HashSet<int> set = new HashSet<int>();
        for(int i=0;i<nums.Length;i++){
            if(set.Contains(nums[i])){
                if(i-Array.IndexOf(nums,nums[i])<=k){
                    return true;
                }else{
                    
                }
            }else{
                set.Add(nums[i]);
            }
        }
        return false;
    }
}