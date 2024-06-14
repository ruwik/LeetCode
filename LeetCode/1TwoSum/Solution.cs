namespace TwoSum {
    public class Solution {
        public int[] TwoSum(int[] nums, int target) {
            var map = new Dictionary<int, int>();
            for (var i = 0; i < nums.Length; i++)
            {
                var current = nums[i];
                var diff = target - current;
                if (map.ContainsKey(current))
                {
                    return new[] {map[current], i};
                }
                map.TryAdd(diff, i);
            }

            return null;
        }
    }
}