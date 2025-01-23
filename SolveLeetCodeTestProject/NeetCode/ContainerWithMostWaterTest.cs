namespace SolveLeetCodeTestProject.NeetCode;

[TestClass]
public class ContainerWithMostWaterTest
{
    [TestMethod]
    public void ContainerWithMostWater()
    {
        Assert.AreEqual(MaxArea([1, 7, 2, 5, 4, 7, 3, 6]), 36);
    }

    // Time complexity O(n)
    // Space complexity O(1)
    public int MaxArea(int[] heights)
    {
        var left = 0;
        var right = heights.Length - 1;
        int max = -1;
        while (left < right)
        {
            var width = right - left;
            var height = 0;
            if (heights[left] < heights[right])
            {
                height = heights[left];
                left++;
            }
            else
            {
                height = heights[right];
                right--;
            }
            max = Math.Max(max, height * width);
        }
        return max;
    }
}

