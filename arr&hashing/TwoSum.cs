public class Solution {
    public int[] TwoSum(int[] nums, int target) {
        var ans = new Dictionary<int,int>();
        for (int i = 0 ; i < nums.Length; i++){
            int diff = target - nums[i];
            if (ans.ContainsKey(diff)){
                return new int[] { i, ans[diff] };
            }
            ans.TryAdd(nums[i],i);
        }
        return new int[] {};
    }
}