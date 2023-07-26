public class Solution {
    public bool ContainsDuplicate(int[] nums) {
        var l = new HashSet<int>(nums);
        return l.Count != nums.Length ? true : false;
    }
}