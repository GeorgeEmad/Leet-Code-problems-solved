public class Solution {
    public int[] TwoSum(int[] nums, int target) {
        Dictionary<int,int> dict = new Dictionary<int,int>();
        int[] result = new int[2];
        for(int i = 0; i< nums.Length;i++)
        {
            var remainder = target - nums[i];
            if(dict.ContainsKey(remainder))
            {
                return new int[]{i, dict[remainder]};
            }
            if(!dict.ContainsKey(nums[i]))
            {
                dict.Add( nums[i], i);
            }
        }
        return result;
    }
}