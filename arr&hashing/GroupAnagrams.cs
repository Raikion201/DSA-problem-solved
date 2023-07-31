public class Solution {
    public IList<IList<string>> GroupAnagrams(string[] strs) {
       var res = new Dictionary<string,IList<string>>();
       var arr = new List<IList<string>>();
       foreach (string s in strs){
           char[] hash = new char[26];
           foreach(char z in s){
               hash[z - 'a']++;
           }
          string resKey = new string(hash);
           if(!res.ContainsKey(resKey)){
               res[resKey] = new List<string>();
           }
           res[resKey].Add(s);
       }
       return res.Values.ToList();
    }
}