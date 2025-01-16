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
    //Space complexity O(1)
    private int[] TwoSum(int[] numbers, int target)
    {
        int left = 0;
        int right = numbers.Length - 1;
        for (int i = 0; i < numbers.Length; i++)
        {
            var add = numbers[left] + numbers[right];
            if (add > target) right--;
            else if (add < target) left++;
            else if (add == target) return [left + 1, right + 1];
        }
        return [];
    }
}

