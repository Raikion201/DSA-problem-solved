public class Solution {
    public int FindMin(int[] nums) {
        int l = 1 ;
        int r = nums.Length - 1;
        if( nums.Length < 3){
            return Math.Min(nums[0],nums[r]);
        }
        if(nums[0] < nums[r] && nums[0] < nums[l] ){
            return nums[0];
        }
        int mid;
        while( l <= r){
             mid = ( l + r ) / 2;
            if( nums[mid] < nums[0] && nums[mid - 1] < nums[mid]  ){
                r = mid - 1;
            }else if (nums[mid] > nums[0] ){
                l = mid + 1;
            }else{
                return nums[mid];
            }


        }

        return nums[l];
    }
}