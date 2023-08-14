public class Solution {
    public string MinWindow(string s, string t) {
        var window = new Dictionary<char,int> ();
        var countT = new Dictionary<char,int> ();

        foreach ( char z in t){
            AddToDict(z,countT);
        }

        int have = 0 ;
        int need = countT.Count;
        int left = 0 ;
        var res = new int [] { -1 , -1};
        var min = int.MaxValue ;

        for (int right = 0 ; right < s.Length ; right++){
            var curr = s[right];
            AddToDict(curr,window);
            if( countT.ContainsKey(curr)){
                if( window[curr] == countT[curr] ){
                have++;
                }
            }
            while (have == need){
                if( right - left + 1 < min ){
                    min = right - left + 1;
                    res = new int[] {left,right};
                }
                window[s[left]]--;
            if( countT.ContainsKey(s[left])){
                if( window[s[left]] < countT[s[left]]  ){
                    have--;
                }
            }
                left++;
            }

        }
       return (min == int.MaxValue) ? String.Empty : s.Substring( res[0], min );
    }

    public void AddToDict( char z , IDictionary<char,int> dict  ){
        if( dict.ContainsKey(z) ){
            dict[z]++;
        }else{
            dict.Add(z,1);
        }
    }
}