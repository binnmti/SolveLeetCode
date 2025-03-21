namespace SolveLeetCodeTestProject.NeetCode;

[TestClass]
public class SearchinRotatedSortedArrayTest
{
    [TestMethod]
    public void SearchinRotatedSortedArray()
    {
        Assert.AreEqual(Search([3, 4, 5, 6, 1, 2], 1), 4);
    }

    // Time complexity: O(n)
    // Space complexity: O(1)
    public int Search(int[] nums, int target)
    {
        int idx = -1;
        for (int i = 0; i < nums.Length; i++)
        {
            if (target == nums[i])
            {
                idx = i;
            }
        }
        return idx;
    }
}

