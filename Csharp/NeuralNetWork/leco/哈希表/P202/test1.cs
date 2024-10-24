public class SolutionP202test1 {
    public bool IsHappy(int n) {
        HashSet<int> list=new HashSet<int>();
        while(true) {
            int sum=0;
            while(n>0){
                sum+=(int)Math.Pow(n%10,2);
                n/=10;
            }
            if(sum==1){
                return true;
            }
            if(list.Contains(sum)){
                return false;
            }else{
                list.Add(sum);
            }
            n=sum;
        }
        
    }
}