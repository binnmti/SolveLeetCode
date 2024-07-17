
namespace SolveLeetCodeTestProject;

internal class Solution167
{
    internal static int[] TwoSum(int[] numbers, int target)
    {
        var map = new Dictionary<int, int>();
        for (int i = 0; i < numbers.Length; i++)
        {
            if (map.TryGetValue(target - numbers[i], out var value))
            {
                return [value + 1, i + 1];
            }
            map[numbers[i]] = i;
        }
        return [];
    }
}