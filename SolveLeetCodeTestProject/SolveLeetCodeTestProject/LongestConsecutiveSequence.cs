namespace SolveLeetCodeTestProject;

[TestClass]
public class LongestConsecutiveSequenceTest
{
    [TestMethod]
    public void LongestConsecutiveSequence()
    {
        Assert.AreEqual(LongestConsecutiveSequence([2, 20, 4, 10, 3, 4, 5]), 4);
        Assert.AreEqual(LongestConsecutiveSequence([0, 3, 2, 5, 4, 6, 1, 1]), 7);
    }

    public int LongestConsecutiveSequence(int[] nums)
    {
        // Time complexity: O(n log n)
        // Space complexity: O(1)
        if (nums.Length == 0) return 0;

        Array.Sort(nums);

        int consecutiveMax = 1;
        int consecutive = 1;
        for (int i = 0; i < nums.Length - 1; i++)
        {
            if (nums[i] == nums[i + 1]) continue;

            if (nums[i] + 1 == nums[i + 1])
            {
                consecutive++;
                consecutiveMax = Math.Max(consecutiveMax, consecutive);
            }
            else
            {
                consecutive = 1;
            }
        }

        return consecutiveMax;
    }
}

