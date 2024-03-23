namespace SolveLeetCodeTestProject;

internal static class Algorithms
{
    internal static int[] TwoSum(int[] nums, int target)
    {
        var map = new Dictionary<int, int>();
        for (int i = 0; i < nums.Length; i++)
        {
            if (map.TryGetValue(target - nums[i], out var value))
            {
                return [value, i];
            }
            map[nums[i]] = i;
        }
        return [];
    }
}