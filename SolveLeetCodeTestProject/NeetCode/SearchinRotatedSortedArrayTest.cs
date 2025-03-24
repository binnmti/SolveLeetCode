namespace SolveLeetCodeTestProject.NeetCode;

[TestClass]
public class SearchinRotatedSortedArrayTest
{
    [TestMethod]
    public void SearchinRotatedSortedArray()
    {
        Assert.AreEqual(Search([1, 3, 5], 1), 0);
        Assert.AreEqual(Search([1, 3], 1), 0);
        Assert.AreEqual(Search([1], 1), 0);
        Assert.AreEqual(Search([3, 5, 6, 0, 1, 2], 4), -1);
        Assert.AreEqual(Search([4, 5, 6, 7, 0, 1, 2], 0), 4);
        Assert.AreEqual(Search([3, 4, 5, 6, 1, 2], 1), 4);
    }

    // Time complexity: O(lon n)
    // Space complexity: O(1)
    public int Search(int[] nums, int target)
    {
        int l = 0;
        int r = nums.Length - 1;
        while (l <= r)
        {
            var m = l + (r - l) / 2;
            if (nums[m] == target) return m;
            if (nums[l] == target) return l;
            if (nums[r] == target) return r;
            if (nums[l] <= nums[m])
            {
                l = m + 1;
            }
            else
            {
                r = m - 1;
            }
        }
        return -1;
    }
}

