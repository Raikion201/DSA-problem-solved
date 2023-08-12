public class Solution {
    public int LengthOfLongestSubstring(string s) {
        if(s.Length <= 1 ) return s.Length;
        int l = 0 , r = 0, max = 0;
        var set = new HashSet<char>() ;
        while(  r < s.Length ){
            if( !set.Contains(s[r]) ){
                max = Math.Max(max , r - l + 1);
                set.Add(s[r]);
                r++;
            }else{
                set.Remove(s[l]);
                l++;
            }
        }


        return max;
    }
}