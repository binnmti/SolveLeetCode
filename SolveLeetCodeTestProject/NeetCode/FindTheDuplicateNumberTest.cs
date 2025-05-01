namespace SolveLeetCodeTestProject.NeetCode;

[TestClass]
public class FindTheDuplicateNumberTest
{
    [TestMethod]
    public void FindTheDuplicateNumber()
    {
        Assert.AreEqual(FindDuplicate([1, 2, 3, 2, 2]), 2);
    }

    // Time complexity: O(n)
    // Space complexity: O(1)
    public int FindDuplicate(int[] nums)
    {
        foreach (var n in nums)
        {
            var index = Math.Abs(n) - 1;
            if (nums[index] < 0)
            {
                return Math.Abs(n);
            }
            nums[index] *= -1;
        }
        return 0;
    }
}

