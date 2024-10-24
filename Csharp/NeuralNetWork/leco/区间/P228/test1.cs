public class SolutionP228test1 {
    public IList<string> SummaryRanges(int[] nums) {
        List<string> list = new List<string>();
        int pre=0,suf=0;
        if(nums.Length==1){
            list.Add(nums[0].ToString());
        }
        for(int i=1; i<nums.Length;i++){
            if(nums[i]==nums[i-1]+1){
                suf=i;
            }else{
                if(suf==pre){
                    list.Add(nums[pre].ToString());
                }else{
                    list.Add(nums[pre].ToString()+"->"+nums[suf].ToString());
                }
                
                pre=i;suf=i;
            }
            if(suf==nums.Length-1){
                if(suf==pre){
                    list.Add(nums[pre].ToString());
                }else{
                    list.Add(nums[pre].ToString()+"->"+nums[suf].ToString());
                }
            }
        }
        return list;
    }
}