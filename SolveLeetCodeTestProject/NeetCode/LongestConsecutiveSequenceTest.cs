namespace SolveLeetCodeTestProject.NeetCode;

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
        // Time complexity: O(n)
        // Space complexity: O(n)
        if (nums.Length == 0) return 0;
        var hash = new HashSet<int>(nums);
        int consecutiveMax = 1;
        for (int i = 0; i < nums.Length; i++)
        {
            int offset = 1;
            while (hash.Contains(nums[i] + offset))
            {
                offset++;
                Console.WriteLine(offset);
            }
            consecutiveMax = Math.Max(consecutiveMax, offset);
        }
        return consecutiveMax;
    }
}

