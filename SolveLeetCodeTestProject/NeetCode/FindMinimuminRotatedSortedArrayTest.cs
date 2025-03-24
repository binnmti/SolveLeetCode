namespace SolveLeetCodeTestProject.NeetCode;

[TestClass]
public class FindMinimuminRotatedSortedArrayTest
{
    [TestMethod]
    public void FindMinimuminRotatedSortedArray()
    {
        Assert.AreEqual(FindMin([3, 4, 5, 6, 1, 2]), 1);
        Assert.AreEqual(FindMin([4, 5, 0, 1, 2, 3]), 0);
        Assert.AreEqual(FindMin([4, 5, 6, 7]), 4);
    }

    // Time complexity: O(log n)
    // Space complexity: O(1)
    public int FindMin(int[] nums)
    {
        var l = 0;
        var r = nums.Length - 1;
        var min = nums[0];
        while (l <= r)
        {
            if (nums[l] <= nums[r])
            {
                min = Math.Min(min, nums[l]);
                return min;
            }
            var center = l + (r - l) / 2;
            min = Math.Min(min, nums[center]);
            if (nums[l] < nums[r])
            {
                r = center - 1;
            }
            else
            {
                l = center + 1;
            }
        }
        return -1;
    }
}

