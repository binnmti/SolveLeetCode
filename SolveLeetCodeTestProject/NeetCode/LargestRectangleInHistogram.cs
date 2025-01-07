namespace SolveLeetCodeTestProject.NeetCode;

[TestClass]
public class LargestRectangleInHistogramTest
{
    [TestMethod]
    public void LargestRectangleInHistogram()
    {
        Assert.AreEqual(LargestRectangleArea([7, 1, 7, 2, 2, 4]), 8);
    }

    //Time complexity O(n ^ 2)
    //Space complexity O(n)
    public int LargestRectangleArea(int[] heights)
    {
        int max = 0;
        //→に順番に
        for (int i = 0; i < heights.Length; i++)
        {
            int w = 1;
            var h = heights[i];
            //右に見ていく
            for (int j = i + 1; j < heights.Length; j++)
            {
                if (heights[j] < h) break;

                w++;
            }
            //左に見ていく
            for (int j = i - 1; j >= 0; j--)
            {
                if (heights[j] < h) break;

                w++;
            }
            max = Math.Max(max, w * h);
        }
        return max;
    }
}

