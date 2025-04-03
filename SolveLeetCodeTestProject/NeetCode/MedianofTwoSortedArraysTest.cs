namespace SolveLeetCodeTestProject.NeetCode;

[TestClass]
public class MedianofTwoSortedArraysTest
{
    [TestMethod]
    public void MedianofTwoSortedArrays()
    {
        Assert.AreEqual(FindMedianSortedArrays([], [2,3]), 2.5);
        Assert.AreEqual(FindMedianSortedArrays([2], []), 2);
        Assert.AreEqual(FindMedianSortedArrays([], [1]), 1);
        Assert.AreEqual(FindMedianSortedArrays([1, 3], [2, 4]), 2.5);
        Assert.AreEqual(FindMedianSortedArrays([1, 2], [3, 4]), 2.5);
        Assert.AreEqual(FindMedianSortedArrays([1, 2], [3]), 2.0);
    }

    // Time complexity: O(n + m)
    // Space complexity: O(n + m)
    public double FindMedianSortedArrays(int[] nums1, int[] nums2)
    {
        var half = (nums1.Length + nums2.Length) / 2;
        var mins = new List<int>();
        int co1 = 0;
        int co2 = 0;
        bool nums1Flag = nums2.Length == 0;
        bool nums2Flag = nums1.Length == 0;
        for (int i = 0; i <= half; i++)
        {
            if (nums1Flag)
            {
                mins.Add(nums1[co1]);
                co1++;
            }
            else if (nums2Flag)
            {
                mins.Add(nums2[co2]);
                co2++;
            }
            else
            {
                if (nums1[co1] < nums2[co2])
                {
                    mins.Add(nums1[co1]);
                    co1++;
                    if (co1 == nums1.Length) nums2Flag = true;
                }
                else
                {
                    mins.Add(nums2[co2]);
                    co2++;
                    if (co2 == nums2.Length) nums1Flag = true;
                }
            }
        }
        if ((nums1.Length + nums2.Length) % 2 == 0)
        {
            return (double)(mins.ElementAt(mins.Count - 2) + mins.ElementAt(mins.Count - 1)) / 2;
        }
        else
        {
            return mins.ElementAt(mins.Count - 1);
        }
    }
}

