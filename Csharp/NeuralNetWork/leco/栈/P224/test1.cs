public class SolutionP224 {
    public int Calculate(string s) {
        s.Replace(" ","");
        for(int i=0;i<s.Length;i++){
            int number=0;
            if(int.TryParse(s[i].ToString(),out var num)){
                number=number*10+num;
            }
        }
        return 0;
    }
}