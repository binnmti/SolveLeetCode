namespace SolveLeetCodeTestProject.NeetCode;

[TestClass]
public class TwoIntegerSumIITest
{
    [TestMethod]
    public void TwoIntegerSumII()
    {
        ReferenceEquals(TwoSum([1, 2, 3, 4], 3), new int[] { 1, 2 });
    }

    //Time complexity O(n^2)
    //Space complexity O(1)
    public int[] TwoSum(int[] numbers, int target)
    {
        for (int i = 0; i < numbers.Length; i++)
        {
            for (int j = i + 1; j < numbers.Length; j++)
            {
                if (numbers[i] + numbers[j] == target)
                {
                    return new List<int>() { i + 1, j + 1 }.ToArray();
                }
            }
        }
        return [];
    }
}

