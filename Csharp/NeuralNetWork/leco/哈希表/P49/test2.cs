public class SolutionP49test2 {
    //比test1更好
    public IList<IList<string>> GroupAnagrams(string[] strs) {
        Dictionary<string,IList<string>> dic = new Dictionary<string,IList<string>>();
        List<IList<string>> list = new List<IList<string>>();
        foreach(string str in strs) {
            string key=GetSortStr(str);
            if(dic.ContainsKey(key)) {
                dic[key].Add(str);
            }else{
                dic.Add(key,new List<string>());
                dic[key].Add(str);
            }
        }

        return dic.Values.ToList();
    }
    public string GetSortStr(string str){
        char[] ch = str.ToCharArray();
        Array.Sort(ch);
        return new string(ch);
    }
}