namespace SolveLeetCodeTestProject.NeetCode;

[TestClass]
public class KokoEatingBananasTest
{
    [TestMethod]
    public void KokoEatingBananas()
    {
        Assert.AreEqual(MinEatingSpeed([1, 1, 1, 999999999], 10), 142857143);
        Assert.AreEqual(MinEatingSpeed([332484035, 524908576, 855865114, 632922376, 222257295, 690155293, 112677673, 679580077, 337406589, 290818316, 877337160, 901728858, 679284947, 688210097, 692137887, 718203285, 629455728, 941802184], 823855818), 14);
        Assert.AreEqual(MinEatingSpeed([25, 10, 23, 4], 4), 25);
        Assert.AreEqual(MinEatingSpeed([3, 6, 7, 11], 8), 4);
        Assert.AreEqual(MinEatingSpeed([1, 4, 3, 2], 9), 2);
    }

    // Time complexity: O(n * m)
    // Space complexity: O(1)
    public int MinEatingSpeed(int[] piles, int h)
    {
        for (var speed = 1; ; speed++)
        {
            long sum = 0;
            foreach (int pile in piles)
            {
                sum += (long)Math.Ceiling((double)pile / speed);
            }
            if (sum <= h)
            {
                return speed;
            }
        }
    }
}

