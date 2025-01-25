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

    //Time complexity O(n^2*m)
    //Space complexity O(1)
    public int Trap(int[] height)
    {
        var output = 0;
        var currentHeight = 1;
        // １段ずつ見て行って、左右に自分より高いものがあればそこは水が入る
        while (currentHeight <= height.Max())
        {
            for (int i = 1; i < height.Length - 1; i++)
            {
                // 左が現在の高さより低ければ何もしない
                if (height[i - 1] <= height[i]) continue;
                if (currentHeight <= height[i] || currentHeight > height[i - 1]) continue;

                // 右に壁があれば終わり
                for (int j = i + 1; j <= height.Length - 1; j++)
                {
                    if (height[j] < currentHeight) continue;

                    output += j - i;
                    i += j - i;
                    break;
                }
            }
            currentHeight++;
        }
        return output;
    }
}

