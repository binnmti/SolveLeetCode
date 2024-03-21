namespace SolveLeetCodeTestProject;

internal static class Algorithms
{
    internal static int[] TwoSum(int[] nums, int target)
    {
        var sortNums = nums.Select((n, idx) => new { n, idx })
                .ToDictionary(x => x.idx, x => x.n)
                .OrderBy(x => x.Value);
        var leftIndex = 0;
        var rightIndex = nums.Length - 1;
        var leftValue = sortNums.ElementAt(leftIndex).Value;
        var rightValue = sortNums.ElementAt(rightIndex).Value;
        while (leftValue + rightValue != target)
        {
            if (leftValue + rightValue < target)
            {
                leftIndex++;
            }
            else if (leftValue + rightValue > target)
            {
                rightIndex--;
            }
            leftValue = sortNums.ElementAt(leftIndex).Value;
            rightValue = sortNums.ElementAt(rightIndex).Value;
        }
        return [sortNums.ElementAt(leftIndex).Key, sortNums.ElementAt(rightIndex).Key];
    }

}