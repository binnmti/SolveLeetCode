namespace SolveLeetCodeTestProject.NeetCode;

[TestClass]
public class MedianofTwoSortedArraysTest
{
    [TestMethod]
    public void MedianofTwoSortedArrays()
    {
        Assert.AreEqual(FindMedianSortedArrays([1, 2], [3]), 2.0);
        Assert.AreEqual(FindMedianSortedArrays([1, 3], [2, 4]), 2.5);
    }

    // Time complexity: O((n + m)log(n + m))
    // Space complexity: O(n + m)
    public double FindMedianSortedArrays(int[] nums1, int[] nums2)
    {
        var numsAll = new List<int>();
        foreach (var n1 in nums1)
        {
            numsAll.Add(n1);
        }
        foreach (var n2 in nums2)
        {
            numsAll.Add(n2);
        }
        numsAll = numsAll.OrderBy(x => x).ToList();
        if ((numsAll.Count % 2) == 0)
        {
            var c1 = numsAll.ElementAt(numsAll.Count / 2 - 1);
            var c2 = numsAll.ElementAt(numsAll.Count / 2);
            return (double)(c1 + c2) / 2;
        }
        else
        {
            return numsAll.ElementAt(numsAll.Count / 2);
        }
    }
}

