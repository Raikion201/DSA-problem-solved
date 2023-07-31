public class Solution {
    public bool IsPalindrome(string s) {
        s = new string(s.Where(c => char.IsLetterOrDigit(c)).ToArray()).ToLower();
        if(s.Length <= 1) return true;
        int length = s.Length - 1;
        int mid = length/2 ;
        for(int i = 0 ; i <= mid ; i++){
            if( s[i] != s[length - i] ){
                return false;
            }
        }
        return true;
    }
}