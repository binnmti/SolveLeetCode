
namespace SolveLeetCodeTestProject
{
    internal class Solution053
    {
        //internal static int MaxSubArray(int[] nums)
        //{
        //    int max = int.MinValue;
        //    for (int i = 0; i < nums.Length; i++)
        //    {
        //        var sum = nums[i];
        //        max = Math.Max(max, sum);
        //        for (int j = i + 1; j < nums.Length; j++)
        //        {
        //            sum += nums[j];
        //            max = Math.Max(max, sum);
        //        }
        //    }
        //    return max;
        //}

        internal static int MaxSubArray(int[] nums)
        {
            return solve(nums, 0, false);
        }


        private static int solve(int[] nums, int i, bool mustPick)
        {
            if (i >= nums.Length) return mustPick ? 0 : int.MinValue;
            if (mustPick) return Math.Max(0, nums[i] + solve(nums, i + 1, true));
            return Math.Max(solve(nums, i + 1, false), nums[i] + solve(nums, i + 1, true));
        }

        //internal static int MaxSubArray(int[] nums)
        //{
        //    int max = nums[0];
        //    for (int i = 0; i < nums.Length; i++)
        //    {
        //        max = MaxSubArrayCore(nums, i, 0, max);
        //    }
        //    return max;

        //}
        //private static int MaxSubArrayCore(int[] nums, int idx, int sum, int max)
        //{
        //    if (idx == nums.Length) return max;

        //    sum += nums[idx];
        //    max = Math.Max(max, sum);
        //    idx++;
        //    return MaxSubArrayCore(nums, idx, sum, max);
        //}
    }
}