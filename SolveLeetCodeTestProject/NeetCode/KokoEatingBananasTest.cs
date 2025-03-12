namespace SolveLeetCodeTestProject.NeetCode;

[TestClass]
public class KokoEatingBananasTest
{
    [TestMethod]
    public void KokoEatingBananas()
    {
        Assert.AreEqual(MinEatingSpeed([332484035, 524908576, 855865114, 632922376, 222257295, 690155293, 112677673, 679580077, 337406589, 290818316, 877337160, 901728858, 679284947, 688210097, 692137887, 718203285, 629455728, 941802184], 823855818), 14);
        Assert.AreEqual(MinEatingSpeed([25, 10, 23, 4], 4), 25);
        Assert.AreEqual(MinEatingSpeed([3, 6, 7, 11], 8), 4);
        Assert.AreEqual(MinEatingSpeed([1, 4, 3, 2], 9), 2);
    }

    // Time complexity: O(n * m * k)
    // Space complexity: O(1)
    public int MinEatingSpeed(int[] piles, int h)
    {
        for (int speed = 1; speed <= piles.Max(x => x); speed++)
        {
            bool isClear = true;
            int eat = 0;
            foreach (var pile in piles)
            {
                bool isFinish = false;
                for (int count = 1; count <= h; count++)
                {
                    if (pile <= speed * count)
                    {
                        isFinish = true;
                        eat += count;
                        break;
                    }
                }
                if (!isFinish || eat > h)
                {
                    isClear = false;
                    break;
                }
            }
            if (isClear)
            {
                return speed;
            }
        }
        return -1;
    }
}

