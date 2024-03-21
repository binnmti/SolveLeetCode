using Newtonsoft.Json.Linq;

namespace SolveLeetCodeTestProject;

internal static class Algorithms
{
    internal static int[] TwoSum(int[] nums, int target)
    {
        var sortNums = nums.ToList().Select((n, idx) => new { idx, n }).ToDictionary(x => x.idx, x => x.n);
        sortNums = sortNums.OrderBy(x => x.Value).ToDictionary(x => x.Key, x => x.Value);

        var left = 0;
        var right = nums.Length - 1;
        var leftValue = sortNums.ElementAt(left).Value;
        var rightValue = sortNums.ElementAt(right).Value;
        while (leftValue + rightValue != target)
        {
            if (leftValue + rightValue < target)
            {
                left++;
            }
            else if (leftValue + rightValue > target)
            {
                right--;
            }
            leftValue = sortNums.ElementAt(left).Value;
            rightValue = sortNums.ElementAt(right).Value;
        }
        return [sortNums.ElementAt(left).Key, sortNums.ElementAt(right).Key];
    }

}