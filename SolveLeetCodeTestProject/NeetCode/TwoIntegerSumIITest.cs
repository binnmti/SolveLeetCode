namespace SolveLeetCodeTestProject.NeetCode;

[TestClass]
public class TwoIntegerSumIITest
{
    [TestMethod]
    public void TwoIntegerSumII()
    {
        ReferenceEquals(TwoSum([1, 2, 3, 4], 3), new List<int>() { 1, 2 }.ToArray());
    }

    //Time complexity O(n)
    //Space complexity O(n)
    private int[] TwoSum(int[] numbers, int target)
    {
        var dic = numbers.Select((v, i) => new { v, i }).ToDictionary(x => x.v, x => x.i);
        foreach (var (v, i) in dic)
        {
            var diff = target - v;
            if (dic.TryGetValue(diff, out var value))
            {
                return [i + 1, value + 1];
            }
        }
        return [];
    }
}

