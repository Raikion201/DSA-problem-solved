public class Solution {
    public int[] ProductExceptSelf(int[] nums) {
        int[] arr = new int[nums.Length];
            int start = 1; // prefix for nums[0];
            int end = 1; // prefix for last num
        for(int i = 0 ; i < arr.Length ; i++){
            arr[i] = start;
            start *= nums[i];
            }

        for(int i = arr.Length - 1 ; i >= 0 ; i--){
                arr[i] *= end;
                end *= nums[i];
        }

        return arr;
    }
} 