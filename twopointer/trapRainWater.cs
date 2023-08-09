public class Solution {
    public int Trap(int[] height) {
        int l = 0 ;
        int r = height.Length - 1;
        int shorter;
        int ans = 0;
       while(l < r){
           if( height[l] > height[r] ){
               shorter = height[r];
               --r;
               while( height[r] < shorter ){
                   ans += shorter - height[r];
                   r--;
               }
           }else if( height[l] < height[r] ){
               shorter = height[l];
                ++l;
               while( height[l] < shorter ){
                ans += shorter - height[l];
                 l++;
               }
           }else{
                shorter = height[l];
                ++l;
                while(height[l] < shorter){
                    ans += shorter - height[l];
                    l++;
                }
           }
       }
    return ans;
    }
}