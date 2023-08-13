public class Solution {
    public bool CheckInclusion(string s1, string s2) {
        if( s1.Length > s2.Length) return false;

        var hash1 = new int[26];
        var hash2 = new int[26];
        for(int i = 0 ; i < s1.Length ; i++){
            hash1[ s1[i] - 'a' ]++;
            hash2[ s2[i] - 'a' ]++;
        }
        int matches = 0;
        for(int i = 0 ; i < 26 ; i++){
            if(hash1[i] == hash2[i] ){
                matches++;
            }
        }
        for (int i = s1.Length   ; i < s2.Length;i++){
           if(matches == 26){
                return true;
            }
            int index = i - s1.Length  ;
            hash2[ s2[i] - 'a' ]++;
            if( hash1[ s2[i] - 'a' ] == hash2[ s2[i] - 'a' ]  ){
                    matches++;
            }else if( hash1[ s2[i] - 'a' ] + 1 == hash2[ s2[i] - 'a' ]  ){
                matches--;
            }

            hash2[ s2[index] - 'a' ]-- ;
            if( hash1[ s2[index] - 'a' ] == hash2[ s2[index] - 'a' ]  ){
                    matches++;
            }else if( hash1[ s2[index] - 'a' ] - 1 == hash2[ s2[index] - 'a' ] ){
                matches--;
            }
        }
        return matches == 26;
    }
}