using System;
using System.Reflection;

namespace SolveLeetCodeTestProject;

[TestClass]
internal class LongestConsecutiveSequenceTest
{
    [TestMethod]
    public void LongestConsecutiveSequence()
    {
        var ret = LongestConsecutiveSequence([2, 20, 4, 10, 3, 4, 5]);
        Assert.AreEqual(ret, 4);
    }

    //Time complexity: O(n^3)
    //Space complexity: O(1)
    public int LongestConsecutiveSequence(int[] nums)
    {
        if (nums.Length == 0) return 0;

        int consecutiveMax = 1;
        for (int i = 0; i < nums.Length; i++)
        {
            int consecutive = 1;
            while (true)
            {
                bool hit = false;
                for (int j = 0; j < nums.Length; j++)
                {
                    if (i == j) continue;

                    if (nums[i] + consecutive == nums[j])
                    {
                        hit = true;
                        break;
                    }
                }
                if (hit == false) break;

                consecutive++;
                consecutiveMax = Math.Max(consecutive, consecutiveMax);
            }
        }
        return consecutiveMax;
    }
}

