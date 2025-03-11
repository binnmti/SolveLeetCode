namespace SolveLeetCodeTestProject.NeetCode;

[TestClass]
public class SlidingWindowMaximumTest
{
    [TestMethod]
    public void SlidingWindowMaximum()
    {
        var a = MaxSlidingWindow([1, 2, 1, 0, 4, 2, 6], 3);
        CollectionAssert.AreEqual(a, new List<int>() { 2, 2, 4, 4, 6 });
    }

    // Time complexity: O(n * m)
    // Space complexity: O(n)
    public int[] MaxSlidingWindow(int[] nums, int k)
    {
        var list = new List<int>();
        for (int i = 0; i <= nums.Length - k; i++)
        {
            int max = -10000;
            for (int j = 0; j < k; j++)
            {
                max = Math.Max(nums[i + j], max);
            }
            list.Add(max);
        }
        return list.ToArray();
    }
}

