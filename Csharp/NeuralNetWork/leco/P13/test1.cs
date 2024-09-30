public class Solution13 {
    

    public int RomanToInt(string s) {
        Dictionary<char, int> num = new Dictionary<char, int> {
            {'I', 1}, {'V', 5}, {'X', 10}, {'L', 50},
            {'C', 100}, {'D', 500}, {'M', 1000}
        };
        int result=0;
        int i=0;
        if(s.Length==1){
            return num[s[0]];
        }
        i=0;
        while(i+1<s.Length){
            if(num[s[i]]<num[s[i+1]]){
                result+=num[s[i+1]]-num[s[i]];
                i+=2;
            }else{
                result+=num[s[i]];
                i++;
            }
        }
        if(i==s.Length-1){
            result+=num[s[s.Length-1]];
        }
        return result;
    }
}