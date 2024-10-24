public class SolutionP219test3 {
//test2优化
    public bool ContainsNearbyDuplicate(int[] nums, int k) {
        Dictionary<int,int> dic=new Dictionary<int,int>();
        for(int i=0;i<nums.Length;i++){
            if(dic.TryGetValue(nums[i], out int temp)){
                if(i-temp<=k){
                    return true;
                }else{
                    dic[nums[i]]=i;
                }
            }else{
                dic.Add(nums[i],i);
            }
        }
        return false;
    }
}