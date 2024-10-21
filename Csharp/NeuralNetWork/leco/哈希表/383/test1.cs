public class SolutionP383test1 {
    public bool CanConstruct(string ransomNote, string magazine) {
        Dictionary<char,int> ran = new Dictionary<char,int>();
        foreach (char c in ransomNote){
            if (ran.ContainsKey(c)){
                ran[c] += 1;
            }else{
                ran.Add(c, 1);
            }
        }
        Dictionary<char, int> mag = new Dictionary<char,int>();
        foreach (char c in magazine){
            if(mag.ContainsKey(c)){
                mag[c] += 1;
            }else{
                mag.Add(c, 1);
            }
        }
        foreach (char c in ransomNote){
            if(!mag.ContainsKey(c)||ran[c]>mag[c]){
                return false;
            }
        }


        return true;
    }
}