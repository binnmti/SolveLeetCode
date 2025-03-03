namespace SolveLeetCodeTestProject.NeetCode;

[TestClass]
public class BinarySearchTest
{
    [TestMethod]
    public void BinarySearch()
    {
        Assert.AreEqual(Search([-1, 0, 2, 4, 6, 8], 4), 3);
        Assert.AreEqual(Search([-1, 0, 2, 4, 6, 8], 4), 3);
    }

    // Time complexity: O(n)
    // Space complexity: O(1)
    public int Search(int[] nums, int target)
    {
        for (int i = 0; i < nums.Length; i++)
        {
            if (nums[i] == target)
            {
                return i;
            }
        }
        return -1;
    }
}

