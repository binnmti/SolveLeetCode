namespace SolveLeetCodeTestProject.NeetCode;

[TestClass]
public class FindMinimuminRotatedSortedArrayTest
{
    [TestMethod]
    public void FindMinimuminRotatedSortedArray()
    {
        Assert.AreEqual(FindMin([3, 4, 5, 6, 1, 2]), 1);
    }

    // Time complexity: O(n)
    // Space complexity: O(1)
    public int FindMin(int[] nums)
    {
        return nums.Min(x => x);
    }
}

