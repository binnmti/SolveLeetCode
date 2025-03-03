namespace SolveLeetCodeTestProject.NeetCode;

[TestClass]
public class BinarySearchTest
{
    [TestMethod]
    public void BinarySearch()
    {
        Assert.AreEqual(Search([2, 5], 2), 0);
        Assert.AreEqual(Search([-1, 0, 3, 5, 9, 12], 13), -1);
        Assert.AreEqual(Search([-1, 0, 3, 5, 9, 12], 9), 4);
        Assert.AreEqual(Search([-1, 0, 3, 5, 9, 12], 0), 1);
        Assert.AreEqual(Search([-1, 0, 2, 4, 6, 8], 4), 3);
        Assert.AreEqual(Search([-1, 0, 2, 4, 6, 8], 3), -1);
    }

    // Time complexity: O(log n)
    // Space complexity: O(1)
    public int Search(int[] nums, int target)
    {
        var index = Array.BinarySearch(nums, target);
        return index >= 0 ? index : -1;
    }
}

