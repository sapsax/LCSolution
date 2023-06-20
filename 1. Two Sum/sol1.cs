public class Solution {
    public int[] TwoSum(int[] nums, int target) {
        Dictionary<int, int> valuePairs = new Dictionary<int, int>();
            for (int index = 0; index < nums.Length; index++)
            {
                var diff = target - nums[index];
                if (valuePairs.ContainsKey(diff))
                {
                   // valuePairs.TryGetValue(diff, out int indx);
                    return  new int[] { valuePairs[diff], index } ;
                }
                else
                {
                    valuePairs.TryAdd(nums[index],index);
                }
            }
            return new int[] { };
    }
}