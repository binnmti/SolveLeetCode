namespace SolveLeetCodeTestProject.NeetCode;

[TestClass]
public class TrappingRainWaterTest
{
    [TestMethod]
    public void TrappingRainWater()
    {
        Assert.AreEqual(Trap([1]), 0);
        Assert.AreEqual(Trap([0, 2, 0, 3, 1, 0, 1, 3, 2, 1]), 9);
        Assert.AreEqual(Trap([4, 2, 0, 3, 2, 5]), 9);
    }

    //Time complexity O(n)
    //Space complexity O(1)
    public int Trap(int[] height)
    {
        var left = 0;
        var right = height.Length - 1;
        var maxLeft = height[left];
        var maxRight = height[right];
        int water = 0;
        while (left < right)
        {
            if (maxLeft < maxRight)
            {
                left++;
                maxLeft = Math.Max(maxLeft, height[left]);
                water += maxLeft - height[left];
            }
            else
            {
                right--;
                maxRight = Math.Max(maxRight, height[right]);
                water += maxRight - height[right];
            }
        }
        return water;
    }
}

